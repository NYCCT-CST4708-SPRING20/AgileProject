using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingWindow
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
                mySqlConn.Open();
                String query = "INSERT INTO test.transactions " +
                    "(transaction_id, account_id, movie_id, tran_date, cc_number, cc_exp_date, cc_name, street_1, street_2, city, state, postal_code) " +
                    "VALUES('456', 1, '2V2cCYJII6', '2020-03-07', '123456789', '2020-03-07', 'Elias Luna', '999 Street', 'Allen Road', 'Bronx', 'NY', 10463)";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConn);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data added to DB");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlConn.Close();
          

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
