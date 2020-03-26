using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUser
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Account;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            conn.Open();
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "select count(*) from dbo.user where email = '" + tbUsername.Text + "'";
            comm.Connection = conn;

            SqlDataReader rdr = comm.ExecuteReader();
            int found = 0;
            while (rdr.Read())
            {
                found = rdr.GetInt32(0);
            }
            if(found == 1)
            {
                MessageBox.Show("Login Successfully!");
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect!");
            }

            conn.Close();
        }
    }
}
