namespace AgileProject.Forms
{
    partial class PlayerWindow
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
            this.timeBar = new System.Windows.Forms.TrackBar();
            this.playScreen = new System.Windows.Forms.Panel();
            this.loading = new System.Windows.Forms.PictureBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.pbMoviePoster = new System.Windows.Forms.PictureBox();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.volumeTag = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.playControllButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.timeBar)).BeginInit();
            this.playScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoviePoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playControllButton)).BeginInit();
            this.SuspendLayout();
            // 
            // timeBar
            // 
            this.timeBar.Location = new System.Drawing.Point(60, 390);
            this.timeBar.Name = "timeBar";
            this.timeBar.Size = new System.Drawing.Size(720, 45);
            this.timeBar.TabIndex = 0;
            this.timeBar.TabStop = false;
            this.timeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // playScreen
            // 
            this.playScreen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playScreen.Controls.Add(this.loading);
            this.playScreen.Controls.Add(this.lblMovieName);
            this.playScreen.Controls.Add(this.pbMoviePoster);
            this.playScreen.Location = new System.Drawing.Point(0, 0);
            this.playScreen.Name = "playScreen";
            this.playScreen.Size = new System.Drawing.Size(784, 385);
            this.playScreen.TabIndex = 1;
            // 
            // loading
            // 
            this.loading.Image = global::AgileProject.Properties.Resources.loading;
            this.loading.Location = new System.Drawing.Point(377, 167);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(50, 50);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loading.TabIndex = 2;
            this.loading.TabStop = false;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMovieName.ForeColor = System.Drawing.Color.White;
            this.lblMovieName.Location = new System.Drawing.Point(201, 3);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(226, 39);
            this.lblMovieName.TabIndex = 1;
            this.lblMovieName.Text = "[Movie Name]";
            // 
            // pbMoviePoster
            // 
            this.pbMoviePoster.Location = new System.Drawing.Point(3, 3);
            this.pbMoviePoster.Name = "pbMoviePoster";
            this.pbMoviePoster.Size = new System.Drawing.Size(192, 276);
            this.pbMoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMoviePoster.TabIndex = 0;
            this.pbMoviePoster.TabStop = false;
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(689, 424);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(90, 45);
            this.volumeBar.TabIndex = 2;
            this.volumeBar.TabStop = false;
            this.volumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // volumeTag
            // 
            this.volumeTag.AutoSize = true;
            this.volumeTag.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.volumeTag.Location = new System.Drawing.Point(644, 428);
            this.volumeTag.Name = "volumeTag";
            this.volumeTag.Size = new System.Drawing.Size(42, 13);
            this.volumeTag.TabIndex = 3;
            this.volumeTag.Text = "Volume";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.time.Location = new System.Drawing.Point(6, 394);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(49, 13);
            this.time.TabIndex = 4;
            this.time.Text = "00:00:00";
            // 
            // playControllButton
            // 
            this.playControllButton.Image = global::AgileProject.Properties.Resources.play;
            this.playControllButton.Location = new System.Drawing.Point(8, 409);
            this.playControllButton.Name = "playControllButton";
            this.playControllButton.Size = new System.Drawing.Size(50, 50);
            this.playControllButton.TabIndex = 5;
            this.playControllButton.TabStop = false;
            this.playControllButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PlayerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.playControllButton);
            this.Controls.Add(this.time);
            this.Controls.Add(this.volumeTag);
            this.Controls.Add(this.playScreen);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.timeBar);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "PlayerWindow";
            this.Text = "PlayerWindow";
            this.Load += new System.EventHandler(this.PlayerWindow_Load);
            this.SizeChanged += new System.EventHandler(this.PlayerWindow_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.timeBar)).EndInit();
            this.playScreen.ResumeLayout(false);
            this.playScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoviePoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playControllButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar timeBar;
        private System.Windows.Forms.Panel playScreen;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Label volumeTag;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.PictureBox playControllButton;
        private System.Windows.Forms.PictureBox pbMoviePoster;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.PictureBox loading;
    }
}