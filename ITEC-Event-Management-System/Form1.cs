using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Please enter a username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"SELECT * FROM Users U INNER JOIN Roles R ON U.role_id = R.role_id WHERE username = '{UsernameTextBox.Text}'";

            var reader = DatabaseHelper.Instance.getData(query);

            if (reader.Read())
            {
                string password, role;
                password = reader["password_hash"].ToString();
                role = reader["role_name"].ToString();

                if (password == PasswordTextBox.Text)
                {
                    //if (role == "admin")
                    //{
                    //    Admin admin = new Admin();
                    //    admin.Show();
                    //    this.Hide();
                    //}
                    //else if (role == "user")
                    //{
                    //    User user = new User();
                    //    user.Show();
                    //    this.Hide();
                    //}
                }
                else
                {
                    MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
