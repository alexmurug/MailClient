using System;
using System.Windows.Forms;

namespace SMTPClient
{
    public partial class SMTPSettings : Form
    {
        public SMTPSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Smtp.Password = SMTPPassword.Text;
            Smtp.Port = SMTPPort.Text;
            Smtp.Server = SMTPServer.Text;
            Smtp.User = SMTPLogin.Text;

            var f = new Send_Mail();
            f.Show();
            this.Hide();

        }
    }
}