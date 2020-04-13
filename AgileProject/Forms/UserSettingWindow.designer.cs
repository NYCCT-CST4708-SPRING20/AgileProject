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
            this.label1.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(304, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change password: ";
            // 
            // changePw
            // 
            this.changePw.Location = new System.Drawing.Point(388, 680);
            this.changePw.Margin = new System.Windows.Forms.Padding(4);
            this.changePw.Name = "changePw";
            this.changePw.Size = new System.Drawing.Size(272, 71);
            this.changePw.TabIndex = 4;
            this.changePw.Text = "Save Change";
            this.changePw.UseVisualStyleBackColor = true;
            this.changePw.Click += new System.EventHandler(this.saveChanges);
            // 
            // textNewpassword
            // 
            this.textNewpassword.Location = new System.Drawing.Point(486, 503);
            this.textNewpassword.Margin = new System.Windows.Forms.Padding(4);
            this.textNewpassword.Name = "textNewpassword";
            this.textNewpassword.PasswordChar = '*';
            this.textNewpassword.Size = new System.Drawing.Size(300, 31);
            this.textNewpassword.TabIndex = 4;
            // 
            // confrimPassword
            // 
            this.confrimPassword.Location = new System.Drawing.Point(486, 568);
            this.confrimPassword.Margin = new System.Windows.Forms.Padding(4);
            this.confrimPassword.Name = "confrimPassword";
            this.confrimPassword.PasswordChar = '*';
            this.confrimPassword.Size = new System.Drawing.Size(300, 31);
            this.confrimPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 580);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Confrim Password:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 507);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter New Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "First name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 305);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email address: ";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(484, 294);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(300, 31);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxLname
            // 
            this.textBoxLname.Location = new System.Drawing.Point(484, 226);
            this.textBoxLname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(300, 31);
            this.textBoxLname.TabIndex = 8;
            this.textBoxLname.TextChanged += new System.EventHandler(this.textBoxLname_TextChanged);
            // 
            // textBoxFname
            // 
            this.textBoxFname.Location = new System.Drawing.Point(484, 144);
            this.textBoxFname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(300, 31);
            this.textBoxFname.TabIndex = 9;
            this.textBoxFname.TextChanged += new System.EventHandler(this.textBoxFname_TextChanged);
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(484, 359);
            this.textBoxOldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '*';
            this.textBoxOldPassword.Size = new System.Drawing.Size(300, 31);
            this.textBoxOldPassword.TabIndex = 11;
            this.textBoxOldPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // oldPassword
            // 
            this.oldPassword.AutoSize = true;
            this.oldPassword.Location = new System.Drawing.Point(216, 370);
            this.oldPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(143, 25);
            this.oldPassword.TabIndex = 10;
            this.oldPassword.Text = "Old password";
            // 
            // UserSettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 879);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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

