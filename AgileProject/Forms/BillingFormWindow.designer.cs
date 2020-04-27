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
            this.city = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.securityCode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPriceTag = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pbMoviePoster = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoviePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // billingAddress
            // 
            this.billingAddress.BackColor = System.Drawing.SystemColors.ControlDark;
            this.billingAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.billingAddress.Location = new System.Drawing.Point(240, 10);
            this.billingAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.billingAddress.Name = "billingAddress";
            this.billingAddress.Size = new System.Drawing.Size(200, 40);
            this.billingAddress.TabIndex = 1;
            this.billingAddress.Text = "Billing Address";
            this.billingAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.billingAddress.UseCompatibleTextRendering = true;
            this.billingAddress.UseWaitCursor = true;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(10, 85);
            this.firstName.Margin = new System.Windows.Forms.Padding(2);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(200, 20);
            this.firstName.TabIndex = 1;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(10, 135);
            this.lastName.Margin = new System.Windows.Forms.Padding(2);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(200, 20);
            this.lastName.TabIndex = 2;
            // 
            // addressLine1
            // 
            this.addressLine1.Location = new System.Drawing.Point(240, 85);
            this.addressLine1.Margin = new System.Windows.Forms.Padding(2);
            this.addressLine1.Name = "addressLine1";
            this.addressLine1.Size = new System.Drawing.Size(200, 20);
            this.addressLine1.TabIndex = 7;
            // 
            // addressLine2
            // 
            this.addressLine2.Location = new System.Drawing.Point(240, 135);
            this.addressLine2.Margin = new System.Windows.Forms.Padding(2);
            this.addressLine2.Name = "addressLine2";
            this.addressLine2.Size = new System.Drawing.Size(200, 20);
            this.addressLine2.TabIndex = 8;
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(240, 185);
            this.state.Margin = new System.Windows.Forms.Padding(2);
            this.state.MaxLength = 2;
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(90, 20);
            this.state.TabIndex = 9;
            // 
            // zipCode
            // 
            this.zipCode.Location = new System.Drawing.Point(240, 235);
            this.zipCode.Margin = new System.Windows.Forms.Padding(2);
            this.zipCode.MaxLength = 5;
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(76, 20);
            this.zipCode.TabIndex = 11;
            this.zipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitOnly_KeyPress);
            // 
            // paymentMethod
            // 
            this.paymentMethod.BackColor = System.Drawing.SystemColors.ControlDark;
            this.paymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.paymentMethod.Location = new System.Drawing.Point(10, 10);
            this.paymentMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.Size = new System.Drawing.Size(200, 40);
            this.paymentMethod.TabIndex = 1;
            this.paymentMethod.Text = "Payment Info";
            this.paymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paymentMethod.UseCompatibleTextRendering = true;
            this.paymentMethod.UseWaitCursor = true;
            // 
            // creditCardNum
            // 
            this.creditCardNum.Location = new System.Drawing.Point(10, 185);
            this.creditCardNum.Margin = new System.Windows.Forms.Padding(2);
            this.creditCardNum.MaxLength = 16;
            this.creditCardNum.Name = "creditCardNum";
            this.creditCardNum.Size = new System.Drawing.Size(200, 20);
            this.creditCardNum.TabIndex = 3;
            this.creditCardNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitOnly_KeyPress);
            // 
            // ccMonth
            // 
            this.ccMonth.Location = new System.Drawing.Point(10, 235);
            this.ccMonth.Margin = new System.Windows.Forms.Padding(2);
            this.ccMonth.MaxLength = 2;
            this.ccMonth.Name = "ccMonth";
            this.ccMonth.Size = new System.Drawing.Size(50, 20);
            this.ccMonth.TabIndex = 4;
            this.ccMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitOnly_KeyPress);
            // 
            // ccYear
            // 
            this.ccYear.Location = new System.Drawing.Point(80, 235);
            this.ccYear.Margin = new System.Windows.Forms.Padding(2);
            this.ccYear.MaxLength = 4;
            this.ccYear.Name = "ccYear";
            this.ccYear.Size = new System.Drawing.Size(80, 20);
            this.ccYear.TabIndex = 5;
            this.ccYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitOnly_KeyPress);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cancel.ForeColor = System.Drawing.Color.Black;
            this.cancel.Location = new System.Drawing.Point(574, 295);
            this.cancel.Margin = new System.Windows.Forms.Padding(2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(105, 33);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // purchase
            // 
            this.purchase.BackColor = System.Drawing.Color.SeaGreen;
            this.purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.purchase.ForeColor = System.Drawing.SystemColors.Control;
            this.purchase.Location = new System.Drawing.Point(683, 295);
            this.purchase.Margin = new System.Windows.Forms.Padding(2);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(87, 33);
            this.purchase.TabIndex = 12;
            this.purchase.Text = "Buy";
            this.purchase.UseVisualStyleBackColor = false;
            this.purchase.Click += new System.EventHandler(this.purchase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(10, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(240, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(240, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(240, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip Code *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(240, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "State *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(10, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Credit Card Number *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(10, 215);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Expiration Date *";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(350, 185);
            this.city.Margin = new System.Windows.Forms.Padding(2);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(90, 20);
            this.city.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(350, 165);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "City *";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(10, 255);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "MM";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(80, 255);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "YYYY";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(10, 285);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "Security Code *";
            // 
            // securityCode
            // 
            this.securityCode.Location = new System.Drawing.Point(10, 305);
            this.securityCode.MaxLength = 3;
            this.securityCode.Name = "securityCode";
            this.securityCode.Size = new System.Drawing.Size(46, 20);
            this.securityCode.TabIndex = 6;
            this.securityCode.UseSystemPasswordChar = true;
            this.securityCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitOnly_KeyPress);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label15.Location = new System.Drawing.Point(470, 10);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(300, 40);
            this.label15.TabIndex = 7;
            this.label15.Text = "Product Info";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.UseCompatibleTextRendering = true;
            this.label15.UseWaitCursor = true;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMovieName.Location = new System.Drawing.Point(580, 65);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(148, 13);
            this.lblMovieName.TabIndex = 9;
            this.lblMovieName.Text = "Movie Name Placeholder";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(580, 85);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(102, 13);
            this.lblGenre.TabIndex = 10;
            this.lblGenre.Text = "Genre: Genre Name";
            // 
            // lblPriceTag
            // 
            this.lblPriceTag.AutoSize = true;
            this.lblPriceTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPriceTag.Location = new System.Drawing.Point(605, 249);
            this.lblPriceTag.Name = "lblPriceTag";
            this.lblPriceTag.Size = new System.Drawing.Size(74, 26);
            this.lblPriceTag.TabIndex = 11;
            this.lblPriceTag.Text = "Price: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPrice.Location = new System.Drawing.Point(692, 249);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 26);
            this.lblPrice.TabIndex = 12;
            // 
            // pbMoviePoster
            // 
            this.pbMoviePoster.Location = new System.Drawing.Point(470, 65);
            this.pbMoviePoster.Name = "pbMoviePoster";
            this.pbMoviePoster.Size = new System.Drawing.Size(100, 144);
            this.pbMoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMoviePoster.TabIndex = 8;
            this.pbMoviePoster.TabStop = false;
            // 
            // BillingFormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(787, 339);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPriceTag);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.pbMoviePoster);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.securityCode);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
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
            this.Controls.Add(this.ccMonth);
            this.Controls.Add(this.city);
            this.Controls.Add(this.state);
            this.Controls.Add(this.addressLine2);
            this.Controls.Add(this.creditCardNum);
            this.Controls.Add(this.addressLine1);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.paymentMethod);
            this.Controls.Add(this.billingAddress);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BillingFormWindow";
            this.Text = "Billing Form";
            this.Load += new System.EventHandler(this.BillingFormWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMoviePoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox securityCode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pbMoviePoster;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPriceTag;
        private System.Windows.Forms.Label lblPrice;
    }
}

