namespace SMTPClient
{
    partial class SMTPSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SMTPServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SMTPLogin = new System.Windows.Forms.TextBox();
            this.SMTPPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SMTPPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SMTPServer
            // 
            this.SMTPServer.Location = new System.Drawing.Point(66, 12);
            this.SMTPServer.Name = "SMTPServer";
            this.SMTPServer.Size = new System.Drawing.Size(100, 20);
            this.SMTPServer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // SMTPLogin
            // 
            this.SMTPLogin.Location = new System.Drawing.Point(117, 40);
            this.SMTPLogin.Name = "SMTPLogin";
            this.SMTPLogin.Size = new System.Drawing.Size(100, 20);
            this.SMTPLogin.TabIndex = 3;
            // 
            // SMTPPassword
            // 
            this.SMTPPassword.Location = new System.Drawing.Point(117, 67);
            this.SMTPPassword.Name = "SMTPPassword";
            this.SMTPPassword.PasswordChar = '*';
            this.SMTPPassword.Size = new System.Drawing.Size(100, 20);
            this.SMTPPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port";
            // 
            // SMTPPort
            // 
            this.SMTPPort.Location = new System.Drawing.Point(223, 12);
            this.SMTPPort.Name = "SMTPPort";
            this.SMTPPort.Size = new System.Drawing.Size(56, 20);
            this.SMTPPort.TabIndex = 8;
            // 
            // SMTPSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 148);
            this.Controls.Add(this.SMTPPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SMTPPassword);
            this.Controls.Add(this.SMTPLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SMTPServer);
            this.Name = "SMTPSettings";
            this.Text = "SMTPSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SMTPServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SMTPLogin;
        private System.Windows.Forms.TextBox SMTPPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SMTPPort;
    }
}