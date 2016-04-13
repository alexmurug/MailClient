using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Threading;

namespace SMTPClient
{
    public partial class Send_Mail : Form
    {
        public Send_Mail()
        {
            InitializeComponent();
        }

        private TcpClient client = new TcpClient();

        private void SendButton_Click(object sender, EventArgs e)
        {
            //    try
            //    {
            //        client.Connect(Smtp.Server,Int32.Parse(Smtp.Port));
            //    }
            //    catch (Exception te)
            //    {
            //        MessageBox.Show(te.ToString());

            //    }

            //    if (!client.Connected)
            //    {
            //        MessageBox.Show("Could not connect to the server.");
            //    }
            //    snd("HELO", true);
            //    snd("MAIL FROM:<" + fromBox.Text + ">", true);
            //    snd("RCPT TO:<" + toBox + ">", true);
            //    snd("DATA", true);
            //    snd("From: " + fromBox.Text);
            //    snd("To: " + toBox.Text);
            //    snd("Subject: " + subjectBox.Text);
            //    snd("");
            //    snd(MessageSend.Text);
            //    snd(".", true);
            //    snd("QUIT", true);


            //}
            //private bool snd(string buffer) { return snd(buffer, false); }
            //private bool snd(string buffer, bool getresponse)
            //{
            //    NetworkStream stream = client.GetStream();
            //    Byte[] sendBytes = Encoding.Default.GetBytes(buffer + "\r\n");
            //    if (!stream.CanWrite) { return false; }
            //    try
            //    {
            //        stream.Write(sendBytes, 0, sendBytes.Length);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //        return false;
            //    }
            //    return true;

           
            SmtpClient client = new SmtpClient(Smtp.Server,Int32.Parse(Smtp.Port));
            
            // Specify the e-mail sender.
            // Create a mailing address that includes a UTF8 character
            // in the display name.
            MailAddress from = new MailAddress(fromBox.Text);
            // Set destinations for the e-mail message.
            MailAddress to = new MailAddress(toBox.Text);
            // Specify the message content.
            MailMessage message = new MailMessage(from, to);
            message.Body = MessageSend.Text;
            // Include some non-ASCII characters in body and subject.
            string someArrows = new string(new char[] { '\u2190', '\u2191', '\u2192', '\u2193' });
            message.Body += Environment.NewLine + someArrows;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.Subject = subjectBox.Text + someArrows;
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            client.Timeout =10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(Smtp.User, Smtp.Password);
            // Set the method that is called back when the send operation ends.
            try
            {
                client.Send(message);
                MessageBox.Show("Mesajul trimis cu succes" + " | Date: " + DateTime.Now);
            }
            catch (Exception)
            {
                MessageBox.Show("Mesajul nu a fost trimis" + " | Date: " + DateTime.Now);
                throw;
            }
            finally
            {
                client.Dispose(); //inchidem fluxul
            }

        }
    }
}
