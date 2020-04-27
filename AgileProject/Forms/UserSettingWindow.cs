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
using AgileProject.Models;

namespace AgileProject.Forms
{
    public partial class UserSettingWindow : Form
    {
        private int accountId;
        private Account oldAccount;

        public UserSettingWindow(int accountId)
        {
            this.accountId = accountId;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            UserDAO userDAO = new UserDAO();
            Account account = userDAO.GetAccountInfo(accountId);
            oldAccount = account;
            textBoxFname.Text = account.firstName;
            textBoxLname.Text = account.lastName;
            textBoxEmail.Text = account.email;
        }


        private void saveChanges(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            Account account = userDAO.GetAccountInfo(accountId);

            if (userDAO.Authentication(account.email, textBoxOldPassword.Text))
            {
                if (textBoxFname.Text != account.firstName)
                {
                    userDAO.UpdateUserInfo(UserInfoKey.FIRST_NAME, textBoxFname.Text, accountId);
                }

                if(textBoxLname.Text != account.lastName)
                {
                    userDAO.UpdateUserInfo(UserInfoKey.LAST_NAME, textBoxLname.Text, accountId);
                }

                if(textBoxEmail.Text != account.email)
                {
                    userDAO.UpdateUserInfo(UserInfoKey.EMAIL_ADDRESS, textBoxEmail.Text, accountId);
                }

                if(textNewpassword.Text != "" || confrimPassword.Text != "")
                {
                    if(textNewpassword.Text == confrimPassword.Text)
                    {
                        userDAO.UpdateUserInfo(UserInfoKey.PASSWORD, textNewpassword.Text, accountId);
                    }
                    else
                    {
                        MessageBox.Show("New passwords do not match. ");
                    }
                }
             
            }
            else
            {
                MessageBox.Show("Incorrect old password. ");
            }
            MessageBox.Show("All changes updated. ");
            textBoxOldPassword.Text = "";
            textNewpassword.Text = "";
            confrimPassword.Text = "";
        }

        private void textBoxFname_TextChanged(object sender, EventArgs e)
        {
            oldAccount.firstName = textBoxFname.Text;
        }

        private void textBoxLname_TextChanged(object sender, EventArgs e)
        {
            oldAccount.lastName = textBoxLname.Text;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            oldAccount.email = textBoxEmail.Text;
        }
    }
}