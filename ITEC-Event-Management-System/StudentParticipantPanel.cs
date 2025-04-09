using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITEC_Event_Management_System.BL;
using ITEC_Event_Management_System.DL;

namespace ITEC_Event_Management_System
{
    public partial class StudentParticipantPanel : Form
    {
        string Username;
        string Email;
        public StudentParticipantPanel(string username, string email)
        {
            InitializeComponent();

            WelcomeBackLabel.Text = WelcomeBackLabel.Text + " " + username + "!";
            Username = username;
            Email = email;

            NameTextBox.Text = username;
            EmailTextBox.Text = email;

            UpdateButton();

            List<ITECEdition> editions = ITECEditionsDL.GetAllEditions();
            ITECIDComboBox.Items.Clear();
            foreach (ITECEdition edition in editions)
            {
                ITECIDComboBox.Items.Add(edition.year);
            }
            ITECIDComboBox.SelectedIndex = 0;

            if (!IsAlphabetOnly(NameTextBox.Text))
                NameErrorLabel.Show();

            if(DoesEmailExist(EmailTextBox.Text))
            {
                AddErrorLabel.Show();
                AddButton.Enabled = false;
                AddButton.BackColor = Color.Gray;
            }
                
        }

        private void StudentParticipantPanel_Load(object sender, EventArgs e)
        {
        }

        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        private bool IsValidEmail(string email)
        {
            if (email == "")
            {
                return true;
            }
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool DoesEmailExist(string email)
        {
            string query = $"SELECT * FROM participants WHERE email = '{email}'";
            var reader = DatabaseHelper.Instance.getData(query);
            bool exists = reader.HasRows;
            reader.Close();
            return exists;
        }

        public bool IsAlphabetOnly(string input)
        {
            return !string.IsNullOrEmpty(input) && Regex.IsMatch(input, @"^[A-Za-z]+$");
        }

        private bool IsValidPhoneNumber(string phone)
        {
            string phonePattern = @"^\d{10,15}$"; // Allows 10-15 digit phone numbers
            return Regex.IsMatch(phone, phonePattern);
        }

        private void UpdateButton()
        {
            if(!DoesEmailExist(Email) && IsValidPhoneNumber(ContactTextBox.Text))
            {
                AddButton.Enabled = true;
                AddButton.BackColor = Color.ForestGreen;
            }
            else
            {
                AddButton.Enabled = false;
                AddButton.BackColor = Color.Gray;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateButton();
        }

        private void ContactTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateButton();
            if(IsValidPhoneNumber(ContactTextBox.Text))
                ContactErrorLabel.Hide();
            else
                ContactErrorLabel.Show();
        }

        public string CapitalizeEachWord(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            return string.Join(" ", input.Split(' ')
                .Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            List<int> ITECIDs = new List<int>();
            List<ITECEdition> editions = ITECEditionsDL.GetAllEditions();
            foreach (ITECEdition edition in editions)
            {
                ITECIDs.Add(edition.ID);
            }

            string nameValue = CapitalizeEachWord(NameTextBox.Text);
            string itecIDValue = ITECIDs[ITECIDComboBox.SelectedIndex].ToString();
            string contactValue = string.IsNullOrWhiteSpace(ContactTextBox.Text) ? "NULL" : $"'{ContactTextBox.Text}'";
            string instituteValue = string.IsNullOrWhiteSpace(InstituteTextBox.Text) ? "NULL" : $"'{InstituteTextBox.Text}'";

            string query = $"INSERT INTO participants (itec_id, name, email, contact, institute, role_id) VALUES ({itecIDValue}, '{nameValue}', '{EmailTextBox.Text.ToLower()}', {contactValue}, {instituteValue}, 1)";

            int result;

            try
            {
                result = DatabaseHelper.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Add Participant\n\nPlease Contact ITEC Management.\n\nErrorMessage:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (result == 1)
            {
                MessageBox.Show("You have been registered as Participant", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddButton.Enabled = false;
                AddButton.BackColor = Color.Gray;

            }
            else
            {
                MessageBox.Show("Could not add participant in database\n\nUnknowen Error. Please Contact ITEC Management.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
    }
}
