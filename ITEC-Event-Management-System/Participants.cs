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
using System.Xml;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITEC_Event_Management_System
{
	public partial class Participants : Form
	{
		bool isOtherDataTable = false;
		public Participants()
		{
			InitializeComponent();

			var itec_editions = DatabaseHelper.Instance.getData("SELECT itec_id FROM itec_editions");
			ITECIDComboBox.Items.Add("None");
			while(itec_editions.Read())
			{
				ITECIDComboBox.Items.Add(int.Parse(itec_editions["itec_id"].ToString()));
			}
			itec_editions.Close();
			ITECIDComboBox.SelectedIndex = 0;


			//List<Lookup> lookups = LookupDataLayer.GetIDsByCategory("ParticipantRoles");
			//         RoleIDComboBox.Items.Add("None");
			//foreach (Lookup lookup in lookups)
			//{
			//	RoleIDComboBox.Items.Add(lookup.ID);
			//         }
			//RoleIDComboBox.SelectedIndex = 0;

			RoleIDComboBox.Items.Clear();
			RoleIDComboBox.Items.Add("None");
			string query = "SELECT * FROM Roles";
			var reader = DatabaseHelper.Instance.getData(query);
			while(reader.Read())
			{
				RoleIDComboBox.Items.Add(reader.GetInt16("role_id"));
			}
			RoleIDComboBox.SelectedIndex = 0;

			UpdateButtons();
        }

		private void ShowEditionsButton_Click(object sender, EventArgs e)
		{
			string query = "SELECT * FROM Itec_Editions";
			var reader = DatabaseHelper.Instance.getData(query);

			MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
			DataTable dt = new DataTable();
			DataAdapter.Fill(dt);

			DataGrid.DataSource = dt;
			DataGrid.Refresh();
			reader.Close();
			isOtherDataTable = true;
		}

		private void ShowRolesButton_Click(object sender, EventArgs e)
		{

            //List<Lookup> lookups = LookupDataLayer.GetIDsByCategory("ParticipantRoles");

            //DataTable dt = new DataTable();
            //dt.Columns.Add("ID", typeof(int));
            //dt.Columns.Add("Category", typeof(string));
            //dt.Columns.Add("Value", typeof(string));

            //foreach (var lookup in lookups)
            //{
            //    dt.Rows.Add(lookup.ID, lookup.category, lookup.value);
            //}

            //DataGrid.DataSource = dt;
            //DataGrid.Refresh();
            isOtherDataTable = true;

            string query = "SELECT * FROM roles";
			var reader = DatabaseHelper.Instance.getData(query);

			MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
			DataTable dt = new DataTable();
			DataAdapter.Fill(dt);

			DataGrid.DataSource = dt;
			DataGrid.Refresh();
			reader.Close();

			isOtherDataTable = true;
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

		public string CapitalizeEachWord(string input)
		{
			if (string.IsNullOrWhiteSpace(input))
				return input;

			return string.Join(" ", input.Split(' ')
				.Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
		}

		private void UpdateButtons()
		{
			SuccessLabel.Text = "None";

			if ((ParticipantIDTextBox.Text == "auto increment" || ParticipantIDTextBox.Text == "") && !string.IsNullOrEmpty(NameTextBox.Text) && !string.IsNullOrEmpty(EmailTextBox.Text) && IsValidEmail(EmailTextBox.Text) && !DoesEmailExist(EmailTextBox.Text) && (IsValidPhoneNumber(ContactTextBox.Text))) 
			{
				AddButton.Enabled = true;
				AddButton.ForeColor = Color.White;
				AddButton.BackColor = Color.ForestGreen;
			}
			else
			{

				AddButton.Enabled = false;
				AddButton.BackColor = Color.Gray;
			}

			if (ParticipantIDTextBox.Text != "" && ParticipantIDTextBox.Text != "auto increment" && IsNumeric(ParticipantIDTextBox.Text))
			{
				DeleteButton.Enabled = true;
				DeleteButton.ForeColor = Color.White;
				DeleteButton.BackColor = Color.Brown;

				RetrieveButton.Enabled = true;
				RetrieveButton.BackColor = Color.Peru;
			}
			else
			{
				DeleteButton.Enabled = false;
				DeleteButton.BackColor = Color.Gray;

				RetrieveButton.Enabled = false;
				RetrieveButton.BackColor = Color.Gray;

			}

			

			if (ParticipantIDTextBox.Text != "" && ParticipantIDTextBox.Text != "auto increment" && IsNumeric(ParticipantIDTextBox.Text))
			{
				UpdateButton.Enabled = true;
				UpdateButton.BackColor = Color.RoyalBlue;
			}
			else
			{
				UpdateButton.Enabled = false;
				UpdateButton.BackColor = Color.Gray;
			}
		}

		private void RetrieveAt(int ID)
		{
			string query = $"Select * FROM participants WHERE participant_id = {ID}";

			MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
			DataTable dt = new DataTable();
			DataAdapter.Fill(dt);
			DataGrid.DataSource = dt;
			DataGrid.Refresh();

		}

		private void NameTextBox_TextChanged(object sender, EventArgs e)
		{
			UpdateButtons();
		}

		private void EmailTextBox_TextChanged(object sender, EventArgs e)
		{
			UpdateButtons();
			if(EmailTextBox.Text == "")
			{
				EmailErrorLabel.Hide();
			}
            else if (!IsValidEmail(EmailTextBox.Text))
            {
                EmailErrorLabel.Text = "Invalid email format";
                EmailErrorLabel.Show();
            }
            else if (ParticipantIDTextBox.Text != "auto increment" || ParticipantIDTextBox.Text != "")
            {
                EmailErrorLabel.Hide();
            }
            
			else if (DoesEmailExist(EmailTextBox.Text))
			{
				EmailErrorLabel.Text = "Email already exists";
				EmailErrorLabel.Show();
			}
			else
			{
				EmailErrorLabel.Hide();
			}
		}

		private void ParticipantIDTextBox_Click(object sender, EventArgs e)
		{
			if (ParticipantIDTextBox.Text == "auto increment")
				ParticipantIDTextBox.Text = "";
			ParticipantIDTextBox.ForeColor = Color.Black;
			ParticipantIDTextBox.Font = new Font(ParticipantIDTextBox.Font, FontStyle.Regular);
		}

		private void ParticipantIDTextBox_TextChanged(object sender, EventArgs e)
		{
			if (!IsNumeric(ParticipantIDTextBox.Text) && ParticipantIDTextBox.Text != "")
			{
				ParticipantErrorLabel.Show();
			}
			else
			{
				ParticipantErrorLabel.Hide();
			}

			UpdateButtons();
		}

		private void ParticipantIDTextBox_Leave(object sender, EventArgs e)
		{
			if (ParticipantIDTextBox.Text == "")
			{
				ParticipantIDTextBox.Text = "auto increment";

				ParticipantIDTextBox.Font = new Font(ParticipantIDTextBox.Font, FontStyle.Italic);
				ParticipantIDTextBox.ForeColor = Color.Gray;
				ParticipantErrorLabel.Hide();
			}
			UpdateButtons();
		}

		private void ShowAllButton_Click(object sender, EventArgs e)
		{
			string query = "SELECT * FROM participants";
			var reader = DatabaseHelper.Instance.getData(query);

			MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
			DataTable dt = new DataTable();
			DataAdapter.Fill(dt);

			DataGrid.DataSource = dt;
			DataGrid.Refresh();
			isOtherDataTable = false;

		}

		private void DataGrid_DoubleClick(object sender, EventArgs e)
		{
			UpdateButtons();
			if (!isOtherDataTable)
			{
				ParticipantIDTextBox.Text = DataGrid.CurrentRow.Cells[0].Value.ToString();
				ITECIDComboBox.Text = DataGrid.CurrentRow.Cells[1].Value.ToString();
				NameTextBox.Text = DataGrid.CurrentRow.Cells[2].Value.ToString();
				EmailTextBox.Text = DataGrid.CurrentRow.Cells[3].Value.ToString();
				ContactTextBox.Text = DataGrid.CurrentRow.Cells[4].Value.ToString();
				InstituteTextBox.Text = DataGrid.CurrentRow.Cells[5].Value.ToString();
				RoleIDComboBox.Text = DataGrid.CurrentRow.Cells[6].Value.ToString();
			}

		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			string nameValue = CapitalizeEachWord(NameTextBox.Text);
			string itecIDValue = ITECIDComboBox.SelectedIndex == 0 ? "NULL" : $"{ITECIDComboBox.Text}";
			string contactValue = string.IsNullOrWhiteSpace(ContactTextBox.Text) ? "NULL" : $"'{ContactTextBox.Text}'";
			string instituteValue = string.IsNullOrWhiteSpace(InstituteTextBox.Text) ? "NULL" : $"'{InstituteTextBox.Text}'";
			string roleIDValue = RoleIDComboBox.SelectedIndex == 0 ? "NULL" : $"{RoleIDComboBox.Text}";

			string query = $"INSERT INTO participants (itec_id, name, email, contact, institute, role_id) VALUES ({itecIDValue}, '{nameValue}', '{EmailTextBox.Text.ToLower()}', {contactValue}, {instituteValue}, {roleIDValue})";
			
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
				NameTextBox.Text = "";
				ITECIDComboBox.SelectedIndex = 0;
				EmailTextBox.Text = "";
				ContactTextBox.Text = "";
                InstituteTextBox.Text = "";
                RoleIDComboBox.SelectedIndex = 0;
                SuccessLabel.Text = "Participant Added Successfully";
				ContactErrorLabel.Hide();
				ShowAllButton.PerformClick();
            }
			else
			{
				MessageBox.Show("Could not add participant in database\n\nUnknowen Error. Please Contact ITEC Management.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void ContactTextBox_Leave(object sender, EventArgs e)
		{
			if(ContactTextBox.Text != "" && !IsValidPhoneNumber(ContactTextBox.Text))
			{
				ContactErrorLabel.Show();
			}
			else
			{
				ContactErrorLabel.Hide();
			}
			UpdateButtons();
		}

		private void ContactTextBox_TextChanged(object sender, EventArgs e)
		{
			UpdateButtons();
			if(IsValidPhoneNumber(ContactTextBox.Text))
			{
				ContactErrorLabel.Hide();
			}
			else
			{
				ContactErrorLabel.Show();
			}
		}

		private void RetrieveButton_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(ParticipantIDTextBox.Text) && IsNumeric(ParticipantIDTextBox.Text))
			{
				RetrieveAt(int.Parse(ParticipantIDTextBox.Text));
			}
			else
			{
				MessageBox.Show("Please enter a valid ID to retrieve data.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string checkQuery = $"Select * FROM Participants WHERE participant_ID = {int.Parse(ParticipantIDTextBox.Text)}";

            var reader = DatabaseHelper.Instance.getData(checkQuery);

            if (!reader.Read())
            {
                MessageBox.Show("No participant Found Against given ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ParticipantIDTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(NameTextBox.Text))
                NameTextBox.Text = reader["name"].ToString();
            if (string.IsNullOrEmpty(EmailTextBox.Text))
                EmailTextBox.Text = reader["email"].ToString();
            if (string.IsNullOrEmpty(ContactTextBox.Text))
                ContactTextBox.Text = reader["contact"].ToString();

            string itecIDValue = ITECIDComboBox.SelectedIndex == 0 ? "NULL" : $"{ITECIDComboBox.Text}";
            string roleIDValue = RoleIDComboBox.SelectedIndex == 0 ? "NULL" : $"{RoleIDComboBox.Text}";

            string instituteValue = string.IsNullOrWhiteSpace(InstituteTextBox.Text) ? "NULL" : $"'{InstituteTextBox.Text}'";

			
            string query = $"UPDATE participants SET itec_id = {itecIDValue}, name = '{CapitalizeEachWord(NameTextBox.Text)}', email = '{EmailTextBox.Text.ToLower()}', contact = {ContactTextBox.Text}, institute = {instituteValue}, role_id = {roleIDValue} WHERE participant_id = {int.Parse(ParticipantIDTextBox.Text)}";

            int result;

            try
            {
                result = DatabaseHelper.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Update Participant\n\nPlease Contact ITEC Management.\n\nErrorMessage:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (result == 1)
            {
                SuccessLabel.Text = "Participant Updated Successfully";
                ShowAllButton.PerformClick();
            }
            else
            {
                MessageBox.Show("Could not update participant in database\n\nUnknown Error. Please Contact ITEC Management.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string queryP = $"Select * FROM participants WHERE participant_ID = {int.Parse(ParticipantIDTextBox.Text)}";

            var reader = DatabaseHelper.Instance.getData(queryP);

            if (!reader.Read())
            {
                MessageBox.Show("No participant Found Against given ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ParticipantIDTextBox.Focus();
                return;
            }

            DialogResult ButtonPressed = MessageBox.Show($"Are you sure you want to delete {reader["name"].ToString()} at {ParticipantIDTextBox.Text} ID", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ButtonPressed == DialogResult.Yes)
            {
                string query = $"DELETE FROM participants WHERE participant_id = {int.Parse(ParticipantIDTextBox.Text)}";

                int result = DatabaseHelper.Instance.ExecuteQuery(query);
                if (result == 0)
                {
                    MessageBox.Show("Could not delete Participant in database\n\nUnknowen Error. Please Contact ITEC Management.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ShowAllButton.PerformClick();
                    SuccessLabel.Show();
                    SuccessLabel.Text = "Participant Deleted";
                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Deletion canceled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"Select * FROM participants WHERE name LIKE '%{NameTextBox.Text}%'";

            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);
            DataGrid.DataSource = dt;
            DataGrid.Refresh();

			isOtherDataTable = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = $"Select * FROM participants WHERE email LIKE '%{EmailTextBox.Text}%'";

            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherDataTable = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = $"Select * FROM participants WHERE contact LIKE '%{ContactTextBox.Text}%'";

            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherDataTable = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = string.IsNullOrEmpty(InstituteTextBox.Text) ? "SELECT * FROM Participants WHERE institute IS NULL" : $"Select * FROM participants WHERE institute LIKE '%{InstituteTextBox.Text}%'";

            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherDataTable = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
			string query = ITECIDComboBox.Text == "None" ? "SELECT * FROM Participants WHERE itec_id IS NULL" : $"Select * FROM participants WHERE itec_id = {ITECIDComboBox.Text}";
			MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherDataTable = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = RoleIDComboBox.Text == "None" ? "SELECT * FROM Participants WHERE role_id IS NULL" : $"Select * FROM participants WHERE role_id = {RoleIDComboBox.Text}";
            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherDataTable = false;

        }
    }
}
