using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ParseBody;

namespace SMTPClient
{
    public partial class Form1 : Form
    {
        private readonly TcpClient tcpClient = new TcpClient();
        private StreamReader reader;
        private NetworkStream stream;

        public Form1() //constructor	   
        {
            InitializeComponent();
            btnDisconnect.Enabled = false;
            btnDelete.Enabled = false;
            btnList.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient.Connect("pop.djslife.net", 110);

                stream = tcpClient.GetStream();

                var buffer = new byte[1024];
                var bytesRead = stream.Read(buffer, 0, buffer.Length);
                var response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                listBox1.Items.Add(response + " | Date: " + DateTime.Now);

                var data = Encoding.ASCII.GetBytes("user " + utilizatorBox.Text + "\r\n");
                //convertim	   "USER	   NumeUtilizator"	   in	   sir	   de	   octeti	   
                stream.Write(data, 0, data.Length); //transmitem	   datele	   la	   serverul	   mail	   
                var sendBytes = Encoding.Default.GetBytes(buffer + "\r\n");
                bytesRead = stream.Read(buffer, 0, buffer.Length);
                response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                listBox1.Items.Add(response + " | Date: " + DateTime.Now);

                data = Encoding.ASCII.GetBytes("pass " + parolaBox.Text + "\r\n");
                //convertim	   "PASS ParolaUtilizator"	   
                stream.Write(data, 0, data.Length);

                bytesRead = stream.Read(buffer, 0, buffer.Length);
                response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                listBox1.Items.Add(response + " | Date: " + DateTime.Now);

                var msg = response;
                if (msg[0] != '+') return;
                utilizatorBox.Enabled = false; //interzice utilizatorului sa se foloseasca de astea	   	   
                parolaBox.Enabled = false;
                btnConnect.Enabled = false;

                btnDisconnect.Enabled = true;
                btnDelete.Enabled = true;
                btnList.Enabled = true;
            }
            catch (Exception)
            {
                listBox1.Items.Add("Connectarea nu a reuşit" + DateTime.Now);
            }
        }

        ////http://stackoverflow.com/questions/2226554/c-class-for-decoding-quoted-printable-encoding
        /// 
        //public static string DecodeQuotedPrintables(string input)
        //{
        //    var occurences = new Regex(@"=[0-9A-Z]{2}", RegexOptions.IgnoreCase);
        //    var matches = occurences.Matches(input);
        //    foreach (Match match in matches)
        //    {
        //        var hexChar = (char) Convert.ToInt32(match.Groups[0].Value.Substring(1), 16);
        //        input = input.Replace(match.Groups[0].Value, hexChar.ToString());
        //    }

        //    return input.Replace("=\r\n", "");
        //}
        
