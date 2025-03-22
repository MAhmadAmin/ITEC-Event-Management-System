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
using System.Web;
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

            if (IDTextBox.Text != "" && IDTextBox.Text != "auto increment" && IsNumeric(IDTextBox.Text) && (IsValidPhoneNumber(ContactTextBox.Text) || string.IsNullOrEmpty(ContactTextBox.Text)))
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

        private void UpdateVendorButtons()
        {
            VendorSuccessLabel.Text = "None";
            VendorSuccessLabel.ForeColor = Color.Green;
            if ((VendorIDTextBox.Text == "auto increment" || VendorIDTextBox.Text == "") && VendorNameTextBox.Text != "" && (IsValidPhoneNumber(VendorContactTextBox.Text) || string.IsNullOrEmpty(VendorContactTextBox.Text)))
            {
                VendorAddButton.Enabled = true;
                VendorAddButton.ForeColor = Color.White;
                VendorAddButton.BackColor = Color.ForestGreen;
            }
            else
            {

                VendorAddButton.Enabled = false;
                VendorAddButton.BackColor = Color.Gray;
            }

            if (VendorIDTextBox.Text != "" && VendorIDTextBox.Text != "auto increment" && IsNumeric(VendorIDTextBox.Text))
            {
                VendorDeleteButton.Enabled = true;
                VendorDeleteButton.ForeColor = Color.White;
                VendorDeleteButton.BackColor = Color.Brown;

                VendorRetrieveButton.Enabled = true;
                VendorRetrieveButton.BackColor = Color.Peru;
            }
            else
            {
                VendorDeleteButton.Enabled = false;
                VendorDeleteButton.BackColor = Color.Gray;

                VendorRetrieveButton.Enabled = false;
                VendorRetrieveButton.BackColor = Color.Gray;
            }

            if (VendorIDTextBox.Text != "" && VendorIDTextBox.Text != "auto increment" && IsNumeric(VendorIDTextBox.Text) && (IsValidPhoneNumber(VendorContactTextBox.Text) || string.IsNullOrEmpty(VendorContactTextBox.Text)))
            {
                VendorUpdateButton.Enabled = true;
                VendorUpdateButton.BackColor = Color.RoyalBlue;
            }
            else
            {
                VendorUpdateButton.Enabled = false;
                VendorUpdateButton.BackColor = Color.Gray;
            }
        }

        private void Sponsors_Load(object sender, EventArgs e)
        {
            UpdateButtons();
            UpdateVendorButtons();
        }

        private void VendorIDTextBox_Click(object sender, EventArgs e)
        {
            if (VendorIDTextBox.Text == "auto increment")
                VendorIDTextBox.Text = "";
            VendorIDTextBox.ForeColor = Color.Black;
            VendorIDTextBox.Font = new Font(VendorIDTextBox.Font, FontStyle.Regular);
        }

        private void VendorIDTextBox_Leave(object sender, EventArgs e)
        {
            if (VendorIDTextBox.Text == "")
            {
                VendorIDTextBox.Text = "auto increment";
                VendorIDTextBox.Font = new Font(VendorIDTextBox.Font, FontStyle.Italic);
                VendorIDTextBox.ForeColor = Color.Gray;
                VendorIDErrorLabel.Hide();
            }
            UpdateVendorButtons();
        }

        private void VendorIDTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateVendorButtons();

            if (!IsNumeric(VendorIDTextBox.Text) && VendorIDTextBox.Text != "")
                VendorIDErrorLabel.Show();
            else
                VendorIDErrorLabel.Hide();
        }

        private void VendorNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateVendorButtons();
        }

        private void VendorContactTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidPhoneNumber(VendorContactTextBox.Text) && VendorContactTextBox.Text != "")
                VendorContactErrorLabel.Show();
            else
                VendorContactErrorLabel.Hide();
            UpdateVendorButtons();
        }

        private void VendorShowAllButton_Click(object sender, EventArgs e)
        {
            List<Vendor> vendors = VendorDL.GetAllVendors();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Contact");
            dataTable.Columns.Add("Service Type");

            foreach(Vendor vendor in vendors)
            {
                string contact = string.IsNullOrEmpty(vendor.Contact) ? "NULL" : vendor.Contact;
                string serviceType = string.IsNullOrEmpty(vendor.Servicetype) ? "NULL" : vendor.Servicetype;

                dataTable.Rows.Add(vendor.ID.ToString(), vendor.Name.ToString(), contact, serviceType);
            }

            VendorDataGrid.DataSource = dataTable;
            VendorDataGrid.Refresh();
        }

        private void VendorAddButton_Click(object sender, EventArgs e)
        {
            string contact = string.IsNullOrWhiteSpace(VendorContactTextBox.Text) ? null : VendorContactTextBox.Text;
            string serviceType = string.IsNullOrWhiteSpace(VendorServiceTextBox.Text) ? null : VendorServiceTextBox.Text;

            int result = VendorDL.StoreVendor(new Vendor(-1, VendorNameTextBox.Text, contact, serviceType));
            if(result == 1)
            {
                VendorSuccessLabel.Text = "Vendor Added Successfully";
                VendorSuccessLabel.ForeColor = Color.Green;
                VendorShowAllButton.PerformClick();
            }
            else
            {
                VendorSuccessLabel.Text = "Failed To Add vendor";
                VendorSuccessLabel.ForeColor = Color.Red;
            }
        }

        private void VendorRetrieveButton_Click(object sender, EventArgs e)
        {
            Vendor vendor = VendorDL.GetVendorByID(int.Parse(VendorIDTextBox.Text));
            if(vendor == null)
            {
                MessageBox.Show("Vendor Not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID");
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Contact");
                dataTable.Columns.Add("Service Type");

                    string contact = string.IsNullOrEmpty(vendor.Contact) ? "NULL" : vendor.Contact;
                    string serviceType = string.IsNullOrEmpty(vendor.Servicetype) ? "NULL" : vendor.Servicetype;

                    dataTable.Rows.Add(vendor.ID.ToString(), vendor.Name.ToString(), contact, serviceType);
                VendorDataGrid.DataSource = dataTable;
                VendorDataGrid.Refresh();
            }
        }

        private void VendorDeleteButton_Click(object sender, EventArgs e)
        {
            int result = VendorDL.DeleteVendor(int.Parse(VendorIDTextBox.Text));

            if(result == 1)
            {
                VendorSuccessLabel.Text = "Vendor Deleted Successfully";
                VendorSuccessLabel.ForeColor = Color.Green;
                VendorShowAllButton.PerformClick();
            }
            else
            {
                VendorSuccessLabel.Text = "Failed To Delete vendor";
                VendorSuccessLabel.ForeColor = Color.Red;
            }
        }

        private void VendorUpdateButton_Click(object sender, EventArgs e)
        {
            string contact = string.IsNullOrWhiteSpace(VendorContactTextBox.Text) ? null : VendorContactTextBox.Text;
            string serviceType = string.IsNullOrWhiteSpace(VendorServiceTextBox.Text) ? null : VendorServiceTextBox.Text;

            int result = VendorDL.UpdateVendor(new Vendor(int.Parse(VendorIDTextBox.Text), VendorNameTextBox.Text, contact, serviceType));

            if(result == 1)
            {
                VendorSuccessLabel.Text = "Vendor Updated Successfully";
                VendorSuccessLabel.ForeColor = Color.Green;
                VendorShowAllButton.PerformClick();
            }
            else if(result == -1)
            {
                VendorSuccessLabel.Text = "Vendor not found";
                VendorSuccessLabel.ForeColor = Color.Red;
            }
            else
            {
                VendorSuccessLabel.Text = "Failed To Update vendor";
                VendorSuccessLabel.ForeColor = Color.Red;
            }
        }

        private void SearchVendorName_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(VendorNameTextBox.Text))
            {
                MessageBox.Show("Please Enter a Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Vendor> vendors = VendorDL.GetVendorsByNameLike(NameTextBox.Text);

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID");
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Contact");
                dataTable.Columns.Add("Service Type");

                foreach (Vendor vendor in vendors)
                {
                    string contact = string.IsNullOrEmpty(vendor.Contact) ? "NULL" : vendor.Contact;
                    string serviceType = string.IsNullOrEmpty(vendor.Servicetype) ? "NULL" : vendor.Servicetype;

                    dataTable.Rows.Add(vendor.ID.ToString(), vendor.Name.ToString(), contact, serviceType);
                }

                VendorDataGrid.DataSource = dataTable;
                VendorDataGrid.Refresh();
            }
        }

        private void SearchVendorContact_Click(object sender, EventArgs e)
        {
            List<Vendor> vendors = new List<Vendor>();
            if (string.IsNullOrEmpty(VendorContactTextBox.Text))
                vendors = VendorDL.GetVendorsByNullContact();
            else
                vendors = VendorDL.GetVendorsByContactLike(VendorContactTextBox.Text);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Contact");
            dataTable.Columns.Add("Service Type");

            foreach (Vendor vendor in vendors)
            {
                string contact = string.IsNullOrEmpty(vendor.Contact) ? "NULL" : vendor.Contact;
                string serviceType = string.IsNullOrEmpty(vendor.Servicetype) ? "NULL" : vendor.Servicetype;

                dataTable.Rows.Add(vendor.ID.ToString(), vendor.Name.ToString(), contact, serviceType);
            }

            VendorDataGrid.DataSource = dataTable;
            VendorDataGrid.Refresh();
        }

        private void SearchVendorService_Click(object sender, EventArgs e)
        {
            List<Vendor> vendors = new List<Vendor> { };
            if (string.IsNullOrWhiteSpace(VendorServiceTextBox.Text))
                vendors = VendorDL.GetVendorsByNullService();
            else
                vendors = VendorDL.GetVendorsByServiceLike(VendorServiceTextBox.Text);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Contact");
            dataTable.Columns.Add("Service Type");

            foreach (Vendor vendor in vendors)
            {
                string contact = string.IsNullOrEmpty(vendor.Contact) ? "NULL" : vendor.Contact;
                string serviceType = string.IsNullOrEmpty(vendor.Servicetype) ? "NULL" : vendor.Servicetype;

                dataTable.Rows.Add(vendor.ID.ToString(), vendor.Name.ToString(), contact, serviceType);
            }

            VendorDataGrid.DataSource = dataTable;
            VendorDataGrid.Refresh();
        }
    }
}