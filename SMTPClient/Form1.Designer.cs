namespace SMTPClient
{
    partial class Form1
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
            this.delaMail = new System.Windows.Forms.TextBox();
            this.catreMail = new System.Windows.Forms.TextBox();
            this.utilizatorBox = new System.Windows.Forms.TextBox();
            this.parolaBox = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnCiteste = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.mesajIDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Logs = new System.Windows.Forms.Label();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delaMail
            // 
            this.delaMail.Location = new System.Drawing.Point(465, 9);
            this.delaMail.Name = "delaMail";
            this.delaMail.Size = new System.Drawing.Size(100, 20);
            this.delaMail.TabIndex = 4;
            // 
            // catreMail
            // 
            this.catreMail.Location = new System.Drawing.Point(599, 9);
            this.catreMail.Name = "catreMail";
            this.catreMail.Size = new System.Drawing.Size(100, 20);
            this.catreMail.TabIndex = 5;
            // 
            // utilizatorBox
            // 
            this.utilizatorBox.Location = new System.Drawing.Point(420, 280);
            this.utilizatorBox.Name = "utilizatorBox";
            this.utilizatorBox.Size = new System.Drawing.Size(100, 20);
            this.utilizatorBox.TabIndex = 6;
            // 
            // parolaBox
            // 
            this.parolaBox.Location = new System.Drawing.Point(420, 307);
            this.parolaBox.Name = "parolaBox";
            this.parolaBox.PasswordChar = '*';
            this.parolaBox.Size = new System.Drawing.Size(100, 20);
            this.parolaBox.TabIndex = 7;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(527, 280);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(77, 47);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(420, 333);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(184, 23);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnCiteste
            // 
            this.btnCiteste.Location = new System.Drawing.Point(870, 152);
            this.btnCiteste.Name = "btnCiteste";
            this.btnCiteste.Size = new System.Drawing.Size(74, 23);
            this.btnCiteste.TabIndex = 10;
            this.btnCiteste.Text = "Read";
            this.btnCiteste.UseVisualStyleBackColor = true;
            this.btnCiteste.Click += new System.EventHandler(this.btnCiteste_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(870, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(870, 208);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 12;
            this.btnList.Text = "Show List Messages";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // mesajIDBox
            // 
            this.mesajIDBox.Location = new System.Drawing.Point(765, 182);
            this.mesajIDBox.Name = "mesajIDBox";
            this.mesajIDBox.Size = new System.Drawing.Size(99, 20);
            this.mesajIDBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(791, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "MesajID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Subiect";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(1, 237);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 173);
            this.listBox1.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(419, 139);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.Location = new System.Drawing.Point(696, 237);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(274, 173);
            this.listBox2.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(693, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Message List";
            // 
            // Logs
            // 
            this.Logs.AutoSize = true;
            this.Logs.Location = new System.Drawing.Point(1, 220);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(30, 13);
            this.Logs.TabIndex = 25;
            this.Logs.Text = "Logs";
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(830, 9);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(100, 20);
            this.subjectBox.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(781, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Subject";
            // 
            // msgBox
            // 
            this.msgBox.Location = new System.Drawing.Point(465, 47);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(465, 20);
            this.msgBox.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(830, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mesajIDBox);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCiteste);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.parolaBox);
            this.Controls.Add(this.utilizatorBox);
            this.Controls.Add(this.catreMail);
            this.Controls.Add(this.delaMail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox delaMail;
        private System.Windows.Forms.TextBox catreMail;
        private System.Windows.Forms.TextBox utilizatorBox;
        private System.Windows.Forms.TextBox parolaBox;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnCiteste;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox mesajIDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Logs;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.Button button1;
    }
}