        private static string DecodeQuotedPrintables(string input, string charSet)
        {
            if (string.IsNullOrEmpty(charSet))
            {
                var charSetOccurences = new Regex(@"=\?.*\?Q\?", RegexOptions.IgnoreCase);
                var charSetMatches = charSetOccurences.Matches(input);
                foreach (Match match in charSetMatches)
                {
                    charSet = match.Groups[0].Value.Replace("=?", "").Replace("?Q?", "");
                    input = input.Replace(match.Groups[0].Value, "").Replace("?=", "");
                }
            }

            Encoding enc = new ASCIIEncoding();
            if (!string.IsNullOrEmpty(charSet))
            {
                try
                {
                    enc = Encoding.GetEncoding(charSet);
                }
                catch
                {
                    enc = new ASCIIEncoding();
                }
            }

            //decode iso-8859-[0-9]
            var occurences = new Regex(@"=[0-9A-Z]{2}", RegexOptions.Multiline);
            var matches = occurences.Matches(input);
            foreach (Match match in matches)
            {
                try
                {
                    byte[] b = new byte[] { byte.Parse(match.Groups[0].Value.Substring(1), System.Globalization.NumberStyles.AllowHexSpecifier) };
                    char[] hexChar = enc.GetChars(b);
                    input = input.Replace(match.Groups[0].Value, hexChar[0].ToString());
                }
                catch
                {; }
            }

            //decode base64String (utf-8?B?)
            occurences = new Regex(@"\?utf-8\?B\?.*\?", RegexOptions.IgnoreCase);
            matches = occurences.Matches(input);
            foreach (Match match in matches)
            {
                byte[] b = Convert.FromBase64String(match.Groups[0].Value.Replace("?utf-8?B?", "").Replace("?UTF-8?B?", "").Replace("?", ""));
                string temp = Encoding.UTF8.GetString(b);
                input = input.Replace(match.Groups[0].Value, temp);
            }

            input = input.Replace("=\r\n", "");

            return input;
        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    var enc = new ASCIIEncoding();

        //    var data = enc.GetBytes("DELE " + Convert.ToInt32(mesajIDBox.Text) + "\r\n");
        //    stream.Write(data, 0, data.Length);
        //    reader = new StreamReader(stream);
        //    listBox1.Items.Add(reader.ReadLine() + " | Date: " + DateTime.Now);
        //    listBox1.Items.Add("Mesaj Sters cu succes" + " | Date: " + DateTime.Now);
        //}

        private void btnList_Click(object sender, EventArgs e)
        {
            var enc = new ASCIIEncoding();
            listBox2.Items.Clear();
            var data = enc.GetBytes("LIST\r\n");
            stream.Write(data, 0, data.Length);
            reader = new StreamReader(stream);
            listBox1.Items.Add(reader.ReadLine() + " | Date: " + DateTime.Now);

            while (true)
            {
                var msg = reader.ReadLine();
                if (msg != ".")
                {
                    if (msg != null)
                        listBox2.Items.Add(string.Format("ID: {0}{1} | Mărimea: {2} de octeţi;", msg[0], msg[1],
                            msg.Substring(2)));
                }
                else
                {
                    break; //iesim din ciclu	   
                }
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (stream != null)
            {
                var enc = new ASCIIEncoding();
                var data = enc.GetBytes("QUIT\r\n");
                stream.Write(data, 0, data.Length);
                reader = new StreamReader(stream);
                listBox1.Items.Add(reader.ReadLine() + " | Data: " + DateTime.Now);
            }

            utilizatorBox.Enabled = true;
            //interzicem utilizatorului sa se foloseasca de astea	   	   
            parolaBox.Enabled = true;
            btnConnect.Enabled = true;

            btnDisconnect.Enabled = false;
            btnDelete.Enabled = false;
            btnList.Enabled = false;
        }

        private void addSMTPServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f2 = new SMTPSettings();
            f2.ShowDialog(); // Shows Form2
        }

        private void ListBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                var data = Encoding.ASCII.GetBytes("RETR " + Convert.ToInt32(listBox2.SelectedIndex + 1) + "\r\n");

                stream.Write(data, 0, data.Length); //transmitem la	server	   
                reader = new StreamReader(stream);
                string sTemp;
                var sTop = "";
                try
                {
                    stream.Write(data, 0, data.Length);

                    sTemp = reader.ReadLine();
                    if (sTemp[0] != '-')
                    {
                        while (sTemp != ".")
                        {
                            sTop += sTemp + "\r\n";
                            sTemp = reader.ReadLine();
                        }
                    }
                }
                catch (InvalidOperationException err)
                {
                    MessageBox.Show("Error: " + err);
                }

                var htmlBody = new BodyMeesage();
                //richTextBox1.AppendText("Data: " +htmlBody.GetDate(sTop));
                //richTextBox1.AppendText("\n\n To: " + htmlBody.GetTo(sTop));
                //richTextBox1.AppendText(" From: " + htmlBody.GetFrom(sTop));
                var str1 = DecodeQuotedPrintables(htmlBody.GetBody(sTop),"");
                webBrowser1.DocumentText = str1;
                //FromLabel.Text = "From: " + htmlBody.GetFrom(DecodeQuotedPrintables(htmlBody.GetFrom(sTop),""));
                ToLabel.Text = "To:" + htmlBody.GetTo(sTop);
                SubjectLabel.Text = "Subject: " + htmlBody.GetSubject(sTop);
            }
        }
    }
}