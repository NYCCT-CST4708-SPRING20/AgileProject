namespace AgileProject.Forms
{
    partial class MovieInfoWindow
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
            this.pbMoviePoster = new System.Windows.Forms.PictureBox();
            this.lbMovieName = new System.Windows.Forms.Label();
            this.lbMovieYear = new System.Windows.Forms.Label();
            this.lbMovieTime = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbHorizontalLine = new System.Windows.Forms.Label();
            this.lbCreditsTitle = new System.Windows.Forms.Label();
            this.lbCredit1 = new System.Windows.Forms.Label();
            this.lbCredit2 = new System.Windows.Forms.Label();
            this.lbCredit3 = new System.Windows.Forms.Label();
            this.lbCredit4 = new System.Windows.Forms.Label();
            this.tbCredit1 = new System.Windows.Forms.TextBox();
            this.tbCredit2 = new System.Windows.Forms.TextBox();
            this.tbCredit4 = new System.Windows.Forms.TextBox();
            this.tbCredit3 = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoviePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMoviePoster
            // 
            this.pbMoviePoster.Location = new System.Drawing.Point(8, 12);
            this.pbMoviePoster.Name = "pbMoviePoster";
            this.pbMoviePoster.Size = new System.Drawing.Size(192, 276);
            this.pbMoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMoviePoster.TabIndex = 0;
            this.pbMoviePoster.TabStop = false;
            // 
            // lbMovieName
            // 
            this.lbMovieName.AutoSize = true;
            this.lbMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMovieName.ForeColor = System.Drawing.Color.White;
            this.lbMovieName.Location = new System.Drawing.Point(211, 15);
            this.lbMovieName.Name = "lbMovieName";
            this.lbMovieName.Size = new System.Drawing.Size(0, 31);
            this.lbMovieName.TabIndex = 1;
            // 
            // lbMovieYear
            // 
            this.lbMovieYear.AutoSize = true;
            this.lbMovieYear.ForeColor = System.Drawing.Color.White;
            this.lbMovieYear.Location = new System.Drawing.Point(214, 50);
            this.lbMovieYear.Name = "lbMovieYear";
            this.lbMovieYear.Size = new System.Drawing.Size(0, 13);
            this.lbMovieYear.TabIndex = 2;
            // 
            // lbMovieTime
            // 
            this.lbMovieTime.AutoSize = true;
            this.lbMovieTime.ForeColor = System.Drawing.Color.White;
            this.lbMovieTime.Location = new System.Drawing.Point(269, 50);
            this.lbMovieTime.Name = "lbMovieTime";
            this.lbMovieTime.Size = new System.Drawing.Size(0, 13);
            this.lbMovieTime.TabIndex = 3;
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbGenre.Location = new System.Drawing.Point(215, 70);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(0, 13);
            this.lbGenre.TabIndex = 4;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.Black;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.ForeColor = System.Drawing.Color.White;
            this.tbDescription.Location = new System.Drawing.Point(217, 95);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(548, 139);
            this.tbDescription.TabIndex = 5;
            this.tbDescription.TabStop = false;
            // 
            // lbHorizontalLine
            // 
            this.lbHorizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbHorizontalLine.Location = new System.Drawing.Point(9, 299);
            this.lbHorizontalLine.Name = "lbHorizontalLine";
            this.lbHorizontalLine.Size = new System.Drawing.Size(780, 1);
            this.lbHorizontalLine.TabIndex = 6;
            // 
            // lbCreditsTitle
            // 
            this.lbCreditsTitle.AutoSize = true;
            this.lbCreditsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCreditsTitle.ForeColor = System.Drawing.Color.White;
            this.lbCreditsTitle.Location = new System.Drawing.Point(12, 312);
            this.lbCreditsTitle.Name = "lbCreditsTitle";
            this.lbCreditsTitle.Size = new System.Drawing.Size(140, 17);
            this.lbCreditsTitle.TabIndex = 7;
            this.lbCreditsTitle.Text = "CAST AND CREDITS";
            // 
            // lbCredit1
            // 
            this.lbCredit1.AutoSize = true;
            this.lbCredit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCredit1.ForeColor = System.Drawing.Color.White;
            this.lbCredit1.Location = new System.Drawing.Point(12, 339);
            this.lbCredit1.Name = "lbCredit1";
            this.lbCredit1.Size = new System.Drawing.Size(0, 13);
            this.lbCredit1.TabIndex = 8;
            // 
            // lbCredit2
            // 
            this.lbCredit2.AutoSize = true;
            this.lbCredit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCredit2.ForeColor = System.Drawing.Color.White;
            this.lbCredit2.Location = new System.Drawing.Point(412, 339);
            this.lbCredit2.Name = "lbCredit2";
            this.lbCredit2.Size = new System.Drawing.Size(0, 13);
            this.lbCredit2.TabIndex = 9;
            // 
            // lbCredit3
            // 
            this.lbCredit3.AutoSize = true;
            this.lbCredit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCredit3.ForeColor = System.Drawing.Color.White;
            this.lbCredit3.Location = new System.Drawing.Point(12, 446);
            this.lbCredit3.Name = "lbCredit3";
            this.lbCredit3.Size = new System.Drawing.Size(0, 13);
            this.lbCredit3.TabIndex = 10;
            // 
            // lbCredit4
            // 
            this.lbCredit4.AutoSize = true;
            this.lbCredit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCredit4.ForeColor = System.Drawing.Color.White;
            this.lbCredit4.Location = new System.Drawing.Point(412, 446);
            this.lbCredit4.Name = "lbCredit4";
            this.lbCredit4.Size = new System.Drawing.Size(0, 13);
            this.lbCredit4.TabIndex = 11;
            // 
            // tbCredit1
            // 
            this.tbCredit1.BackColor = System.Drawing.Color.Black;
            this.tbCredit1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCredit1.ForeColor = System.Drawing.Color.DarkSalmon;
            this.tbCredit1.Location = new System.Drawing.Point(15, 355);
            this.tbCredit1.Multiline = true;
            this.tbCredit1.Name = "tbCredit1";
            this.tbCredit1.Size = new System.Drawing.Size(377, 87);
            this.tbCredit1.TabIndex = 12;
            this.tbCredit1.TabStop = false;
            // 
            // tbCredit2
            // 
            this.tbCredit2.BackColor = System.Drawing.Color.Black;
            this.tbCredit2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCredit2.ForeColor = System.Drawing.Color.DarkSalmon;
            this.tbCredit2.Location = new System.Drawing.Point(415, 354);
            this.tbCredit2.Multiline = true;
            this.tbCredit2.Name = "tbCredit2";
            this.tbCredit2.Size = new System.Drawing.Size(377, 87);
            this.tbCredit2.TabIndex = 13;
            this.tbCredit2.TabStop = false;
            // 
            // tbCredit4
            // 
            this.tbCredit4.BackColor = System.Drawing.Color.Black;
            this.tbCredit4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCredit4.ForeColor = System.Drawing.Color.DarkSalmon;
            this.tbCredit4.Location = new System.Drawing.Point(415, 461);
            this.tbCredit4.Multiline = true;
            this.tbCredit4.Name = "tbCredit4";
            this.tbCredit4.Size = new System.Drawing.Size(377, 87);
            this.tbCredit4.TabIndex = 15;
            this.tbCredit4.TabStop = false;
            // 
            // tbCredit3
            // 
            this.tbCredit3.BackColor = System.Drawing.Color.Black;
            this.tbCredit3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCredit3.ForeColor = System.Drawing.Color.DarkSalmon;
            this.tbCredit3.Location = new System.Drawing.Point(15, 462);
            this.tbCredit3.Multiline = true;
            this.tbCredit3.Name = "tbCredit3";
            this.tbCredit3.Size = new System.Drawing.Size(377, 87);
            this.tbCredit3.TabIndex = 14;
            this.tbCredit3.TabStop = false;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Firebrick;
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(217, 264);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(125, 23);
            this.btnList.TabIndex = 16;
            this.btnList.UseVisualStyleBackColor = false;
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Firebrick;
            this.btnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchase.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnPurchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Location = new System.Drawing.Point(664, 264);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(124, 23);
            this.btnPurchase.TabIndex = 17;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Visible = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Firebrick;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(738, 264);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 23);
            this.btnPlay.TabIndex = 18;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Visible = false;
            // 
            // MovieInfoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.tbCredit4);
            this.Controls.Add(this.tbCredit3);
            this.Controls.Add(this.tbCredit2);
            this.Controls.Add(this.tbCredit1);
            this.Controls.Add(this.lbCredit4);
            this.Controls.Add(this.lbCredit3);
            this.Controls.Add(this.lbCredit2);
            this.Controls.Add(this.lbCredit1);
            this.Controls.Add(this.lbCreditsTitle);
            this.Controls.Add(this.lbHorizontalLine);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.lbMovieTime);
            this.Controls.Add(this.lbMovieYear);
            this.Controls.Add(this.lbMovieName);
            this.Controls.Add(this.pbMoviePoster);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovieInfoWindow";
            this.Load += new System.EventHandler(this.MovieInfoWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMoviePoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMoviePoster;
        private System.Windows.Forms.Label lbMovieName;
        private System.Windows.Forms.Label lbMovieYear;
        private System.Windows.Forms.Label lbMovieTime;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbHorizontalLine;
        private System.Windows.Forms.Label lbCreditsTitle;
        private System.Windows.Forms.Label lbCredit1;
        private System.Windows.Forms.Label lbCredit2;
        private System.Windows.Forms.Label lbCredit3;
        private System.Windows.Forms.Label lbCredit4;
        private System.Windows.Forms.TextBox tbCredit1;
        private System.Windows.Forms.TextBox tbCredit2;
        private System.Windows.Forms.TextBox tbCredit4;
        private System.Windows.Forms.TextBox tbCredit3;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnPlay;
    }
}