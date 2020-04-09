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

namespace AgileProject.Forms
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {




           SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sakib\\Documents\\Data.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter sda = new SqlDataAdapter("Select * from [Table] where username = '" + usertxt1.Text + "' and password= '" + passtxt1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows[0][0].ToString()== "1")
            {
                this.Hide();

                MainWindow ss = new MainWindow();
                ss.Show();
            }

            else
            {
                MessageBox.Show("Please check your username or password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationWindow sd = new RegistrationWindow();
            sd.Show();

        }
    }
}
