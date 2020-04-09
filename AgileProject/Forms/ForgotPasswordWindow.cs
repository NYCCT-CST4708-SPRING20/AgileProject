using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace AgileProject.Forms
{
    public partial class ForgotPasswordWindow : Form
    {
        
        public static string to;
        public ForgotPasswordWindow()
        {
            InitializeComponent();
            /// Hi testing Github push
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection mycon; //connection
            mycon = new SqlConnection();
            mycon.ConnectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=Account;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            mycon.Open();
            SqlCommand mycmd; //sql command
            mycmd = new SqlCommand();
            mycmd.CommandText = "select count(*) from dbo.Account where email = '" + txtEmail.Text + "'";
            mycmd.Connection = mycon;

            SqlDataReader myreader = mycmd.ExecuteReader();
            int found = 0;
            while (myreader.Read())
            {
                found = myreader.GetInt32(0);
                
            }
            if (found == 1)
                MessageBox.Show("Email Sent Successfully");
            else
                MessageBox.Show("No user found");

            
            mycon.Close();


        }

        
    }
}
