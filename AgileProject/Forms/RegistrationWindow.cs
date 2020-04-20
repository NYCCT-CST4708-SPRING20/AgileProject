using AgileProject.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgileProject.Forms
{
    public partial class RegistrationWindow : Form
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbFirstName.Text) ||
               String.IsNullOrWhiteSpace(tbLastName.Text) ||
               String.IsNullOrWhiteSpace(tbEmailAddress.Text) ||
               String.IsNullOrWhiteSpace(tbConfirmEmail.Text) ||
               String.IsNullOrWhiteSpace(tbPassword.Text) ||
               String.IsNullOrWhiteSpace(tbConfirmPw.Text))
            {
                MessageBox.Show("One of the field is empty, please check!");
                return;
            }



            UserDAO userDAO = new UserDAO();

            if (tbEmailAddress.Text == tbConfirmEmail.Text)
            {
                if (!IsValidEmail(tbEmailAddress.Text))
                {
                    MessageBox.Show("Invalid email format");
                    return;
                }

                if (userDAO.FindEmail(tbEmailAddress.Text))
                {
                    MessageBox.Show("This email is already used by another account!");
                }
                else
                {
                    if (tbPassword.Text == tbConfirmPw.Text)
                    {
                        userDAO.AddNewUser(tbFirstName.Text, tbLastName.Text, tbEmailAddress.Text, tbPassword.Text);
                        MessageBox.Show("Sign Up Successfully!\nClick OK to go back to the login window!");
                        this.Hide();
                        LoginWindow loginWindow = new LoginWindow();
                        loginWindow.FormClosed += (s, args) => this.Close();
                        loginWindow.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password do no match!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Email do not match!");
            }
        }

        private void RegistrationWindow_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            lbLogin.MouseEnter += (s, args) => lbLogin.Font = new Font(lbLogin.Font.Name, lbLogin.Font.SizeInPoints, FontStyle.Underline);
            lbLogin.MouseLeave += (s, args) => lbLogin.Font = new Font(lbLogin.Font.Name, lbLogin.Font.SizeInPoints, FontStyle.Regular);
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.FormClosed += (s, args) => this.Close();
            loginWindow.Show();
        }

        private static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}