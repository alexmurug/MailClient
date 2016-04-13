namespace SMTPClient
{
    partial class Send_Mail
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
            this.toBox = new System.Windows.Forms.TextBox();
            this.fromBox = new System.Windows.Forms.TextBox();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.MessageSend = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toBox
            // 
            this.toBox.Location = new System.Drawing.Point(231, 12);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(178, 20);
            this.toBox.TabIndex = 0;
            // 
            // fromBox
            // 
            this.fromBox.Location = new System.Drawing.Point(75, 12);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(114, 20);
            this.fromBox.TabIndex = 1;
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(75, 38);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(334, 20);
            this.subjectBox.TabIndex = 2;
            // 
            // MessageSend
            // 
            this.MessageSend.Location = new System.Drawing.Point(28, 103);
            this.MessageSend.Name = "MessageSend";
            this.MessageSend.Size = new System.Drawing.Size(381, 364);
            this.MessageSend.TabIndex = 3;
            this.MessageSend.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subject";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(287, 64);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(122, 33);
            this.SendButton.TabIndex = 8;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // Send_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 479);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessageSend);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.toBox);
            this.Name = "Send_Mail";
            this.Text = "Send_Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.TextBox fromBox;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.RichTextBox MessageSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SendButton;
    }
}