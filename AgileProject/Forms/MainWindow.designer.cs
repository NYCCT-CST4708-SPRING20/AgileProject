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
            this.btnHome = new System.Windows.Forms.Button();
            this.cbbGenre = new System.Windows.Forms.ComboBox();
            this.btnMyList = new System.Windows.Forms.Button();
            this.pnMovies = new System.Windows.Forms.Panel();
            this.tbTestMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 41);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // cbbGenre
            // 
            this.cbbGenre.FormattingEnabled = true;
            this.cbbGenre.Location = new System.Drawing.Point(93, 43);
            this.cbbGenre.Name = "cbbGenre";
            this.cbbGenre.Size = new System.Drawing.Size(121, 21);
            this.cbbGenre.TabIndex = 2;
            this.cbbGenre.SelectedIndexChanged += new System.EventHandler(this.cbbGenre_SelectedIndexChanged);
            this.cbbGenre.MouseHover += new System.EventHandler(this.cbbGenre_MouseHover);
            // 
            // btnMyList
            // 
            this.btnMyList.Location = new System.Drawing.Point(220, 43);
            this.btnMyList.Name = "btnMyList";
            this.btnMyList.Size = new System.Drawing.Size(75, 23);
            this.btnMyList.TabIndex = 3;
            this.btnMyList.Text = "My List";
            this.btnMyList.UseVisualStyleBackColor = true;
            this.btnMyList.Click += new System.EventHandler(this.btnMyList_Click);
            // 
            // pnMovies
            // 
            this.pnMovies.AutoScroll = true;
            this.pnMovies.Location = new System.Drawing.Point(2, 70);
            this.pnMovies.Name = "pnMovies";
            this.pnMovies.Size = new System.Drawing.Size(1420, 698);
            this.pnMovies.TabIndex = 4;
            // 
            // tbTestMessage
            // 
            this.tbTestMessage.Location = new System.Drawing.Point(301, 44);
            this.tbTestMessage.Name = "tbTestMessage";
            this.tbTestMessage.Size = new System.Drawing.Size(1111, 20);
            this.tbTestMessage.TabIndex = 5;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 771);
            this.Controls.Add(this.tbTestMessage);
            this.Controls.Add(this.pnMovies);
            this.Controls.Add(this.btnMyList);
            this.Controls.Add(this.cbbGenre);
            this.Controls.Add(this.btnHome);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox cbbGenre;
        private System.Windows.Forms.Button btnMyList;
        private System.Windows.Forms.Panel pnMovies;
        private System.Windows.Forms.TextBox tbTestMessage;
    }
}

