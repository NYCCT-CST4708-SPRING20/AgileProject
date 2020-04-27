namespace AgileProject.Forms
{
    partial class MainWindow
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
            this.pnMovies = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblMyList = new System.Windows.Forms.Label();
            this.lbMyMovies = new System.Windows.Forms.Label();
            this.pnGenre = new System.Windows.Forms.Panel();
            this.lbSearchBoxUnderline = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.pnUserOptions = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbSignOut = new System.Windows.Forms.Label();
            this.lbUserSetting = new System.Windows.Forms.Label();
            this.pbUserIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnUserOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMovies
            // 
            this.pnMovies.AutoScroll = true;
            this.pnMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnMovies.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pnMovies.Location = new System.Drawing.Point(0, 70);
            this.pnMovies.Name = "pnMovies";
            this.pnMovies.Size = new System.Drawing.Size(1424, 701);
            this.pnMovies.TabIndex = 4;
            this.pnMovies.UseWaitCursor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.Black;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.tbSearch.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbSearch.Location = new System.Drawing.Point(750, 23);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(250, 28);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.TabStop = false;
            this.tbSearch.Text = " Search a movie";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.White;
            this.lblHome.Location = new System.Drawing.Point(239, 20);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(86, 31);
            this.lblHome.TabIndex = 8;
            this.lblHome.Text = "Home";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.White;
            this.lblGenre.Location = new System.Drawing.Point(349, 20);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(89, 31);
            this.lblGenre.TabIndex = 9;
            this.lblGenre.Text = "Genre";
            this.lblGenre.Click += new System.EventHandler(this.lblGenre_Click);
            // 
            // lblMyList
            // 
            this.lblMyList.AutoSize = true;
            this.lblMyList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyList.ForeColor = System.Drawing.Color.White;
            this.lblMyList.Location = new System.Drawing.Point(459, 20);
            this.lblMyList.Name = "lblMyList";
            this.lblMyList.Size = new System.Drawing.Size(108, 31);
            this.lblMyList.TabIndex = 10;
            this.lblMyList.Text = "Wishlist";
            this.lblMyList.Click += new System.EventHandler(this.lblMyList_Click);
            // 
            // lbMyMovies
            // 
            this.lbMyMovies.AutoSize = true;
            this.lbMyMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbMyMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMyMovies.ForeColor = System.Drawing.Color.White;
            this.lbMyMovies.Location = new System.Drawing.Point(585, 20);
            this.lbMyMovies.Name = "lbMyMovies";
            this.lbMyMovies.Size = new System.Drawing.Size(143, 31);
            this.lbMyMovies.TabIndex = 11;
            this.lbMyMovies.Text = "My Movies";
            this.lbMyMovies.Click += new System.EventHandler(this.lbMyMovies_Click);
            // 
            // pnGenre
            // 
            this.pnGenre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnGenre.Location = new System.Drawing.Point(338, 61);
            this.pnGenre.Name = "pnGenre";
            this.pnGenre.Size = new System.Drawing.Size(120, 0);
            this.pnGenre.TabIndex = 12;
            this.pnGenre.Visible = false;
            // 
            // lbSearchBoxUnderline
            // 
            this.lbSearchBoxUnderline.BackColor = System.Drawing.Color.White;
            this.lbSearchBoxUnderline.ForeColor = System.Drawing.Color.White;
            this.lbSearchBoxUnderline.Location = new System.Drawing.Point(750, 54);
            this.lbSearchBoxUnderline.Name = "lbSearchBoxUnderline";
            this.lbSearchBoxUnderline.Size = new System.Drawing.Size(250, 1);
            this.lbSearchBoxUnderline.TabIndex = 13;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lbSearch.ForeColor = System.Drawing.Color.White;
            this.lbSearch.Location = new System.Drawing.Point(1006, 22);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(93, 29);
            this.lbSearch.TabIndex = 14;
            this.lbSearch.Text = "Search";
            this.lbSearch.Click += new System.EventHandler(this.lbSearch_Click);
            this.lbSearch.MouseLeave += new System.EventHandler(this.lbSearch_MouseLeave);
            this.lbSearch.MouseHover += new System.EventHandler(this.lbSearch_MouseHover);
            // 
            // pnUserOptions
            // 
            this.pnUserOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnUserOptions.Controls.Add(this.lbUserName);
            this.pnUserOptions.Controls.Add(this.lbSignOut);
            this.pnUserOptions.Controls.Add(this.lbUserSetting);
            this.pnUserOptions.Location = new System.Drawing.Point(1206, 59);
            this.pnUserOptions.Name = "pnUserOptions";
            this.pnUserOptions.Size = new System.Drawing.Size(200, 90);
            this.pnUserOptions.TabIndex = 16;
            this.pnUserOptions.Visible = false;
            // 
            // lbUserName
            // 
            this.lbUserName.BackColor = System.Drawing.Color.DimGray;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUserName.ForeColor = System.Drawing.Color.White;
            this.lbUserName.Location = new System.Drawing.Point(0, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(200, 30);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSignOut
            // 
            this.lbSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSignOut.ForeColor = System.Drawing.Color.White;
            this.lbSignOut.Location = new System.Drawing.Point(0, 60);
            this.lbSignOut.Name = "lbSignOut";
            this.lbSignOut.Size = new System.Drawing.Size(200, 30);
            this.lbSignOut.TabIndex = 1;
            this.lbSignOut.Text = "Sign Out";
            this.lbSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSignOut.Click += new System.EventHandler(this.lbSignOut_Click);
            this.lbSignOut.MouseLeave += new System.EventHandler(this.lbSignOut_MouseLeave);
            this.lbSignOut.MouseHover += new System.EventHandler(this.lbSignOut_MouseHover);
            // 
            // lbUserSetting
            // 
            this.lbUserSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbUserSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUserSetting.ForeColor = System.Drawing.Color.White;
            this.lbUserSetting.Location = new System.Drawing.Point(0, 30);
            this.lbUserSetting.Name = "lbUserSetting";
            this.lbUserSetting.Size = new System.Drawing.Size(200, 30);
            this.lbUserSetting.TabIndex = 0;
            this.lbUserSetting.Text = "User Setting";
            this.lbUserSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUserSetting.Click += new System.EventHandler(this.lbUserSetting_Click);
            this.lbUserSetting.MouseLeave += new System.EventHandler(this.lbUserSetting_MouseLeave);
            this.lbUserSetting.MouseHover += new System.EventHandler(this.lbUserSetting_MouseHover);
            // 
            // pbUserIcon
            // 
            this.pbUserIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUserIcon.Image = global::AgileProject.Properties.Resources.UserIcon;
            this.pbUserIcon.Location = new System.Drawing.Point(1367, 17);
            this.pbUserIcon.Name = "pbUserIcon";
            this.pbUserIcon.Size = new System.Drawing.Size(36, 36);
            this.pbUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserIcon.TabIndex = 15;
            this.pbUserIcon.TabStop = false;
            this.pbUserIcon.Click += new System.EventHandler(this.pbUserIcon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgileProject.Properties.Resources.popcorn;
            this.pictureBox1.Location = new System.Drawing.Point(8, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1424, 771);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnUserOptions);
            this.Controls.Add(this.pbUserIcon);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.lbSearchBoxUnderline);
            this.Controls.Add(this.pnGenre);
            this.Controls.Add(this.lbMyMovies);
            this.Controls.Add(this.lblMyList);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pnMovies);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnUserOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnMovies;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblMyList;
        private System.Windows.Forms.Label lbMyMovies;
        private System.Windows.Forms.Panel pnGenre;
        private System.Windows.Forms.Label lbSearchBoxUnderline;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.PictureBox pbUserIcon;
        private System.Windows.Forms.Panel pnUserOptions;
        private System.Windows.Forms.Label lbSignOut;
        private System.Windows.Forms.Label lbUserSetting;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

