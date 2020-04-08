namespace AgileProject.Forms
{
    partial class RegistrationWindow
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
            this.btnregister = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.confirmpass = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.userid = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnregister.Location = new System.Drawing.Point(177, 314);
            this.btnregister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(189, 31);
            this.btnregister.TabIndex = 0;
            this.btnregister.Text = "Create Account";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 193);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 1;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.BackColor = System.Drawing.Color.Yellow;
            this.gender.Location = new System.Drawing.Point(142, 197);
            this.gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(40, 13);
            this.gender.TabIndex = 2;
            this.gender.Text = "gender";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.Color.Yellow;
            this.pass.Location = new System.Drawing.Point(125, 241);
            this.pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(53, 13);
            this.pass.TabIndex = 4;
            this.pass.Text = "Password";
            // 
            // confirmpass
            // 
            this.confirmpass.AutoSize = true;
            this.confirmpass.BackColor = System.Drawing.Color.Yellow;
            this.confirmpass.Location = new System.Drawing.Point(91, 285);
            this.confirmpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmpass.Name = "confirmpass";
            this.confirmpass.Size = new System.Drawing.Size(90, 13);
            this.confirmpass.TabIndex = 5;
            this.confirmpass.Text = "Confirm password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(213, 281);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(213, 237);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.SkyBlue;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox4.Location = new System.Drawing.Point(-3, 0);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(521, 59);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "User Registration";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // userid
            // 
            this.userid.AutoSize = true;
            this.userid.BackColor = System.Drawing.Color.Yellow;
            this.userid.Location = new System.Drawing.Point(125, 159);
            this.userid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(57, 13);
            this.userid.TabIndex = 9;
            this.userid.Text = "UserName";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.BackColor = System.Drawing.Color.Yellow;
            this.lastname.Location = new System.Drawing.Point(125, 120);
            this.lastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(55, 13);
            this.lastname.TabIndex = 10;
            this.lastname.Text = "LastName";
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.BackColor = System.Drawing.Color.Yellow;
            this.firstname.Location = new System.Drawing.Point(125, 81);
            this.firstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(54, 13);
            this.firstname.TabIndex = 11;
            this.firstname.Text = "FirstName";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(213, 155);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(153, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(213, 116);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(153, 20);
            this.textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(213, 79);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(153, 20);
            this.textBox7.TabIndex = 14;
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(517, 382);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.confirmpass);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnregister);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistrationWindow";
            this.Text = "SignInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label confirmpass;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label userid;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
    }
}