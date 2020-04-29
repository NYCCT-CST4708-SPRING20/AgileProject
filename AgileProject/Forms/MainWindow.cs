using AgileProject.DAO;
using AgileProject.Model;
using AgileProject.Models;
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
        private readonly int accountId;

        public MainWindow(int accountId)
        {
            this.accountId = accountId;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            if (accountId == 0) this.Close();

            Account account = (new UserDAO()).GetAccountInfo(accountId);
            lbUserName.Text = account.firstName + " " + account.lastName;

            MovieDAO movieDAO = new MovieDAO();
            loadMovies(movieDAO.GetAllMovieList());
            loadGenres(movieDAO.GetGenreStringList());
        }

        private void loadGenres(List<String> genres)
        {
            int y = 0;
            Font font = new Font("Microsoft Sans Serif", 18.00F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genres.ForEach(g =>
            {
                pnGenre.Height += 30;
                Label genre = new Label();
                genre.Cursor = Cursors.Hand;
                genre.Font = font;
                genre.BackColor = Color.Black;
                genre.ForeColor = Color.White;
                genre.Size = new Size(120, 30);
                genre.Location = new Point(0, y);
                genre.Text = g;
                genre.Click += new EventHandler(genreClick);
                genre.MouseHover += new EventHandler(genreMenuMouseHover);
                genre.MouseLeave += new EventHandler(genreMenuMouseLeave);
                y += 30;
                pnGenre.Controls.Add(genre);

            });
        }

        private void genreClick(object sender, EventArgs e)
        {
            pnGenre.Visible = pnGenre.Visible == true ? false : true;
            loadMovies((new MovieDAO()).GetGenreMoviesList(((Label) sender).Text));
        }

        private void genreMenuMouseHover(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = ColorTranslator.FromHtml("#2b2b2b");
        }

        private void genreMenuMouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Black;
        }

        private void loadMovies(List<Movie> list)
        {
            hideDropDowns();

            pnMovies.Controls.Clear();

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
                name.ForeColor = Color.White;
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
                genre.ForeColor = Color.White;
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
                price.ForeColor = Color.White;
                price.Location = new Point(x + 88, y + 225);
                price.Size = new Size(40, 13);
                price.TabIndex = 6;
                price.TextAlign = ContentAlignment.MiddleRight;
                price.Text = "$" + m.purchasePrice.ToString();

                y = (list.IndexOf(m) + 1) % 10 == 0 ? y + 250 : y;
                x = (list.IndexOf(m) + 1) % 10 == 0 ? 10 : x + 140;
            });
        }

        private void movieInfoOpen_Click(object sender, EventArgs e, String movieId)
        {
            hideDropDowns();
            MovieInfoWindow movieInfoWindow = new MovieInfoWindow(movieId, accountId);
            movieInfoWindow.ShowDialog();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            loadMovies((new MovieDAO()).GetAllMovieList());
        }

        private void lblGenre_Click(object sender, EventArgs e)
        {
            pnUserOptions.Visible = false;
            pnGenre.Visible = pnGenre.Visible == true ? false : true;
        }

        /// <summary>
        /// Hide Caret from Textbox
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        /// <summary>
        /// Show Caret in Textbox
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ShowCaret(IntPtr hWnd);

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            tbSearch.Clear();
            lbSearchBoxUnderline.Height = 3;
        }

        private void lbSearch_Click(object sender, EventArgs e)
        {
            HideCaret(tbSearch.Handle);
            lbSearchBoxUnderline.Height = 1;
            loadMovies((new MovieDAO()).SearchMovies(tbSearch.Text));
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            hideDropDowns();
            ShowCaret(tbSearch.Handle);
        }

        private void lbSearch_MouseHover(object sender, EventArgs e)
        {
            lbSearch.BackColor = ColorTranslator.FromHtml("#2b2b2b");
        }

        private void lbSearch_MouseLeave(object sender, EventArgs e)
        {
            lbSearch.BackColor = Color.Black;
        }

        private void pbUserIcon_Click(object sender, EventArgs e)
        {
            pnGenre.Visible = false;
            pnUserOptions.Visible = pnUserOptions.Visible == true ? false : true;
        }

        private void lbUserSetting_Click(object sender, EventArgs e)
        {
            UserSettingWindow userSetting = new UserSettingWindow(accountId);
            pnUserOptions.Visible = false;
            userSetting.ShowDialog();
            Account account = (new UserDAO()).GetAccountInfo(accountId);
            lbUserName.Text = account.firstName + " " + account.lastName;
        }

        private void lbSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginWindow login = new LoginWindow();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }

        private void lbUserSetting_MouseHover(object sender, EventArgs e)
        {
            lbUserSetting.BackColor = Color.DimGray;
        }

        private void lbUserSetting_MouseLeave(object sender, EventArgs e)
        {
            lbUserSetting.BackColor = Color.Black;
        }

        private void lbSignOut_MouseHover(object sender, EventArgs e)
        {
            lbSignOut.BackColor = Color.DimGray;
        }

        private void lbSignOut_MouseLeave(object sender, EventArgs e)
        {
            lbSignOut.BackColor = Color.Black;
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                lbSearch_Click(this, new EventArgs());
            }
        }

        private void lblMyList_Click(object sender, EventArgs e)
        {
            loadMovies((new MyListDAO()).GetMyList(accountId));
        }

        private void lbMyMovies_Click(object sender, EventArgs e)
        {
            loadMovies((new Order()).OrderList(accountId));
        }

        private void hideDropDowns()
        {
            pnGenre.Visible = false;
            pnUserOptions.Visible = false;
        }
    }
}
