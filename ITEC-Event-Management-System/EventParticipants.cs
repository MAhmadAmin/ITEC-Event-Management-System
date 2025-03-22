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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITEC_Event_Management_System
{
    public partial class EventParticipants : Form
    {
        bool isOtherTable = false;
        public EventParticipants()
        {
            InitializeComponent();
        }

        private void EventParticipants_Load(object sender, EventArgs e)
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
            if ((RegistrationIDTextBox.Text == "auto increment" || RegistrationIDTextBox.Text == "") && (FeeAmountTextBox.Text == "" || IsNumeric(FeeAmountTextBox.Text)))
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

            if (RegistrationIDTextBox.Text != "" && RegistrationIDTextBox.Text != "auto increment" && IsNumeric(RegistrationIDTextBox.Text))
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

            if (RegistrationIDTextBox.Text != "" && RegistrationIDTextBox.Text != "auto increment" && IsNumeric(RegistrationIDTextBox.Text) && (FeeAmountTextBox.Text == "" || IsNumeric(FeeAmountTextBox.Text)))
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

            List<Participant> participants = ParticipantDL.GetAllParticipants();
            ParticipantIDComboBox.Items.Clear();
            ParticipantIDComboBox.Items.Add("None");
            foreach (Participant participant in participants)
            {
                ParticipantIDComboBox.Items.Add(participant.ID);
            }
            ParticipantIDComboBox.SelectedIndex = 0;

            List<Lookup> lookups = LookupDataLayer.GetIDsByCategory("PaymentStatus");
            PaymentStatusIDComboBox.Items.Clear();
            PaymentStatusIDComboBox.Items.Add("None");
            foreach (Lookup lookup in lookups)
            {
                PaymentStatusIDComboBox.Items.Add(lookup.ID);
            }
            PaymentStatusIDComboBox.SelectedIndex = 0;
        }

        private void RegistrationIDTextBox_Click(object sender, EventArgs e)
        {
            if (RegistrationIDTextBox.Text == "auto increment")
                RegistrationIDTextBox.Text = "";
            RegistrationIDTextBox.ForeColor = Color.Black;
            RegistrationIDTextBox.Font = new Font(RegistrationIDTextBox.Font, FontStyle.Regular);
        }

        private void RegistrationIDTextBox_Leave(object sender, EventArgs e)
        {
            if (RegistrationIDTextBox.Text == "")
            {
                RegistrationIDTextBox.Text = "auto increment";
                RegistrationIDTextBox.Font = new Font(RegistrationIDTextBox.Font, FontStyle.Italic);
                RegistrationIDTextBox.ForeColor = Color.Gray;
                RegistrationIDErrorLabel.Hide();
            }
            UpdateButtons();
        }

        private void RegistrationIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumeric(RegistrationIDTextBox.Text) && RegistrationIDTextBox.Text != "")
                RegistrationIDErrorLabel.Show();
            else
                RegistrationIDErrorLabel.Hide();

            UpdateButtons();
        }

        private void FeeAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!IsNumeric(FeeAmountTextBox.Text) && FeeAmountTextBox.Text != "")
            {
                FeeErrorLabel.Show();
            }
            else
            {
                FeeErrorLabel.Hide();
            }
            UpdateButtons();
        }

        private void ShowDataGrid(List<EventParticipant> eventsParticipants)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Registration ID");
            dt.Columns.Add("Event ID");
            dt.Columns.Add("Participant ID");
            dt.Columns.Add("Payment Status ID");
            dt.Columns.Add("Fee Amount");

            foreach (EventParticipant participant in eventsParticipants)
            {
                DataRow row = dt.NewRow();
                row["Registration ID"] = participant.RegistrationID;
                row["Event ID"] = participant.EventID == -1 ? "NULL" : participant.EventID.ToString();
                row["Participant ID"] = participant.ParticipantID == -1 ? "NULL" : participant.ParticipantID.ToString();
                row["Payment Status ID"] = participant.PaymentStatusID == -1 ? "NULL" : participant.PaymentStatusID.ToString();
                row["Fee Amount"] = participant.FeeAmount == -1 ? "NULL" : participant.FeeAmount.ToString();
                dt.Rows.Add(row);
            }

            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = false;
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            List<EventParticipant> participants = EventParticipantDL.GetAllEventParticipants();
            ShowDataGrid(participants);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int eventID = EventIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(EventIDComboBox.Text);
            int participantID = ParticipantIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(ParticipantIDComboBox.Text);
            int paymentStatusID = PaymentStatusIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(PaymentStatusIDComboBox.Text);
            float feeAmount = string.IsNullOrWhiteSpace(FeeAmountTextBox.Text) ? -1 : float.Parse(FeeAmountTextBox.Text);

            EventParticipant newParticipant = new EventParticipant(-1, eventID, participantID, paymentStatusID, feeAmount);
            int result = EventParticipantDL.StoreEventParticipant(newParticipant);

            if(result == 1)
            {
                SuccessLabel.Text = "Participant added successfully!";
                SuccessLabel.ForeColor = Color.Green;
            }
            else
            {
                SuccessLabel.Text = "Failed to add participant!";
                SuccessLabel.ForeColor = Color.Red;
            }
            ShowAllButton.PerformClick();
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

        private void ShowParticipantsButton_Click(object sender, EventArgs e)
        {
            List<Participant> participants = ParticipantDL.GetAllParticipants();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("ITEC ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Contact");
            dataTable.Columns.Add("Institute");
            dataTable.Columns.Add("Role ID");

            foreach (Participant participant in participants)
            {
                string ITECID = participant.ID == -1 ? "NULL" : participant.ID.ToString();
                string contact = string.IsNullOrEmpty(participant.contact) ? "NULL" : participant.contact;
                string institute = string.IsNullOrEmpty(participant.institute) ? "NULL" : participant.institute;
                string roleID = participant.roleID == -1 ? "NULL" : participant.roleID.ToString();
                dataTable.Rows.Add(participant.ID, ITECID, participant.name, participant.email, contact, institute, roleID);
            }

            DataGrid.DataSource = dataTable;
            DataGrid.Refresh();
            isOtherTable = true;
        }

        private void ShowPaymentStatusesButton_Click(object sender, EventArgs e)
        {
            List<Lookup> lookups = LookupDataLayer.GetIDsByCategory("PaymentStatus");

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

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            EventParticipant participant = EventParticipantDL.GetEventParticipantByID(int.Parse(RegistrationIDTextBox.Text));
            if (participant != null)
            {
                List<EventParticipant> parti = new List<EventParticipant>();
                parti.Add(participant);
                ShowDataGrid(parti);
            }
            else
            {
                SuccessLabel.Text = "Participant not found!";
                SuccessLabel.ForeColor = Color.Red;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int registrationID = int.Parse(RegistrationIDTextBox.Text);
            int eventID = EventIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(EventIDComboBox.Text);
            int participantID = ParticipantIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(ParticipantIDComboBox.Text);
            int paymentStatusID = PaymentStatusIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(PaymentStatusIDComboBox.Text);
            float feeAmount = string.IsNullOrWhiteSpace(FeeAmountTextBox.Text) ? -1 : float.Parse(FeeAmountTextBox.Text);

            EventParticipant updatedParticipant = new EventParticipant(registrationID, eventID, participantID, paymentStatusID, feeAmount);
            int result = EventParticipantDL.UpdateEventParticipant(updatedParticipant);

            if (result == 1)
            {
                SuccessLabel.Text = "Participant updated successfully";
                SuccessLabel.ForeColor = Color.Green;
            }
            else if(result == -1)
            {
                SuccessLabel.Text = "No evnet participation found";
                SuccessLabel.ForeColor = Color.Red;
            }
            else
            {
                SuccessLabel.Text = "Failed to update participant";
                SuccessLabel.ForeColor = Color.Red;
            }
            ShowAllButton.PerformClick();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int result = EventParticipantDL.DeleteEventParticipant(int.Parse(RegistrationIDTextBox.Text));
            if(result == 1)
            {
                SuccessLabel.ForeColor = Color.Green;
                SuccessLabel.Text = "Event Participant Deleted Successfully";
            }
            else if(result == -1)
            {
                SuccessLabel.ForeColor= Color.Red;
                SuccessLabel.Text = "No evnet participation found";
            }
            else
            {
                SuccessLabel.ForeColor = Color.Red;
                SuccessLabel.Text = "Failed to delete Event Participant";
            }
            ShowAllButton.PerformClick();
        }

        private void SearchEventID_Click(object sender, EventArgs e)
        {
            List<EventParticipant> participants = new List<EventParticipant>();
            if (EventIDComboBox.SelectedIndex == 0)
            {
                participants = EventParticipantDL.GetEventParticipantsByNullEventID();
            }
            else
            {
                participants = EventParticipantDL.GetEventParticipantsByEventID(int.Parse(EventIDComboBox.Text));
            }

            ShowDataGrid(participants);
        }

        private void SearchParticipantID_Click(object sender, EventArgs e)
        {
            List<EventParticipant> participants = new List<EventParticipant>();
            if (ParticipantIDComboBox.SelectedIndex == 0)
            {
                participants = EventParticipantDL.GetEventParticipantsByNullParticipantID();
            }
            else
            {
                participants = EventParticipantDL.GetEventParticipantsByParticipantID(int.Parse(ParticipantIDComboBox.Text));
            }
            ShowDataGrid(participants);
        }

        private void SearchPaymentStatusStatues_Click(object sender, EventArgs e)
        {
            List<EventParticipant> participants = new List<EventParticipant>();
            if (PaymentStatusIDComboBox.SelectedIndex == 0)
            {
                participants = EventParticipantDL.GetEventParticipantsByNullPaymentStatusID();
            }
            else
            {
                participants = EventParticipantDL.GetEventParticipantsByPaymentStatusID(int.Parse(PaymentStatusIDComboBox.Text));
            }
            ShowDataGrid(participants);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<EventParticipant> participants = new List<EventParticipant>();
            if (FeeAmountTextBox.Text == "")
            {
                participants = EventParticipantDL.GetEventParticipantsByNullFeeAmount();
            }
            else
            {
                participants = EventParticipantDL.GetEventParticipantsByFeeAmount(float.Parse(FeeAmountTextBox.Text));
            }
            ShowDataGrid(participants);
        }
    }
}
