using MySql.Data.MySqlClient;
using AgileProject.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgileProject.Model;
using System.Text.RegularExpressions;

namespace AgileProject.Forms
{
    public partial class BillingFormWindow : Form
    {
        private readonly String movieId;
        private readonly int accountId;
        public BillingFormWindow(String movieId, int accountId)
        {
            this.movieId = movieId;
            this.accountId = accountId;
            InitializeComponent();
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(firstName.Text) ||
                String.IsNullOrWhiteSpace(lastName.Text) ||
                String.IsNullOrWhiteSpace(creditCardNum.Text) ||
                String.IsNullOrWhiteSpace(ccMonth.Text) ||
                String.IsNullOrWhiteSpace(ccYear.Text) ||
                String.IsNullOrWhiteSpace(securityCode.Text) ||
                String.IsNullOrWhiteSpace(addressLine1.Text) ||
                String.IsNullOrWhiteSpace(state.Text) ||
                String.IsNullOrWhiteSpace(city.Text) ||
                String.IsNullOrWhiteSpace(zipCode.Text))
            {
                MessageBox.Show("Make sure all field with * sign is not empty");
            }
            else
            {
                if (!IsDigitsOnly(creditCardNum.Text))
                {
                    MessageBox.Show("Make sure the credit card you input is digit only!");
                    return;
                }

                if (!IsDigitsOnly(ccMonth.Text))
                {
                    MessageBox.Show("Make sure the month you input is digit only!");
                    return;
                }

                if (!IsDigitsOnly(ccYear.Text))
                {
                    MessageBox.Show("Make sure the year you input is digit only!");
                    return;
                }

                if (!IsDigitsOnly(securityCode.Text))
                {
                    MessageBox.Show("Make sure the security code you input is digit only!");
                    return;
                }

                if (!Regex.IsMatch(state.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Make sure the state that you input is letter only");
                    return;
                }

                if (!Regex.IsMatch(city.Text, @"^[a-zA-Z ]+$"))
                {
                    MessageBox.Show("Make sure the city that you input is letter only");
                    return;
                }

                if (!IsDigitsOnly(zipCode.Text))
                {
                    MessageBox.Show("Make sure the zip code you input is digit only!");
                    return;
                }

                Order orderDao = new Order();
                orderDao.NewOrder(
                    accountId,
                    movieId,
                    long.Parse(creditCardNum.Text),
                    Int32.Parse(ccYear.Text + ccMonth.Text),
                    firstName.Text + " " + lastName.Text,
                    addressLine1.Text,
                    addressLine2.Text,
                    city.Text,
                    state.Text.ToUpper(),
                    Int32.Parse(zipCode.Text));

                MessageBox.Show("Thank your for your purchase!");
                this.Close();
            }
            
        }

        private void BillingFormWindow_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            MovieDAO movieDAO = new MovieDAO();
            Movie movie = movieDAO.GetMovieData(movieId);
            pbMoviePoster.Image = (Image)Properties.Resources.ResourceManager.GetObject(movieId);
            lblMovieName.Text = movie.movieName;
            lblGenre.Text = movie.genre;
            lblPrice.Text = "$" + movie.purchasePrice.ToString();
        }

        private void digitOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
