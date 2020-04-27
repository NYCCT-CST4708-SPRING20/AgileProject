namespace AgileProject.Forms
{
    partial class LoginWindow
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
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblForgotPw = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(137, 126);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(166, 20);
            this.tbEmail.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(137, 165);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(166, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(51, 129);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email: ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(51, 168);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password: ";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(54, 210);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(249, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUp.ForeColor = System.Drawing.Color.White;
            this.lblSignUp.Location = new System.Drawing.Point(51, 240);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(45, 13);
            this.lblSignUp.TabIndex = 5;
            this.lblSignUp.Text = "Sign Up";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // lblForgotPw
            // 
            this.lblForgotPw.AutoSize = true;
            this.lblForgotPw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPw.ForeColor = System.Drawing.Color.White;
            this.lblForgotPw.Location = new System.Drawing.Point(211, 240);
            this.lblForgotPw.Name = "lblForgotPw";
            this.lblForgotPw.Size = new System.Drawing.Size(92, 13);
            this.lblForgotPw.TabIndex = 6;
            this.lblForgotPw.Text = "Forgot Password?";
            this.lblForgotPw.Click += new System.EventHandler(this.lblForgotPw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 108);
            this.label1.TabIndex = 7;
            this.label1.Text = "LOGO";
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(360, 298);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblForgotPw);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginWindow";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblForgotPw;
        private System.Windows.Forms.Label label1;
    }
}

