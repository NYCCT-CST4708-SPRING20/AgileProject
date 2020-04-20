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
using AgileProject.DAO;

namespace AgileProject.Forms
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            lblSignUp.MouseEnter += (s, args) => lblSignUp.Font = new Font(lblSignUp.Font.Name, lblSignUp.Font.SizeInPoints, FontStyle.Underline);
            lblSignUp.MouseLeave += (s, args) => lblSignUp.Font = new Font(lblSignUp.Font.Name, lblSignUp.Font.SizeInPoints, FontStyle.Regular);
            lblForgotPw.MouseEnter += (s, args) => lblForgotPw.Font = new Font(lblForgotPw.Font.Name, lblForgotPw.Font.SizeInPoints, FontStyle.Underline);
            lblForgotPw.MouseLeave += (s, args) => lblForgotPw.Font = new Font(lblForgotPw.Font.Name, lblForgotPw.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            if(userDAO.Authentication(tbEmail.Text, tbPassword.Text))
            {
                this.Hide();
                MainWindow mainWindow = new MainWindow(userDAO.GetID(tbEmail.Text, tbPassword.Text));
                mainWindow.FormClosed += (s, args) => this.Close();
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Incorrect email or password");
            }
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.FormClosed += (s, args) => this.Close();
            registrationWindow.Show();
        }

        private void lblForgotPw_Click(object sender, EventArgs e)
        {
            ForgotPasswordWindow forgotPasswordWindow = new ForgotPasswordWindow();
            forgotPasswordWindow.ShowDialog();
        }
    }
}
