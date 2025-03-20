using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITEC_Event_Management_System.BL;
using ITEC_Event_Management_System.DL;

namespace ITEC_Event_Management_System
{
    public partial class Sponsors : Form
    {
        public Sponsors()
        {
            InitializeComponent();
            UpdateButtons();
        }

        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        private bool IsValidPhoneNumber(string phone)
        {
            string phonePattern = @"^\d{10,15}$";
            return Regex.IsMatch(phone, phonePattern);
        }

        private void UpdateButtons()
        {
            SuccessLabel.Text = "None";
            SuccessLabel.ForeColor = Color.Green;
            if ((IDTextBox.Text == "auto increment" || IDTextBox.Text == "") && NameTextBox.Text != "" && (IsValidPhoneNumber(ContactTextBox.Text) || string.IsNullOrEmpty(ContactTextBox.Text)))
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

            if (IDTextBox.Text != "" && IDTextBox.Text != "auto increment")
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

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            List<Sponsor> sponsors = SponsorDL.GetAllSponsors();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Contact");

            foreach (Sponsor sponsor in sponsors)
            {
                DataRow row = dt.NewRow();
                row["ID"] = sponsor.ID;
                row["Name"] = sponsor.name;
                row["Contact"] = sponsor.contact;
                dt.Rows.Add(row);
            }

            DataGrid.DataSource = dt;
            DataGrid.Refresh();
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateButtons();

            if (!IsNumeric(IDTextBox.Text) && IDTextBox.Text != "")
                IDErrorLabel.Show();
            else
                IDErrorLabel.Hide();
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

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void ContactTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidPhoneNumber(ContactTextBox.Text) && ContactTextBox.Text != "")
                ContactErrorLabel.Show();
            else
                ContactErrorLabel.Hide();
            UpdateButtons();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int result = SponsorDL.StoreSponsor(new Sponsor(-1, NameTextBox.Text, ContactTextBox.Text));

            if (result == 1)
            {
                SuccessLabel.Text = "Sponsor Added Successfully";
                SuccessLabel.ForeColor = Color.ForestGreen;

                NameTextBox.Text = "";
                ContactTextBox.Clear();

                ShowAllButton.PerformClick();
            }
            else
            {
                SuccessLabel.Text = "Sponsor Addition Failed";
                SuccessLabel.ForeColor = Color.Red;
            }
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            Sponsor sponsor = SponsorDL.GetSponsorByID(int.Parse(IDTextBox.Text));

            if (sponsor != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Contact");
                dt.Rows.Clear();
                DataRow row = dt.NewRow();
                row["ID"] = sponsor.ID;
                row["Name"] = sponsor.name;
                row["Contact"] = sponsor.contact;
                dt.Rows.Add(row);
                DataGrid.DataSource = dt;
                DataGrid.Refresh();
            }
            else
            {
                SuccessLabel.Text = "Sponsor Retrieval Failed";
                SuccessLabel.ForeColor = Color.Red;
                MessageBox.Show("No Sponsor Found with the given ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int result = SponsorDL.UpdateSponsor(new Sponsor(int.Parse(IDTextBox.Text), NameTextBox.Text, ContactTextBox.Text));
            if (result != 0)
            {
                SuccessLabel.Text = "Sponsor Updated Successfully";
                SuccessLabel.ForeColor = Color.ForestGreen;
                RetrieveAt(int.Parse(IDTextBox.Text));
            }
            else
            {
                SuccessLabel.Text = "Sponsor Update Failed";
                SuccessLabel.ForeColor = Color.Red;
            }
        }

        private void RetrieveAt(int ID)
        {
            Sponsor sponsor = SponsorDL.GetSponsorByID(ID);

            if (sponsor != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Contact");
                dt.Rows.Clear();
                DataRow row = dt.NewRow();
                row["ID"] = sponsor.ID;
                row["Name"] = sponsor.name;
                row["Contact"] = sponsor.contact;
                dt.Rows.Add(row);
                DataGrid.DataSource = dt;
                DataGrid.Refresh();
            }
            else
            {
                SuccessLabel.Text = "Sponsor Retrieval Failed";
                SuccessLabel.ForeColor = Color.Red;
                MessageBox.Show("No Sponsor Found with the given ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int result = SponsorDL.DeleteSponsor(int.Parse(IDTextBox.Text));
            if (result != 0)
            {
                SuccessLabel.Text = "Sponsor Deleted Successfully";
                SuccessLabel.ForeColor = Color.ForestGreen;
                IDTextBox.Text = "auto increment";
                IDErrorLabel.Hide();
                IDTextBox.Font = new Font(IDTextBox.Font, FontStyle.Italic);
                IDTextBox.ForeColor = Color.Gray;
                NameTextBox.Text = "";
                ShowAllButton.PerformClick();
            }
            else
            {
                SuccessLabel.Text = "Sponsor Deletion Failed";
                SuccessLabel.ForeColor = Color.Red;
            }
        }

        private void NameSearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                MessageBox.Show("Please enter a name to search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                List<Sponsor> sponsors = SponsorDL.GetSponsorsByLikeName(NameTextBox.Text);
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Contact");
                foreach(Sponsor sponsor in sponsors)
                {
                    DataRow row = dt.NewRow();
                    row["ID"] = sponsor.ID;
                    row["Name"] = sponsor.name;
                    row["Contact"] = sponsor.contact;
                    dt.Rows.Add(row);
                }
                DataGrid.DataSource = dt;
                DataGrid.Refresh();
            }
        }

        private void ContactSearchButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ContactTextBox.Text))
            {
                List<Sponsor> sponsors = SponsorDL.GetSponsorsByNullContact();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Contact");
                foreach (Sponsor sponsor in sponsors)
                {
                    DataRow row = dt.NewRow();
                    row["ID"] = sponsor.ID;
                    row["Name"] = sponsor.name;
                    row["Contact"] = sponsor.contact;
                    dt.Rows.Add(row);
                }
                DataGrid.DataSource = dt;
                DataGrid.Refresh();
            }
            else
            {
                List<Sponsor> sponsors = SponsorDL.GetSponsorsByLikeContact(ContactTextBox.Text);
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Contact");
                foreach (Sponsor sponsor in sponsors)
                {
                    DataRow row = dt.NewRow();
                    row["ID"] = sponsor.ID;
                    row["Name"] = sponsor.name;
                    row["Contact"] = sponsor.contact;
                    dt.Rows.Add(row);
                }
                DataGrid.DataSource = dt;
                DataGrid.Refresh();
            }
        }
    }
}
