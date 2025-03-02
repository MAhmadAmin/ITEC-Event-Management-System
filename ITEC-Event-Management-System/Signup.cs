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
using MySqlX.XDevAPI;

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
            UsernameErrorLabel.Hide();
        }

        private void Signup_closed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
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
        private bool EmailExists(string inputEmail)
        {
            string query = $"SELECT * FROM Users WHERE email = '{inputEmail}'";
            var reader = DatabaseHelper.Instance.getData(query);
            return reader.Read();
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.ToLower();
            if (UserExists(username))
            {
                UsernameErrorLabel.Show();
            }
            else
            {
                UsernameErrorLabel.Hide();
            }
        }


        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text.ToLower();
            if (!IsValidEmail(email))
            {
                EmailErrorLabel.Text = "Invalid email format";
                EmailErrorLabel.Show();
            }

            else if (EmailExists(email))
            {
                EmailErrorLabel.Text = "Email already used";
                EmailErrorLabel.Show();
            }
            else
            {
                EmailErrorLabel.Hide();
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
            EmailErrorLabel.Hide();
        }

        private void ConfirmPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                PasswordErrorLabel.Show();
            }
            else
            {
                PasswordErrorLabel.Hide();
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

        private void SignupButton_Click(object sender, EventArgs e)
        {
            if(UsernameTextBox.Text == "" || PasswordTextBox.Text == "" || ConfirmPasswordTextBox.Text == "" || SignupRole.Text == "" || EmailTextBox.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int errorCount = 0;
            string error = "";
            if (UserExists(UsernameTextBox.Text))
            {
                error += "Username already exists\n";
                errorCount++;
            }

            if (!IsValidEmail(EmailTextBox.Text))
            {
                error += "Invalid email format\n";
                errorCount++;
            }

            if (EmailExists(EmailTextBox.Text))
            {
                error += "Email already exists\n";
                errorCount++;
            }

            if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                error += "Passwords do not match\n";
                errorCount++;
            }

            if (errorCount > 0)
            {
                if(errorCount == 1)
                {
                    MessageBox.Show(error + "\nPlease Correct and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Please fix following fields: \n\n" + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }


            string query = "";

            query = $"INSERT INTO Users (username, email, password_hash, role_id) VALUES ('{UsernameTextBox.Text.ToLower()}', '{EmailTextBox.Text.ToLower()}', '{PasswordTextBox.Text}', {SignupRole.SelectedIndex} + 3 )";
            int result;

            try
            {
                result = DatabaseHelper.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Signup failed\n\nPlease Contact ITEC Management.\n\nErrorMessage:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (result == 1)
            {
                ErrorLabel.ForeColor = Color.Green;
                ErrorLabel.Text = "User Added";
                MessageBox.Show("Signup successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else
            {
                MessageBox.Show("Could not add user in database\n\nUnknowen Error. Please Contact ITEC Management.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if(ConfirmPasswordTextBox.Text != "" && PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                PasswordErrorLabel.Show();
            }

            else if (PasswordTextBox.Text == ConfirmPasswordTextBox.Text)
            {
                PasswordErrorLabel.Hide();
            }
        }
    }
}
