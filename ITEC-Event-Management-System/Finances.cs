using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITEC_Event_Management_System.BL;
using ITEC_Event_Management_System.DL;

namespace ITEC_Event_Management_System
{
    public partial class Finances : Form
    {
        bool isOtherTable = false;
        public Finances()
        {
            InitializeComponent();
        }

        private void Finances_Load(object sender, EventArgs e)
        {
            UpdateButtons();
            UpdateComboBoxes();
        }

        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        private void UpdateButtons()
        {
            SuccessLabel.Text = "None";
            SuccessLabel.ForeColor = Color.Green;
            if ((TransactionIDTextBox.Text == "auto increment" || TransactionIDTextBox.Text == "") && IsNumeric(AmountTextBox.Text) && IsNumeric(FromIDTextBox.Text) && IsNumeric(ToIDTextBox.Text) && FromTypeComboBox.SelectedIndex != 0 && ToTypeComboBox.SelectedIndex != 0)
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

            if (TransactionIDTextBox.Text != "" && TransactionIDTextBox.Text != "auto increment" && IsNumeric(TransactionIDTextBox.Text))
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

            if (TransactionIDTextBox.Text != "" && TransactionIDTextBox.Text != "auto increment" && IsNumeric(TransactionIDTextBox.Text) && IsNumeric(AmountTextBox.Text) && IsNumeric(FromIDTextBox.Text) && IsNumeric(ToIDTextBox.Text) && FromTypeComboBox.SelectedIndex != 0 && ToTypeComboBox.SelectedIndex != 0)
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

        private void UpdateComboBoxes()
        {
            List<Event> events = EventDL.GetAllEvents();
            EventIDComboBox.Items.Add("None");
            foreach (Event evn in events)
            {
                EventIDComboBox.Items.Add(evn.ID);
            }
            EventIDComboBox.SelectedIndex = 0;

            List<ITECEdition> editions = ITECEditionsDL.GetAllEditions();
            ITECIDComboBox.Items.Clear();
            ITECIDComboBox.Items.Add("None");
            foreach (ITECEdition edition in editions)
            {
                ITECIDComboBox.Items.Add(edition.ID);
            }
            ITECIDComboBox.SelectedIndex = 0;

            List<Lookup> lookups = LookupDataLayer.GetIDsByCategory("FinanceTypes");
            TypeIDComboBox.Items.Clear();
            TypeIDComboBox.Items.Add("None");
            foreach (Lookup lookup in lookups)
            {
                TypeIDComboBox.Items.Add(lookup.ID);
            }
            TypeIDComboBox.SelectedIndex = 0;

            FromTypeComboBox.Items.Clear();
            FromTypeComboBox.Items.Add("None");
            FromTypeComboBox.Items.Add("User");
            FromTypeComboBox.Items.Add("Sponsor");
            FromTypeComboBox.Items.Add("Committee");
            FromTypeComboBox.Items.Add("Vendor");
            FromTypeComboBox.SelectedIndex = 0;

            ToTypeComboBox.Items.Clear();
            ToTypeComboBox.Items.Add("None");
            ToTypeComboBox.Items.Add("User");
            ToTypeComboBox.Items.Add("Sponsor");
            ToTypeComboBox.Items.Add("Committee");
            ToTypeComboBox.Items.Add("Vendor");
            ToTypeComboBox.SelectedIndex = 0;
        }

        private void TransactionIDTextBox_Click(object sender, EventArgs e)
        {
            if (TransactionIDTextBox.Text == "auto increment")
                TransactionIDTextBox.Text = "";
            TransactionIDTextBox.ForeColor = Color.Black;
            TransactionIDTextBox.Font = new Font(TransactionIDTextBox.Font, FontStyle.Regular);
        }

        private void TransactionIDTextBox_Leave(object sender, EventArgs e)
        {
            if (TransactionIDTextBox.Text == "")
            {
                TransactionIDTextBox.Text = "auto increment";
                TransactionIDTextBox.Font = new Font(TransactionIDTextBox.Font, FontStyle.Italic);
                TransactionIDTextBox.ForeColor = Color.Gray;
                IDErrorLabel.Hide();
            }
            UpdateButtons();
        }

        private void TransactionIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumeric(TransactionIDTextBox.Text) && TransactionIDTextBox.Text != "")
                IDErrorLabel.Show();
            else
                IDErrorLabel.Hide();
            UpdateButtons();
        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumeric(AmountTextBox.Text) && !string.IsNullOrWhiteSpace(AmountTextBox.Text))
                AmountErrorLabel.Show();
            else
                AmountErrorLabel.Hide();
            UpdateButtons();
        }

        private void FromIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumeric(FromIDTextBox.Text) && !string.IsNullOrWhiteSpace(FromIDTextBox.Text))
                FromIDErrorLabel.Show();
            else
                FromIDErrorLabel.Hide();
            UpdateButtons();
        }

        private void ToIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumeric(ToIDTextBox.Text) && !string.IsNullOrWhiteSpace(ToIDTextBox.Text))
                ToIDErrorLabel.Show();
            else
                ToIDErrorLabel.Hide();
            UpdateButtons();
        }

        private void FromTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void ToTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void ShowEditionsButton_Click(object sender, EventArgs e)
        {
            List<ITECEdition> editions = ITECEditionsDL.GetAllEditions();
            DataTable dt =
                new DataTable();
            dt.Columns.Add("ITEC ID");
            dt.Columns.Add("Year");
            dt.Columns.Add("Theme");
            dt.Columns.Add("Description");
            foreach (ITECEdition edition in editions)
            {
                string themeValue = string.IsNullOrEmpty(edition.theme) ? "NULL" : edition.theme;
                string descriptionValue = string.IsNullOrEmpty(edition.description) ? "NULL" : edition.description;
                dt.Rows.Add(edition.ID, edition.year, themeValue, descriptionValue);
            }
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = true;
        }

        private void ShowEventsButton_Click(object sender, EventArgs e)
        {
            List<Event> events = EventDL.GetAllEvents();

            DataTable dt = new DataTable();

            dt.Columns.Add("Event ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Date");
            dt.Columns.Add("Description");
            dt.Columns.Add("ITEC ID");
            dt.Columns.Add("Category ID");
            dt.Columns.Add("Venue ID");
            dt.Columns.Add("Committee ID");

            foreach (Event evn in events)
            {
                string ITECIDValue = evn.ITECID == -1 ? "NULL" : evn.ITECID.ToString();
                string categoryIDValue = evn.categoryID == -1 ? "NULL" : evn.categoryID.ToString();
                string venueIDValue = evn.venueID == -1 ? "NULL" : evn.venueID.ToString();
                string committeeIDValue = evn.committeeID == -1 ? "NULL" : evn.committeeID.ToString();
                dt.Rows.Add(evn.ID, evn.name, evn.date.ToShortDateString(), evn.description, ITECIDValue, categoryIDValue, venueIDValue, committeeIDValue);
            }

            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = true;
        }

        private void ShowTypesButton_Click(object sender, EventArgs e)
        {
            List<Lookup> lookups = LookupDataLayer.GetIDsByCategory("FinanceTypes");

            DataTable dt = new DataTable();
            dt.Columns.Add("Role Category");
            dt.Columns.Add("ID");
            dt.Columns.Add("Role Value");
            foreach (Lookup lookup in lookups)
            {
                DataRow row = dt.NewRow();
                row["ID"] = lookup.ID;
                row["Role Category"] = lookup.category;
                row["Role Value"] = lookup.value;
                dt.Rows.Add(row);
            }
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = true;
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            List<Finance> finances = FinanceDL.GetAll();
            ShowDataGrid(finances);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int ITECID = ITECIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(ITECIDComboBox.Text);
            int EventID = EventIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(EventIDComboBox.Text);
            int TypeID = TypeIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(TypeIDComboBox.Text);
            string Description = string.IsNullOrWhiteSpace(DescriptionTextBox.Text) ? null : DescriptionTextBox.Text;

            int result = FinanceDL.Store(new Finance(-1, ITECID, EventID, TypeID, int.Parse(AmountTextBox.Text), FromTypeComboBox.Text.ToString(), int.Parse(FromIDTextBox.Text), ToTypeComboBox.Text.ToString(), int.Parse(ToIDTextBox.Text), Description));
            
            if(result == 1)
            {
                SuccessLabel.ForeColor = Color.Green;
                SuccessLabel.Text = "Finance Added Successfully";
                ShowAllButton.PerformClick();
            }
            else
            {
                SuccessLabel.ForeColor = Color.Red;
                SuccessLabel.Text = "Unable to Add Finance";
            }
        }

        private void ShowDataGrid(List<Finance> finances)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Transaction ID");
            dt.Columns.Add("ITEC ID");
            dt.Columns.Add("Event ID");
            dt.Columns.Add("Type ID");
            dt.Columns.Add("Amount");
            dt.Columns.Add("From Type");
            dt.Columns.Add("From ID");
            dt.Columns.Add("To Type");
            dt.Columns.Add("To ID");
            dt.Columns.Add("Description");
            dt.Columns.Add("Date Recorded");

            foreach (Finance f in finances)
            {
                string ITECID = f.ITECID == -1 ? "NULL" : f.ITECID.ToString();
                string EventID = f.EventID == -1 ? "NULL" : f.EventID.ToString();
                string TypeID = f.TypeID == -1 ? "NULL" : f.TypeID.ToString();
                string Description = string.IsNullOrEmpty(f.Description) ? "NULL" : f.Description;
                dt.Rows.Add(f.TransactionID, ITECID, EventID, TypeID, f.Amount, f.FromType, f.FromID, f.ToType, f.ToID, Description, f.DateRecorded);
            }

            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int ITECID = ITECIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(ITECIDComboBox.Text);
            int EventID = EventIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(EventIDComboBox.Text);
            int TypeID = TypeIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(TypeIDComboBox.Text);
            string Description = string.IsNullOrWhiteSpace(DescriptionTextBox.Text) ? null : DescriptionTextBox.Text;

            int result = FinanceDL.Update(new Finance(int.Parse(TransactionIDTextBox.Text), ITECID, EventID, TypeID, int.Parse(AmountTextBox.Text), FromTypeComboBox.Text.ToString(), int.Parse(FromIDTextBox.Text), ToTypeComboBox.Text.ToString(), int.Parse(ToIDTextBox.Text), Description));

            if (result == 1)
            {
                SuccessLabel.ForeColor = Color.Green;
                SuccessLabel.Text = "Finance Updated Successfully";
                ShowAllButton.PerformClick();
            }
            else
            {
                SuccessLabel.ForeColor = Color.Red;
                SuccessLabel.Text = "Unable to Update Finance";
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int result = FinanceDL.Delete(int.Parse(TransactionIDTextBox.Text));

            if(result == 1)
            {
                SuccessLabel.ForeColor = Color.Green;
                SuccessLabel.Text = "Finance Deleted Successfully";
                ShowAllButton.PerformClick();
            }
            else
            {
                SuccessLabel.ForeColor = Color.Red;
                SuccessLabel.Text = "Unable to Delete Finance";
            }
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            List<Finance> finances = new List<Finance>();

            Finance f = FinanceDL.GetByID(int.Parse(TransactionIDTextBox.Text));
            if(f != null)
            {
                finances.Add(f);
                ShowDataGrid(finances);
            }
            else
            {
                SuccessLabel.ForeColor = Color.Red;
                SuccessLabel.Text = "No Finance Found";
            }
        }

        private void SearchEditionID_Click(object sender, EventArgs e)
        {
            List<Finance> finances = new List<Finance>();
            if(ITECIDComboBox.SelectedIndex == 0)
                finances = FinanceDL.GetByNullITECID();
            else
                finances = FinanceDL.GetByITECID(int.Parse(ITECIDComboBox.Text));
            ShowDataGrid(finances);
        }

        private void SearchEventID_Click(object sender, EventArgs e)
        {
            List<Finance> finances = new List<Finance>();
            if (EventIDComboBox.SelectedIndex == 0)
                finances = FinanceDL.GetByNullEventID();
            else
                finances = FinanceDL.GetByEventID(int.Parse(EventIDComboBox.Text));
            ShowDataGrid(finances);
        }

        private void SearchTypeID_Click(object sender, EventArgs e)
        {
            List<Finance> finances = new List<Finance>();
            if (TypeIDComboBox.SelectedIndex == 0)
                finances = FinanceDL.GetByNullTypeID();
            else
                finances = FinanceDL.GetByTypeID(int.Parse(TypeIDComboBox.Text));
            ShowDataGrid(finances);
        }

        private void SearchAmount_Click(object sender, EventArgs e)
        {
            if(IsNumeric(AmountTextBox.Text))
            {
                List<Finance> finances = FinanceDL.GetByAmount(int.Parse(AmountTextBox.Text));
                ShowDataGrid(finances);
            }
        }

        private void SearchFromType_Click(object sender, EventArgs e)
        {
            if (FromTypeComboBox.SelectedIndex != 0)
            {
                List<Finance> finances = FinanceDL.GetByFromType(FromTypeComboBox.Text);
                ShowDataGrid(finances);
            }
        }

        private void SearchFromID_Click(object sender, EventArgs e)
        {
            if(IsNumeric(FromIDTextBox.Text))
            {
                List<Finance> finances = FinanceDL.GetByFromID(int.Parse(FromIDTextBox.Text));
                ShowDataGrid(finances);
            }
        }

        private void SearchToType_Click(object sender, EventArgs e)
        {
            if (ToTypeComboBox.SelectedIndex != 0)
            {
                List<Finance> finances = FinanceDL.GetByToType(ToTypeComboBox.Text);
                ShowDataGrid(finances);
            }
        }

        private void SearchToID_Click(object sender, EventArgs e)
        {
            if (IsNumeric(ToIDTextBox.Text))
            {
                List<Finance> finances = FinanceDL.GetByToID(int.Parse(ToIDTextBox.Text));
                ShowDataGrid(finances);
            }
        }

        private void SearchDescription_Click(object sender, EventArgs e)
        {
            List<Finance> finances = new List<Finance>();
            if(string.IsNullOrWhiteSpace(DescriptionTextBox.Text))
            {
                finances = FinanceDL.GetByNullDescription();
            }
            else
            {
                finances = FinanceDL.GetByDescription(DescriptionTextBox.Text);
            }
            ShowDataGrid(finances);
        }

        private void DataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (!isOtherTable)
            {
                TransactionIDTextBox.Text = DataGrid.CurrentRow.Cells[0].Value.ToString();
                ITECIDComboBox.Text = DataGrid.CurrentRow.Cells[1].Value.ToString() == "NULL" ? "None" : DataGrid.CurrentRow.Cells[1].Value.ToString();
                EventIDComboBox.Text = DataGrid.CurrentRow.Cells[2].Value.ToString() == "NULL" ? "None" : DataGrid.CurrentRow.Cells[2].Value.ToString();
                TypeIDComboBox.Text = DataGrid.CurrentRow.Cells[3].Value.ToString() == "NULL" ? "None" : DataGrid.CurrentRow.Cells[3].Value.ToString();
                AmountTextBox.Text = DataGrid.CurrentRow.Cells[4].Value.ToString();
                FromTypeComboBox.Text = DataGrid.CurrentRow.Cells[5].Value.ToString();
                FromIDTextBox.Text = DataGrid.CurrentRow.Cells[6].Value.ToString();
                ToTypeComboBox.Text = DataGrid.CurrentRow.Cells[7].Value.ToString();
                ToIDTextBox.Text = DataGrid.CurrentRow.Cells[8].Value.ToString();
                DescriptionTextBox.Text = DataGrid.CurrentRow.Cells[9].Value.ToString() == "NULL" ? string.Empty : DataGrid.CurrentRow.Cells[9].Value.ToString();

                UpdateButtons();
            }
        }
    }
}
