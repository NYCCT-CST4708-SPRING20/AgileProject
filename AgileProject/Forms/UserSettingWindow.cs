using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace agileProject
{
    public partial class UserSettingWindow : Form
    {
        private int userId = 1;
        public object ConfigurationManager { get; private set; }


        public UserSettingWindow()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection myconn;
            myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=user;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            myconn.Open();

            SqlCommand mycmd = new SqlCommand("Select * from dbo.account where id = 1", myconn);
            SqlDataReader sqlDataReader = mycmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                textBoxFname.Text = sqlDataReader.GetString(1);
                textBoxLname.Text = sqlDataReader.GetString(2);
                textBoxEmail.Text = sqlDataReader.GetString(3);

            }
        }

        private void textOldpassword_Leave(object sender, EventArgs e)
        {
        
        }

        private void changePw_Click(object sender, EventArgs e)
        {
            
                SqlConnection myconn = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=user;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

                if(!String.IsNullOrEmpty(textNewpassword.Text) && textNewpassword.Text == confrimPassword.Text)
                {
                    myconn.Open();
                    SqlCommand mycmd = new SqlCommand("UPDATE dbo.account SET password = '" + confrimPassword.Text + "' WHERE id = 1", myconn);
                    mycmd.ExecuteNonQuery();
                    myconn.Close();
                    MessageBox.Show("Password Changed. ");
                }
                else
                {
                    MessageBox.Show("Check your New Password and confrim Password");
                }
            }

        }
    }