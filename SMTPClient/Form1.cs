using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SMTPClient
{
    public partial class Form1 : Form
    {
        private readonly string addrIP = "smtp.djslife.net"; //	   localhost
        private readonly int portSMTP = 25;


        private readonly TcpClient tcpClient = new TcpClient();
        private StreamReader reader;
        private NetworkStream stream;

        public Form1() //constructor	   
        {
            InitializeComponent();
            btnDisconnect.Enabled = false;
            btnCiteste.Enabled = false;
            btnDelete.Enabled = false;
            btnList.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("alexandru.murug@gmail.com", "Anisoara06");

            var mm = new MailMessage(delaMail.Text, catreMail.Text, subjectBox.Text, msgBox.Text);
            mm.BodyEncoding = Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            try
            {
                client.Send(mm);
                listBox1.Items.Add("Mesajul trimis cu succes" + " | Date: " + DateTime.Now);
            }
            catch (Exception)
            {
                listBox1.Items.Add("Mesajul nu a fost trimis" + " | Date: " + DateTime.Now);
                throw;
            }
            finally
            {
                client.Dispose(); //inchidem fluxul
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            tcpClient.Connect("pop.djslife.net", 110); //conectam	   la	   IP	   si	   portul	   respectiv	   

            stream = tcpClient.GetStream();

            var buffer = new byte[1024];
            var bytesRead = stream.Read(buffer, 0, buffer.Length);
            var response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            listBox1.Items.Add(response + " | Date: " + DateTime.Now);

            var data = Encoding.ASCII.GetBytes("user " + utilizatorBox.Text + "\r\n");
            //convertim	   "USER	   NumeUtilizator"	   in	   sir	   de	   octeti	   
            stream.Write(data, 0, data.Length); //transmitem	   datele	   la	   serverul	   mail	   

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
            btnCiteste.Enabled = true;
            btnDelete.Enabled = true;
            btnList.Enabled = true;
        }

        private void btnCiteste_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
            var str = string.Empty;
            var strTemp = string.Empty;
            var data = Encoding.ASCII.GetBytes("RETR " + Convert.ToInt32(mesajIDBox.Text) + "\r\n");

            stream.Write(data, 0, data.Length); //transmitem la	server	   
            reader = new StreamReader(stream);
            while ((strTemp = reader.ReadLine()) != null)
            {
                if (strTemp == "." || strTemp.IndexOf("-ERR") != -1)
                {
                    break;
                }
                str += strTemp;
            }

            //var myReadBuffer = new byte[1024];
            //var myCompleteMessage = new StringBuilder();
            //var numberOfBytesRead = 0;

            //do
            //{
            //    numberOfBytesRead = stream.Read(myReadBuffer, 0, myReadBuffer.Length);

            //    myCompleteMessage.AppendFormat("{0}", Encoding.ASCII.GetString(myReadBuffer, 0, numberOfBytesRead));
            //} while (stream.DataAvailable);

            richTextBox1.AppendText(str);
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var enc = new ASCIIEncoding();

            var data = enc.GetBytes("DELE " + Convert.ToInt32(mesajIDBox.Text) + "\r\n");
            stream.Write(data, 0, data.Length);
            reader = new StreamReader(stream);
            listBox1.Items.Add(reader.ReadLine() + " | Date: " + DateTime.Now);
            listBox1.Items.Add("Mesaj Sters cu succes" + " | Date: " + DateTime.Now);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            //metoda	   apelata	   cand	   inchidem	   aplicatia	   
        {
            if (stream != null)
            {
                var enc = new ASCIIEncoding();

                var data = enc.GetBytes("QUIT\r\n");
                stream.Write(data, 0, data.Length);
            }
        }

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
                    listBox2.Items.Add("ID: " + msg[0] + " | Mărimea: " + msg.Substring(2) + " de octeţi;");
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
            }

            utilizatorBox.Enabled = true;
            //interzicem utilizatorului sa se foloseasca de astea	   	   
            parolaBox.Enabled = true;
            btnConnect.Enabled = true;

            btnDisconnect.Enabled = false;
            btnCiteste.Enabled = false;
            btnDelete.Enabled = false;
            btnList.Enabled = false;
        }
    }
}