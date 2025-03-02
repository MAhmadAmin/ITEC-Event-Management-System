using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITEC_Event_Management_System
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
        }

        private void Signup_closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UsernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EmailTextBox.Focus();
            }
        }

        private void EmailTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PasswordTextBox.Focus();
            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmPasswordTextBox.Focus();
            }
        }

        private void ConfirmPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignupRole.Focus();
            }
        }

        private void ConfirmPasswordTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignupRole.Focus();
            }
        }

        private void SignupRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            SignupButton.Focus();
        }

        private bool UserExists(string inputUserName)
        {
            string query = $"SELECT * FROM Users WHERE username = '{inputUserName}'";
            var reader = DatabaseHelper.Instance.getData(query);
            return reader.Read();
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            if (UserExists(username))
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Username already exists";
                UsernameLabel.ForeColor = Color.Red;
            }
            else
            {
                ErrorLabel.Text = "";
                UsernameLabel.ForeColor = Color.Black;
            }
        }


        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
        string email = EmailTextBox.Text;
            if (!IsValidEmail(email))
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Invalid email format";
                EmailLabel.ForeColor = Color.Red;
            }
            else
            {
                ErrorLabel.Text = "";
                EmailLabel.ForeColor = Color.Black;
            }
        }

        private bool IsValidEmail(string email)
        {
            if(email == "")
            {
                return true;
            }
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
        }

        private void ConfirmPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Passwords do not match";
                //PasswordLabel.ForeColor = Color.Red;
                ConfirmPasswordLabel.ForeColor = Color.Red;
            }
            else
            {
                ErrorLabel.Text = "";
                //PasswordLabel.ForeColor = Color.Black;
                ConfirmPasswordLabel.ForeColor = Color.Black;
            }
        }

        private void ToggleShowPassword_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.PasswordChar == '*')
            {
                PasswordTextBox.PasswordChar = '\0';
                ConfirmPasswordTextBox.PasswordChar = '\0';
                ToggleShowPassword.ForeColor = Color.Green;
                ToggleShowPassword.Text = "Hide Password";
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
                ConfirmPasswordTextBox.PasswordChar = '*';
                ToggleShowPassword.ForeColor = Color.Red;
                ToggleShowPassword.Text = "Show Password";
            }
        }
    }
}
