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
using AgileProject.DAO;

namespace AgileProject.Forms
{
    public partial class ForgotPasswordWindow : Form
    {
        
        public static string to;
        public ForgotPasswordWindow()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            if (tbEmail.Text != "" && userDAO.FindEmail(tbEmail.Text))
            {
                MessageBox.Show("Email sent!");
            }
            else
            {
                MessageBox.Show("Cannot find email, please check if you typed in a correct emaill address!");
            }
        }

        private void ForgotPasswordWindow_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
