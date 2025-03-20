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
using ITEC_Event_Management_System.DL;
using ITEC_Event_Management_System.BL;

namespace ITEC_Event_Management_System
{
    public partial class EventCategories : Form
    {
        public EventCategories()
        {
            InitializeComponent();
        }
        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        private void UpdateButtons()
        {
            SuccessLabel.Text = "None";
            SuccessLabel.ForeColor = Color.Green;
            if ((IDTextBox.Text == "auto increment" || IDTextBox.Text == "") && NameTextBox.Text != "" )
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

            if (IDTextBox.Text != "" && IDTextBox.Text != "auto increment" && IsNumeric(IDTextBox.Text))
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
        public string CapitalizeEachWord(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            return string.Join(" ", input.Split(' ')
                .Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
        }
        private void IDTextBox_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "auto increment")
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
            UpdateButtons();
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateButtons();

            if (!IsNumeric(IDTextBox.Text) && IDTextBox.Text != "")
                IDErrorLabel.Show();
            else
                IDErrorLabel.Hide();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            List<EventCategory> categories = EventCategoryDL.GetAllCategories();

            if (categories.Count == 0)
            {
                SuccessLabel.Text = "No categories found";
                SuccessLabel.ForeColor = Color.Red;
                return;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            foreach (EventCategory category in categories)
            {
                dt.Rows.Add(category.ID, category.name);
            }
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
        }

        private void EventCategories_Load(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int result = EventCategoryDL.StoreCategory(new EventCategory(-1, CapitalizeEachWord(NameTextBox.Text)));
            if (result == 1)
            {
                SuccessLabel.Text = "Category added successfully";
                SuccessLabel.ForeColor = Color.Green;
                ShowAllButton.PerformClick();
            }
            else
            {
                SuccessLabel.Text = "Failed to add category";
                SuccessLabel.ForeColor = Color.Red;
                MessageBox.Show("Failed to add category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            EventCategory category = EventCategoryDL.GetCategoryByID(int.Parse(IDTextBox.Text));
            if (category != null)
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID");
                dataTable.Columns.Add("Name");
                dataTable.Rows.Add(category.ID, category.name);
                DataGrid.DataSource = dataTable;
                DataGrid.Refresh();
            }
            else
            {
                SuccessLabel.Text = "Category not found";
                SuccessLabel.ForeColor = Color.Red;
                MessageBox.Show("No Category Found", CapitalizeEachWord(IDTextBox.Text) + " not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDTextBox.Text);
            string name = CapitalizeEachWord(NameTextBox.Text);

            EventCategory category = new EventCategory(id, name);
            int result = EventCategoryDL.UpdateCategory(category);

            if (result == 1)
            {
                SuccessLabel.Text = "Category updated successfully";
                SuccessLabel.ForeColor = Color.Green;
                ShowAllButton.PerformClick();
            }
            else
            {
                SuccessLabel.Text = "Failed to update category";
                SuccessLabel.ForeColor = Color.Red;
                MessageBox.Show("Failed to update category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int result = EventCategoryDL.DeleteCategory(new EventCategory(int.Parse(IDTextBox.Text), ""));
            if (result == 1)
            {
                SuccessLabel.Text = "Category deleted successfully";
                SuccessLabel.ForeColor = Color.Green;
                ShowAllButton.PerformClick();
            }
            else
            {
                SuccessLabel.Text = "Failed to delete category";
                SuccessLabel.ForeColor = Color.Red;
                MessageBox.Show("Failed to delete category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NameSearchButton_Click(object sender, EventArgs e)
        {
            List<EventCategory> categories = EventCategoryDL.GetCategoriesByNameLike(NameTextBox.Text);

            if (categories.Count == 0)
            {
                SuccessLabel.Text = "No categories found";
                SuccessLabel.ForeColor = Color.Red;
                return;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            foreach (EventCategory category in categories)
            {
                dt.Rows.Add(category.ID, category.name);
            }
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
        }
    }
}
