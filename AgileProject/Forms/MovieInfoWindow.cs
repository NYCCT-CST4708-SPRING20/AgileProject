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
    public partial class MovieInfoWindow : Form
    {
        private readonly String movieId;
        private readonly int accountId;
        public MovieInfoWindow(String movieId, int accountId)
        {
            this.movieId = movieId;
            this.accountId = accountId;
            InitializeComponent();
        }

        private void MovieInfoWindow_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            MovieDAO movieDao = new MovieDAO();
            Movie movie = movieDao.GetMovieData(movieId);
            pbMoviePoster.Image = (Image)AgileProject.Properties.Resources.ResourceManager.GetObject(movieId);
            lbMovieName.Text = movie.movieName;
            lbMovieYear.Text = movie.year.ToString();
            lbMovieTime.Text = movie.movieLength.ToString() + " minutes";
            lbGenre.Text = movie.genre;
            tbDescription.Text = movie.movieDescription;
            btnPurchase.Text = "$" + movie.purchasePrice.ToString() + " Buy";
            Label[] lbCredits = { lbCredit1, lbCredit2, lbCredit3, lbCredit4 };
            TextBox[] tbCredits = { tbCredit1, tbCredit2, tbCredit3, tbCredit4 };
            String[] creditTitle = { "Actors", "Producers", "Directors", "Writers" };
            String[] creditInfo = { movie.actors, movie.producers, movie.directors, movie.writers };
            int i = 0;
            for(int j = 0; j < 4; j++)
            {
                if(creditInfo[j] != "")
                {
                    lbCredits[i].Text = creditTitle[j];
                    tbCredits[i].Text = creditInfo[j];
                    i++;
                }
            }
            initializeButtons();
        }

        private void initializeButtons()
        {
            MyListDAO myListDAO = new MyListDAO();
            btnList.Text = myListDAO.Contains(accountId, movieId) ? "Remove from My List" :  "Add to My List";
            btnList.Click += (s, e) => { 
                if(myListDAO.Contains(accountId, movieId))
                {
                    myListDAO.DelFromList(accountId, movieId);
                    btnList.Text = "Add to My List";
                }
                else
                {
                    myListDAO.AddToList(accountId, movieId);
                    btnList.Text = "Remove from My List";
                }
            };

            Order order = new Order();
            if(order.Ordered(accountId, movieId))
            {
                btnPlay.Visible = true;
                btnPurchase.Visible = false;
            }
            else
            {
                btnPlay.Visible = false;
                btnPurchase.Visible = true;
            }

            btnPlay.Click += (s, e) =>
            {
                (new PlayerWindow(movieId)).Show();
            };

            btnPurchase.Click += (s, e) =>
            {
                BillingFormWindow billing = new BillingFormWindow(movieId, accountId);
                billing.ShowDialog();
                MovieInfoWindow_Load(null, EventArgs.Empty);
            };
        }
    }
}
