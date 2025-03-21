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
using Org.BouncyCastle.Asn1.BC;
using Org.BouncyCastle.Tls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITEC_Event_Management_System
{
    public partial class VenueAllocations : Form
    {
        bool isOtherTable = false;
        public VenueAllocations()
        {
            InitializeComponent();
        }
        private void VenueAllocations_Load_1(object sender, EventArgs e)
        {
            LoadComboBoxes();
            UpdateButtons();
        }
        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        private void LoadComboBoxes()
        {
            List<Venue> venues = VenueDL.GetAllVenues();
            VenueIDComboBox.Items.Add("None");
            foreach (Venue venue in venues)
            {
                VenueIDComboBox.Items.Add(venue.ID);
            }
            VenueIDComboBox.SelectedIndex = 0;

            List<Event> events = EventDL.GetAllEvents();
            EventIDComboBox.Items.Add("None");
            foreach (Event evn in events)
            {
                EventIDComboBox.Items.Add(evn.ID);
            }
            EventIDComboBox.SelectedIndex = 0;
        }

        private void UpdateButtons()
        {
            SuccessLabel.Text = "None";
            SuccessLabel.ForeColor = Color.Green;
            if ((AllocationIDTextBox.Text == "auto increment" || AllocationIDTextBox.Text == ""))
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

            if (AllocationIDTextBox.Text != "" && AllocationIDTextBox.Text != "auto increment" && IsNumeric(AllocationIDTextBox.Text))
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

            if (AllocationIDTextBox.Text != "" && AllocationIDTextBox.Text != "auto increment" && IsNumeric(AllocationIDTextBox.Text))
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

        private void AllocationIDTextBox_Click(object sender, EventArgs e)
        {
            if (AllocationIDTextBox.Text == "auto increment")
                AllocationIDTextBox.Text = "";
            AllocationIDTextBox.ForeColor = Color.Black;
            AllocationIDTextBox.Font = new Font(AllocationIDTextBox.Font, FontStyle.Regular);
        }

        private void AllocationIDTextBox_Leave(object sender, EventArgs e)
        {
            if (AllocationIDTextBox.Text == "")
            {
                AllocationIDTextBox.Text = "auto increment";
                AllocationIDTextBox.Font = new Font(AllocationIDTextBox.Font, FontStyle.Italic);
                AllocationIDTextBox.ForeColor = Color.Gray;
                IDErrorLabel.Hide();
            }
            UpdateButtons();
        }

        private void AllocationIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumeric(AllocationIDTextBox.Text) && AllocationIDTextBox.Text != "")
                IDErrorLabel.Show();
            else
                IDErrorLabel.Hide();
            UpdateButtons();
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            List <VenueAllocation> venueAllocations = VenueAllocationDL.GetAllVenueAllocations();

            DataTable dt = new DataTable();
            dt.Columns.Add("Allocation ID");
            dt.Columns.Add("Event ID");
            dt.Columns.Add("Venue ID");
            dt.Columns.Add("Date");
            dt.Columns.Add("Time");

            foreach(VenueAllocation venueAllocation in venueAllocations)
            {
                string eventID = venueAllocation.EventID == -1 ? "NULL" : venueAllocation.EventID.ToString();
                string venueID = venueAllocation.VenueID == -1 ? "NULL" : venueAllocation.VenueID.ToString();
                dt.Rows.Add(venueAllocation.AllocationID, eventID, venueID, venueAllocation.AssignedDate.ToShortDateString(), venueAllocation.AssignedTime.ToString());
            }
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DatePicker.Value.ToShortDateString());
            //MessageBox.Show(TimePicker.Value.ToString("HH:mm:ss"));
            //DateTime date = new DateTime(DatePicker.Value.Year, DatePicker.Value.Month, DatePicker.Value.Day);
            //TimeSpan time = new TimeSpan(TimePicker.Value.Hour, TimePicker.Value.Minute, TimePicker.Value.Second);
            //MessageBox.Show(date.ToString());
            //MessageBox.Show(time.ToString());

            int evnetID = EventIDComboBox.Text == "None" ? -1 : Convert.ToInt32(EventIDComboBox.Text);
            int venueID = VenueIDComboBox.Text == "None" ? -1 : Convert.ToInt32(VenueIDComboBox.Text);
            VenueAllocation venueAllocation = new VenueAllocation(-1, evnetID, venueID, DateTime.Parse(DatePicker.Value.ToString("yyyy-MM-dd")), TimeSpan.Parse(TimePicker.Value.ToString("HH:mm:ss")));
            int result = VenueAllocationDL.StoreVenueAllocation(venueAllocation);
            if (result == 1)
            {
                SuccessLabel.Text = "Success";
                SuccessLabel.ForeColor = Color.Green;
                ShowAllButton.PerformClick();
            }
            else
            {
                SuccessLabel.Text = "Failed";
                SuccessLabel.ForeColor = Color.Red;
            }
        }

        private void ShowEventsButton_Click(object sender, EventArgs e)
        {
            List<Event> events = EventDL.GetAllEvents();

            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
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

        private void ShowVenuesButton_Click(object sender, EventArgs e)
        {
            List<Venue> venues = VenueDL.GetAllVenues();
            
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Capacity");
            dt.Columns.Add("Location");

            foreach(Venue venue in venues)
            {
                string location = venue.location == null ? "NULL" : venue.location;
                dt.Rows.Add(venue.ID, venue.name, venue.capacity, location);
            }
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = true;
        }

        private void RetrieveAt(int ID)
        {
            VenueAllocation venueAllocation = VenueAllocationDL.GetVenueAllocationByID(ID);
            if(venueAllocation == null)
            {
                MessageBox.Show("No such record found");
                return;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("Allocation ID");
            dt.Columns.Add("Event ID");
            dt.Columns.Add("Venue ID");
            dt.Columns.Add("Date");
            dt.Columns.Add("Time");

                string eventID = venueAllocation.EventID == -1 ? "NULL" : venueAllocation.EventID.ToString();
                string venueID = venueAllocation.VenueID == -1 ? "NULL" : venueAllocation.VenueID.ToString();
                dt.Rows.Add(venueAllocation.AllocationID, eventID, venueID, venueAllocation.AssignedDate.ToShortDateString(), venueAllocation.AssignedTime.ToString());
            
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = false;
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            RetrieveAt(int.Parse(AllocationIDTextBox.Text));
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int eventID = EventIDComboBox.Text == "None" ? -1 : Convert.ToInt32(EventIDComboBox.Text);
            int venueID = VenueIDComboBox.Text == "None" ? -1 : Convert.ToInt32(VenueIDComboBox.Text);
            VenueAllocation venueAllocation = new VenueAllocation(int.Parse(AllocationIDTextBox.Text), eventID, venueID, DateTime.Parse(DatePicker.Value.ToString("yyyy-MM-dd")), TimeSpan.Parse(TimePicker.Value.ToString("HH:mm:ss")));
            int result = VenueAllocationDL.UpdateVenueAllocation(venueAllocation);
            if (result == 0)
            {
                SuccessLabel.Text = "Failed";
                SuccessLabel.ForeColor = Color.Red;
            }
            else
            {
                SuccessLabel.Text = "Success";
                SuccessLabel.ForeColor = Color.Green;
                RetrieveAt(int.Parse(AllocationIDTextBox.Text));
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int result = VenueAllocationDL.DeleteVenueAllocation(int.Parse(AllocationIDTextBox.Text));
            if (result == 0)
            {
                SuccessLabel.Text = "Failed";
                SuccessLabel.ForeColor = Color.Red;
                MessageBox.Show("No such record found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SuccessLabel.Text = "Success";
                SuccessLabel.ForeColor = Color.Green;
                ShowAllButton.PerformClick();
            }
        }

        private void SearchEventsButton_Click(object sender, EventArgs e)
        {
            List<VenueAllocation> venueAllocations = new List<VenueAllocation>();

            DataTable dt = new DataTable();
            dt.Columns.Add("Allocation ID");
            dt.Columns.Add("Event ID");
            dt.Columns.Add("Venue ID");
            dt.Columns.Add("Date");
            dt.Columns.Add("Time");

            if(EventIDComboBox.Text == "None")
            {
                venueAllocations = VenueAllocationDL.GetVenueAllocationsByNullEventID();
                foreach(VenueAllocation venueAllocation in venueAllocations)
                {
                    string eventID = venueAllocation.EventID == -1 ? "NULL" : venueAllocation.EventID.ToString();
                    string venueID = venueAllocation.VenueID == -1 ? "NULL" : venueAllocation.VenueID.ToString();
                    dt.Rows.Add(venueAllocation.AllocationID, eventID, venueID, venueAllocation.AssignedDate.ToShortDateString(), venueAllocation.AssignedTime.ToString());
                }
            }
            else
            {
                venueAllocations = VenueAllocationDL.GetVenueAllocationsByEventID(int.Parse(EventIDComboBox.Text));
                foreach (VenueAllocation venueAllocation in venueAllocations)
                {
                    string eventID = venueAllocation.EventID == -1 ? "NULL" : venueAllocation.EventID.ToString();
                    string venueID = venueAllocation.VenueID == -1 ? "NULL" : venueAllocation.VenueID.ToString();
                    dt.Rows.Add(venueAllocation.AllocationID, eventID, venueID, venueAllocation.AssignedDate.ToShortDateString(), venueAllocation.AssignedTime.ToString());
                }
            }

            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = false;
        }

        private void SearchVenues_Click(object sender, EventArgs e)
        {
            List<VenueAllocation> venueAllocations = new List<VenueAllocation>();

            DataTable dt = new DataTable();
            dt.Columns.Add("Allocation ID");
            dt.Columns.Add("Event ID");
            dt.Columns.Add("Venue ID");
            dt.Columns.Add("Date");
            dt.Columns.Add("Time");

            if(VenueIDComboBox.Text == "None")
            {
                venueAllocations = VenueAllocationDL.GetVenueAllocationsByNullVenueID();
                foreach (VenueAllocation venueAllocation in venueAllocations)
                {
                    string eventID = venueAllocation.EventID == -1 ? "NULL" : venueAllocation.EventID.ToString();
                    string venueID = venueAllocation.VenueID == -1 ? "NULL" : venueAllocation.VenueID.ToString();
                    dt.Rows.Add(venueAllocation.AllocationID, eventID, venueID, venueAllocation.AssignedDate.ToShortDateString(), venueAllocation.AssignedTime.ToString());
                }
            }
            else
            {
                venueAllocations = VenueAllocationDL.GetVenueAllocationsByVenueID(int.Parse(VenueIDComboBox.Text));
                foreach (VenueAllocation venueAllocation in venueAllocations)
                {
                    string eventID = venueAllocation.EventID == -1 ? "NULL" : venueAllocation.EventID.ToString();
                    string venueID = venueAllocation.VenueID == -1 ? "NULL" : venueAllocation.VenueID.ToString();
                    dt.Rows.Add(venueAllocation.AllocationID, eventID, venueID, venueAllocation.AssignedDate.ToShortDateString(), venueAllocation.AssignedTime.ToString());
                }
            }

            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = false;
        }

        private void SearchDateAndTime_Click(object sender, EventArgs e)
        {
            VenueAllocation venueAllocationObj = new VenueAllocation(-1, -1, -1, DateTime.Parse(DatePicker.Value.ToString("yyyy-MM-dd")), TimeSpan.Parse(TimePicker.Value.ToString("HH:mm:ss")));
            List<VenueAllocation> venueAllocations = VenueAllocationDL.GetVenueAllocationsByDateandTime(venueAllocationObj);
            DataTable dt = new DataTable();
            dt.Columns.Add("Allocation ID");
            dt.Columns.Add("Event ID");
            dt.Columns.Add("Venue ID");
            dt.Columns.Add("Date");
            dt.Columns.Add("Time");

            foreach (VenueAllocation venueAllocation in venueAllocations)
            {
                string eventID = venueAllocation.EventID == -1 ? "NULL" : venueAllocation.EventID.ToString();
                string venueID = venueAllocation.VenueID == -1 ? "NULL" : venueAllocation.VenueID.ToString();
                dt.Rows.Add(venueAllocation.AllocationID, eventID, venueID, venueAllocation.AssignedDate.ToShortDateString(), venueAllocation.AssignedTime.ToString());
            }
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = false;
        }

        private void SearchDate_Click(object sender, EventArgs e)
        {
            List<VenueAllocation> venueAllocations = VenueAllocationDL.GetVenueAllocationsByDate(DateTime.Parse(DatePicker.Value.ToString("yyyy-MM-dd")));
            DataTable dt = new DataTable();
            dt.Columns.Add("Allocation ID");
            dt.Columns.Add("Event ID");
            dt.Columns.Add("Venue ID");
            dt.Columns.Add("Date");
            dt.Columns.Add("Time");

            foreach (VenueAllocation venueAllocation in venueAllocations)
            {
                string eventID = venueAllocation.EventID == -1 ? "NULL" : venueAllocation.EventID.ToString();
                string venueID = venueAllocation.VenueID == -1 ? "NULL" : venueAllocation.VenueID.ToString();
                dt.Rows.Add(venueAllocation.AllocationID, eventID, venueID, venueAllocation.AssignedDate.ToShortDateString(), venueAllocation.AssignedTime.ToString());
            }
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = false;
        }

        private void ShowConflictsButton_Click(object sender, EventArgs e)
        {
            DataTable dt = VenueAllocationDL.GetVenueAllocationsConflict();

            //DataTable dt = new DataTable();
            //dt.Columns.Add("1st Allocation ID");
            //dt.Columns.Add("1st Event ID");
            //dt.Columns.Add("2nd Allocation ID");
            //dt.Columns.Add("2nd Event ID");
            //dt.Columns.Add("Venue ID");
            //dt.Columns.Add("Date");
            //dt.Columns.Add("Time");


            if (dt != null)
            {
                DataGrid.DataSource = dt;
                DataGrid.Refresh();
                isOtherTable = true;
            }
            else
            {
                MessageBox.Show("No conflicts found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DataGrid_DoubleClick(object sender, EventArgs e)
        {
            if(!isOtherTable)
            {
                AllocationIDTextBox.Text = DataGrid.CurrentRow.Cells[0].Value.ToString();
                EventIDComboBox.Text = DataGrid.CurrentRow.Cells[1].Value.ToString();
                VenueIDComboBox.Text = DataGrid.CurrentRow.Cells[2].Value.ToString();
                DatePicker.Value = DateTime.Parse(DataGrid.CurrentRow.Cells[3].Value.ToString());
                TimePicker.Value = DateTime.Parse(DataGrid.CurrentRow.Cells[4].Value.ToString());
                UpdateButtons();
            }
        }
    }
}
