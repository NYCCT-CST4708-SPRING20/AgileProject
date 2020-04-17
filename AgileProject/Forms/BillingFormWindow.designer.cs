namespace AgileProject.Forms
{
    partial class BillingFormWindow
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
            this.billingInfo = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.billingAddress = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.addressLine1 = new System.Windows.Forms.TextBox();
            this.addressLine2 = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.zipCode = new System.Windows.Forms.TextBox();
            this.paymentMethod = new System.Windows.Forms.Label();
            this.creditCardNum = new System.Windows.Forms.TextBox();
            this.ccMonth = new System.Windows.Forms.TextBox();
            this.ccYear = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.purchase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ccDay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // billingInfo
            // 
            this.billingInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.billingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.billingInfo.Location = new System.Drawing.Point(23, 18);
            this.billingInfo.Name = "billingInfo";
            this.billingInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.billingInfo.Size = new System.Drawing.Size(353, 47);
            this.billingInfo.TabIndex = 0;
            this.billingInfo.Text = "Billing Information";
            this.billingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.billingInfo.UseCompatibleTextRendering = true;
            this.billingInfo.UseWaitCursor = true;
            this.billingInfo.Click += new System.EventHandler(this.billingInfo_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ControlDark;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.name.Location = new System.Drawing.Point(23, 85);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(255, 44);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.name.UseCompatibleTextRendering = true;
            this.name.UseWaitCursor = true;
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // billingAddress
            // 
            this.billingAddress.BackColor = System.Drawing.SystemColors.ControlDark;
            this.billingAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.billingAddress.Location = new System.Drawing.Point(23, 199);
            this.billingAddress.Name = "billingAddress";
            this.billingAddress.Size = new System.Drawing.Size(255, 52);
            this.billingAddress.TabIndex = 1;
            this.billingAddress.Text = "Billing Address";
            this.billingAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.billingAddress.UseCompatibleTextRendering = true;
            this.billingAddress.UseWaitCursor = true;
            this.billingAddress.Click += new System.EventHandler(this.name_Click);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(27, 151);
            this.firstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 22);
            this.firstName.TabIndex = 2;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(179, 151);
            this.lastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 22);
            this.lastName.TabIndex = 2;
            this.lastName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // addressLine1
            // 
            this.addressLine1.Location = new System.Drawing.Point(27, 281);
            this.addressLine1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressLine1.Name = "addressLine1";
            this.addressLine1.Size = new System.Drawing.Size(252, 22);
            this.addressLine1.TabIndex = 2;
            // 
            // addressLine2
            // 
            this.addressLine2.Location = new System.Drawing.Point(27, 327);
            this.addressLine2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressLine2.Name = "addressLine2";
            this.addressLine2.Size = new System.Drawing.Size(252, 22);
            this.addressLine2.TabIndex = 2;
            this.addressLine2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(27, 377);
            this.state.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(100, 22);
            this.state.TabIndex = 2;
            // 
            // zipCode
            // 
            this.zipCode.Location = new System.Drawing.Point(27, 439);
            this.zipCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(100, 22);
            this.zipCode.TabIndex = 2;
            this.zipCode.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // paymentMethod
            // 
            this.paymentMethod.BackColor = System.Drawing.SystemColors.ControlDark;
            this.paymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.paymentMethod.Location = new System.Drawing.Point(509, 199);
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.Size = new System.Drawing.Size(255, 52);
            this.paymentMethod.TabIndex = 1;
            this.paymentMethod.Text = "Payment Method";
            this.paymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paymentMethod.UseCompatibleTextRendering = true;
            this.paymentMethod.UseWaitCursor = true;
            this.paymentMethod.Click += new System.EventHandler(this.name_Click);
            // 
            // creditCardNum
            // 
            this.creditCardNum.Location = new System.Drawing.Point(509, 281);
            this.creditCardNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.creditCardNum.Name = "creditCardNum";
            this.creditCardNum.Size = new System.Drawing.Size(252, 22);
            this.creditCardNum.TabIndex = 2;
            // 
            // ccMonth
            // 
            this.ccMonth.Location = new System.Drawing.Point(537, 327);
            this.ccMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccMonth.Name = "ccMonth";
            this.ccMonth.Size = new System.Drawing.Size(60, 22);
            this.ccMonth.TabIndex = 2;
            // 
            // ccYear
            // 
            this.ccYear.Location = new System.Drawing.Point(663, 327);
            this.ccYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccYear.Name = "ccYear";
            this.ccYear.Size = new System.Drawing.Size(78, 22);
            this.ccYear.TabIndex = 2;
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cancel.ForeColor = System.Drawing.Color.Black;
            this.cancel.Location = new System.Drawing.Point(509, 423);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(140, 41);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // purchase
            // 
            this.purchase.BackColor = System.Drawing.Color.SeaGreen;
            this.purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.purchase.ForeColor = System.Drawing.SystemColors.Control;
            this.purchase.Location = new System.Drawing.Point(661, 423);
            this.purchase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(116, 41);
            this.purchase.TabIndex = 3;
            this.purchase.Text = "Buy";
            this.purchase.UseVisualStyleBackColor = false;
            this.purchase.Click += new System.EventHandler(this.purchase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(39, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "first";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(191, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "last";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(39, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(39, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address 2";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(35, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip Code";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(39, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "State";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(517, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Credit Card Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(548, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Expiration Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(659, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 4;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(176, 377);
            this.city.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 22);
            this.city.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(189, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "City";
            this.label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // ccDay
            // 
            this.ccDay.Location = new System.Drawing.Point(603, 327);
            this.ccDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccDay.Name = "ccDay";
            this.ccDay.Size = new System.Drawing.Size(54, 22);
            this.ccDay.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(548, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "MM";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(614, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "DD";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(679, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "YYYY";
            this.label13.Click += new System.EventHandler(this.label12_Click);
            // 
            // BillingFormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.purchase);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.ccYear);
            this.Controls.Add(this.zipCode);
            this.Controls.Add(this.ccDay);
            this.Controls.Add(this.ccMonth);
            this.Controls.Add(this.city);
            this.Controls.Add(this.state);
            this.Controls.Add(this.addressLine2);
            this.Controls.Add(this.creditCardNum);
            this.Controls.Add(this.addressLine1);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.paymentMethod);
            this.Controls.Add(this.billingAddress);
            this.Controls.Add(this.name);
            this.Controls.Add(this.billingInfo);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BillingFormWindow";
            this.Text = "Billing Form";
            this.Load += new System.EventHandler(this.billingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label billingInfo;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label billingAddress;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox addressLine1;
        private System.Windows.Forms.TextBox addressLine2;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.TextBox zipCode;
        private System.Windows.Forms.Label paymentMethod;
        private System.Windows.Forms.TextBox creditCardNum;
        private System.Windows.Forms.TextBox ccMonth;
        private System.Windows.Forms.TextBox ccYear;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button purchase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ccDay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

