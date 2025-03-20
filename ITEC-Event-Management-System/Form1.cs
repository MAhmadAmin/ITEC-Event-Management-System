using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITEC_Event_Management_System
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
        }

		private void Login_Load(object sender, EventArgs e)
		{
			//AdminDashboard admin = new AdminDashboard();
			//this.Hide();
			//admin.Show();
			//this.Hide();
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			ErrorLabel.Text = "";
			ErrorLabel.ForeColor = Color.Red;

			if (UsernameTextBox.Text == "" || PasswordTextBox.Text == "")
			{
				MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string query = $"SELECT * FROM Users U INNER JOIN Roles R ON U.role_id = R.role_id WHERE username = '{UsernameTextBox.Text.ToLower()}'";

			var reader = DatabaseHelper.Instance.getData(query);

			if (reader.Read())
			{
				string password, role;
				password = reader["password_hash"].ToString();
				role = reader["role_name"].ToString();

				if (password == PasswordTextBox.Text)
				{
					ErrorLabel.ForeColor = Color.Green;
					ErrorLabel.Text = "Login successful";

					if (role == "Admin")
					{
						AdminDashboard admin = new AdminDashboard(reader["username"].ToString());
						admin.Show();
						this.Hide();
					}
					else if (role == "user")
					{
						//User user = new User();
						//user.Show();
						//this.Hide();
					}
				}
				else
				{
					PasswordTextBox.Focus();
					PasswordTextBox.SelectAll();

					ErrorLabel.Text = "Incorrect password";

					ErrorLabel.ForeColor = Color.Red;
					//MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				PasswordTextBox.Text = "";
				UsernameTextBox.Focus();
				UsernameTextBox.SelectAll();

				ErrorLabel.ForeColor = Color.Red;
				ErrorLabel.Text = "User not found";

				//MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void SignupButton_Click(object sender, EventArgs e)
		{
			Signup signupFrom = new Signup();
			this.Hide();
			signupFrom.Show();
		}

		private void UsernameTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				PasswordTextBox.Focus();
			}
		}

		private void UsernameTextBox_TextChanged(object sender, EventArgs e)
		{
			ErrorLabel.Text = "";
		}

		private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				LoginButton.PerformClick();
			}
		}

		private void PasswordTextBox_TextChanged(object sender, EventArgs e)
		{
			ErrorLabel.Text = "";
		}

		private void ToggleShowPassword_Click(object sender, EventArgs e)
		{
			if (PasswordTextBox.PasswordChar == '*')
			{
				PasswordTextBox.PasswordChar = '\0';
				ToggleShowPassword.ForeColor = Color.Green;
				ToggleShowPassword.Text = "Hide Password";
			}
			else
			{
				PasswordTextBox.PasswordChar = '*';
				ToggleShowPassword.ForeColor = Color.Red;
				ToggleShowPassword.Text = "Show Password";
			}
		}
	}
}
