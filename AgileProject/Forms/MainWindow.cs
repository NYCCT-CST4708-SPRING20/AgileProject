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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MovieDAO movieDAO = new MovieDAO();
            loadMovies(movieDAO.GetAllMovieList());
            movieDAO.GetGenreStringList().ForEach(g => cbbGenre.Items.Add(g));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnMovies.Controls.Clear();
            loadMovies((new MovieDAO()).GetAllMovieList());
        }

        private void loadMovies(List<Movie> list)
        {
            int x = 10, y = 10;

            list.ForEach(m =>
            {
                // poster picture
                PictureBox pb = new PictureBox();
                ((ISupportInitialize)(pb)).BeginInit();
                pnMovies.Controls.Add(pb);
                pb.Image = (Image)AgileProject.Properties.Resources.ResourceManager.GetObject(m.movieId);
                pb.Location = new Point(x, y);
                pb.Name = "pb";
                pb.Size = new Size(128, 184);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.TabIndex = 0;
                pb.TabStop = false;
                pb.Cursor = Cursors.Hand;
                pb.Click += (s, e) => movieInfoOpen_Click(s, e, m.movieId);
                ((ISupportInitialize)(pb)).EndInit();

                // movie name
                Label name = new Label();
                pnMovies.Controls.Add(name);
                name.AutoSize = false;
                name.AutoEllipsis = true;
                name.Font = new Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
                name.Location = new Point(x, y + 190);
                name.Size = new Size(128, 30);
                name.TabIndex = 6;
                name.Text = m.movieName;
                name.Cursor = Cursors.Hand;
                name.Click += (s, e) => movieInfoOpen_Click(s, e, m.movieId);
                name.MouseEnter += (s, e) => name.Font = new Font(name.Font.Name, name.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
                name.MouseLeave += (s, e) => name.Font = new Font(name.Font.Name, name.Font.SizeInPoints, FontStyle.Regular | FontStyle.Bold);

                // movie genre
                Label genre = new Label();
                pnMovies.Controls.Add(genre);
                genre.AutoSize = false;
                genre.Location = new Point(x, y + 225);
                genre.Size = new Size(60, 13);
                genre.TabIndex = 6;
                genre.Text = m.genre;
                genre.Cursor = Cursors.Hand;
                genre.Click += (s, e) => {
                    pnMovies.Controls.Clear();
                    loadMovies((new MovieDAO()).GetGenreMoviesList(genre.Text));
                };
                genre.MouseEnter += (s, e) =>  genre.Font = new Font(genre.Font.Name, genre.Font.SizeInPoints, FontStyle.Underline);
                genre.MouseLeave += (s, e) => genre.Font = new Font(genre.Font.Name, genre.Font.SizeInPoints, FontStyle.Regular);

                // movie price
                Label price = new Label();
                pnMovies.Controls.Add(price);
                price.AutoSize = false;
                price.Location = new Point(x + 88, y + 225);
                price.Size = new Size(40, 13);
                price.TabIndex = 6;
                price.TextAlign = ContentAlignment.MiddleRight;
                price.Text = "$" + m.purchasePrice.ToString();

                y = (list.IndexOf(m) + 1) % 10 == 0 ? y + 250 : y;
                x = (list.IndexOf(m) + 1) % 10 == 0 ? 10 : x + 140;
            });
        }

        private void cbbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnMovies.Controls.Clear();
            loadMovies((new MovieDAO()).GetGenreMoviesList(cbbGenre.Text));
        }

        private void openMovieInfoFrom()
        {

        }

        private void btnMyList_Click(object sender, EventArgs e)
        {
            //MovieInfo mi = new MovieInfo();
            //mi.ShowDialog();
        }

        private void movieInfoOpen_Click(object sender, EventArgs e, String movieId)
        {
            //MovieInfo mi = new MovieInfo();
            //mi.ShowDialog();
        }

        private void cbbGenre_MouseHover(object sender, EventArgs e)
        {
            var box = sender as ComboBox;
            box.DroppedDown = true;
        }
    }
}
