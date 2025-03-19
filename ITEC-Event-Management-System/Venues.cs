using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITEC_Event_Management_System
{
    public partial class Venues : Form
    {
        public Venues()
        {
            InitializeComponent();
            UpdateButtons();
        }

        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        private void UpdateButtons()
        {
            label1.Show();
            SuccessLabel.Show();
            SuccessLabel.Text = "None";
            if ((IDTextBox.Text == "auto increment" || IDTextBox.Text == "") && NameTextBox.Text != "" && CapacityTextBox.Text != "" && IsNumeric(CapacityTextBox.Text))
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

            if (IDTextBox.Text != "" && IDTextBox.Text != "auto increment" && IsNumeric(IDTextBox.Text))
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

            if (IDTextBox.Text != "" && IDTextBox.Text != "auto increment" && (CapacityTextBox.Text == "" || IsNumeric(CapacityTextBox.Text)))
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
            string query = $"Select * FROM venues WHERE venue_id = {ID}";

            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
        }

        private void IDTextBox_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "auto increment")
                IDTextBox.Text = "";
            IDTextBox.ForeColor = Color.Black;
            IDTextBox.Font = new Font(IDTextBox.Font, FontStyle.Regular);
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateButtons();

            if (!IsNumeric(IDTextBox.Text) && IDTextBox.Text != "")
            {
                IDErrorLabel.Show();
            }
            else
            {
                IDErrorLabel.Hide();
            }

            //if(IDTextBox.Text == "")
            //{
            //    AddButton.Enabled = true;
            //    AddButton.ForeColor = Color.White;
            //    AddButton.BackColor = Color.ForestGreen;
            //}
            //else
            //{
            //    AddButton.Enabled = false;
            //    AddButton.ForeColor = Color.White;
            //    AddButton.BackColor = Color.Gray;

            //}
        }

        private void IDTextBox_Leave(object sender, EventArgs e)
        {
            UpdateButtons();
            if (IDTextBox.Text == "")
            {
                IDTextBox.Text = "auto increment";

                IDTextBox.Font = new Font(IDTextBox.Font, FontStyle.Italic);
                IDTextBox.ForeColor = Color.Gray;
                IDErrorLabel.Hide();
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void CapacityTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateButtons();
            if(CapacityTextBox.Text != "" && !IsNumeric(CapacityTextBox.Text))
            {
                CapacityErrorLabel.Show();
            }
            else
            {
                CapacityErrorLabel.Hide();
            }
        }

        private void LocationTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string locationValue = string.IsNullOrWhiteSpace(LocationTextBox.Text) ? "NULL" : $"'{LocationTextBox.Text}'";
            string query = $"INSERT INTO venues (venue_name, capacity, location) VALUES ('{NameTextBox.Text}', {int.Parse(CapacityTextBox.Text)}, {locationValue})";
            int result;

            try
            {
                result = DatabaseHelper.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Add Edition\n\nPlease Contact ITEC Management.\n\nErrorMessage:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (result == 1)
            {
                SuccessLabel.Text = "Edition Added.";
                ShowAllButton.PerformClick();
            }
            else
            {
                MessageBox.Show("Could not add edition in database\n\nUnknowen Error. Please Contact ITEC Management.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM venues";
            var reader = DatabaseHelper.Instance.getData(query);

            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);

            DataGrid.DataSource = dt;
            DataGrid.Refresh();
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            string query = $"Select * FROM venues WHERE venue_ID = {int.Parse(IDTextBox.Text)}";

            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);
            DataGrid.DataSource = dt;
            DataGrid.Refresh();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string queryP = $"Select * FROM venues WHERE venue_ID = {int.Parse(IDTextBox.Text)}";

            var reader = DatabaseHelper.Instance.getData(queryP);

            if (!reader.Read())
            {
                MessageBox.Show("No venue Found Against given ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IDTextBox.Focus();
                return;
            }

            DialogResult ButtonPressed = MessageBox.Show($"Are you sure you want to delete {reader["venue_name"].ToString()} venue at {IDTextBox.Text} ID", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ButtonPressed == DialogResult.Yes)
            {
                string query = $"DELETE FROM venues WHERE venue_ID = {int.Parse(IDTextBox.Text)}";

                int result = DatabaseHelper.Instance.ExecuteQuery(query);
                if (result == 0)
                {
                    MessageBox.Show("Could not delete venue in database\n\nUnknowen Error. Please Contact ITEC Management.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ShowAllButton.PerformClick();
                    SuccessLabel.Show();
                    SuccessLabel.Text = "Venue Deleted";
                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Deletion canceled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string query = $"Select * FROM venues WHERE venue_ID = {int.Parse(IDTextBox.Text)}";

            var reader = DatabaseHelper.Instance.getData(query);

            if (!reader.Read())
            {
                MessageBox.Show("No venue Found Against given ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IDTextBox.Focus();
                return;
            }



            if (string.IsNullOrEmpty(NameTextBox.Text))
                NameTextBox.Text = reader["venue_name"].ToString();
            if (string.IsNullOrEmpty(CapacityTextBox.Text))
                CapacityTextBox.Text = reader["capacity"].ToString();
            //if (string.IsNullOrEmpty(LocationTextBox.Text))
            //    LocationTextBox.Text = reader["location"].ToString();

            string locationValue = string.IsNullOrWhiteSpace(LocationTextBox.Text) ? "NULL" : $"'{LocationTextBox.Text}'";

            string query1 = $"UPDATE venues SET venue_name = '{NameTextBox.Text}', Capacity = {int.Parse(CapacityTextBox.Text)}, location = {locationValue} WHERE venue_ID = {int.Parse(IDTextBox.Text)}";



            //string nameValue = string.IsNullOrWhiteSpace(NameTextBox.Text) ? "NULL" : $"'{NameTextBox.Text}'";
            //int capacityValue = int.TryParse(CapacityTextBox.Text, out int cap) ? cap : 0;
            //int venueID = int.TryParse(IDTextBox.Text, out int id) ? id : 0;

            //// If locationValue is a string, wrap it in single quotes
            //string locationValue = string.IsNullOrWhiteSpace(LocationTextBox.Text) ? "NULL" : $"'{LocationTextBox.Text}'";

            //// Correct query
            //string query1 = $"UPDATE venues SET venue_name = {nameValue}, Capacity = {capacityValue}, location = {locationValue} WHERE venue_ID = {venueID}";



            int result = DatabaseHelper.Instance.ExecuteQuery(query1);
            if (result == 0)
            {
                MessageBox.Show("Could not update in database\n\nUnknowen Error. Please Contact ITEC Management.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                RetrieveAt(int.Parse(IDTextBox.Text));
                SuccessLabel.Text = "Record Updated";
                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DataGrid_DoubleClick_1(object sender, EventArgs e)
        {
            UpdateButtons();
            IDTextBox.Text = DataGrid.CurrentRow.Cells[0].Value.ToString();
            NameTextBox.Text = DataGrid.CurrentRow.Cells[1].Value.ToString();
            CapacityTextBox.Text = DataGrid.CurrentRow.Cells[2].Value.ToString();
            LocationTextBox.Text = DataGrid.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = $"Select * FROM venues WHERE venue_name LIKE '%{NameTextBox.Text}%'";
            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = string.IsNullOrEmpty(CapacityTextBox.Text) ? "SELECT * FROM venues WHERE Capacity is NULL" : $"SELECT * FROM venues WHERE capacity = {int.Parse(CapacityTextBox.Text)}";

            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = string.IsNullOrEmpty(LocationTextBox.Text) ? "SELECT * FROM venues WHERE location is NULL" : $"SELECT * FROM venues WHERE location LIKE '%{LocationTextBox.Text}%'";

            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
        }
    }
}
