namespace AgileProject.Forms
{
    partial class UserSettingWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.changePw = new System.Windows.Forms.Button();
            this.textNewpassword = new System.Windows.Forms.TextBox();
            this.confrimPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.oldPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Setting";
            // 
            // changePw
            // 
            this.changePw.Location = new System.Drawing.Point(85, 274);
            this.changePw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changePw.Name = "changePw";
            this.changePw.Size = new System.Drawing.Size(167, 28);
            this.changePw.TabIndex = 4;
            this.changePw.Text = "Save Change";
            this.changePw.UseVisualStyleBackColor = true;
            this.changePw.Click += new System.EventHandler(this.saveChanges);
            // 
            // textNewpassword
            // 
            this.textNewpassword.Location = new System.Drawing.Point(160, 187);
            this.textNewpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNewpassword.Name = "textNewpassword";
            this.textNewpassword.PasswordChar = '*';
            this.textNewpassword.Size = new System.Drawing.Size(152, 20);
            this.textNewpassword.TabIndex = 4;
            // 
            // confrimPassword
            // 
            this.confrimPassword.Location = new System.Drawing.Point(160, 217);
            this.confrimPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confrimPassword.Name = "confrimPassword";
            this.confrimPassword.PasswordChar = '*';
            this.confrimPassword.Size = new System.Drawing.Size(152, 20);
            this.confrimPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Confrim Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter New Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "First name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email address: ";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(160, 127);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(152, 20);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxLname
            // 
            this.textBoxLname.Location = new System.Drawing.Point(160, 97);
            this.textBoxLname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(152, 20);
            this.textBoxLname.TabIndex = 8;
            this.textBoxLname.TextChanged += new System.EventHandler(this.textBoxLname_TextChanged);
            // 
            // textBoxFname
            // 
            this.textBoxFname.Location = new System.Drawing.Point(160, 67);
            this.textBoxFname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(152, 20);
            this.textBoxFname.TabIndex = 9;
            this.textBoxFname.TextChanged += new System.EventHandler(this.textBoxFname_TextChanged);
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(160, 157);
            this.textBoxOldPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '*';
            this.textBoxOldPassword.Size = new System.Drawing.Size(152, 20);
            this.textBoxOldPassword.TabIndex = 11;
            // 
            // oldPassword
            // 
            this.oldPassword.AutoSize = true;
            this.oldPassword.Location = new System.Drawing.Point(35, 160);
            this.oldPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(71, 13);
            this.oldPassword.TabIndex = 10;
            this.oldPassword.Text = "Old password";
            // 
            // UserSettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 313);
            this.Controls.Add(this.changePw);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.textNewpassword);
            this.Controls.Add(this.oldPassword);
            this.Controls.Add(this.confrimPassword);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserSettingWindow";
            this.Text = "User Setting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNewpassword;
        private System.Windows.Forms.TextBox confrimPassword;
        private System.Windows.Forms.Button changePw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.Label oldPassword;
    }
}

