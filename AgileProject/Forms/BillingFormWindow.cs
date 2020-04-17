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

namespace AgileProject.Forms
{
    public partial class BillingFormWindow : Form
    {
        const string connStr = "";
        MySqlConnection mySqlConn = new MySqlConnection(connStr);
        public BillingFormWindow()
        {
           
            InitializeComponent();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void billingForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void billingInfo_Click(object sender, EventArgs e)
        {

        }

        private void purchase_Click(object sender, EventArgs e)
        {
            try
            {
                Order orderDao = new Order();
                orderDao.NewOrder(
                    456, 
                    "2V2cCYJII6", 
                    Int32.Parse(creditCardNum.Text),
                    Int32.Parse(ccMonth.Text + "-" + ccDay.Text + "-" + ccYear.Text),
                    firstName.Text + " " + lastName.Text,
                    addressLine1.Text,
                    addressLine2.Text,
                    city.Text,
                    state.Text,
                    Int32.Parse(zipCode.Text));
       
                MessageBox.Show("Data added to DB");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
