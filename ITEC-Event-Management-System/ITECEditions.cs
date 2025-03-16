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
using MySqlX.XDevAPI.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITEC_Event_Management_System
{
	public partial class ITECEditions : Form
	{
		public ITECEditions()
		{
			InitializeComponent();
		}

		private void ITECEditions_Load(object sender, EventArgs e)
		{
			UpdateButtons();
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

			AddButton.Enabled = false;
			AddButton.ForeColor = Color.White;
			AddButton.BackColor = Color.Gray;
		}

		private void IDTextBox_Click(object sender, EventArgs e)
		{
			if(IDTextBox.Text == "auto increment")
				IDTextBox.Text = "";
			IDTextBox.ForeColor = Color.Black;
			IDTextBox.Font = new Font(IDTextBox.Font, FontStyle.Regular);
		}

		private void IDTextBox_Leave(object sender, EventArgs e)
		{
			if (IDTextBox.Text == "")
			{
				IDTextBox.Text = "auto increment";

				IDTextBox.Font = new Font(IDTextBox.Font, FontStyle.Italic);
				IDTextBox.ForeColor = Color.Gray;

				IDErrorLabel.Hide();
			}
		}

		private bool IsNumeric(string input)
		{
			return int.TryParse(input, out _);
		}

		private void YearTextBox_TextChanged(object sender, EventArgs e)
		{
			UpdateButtons();

			if (YearTextBox.Text == "")
			{
				YearErrorLabel.Hide();
			}
			else if (!IsNumeric(YearTextBox.Text))
			{
				YearErrorLabel.Show();
			}
			else
			{
				YearErrorLabel.Hide();
			}
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			if (YearTextBox.Text == "" || ThemeTextBox.Text == "" || DescriptionTextBox.Text == "")
			{
				MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!IsNumeric(YearTextBox.Text))
			{
				MessageBox.Show("ID and Year must be numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int year = int.Parse(YearTextBox.Text);
			string query = $"INSERT INTO Itec_editions (year, theme, description) VALUES ({year}, '{ThemeTextBox.Text}', '{DescriptionTextBox.Text}')";
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
			string query = "SELECT * FROM Itec_Editions";
			var reader = DatabaseHelper.Instance.getData(query);

			MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
			DataTable dt = new DataTable();
			DataAdapter.Fill(dt);

			DataGrid.DataSource = dt;
			DataGrid.Refresh();

		}

		private void UpdateButtons()
		{
			SuccessLabel.Text = "None";
			if ((IDTextBox.Text == "auto increment" || IDTextBox.Text == "") && YearTextBox.Text != "")
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

			if(IDTextBox.Text != "" && IDTextBox.Text != "auto increment" && IsNumeric(IDTextBox.Text))
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

			if(IDTextBox.Text != "" && IDTextBox.Text != "auto increment" && YearTextBox.Text !="" && IsNumeric(IDTextBox.Text) && IsNumeric(YearTextBox.Text))
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

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
			string query = $"Select * FROM Itec_editions WHERE itec_ID = {int.Parse(IDTextBox.Text)}";

            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);

            DataGrid.DataSource = dt;
            DataGrid.Refresh();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string queryP = $"Select * FROM Itec_editions WHERE itec_ID = {int.Parse(IDTextBox.Text)}";

            var reader = DatabaseHelper.Instance.getData(queryP);

            if (!reader.Read())
            {
                MessageBox.Show("No Edition Found Against given ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IDTextBox.Focus();
                return;
            }

            DialogResult ButtonPressed = MessageBox.Show($"Are you sure you want to delete Edition at {IDTextBox.Text} ID", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ButtonPressed == DialogResult.Yes)
            {
                string query = $"DELETE FROM Itec_editions WHERE itec_ID = {int.Parse(IDTextBox.Text)}";

				int result = DatabaseHelper.Instance.ExecuteQuery(query);
				if (result == 0)
				{
					MessageBox.Show("Could not delete edition in database\n\nUnknowen Error. Please Contact ITEC Management.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
                {
                    ShowAllButton.PerformClick();
                    SuccessLabel.Show();
                    SuccessLabel.Text = "Edition Deleted";
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

            string query = $"Select * FROM Itec_editions WHERE itec_ID = {int.Parse(IDTextBox.Text)}";

            var reader = DatabaseHelper.Instance.getData(query);

			if(!reader.Read())
			{
				MessageBox.Show("No Edition Found Against given ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
				IDTextBox.Focus();
				return;
            }

			if(ThemeTextBox.Text == "")
				ThemeTextBox.Text = reader["theme"].ToString();
			if (DescriptionTextBox.Text == "")
				DescriptionTextBox.Text = reader["description"].ToString();

			string query1 = $"UPDATE Itec_editions SET year = {int.Parse(YearTextBox.Text)}, theme = '{ThemeTextBox.Text}', description = '{DescriptionTextBox.Text}' WHERE itec_ID = {int.Parse(IDTextBox.Text)}";

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

		private void RetrieveAt(int ID)
		{
            string query = $"Select * FROM Itec_editions WHERE itec_ID = {ID}";

            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);

            DataGrid.DataSource = dt;
            DataGrid.Refresh();
        }

        private void DataGrid_DoubleClick(object sender, EventArgs e)
        {
			UpdateButtons();
			IDTextBox.Text = DataGrid.CurrentRow.Cells[0].Value.ToString();
            YearTextBox.Text = DataGrid.CurrentRow.Cells[1].Value.ToString();
            ThemeTextBox.Text = DataGrid.CurrentRow.Cells[2].Value.ToString();
            DescriptionTextBox.Text = DataGrid.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
