using System.Drawing;

namespace AgileProject.Forms
{
    partial class ForgotPasswordWindow
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
            this.lbMessage1 = new System.Windows.Forms.Label();
            this.lbMessage2 = new System.Windows.Forms.Label();
            this.gbEmail = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMessage1
            // 
            this.lbMessage1.AutoSize = true;
            this.lbMessage1.Location = new System.Drawing.Point(51, 32);
            this.lbMessage1.Name = "lbMessage1";
            this.lbMessage1.Size = new System.Drawing.Size(259, 13);
            this.lbMessage1.TabIndex = 0;
            this.lbMessage1.Text = "Enter your the email address that you used to register.";
            // 
            // lbMessage2
            // 
            this.lbMessage2.AutoSize = true;
            this.lbMessage2.Location = new System.Drawing.Point(41, 45);
            this.lbMessage2.Name = "lbMessage2";
            this.lbMessage2.Size = new System.Drawing.Size(280, 13);
            this.lbMessage2.TabIndex = 1;
            this.lbMessage2.Text = "We\'ll send you an email with a link to reset your password.";
            // 
            // gbEmail
            // 
            this.gbEmail.Controls.Add(this.tbEmail);
            this.gbEmail.Location = new System.Drawing.Point(41, 70);
            this.gbEmail.Name = "gbEmail";
            this.gbEmail.Size = new System.Drawing.Size(280, 51);
            this.gbEmail.TabIndex = 2;
            this.gbEmail.TabStop = false;
            this.gbEmail.Text = "Email Address";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(10, 20);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(256, 20);
            this.tbEmail.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(234, 128);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ForgotPasswordWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 184);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.gbEmail);
            this.Controls.Add(this.lbMessage2);
            this.Controls.Add(this.lbMessage1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ForgotPasswordWindow";
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.ForgotPasswordWindow_Load);
            this.gbEmail.ResumeLayout(false);
            this.gbEmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMessage1;
        private System.Windows.Forms.Label lbMessage2;
        private System.Windows.Forms.GroupBox gbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnSend;
    }
}