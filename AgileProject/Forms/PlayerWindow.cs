using AgileProject.DAO;
using AgileProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgileProject.Forms
{
    public partial class PlayerWindow : Form
    {
        private bool playing = false;
        private String movieId;

        public PlayerWindow(String movieId)
        {
            this.movieId = movieId;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (playing)
                playControllButton.Image = Properties.Resources.pause;
            else
                playControllButton.Image = Properties.Resources.play;

            playing = !playing;
        }

        private void PlayerWindow_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            loading.Location = new Point(this.Width / 2 - 25, this.Height / 2 - 100);

            MovieDAO movieDAO = new MovieDAO();
            Movie movie = movieDAO.GetMovieData(movieId);

            pbMoviePoster.Image = (Image)Properties.Resources.ResourceManager.GetObject(movieId);
            lblMovieName.Text = movie.movieName;
            time.Text = TimeSpan.FromMinutes(movie.movieLength).ToString(@"hh\:mm\:ss");
        }

        private void PlayerWindow_SizeChanged(object sender, EventArgs e)
        {
            playScreen.Width = this.Width - 15;
            playScreen.Height = this.Height - 115;
            loading.Location = new Point(this.Width / 2 - 25, this.Height / 2 - 100);
            time.Location = new Point(time.Location.X, this.Height - 106);
            timeBar.Width = this.Width - 80;
            timeBar.Location = new Point(timeBar.Location.X, this.Height - 110);
            playControllButton.Location = new Point(playControllButton.Location.X, this.Height - 91);
            volumeTag.Location = new Point(this.Width - 156, this.Height - 72);
            volumeBar.Location = new Point(this.Width - 111, this.Height - 76);

        }
    }
}
