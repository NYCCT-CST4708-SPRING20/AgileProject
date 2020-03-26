namespace BillingWindow
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
            this.creditCardDateMonth = new System.Windows.Forms.TextBox();
            this.securityCode = new System.Windows.Forms.TextBox();
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
            this.creditCardDateYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // billingInfo
            // 
            this.billingInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.billingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.billingInfo.Location = new System.Drawing.Point(17, 15);
            this.billingInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.billingInfo.Name = "billingInfo";
            this.billingInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.billingInfo.Size = new System.Drawing.Size(265, 38);
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
            this.name.Location = new System.Drawing.Point(17, 69);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(191, 36);
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
            this.billingAddress.Location = new System.Drawing.Point(17, 162);
            this.billingAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.billingAddress.Name = "billingAddress";
            this.billingAddress.Size = new System.Drawing.Size(191, 42);
            this.billingAddress.TabIndex = 1;
            this.billingAddress.Text = "Billing Address";
            this.billingAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.billingAddress.UseCompatibleTextRendering = true;
            this.billingAddress.UseWaitCursor = true;
            this.billingAddress.Click += new System.EventHandler(this.name_Click);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(20, 123);
            this.firstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(76, 20);
            this.firstName.TabIndex = 2;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(134, 123);
            this.lastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(76, 20);
            this.lastName.TabIndex = 2;
            this.lastName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // addressLine1
            // 
            this.addressLine1.Location = new System.Drawing.Point(20, 228);
            this.addressLine1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressLine1.Name = "addressLine1";
            this.addressLine1.Size = new System.Drawing.Size(190, 20);
            this.addressLine1.TabIndex = 2;
            // 
            // addressLine2
            // 
            this.addressLine2.Location = new System.Drawing.Point(20, 266);
            this.addressLine2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressLine2.Name = "addressLine2";
            this.addressLine2.Size = new System.Drawing.Size(190, 20);
            this.addressLine2.TabIndex = 2;
            this.addressLine2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(20, 306);
            this.state.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(76, 20);
            this.state.TabIndex = 2;
            // 
            // zipCode
            // 
            this.zipCode.Location = new System.Drawing.Point(20, 357);
            this.zipCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(76, 20);
            this.zipCode.TabIndex = 2;
            this.zipCode.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // paymentMethod
            // 
            this.paymentMethod.BackColor = System.Drawing.SystemColors.ControlDark;
            this.paymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.paymentMethod.Location = new System.Drawing.Point(382, 162);
            this.paymentMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.Size = new System.Drawing.Size(191, 42);
            this.paymentMethod.TabIndex = 1;
            this.paymentMethod.Text = "Payment Method";
            this.paymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paymentMethod.UseCompatibleTextRendering = true;
            this.paymentMethod.UseWaitCursor = true;
            this.paymentMethod.Click += new System.EventHandler(this.name_Click);
            // 
            // creditCardNum
            // 
            this.creditCardNum.Location = new System.Drawing.Point(382, 228);
            this.creditCardNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.creditCardNum.Name = "creditCardNum";
            this.creditCardNum.Size = new System.Drawing.Size(190, 20);
            this.creditCardNum.TabIndex = 2;
            // 
            // creditCardDateMonth
            // 
            this.creditCardDateMonth.Location = new System.Drawing.Point(382, 266);
            this.creditCardDateMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.creditCardDateMonth.Name = "creditCardDateMonth";
            this.creditCardDateMonth.Size = new System.Drawing.Size(33, 20);
            this.creditCardDateMonth.TabIndex = 2;
            // 
            // securityCode
            // 
            this.securityCode.Location = new System.Drawing.Point(496, 266);
            this.securityCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.securityCode.Name = "securityCode";
            this.securityCode.Size = new System.Drawing.Size(76, 20);
            this.securityCode.TabIndex = 2;
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cancel.ForeColor = System.Drawing.Color.Black;
            this.cancel.Location = new System.Drawing.Point(382, 344);
            this.cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(105, 33);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // purchase
            // 
            this.purchase.BackColor = System.Drawing.Color.SeaGreen;
            this.purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.purchase.ForeColor = System.Drawing.SystemColors.Control;
            this.purchase.Location = new System.Drawing.Point(496, 344);
            this.purchase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(87, 33);
            this.purchase.TabIndex = 3;
            this.purchase.Text = "Buy";
            this.purchase.UseVisualStyleBackColor = false;
            this.purchase.Click += new System.EventHandler(this.purchase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(29, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "first";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(143, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "last";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(29, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(29, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address 2";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(26, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip Code";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(29, 289);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "State";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(388, 209);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Credit Card Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(386, 248);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Expiry Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(494, 248);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Security Code";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(132, 306);
            this.city.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(76, 20);
            this.city.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(142, 288);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "City";
            this.label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // creditCardDateYear
            // 
            this.creditCardDateYear.Location = new System.Drawing.Point(419, 266);
            this.creditCardDateYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.creditCardDateYear.Name = "creditCardDateYear";
            this.creditCardDateYear.Size = new System.Drawing.Size(53, 20);
            this.creditCardDateYear.TabIndex = 2;
            // 
            // BillingFormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 449);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.securityCode);
            this.Controls.Add(this.zipCode);
            this.Controls.Add(this.creditCardDateYear);
            this.Controls.Add(this.creditCardDateMonth);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox creditCardDateMonth;
        private System.Windows.Forms.TextBox securityCode;
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
        private System.Windows.Forms.TextBox creditCardDateYear;
    }
}

