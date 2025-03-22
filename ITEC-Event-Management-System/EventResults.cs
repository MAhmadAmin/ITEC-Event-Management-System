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
    public partial class EventResults : Form
    {
        bool isOtherTable = false;
        public EventResults()
        {
            InitializeComponent();
        }

        private void EventResults_Load(object sender, EventArgs e)
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
            if ((ResultIDTextBox.Text == "auto increment" || ResultIDTextBox.Text == "") && (PositionTextBox.Text == "" || IsNumeric(PositionTextBox.Text)) && (ScoreTextBox.Text == "" || IsNumeric(ScoreTextBox.Text)))
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

            if (ResultIDTextBox.Text != "" && ResultIDTextBox.Text != "auto increment" && IsNumeric(ResultIDTextBox.Text))
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

            if (ResultIDTextBox.Text != "" && ResultIDTextBox.Text != "auto increment" && IsNumeric(ResultIDTextBox.Text) && (PositionTextBox.Text == "" || IsNumeric(PositionTextBox.Text)) && (ScoreTextBox.Text == "" || IsNumeric(ScoreTextBox.Text)))
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

            List<Team> teams = TeamDL.GetAllTeams();
            TeamIDComboBox.Items.Clear();
            TeamIDComboBox.Items.Add("None");
            foreach (Team team in teams)
            {
                TeamIDComboBox.Items.Add(team.ID);
            }
            TeamIDComboBox.SelectedIndex = 0;
        }

        private void ResultIDTextBox_Click(object sender, EventArgs e)
        {
            if (ResultIDTextBox.Text == "auto increment")
                ResultIDTextBox.Text = "";
            ResultIDTextBox.ForeColor = Color.Black;
            ResultIDTextBox.Font = new Font(ResultIDTextBox.Font, FontStyle.Regular);
        }

        private void ResultIDTextBox_Leave(object sender, EventArgs e)
        {
            if (ResultIDTextBox.Text == "")
            {
                ResultIDTextBox.Text = "auto increment";
                ResultIDTextBox.Font = new Font(ResultIDTextBox.Font, FontStyle.Italic);
                ResultIDTextBox.ForeColor = Color.Gray;
                ResultIDErrorLabel.Hide();
            }
            UpdateButtons();
        }

        private void ResultIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumeric(ResultIDTextBox.Text) && ResultIDTextBox.Text != "")
                ResultIDErrorLabel.Show();
            else
                ResultIDErrorLabel.Hide();
            UpdateButtons();
        }

        private void PositionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PositionTextBox.Text) && !IsNumeric(PositionTextBox.Text))
                PositionErrorLabel.Show();
            else PositionErrorLabel.Hide();
            UpdateButtons();
        }

        private void ScoreTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ScoreTextBox.Text) && !IsNumeric(ScoreTextBox.Text))
                ScoreErrorLabel.Show();
            else ScoreErrorLabel.Hide();
            UpdateButtons();
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

        private void ShowParticipantsButton_Click(object sender, EventArgs e)
        {
            List<Participant> participants = ParticipantDL.GetAllParticipants();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Participant ID");
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

        private void ShowTeamsButton_Click(object sender, EventArgs e)
        {
            List<Team> teams = TeamDL.GetAllTeams();

            if (teams.Count > 0)
            {

                DataTable dt = new DataTable();

                dt.Columns.Add("Team ID");
                dt.Columns.Add("Event ID");
                dt.Columns.Add("Name");
                foreach (Team team in teams)
                {
                    string eventID = team.EventID == -1 ? "NULL" : team.EventID.ToString();
                    dt.Rows.Add(team.ID, eventID, team.Name);
                }
                DataGrid.DataSource = dt;
                DataGrid.Refresh();
                isOtherTable = true;
            }
            else
            {
                SuccessLabel.Text = "No teams found";
                SuccessLabel.ForeColor = Color.Red;
            }
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            List<EventResult> results = EventResultDL.GetAllEventResults();

            ShowDataGrid(results);
        }

        private void ShowDataGrid(List<EventResult> results)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Result ID");
            dt.Columns.Add("Event ID");
            dt.Columns.Add("Participant ID");
            dt.Columns.Add("Team ID");
            dt.Columns.Add("Position");
            dt.Columns.Add("Score");
            dt.Columns.Add("Remarks");

            foreach (EventResult result in results)
            {
                string eventID = result.EventID == -1 ? "NULL" : result.EventID.ToString();
                string participantID = result.ParticipantID == -1 ? "NULL" : result.ParticipantID.ToString();
                string teamID = result.TeamID == -1 ? "NULL" : result.TeamID.ToString();
                string position = result.Position == -1 ? "NULL" : result.Position.ToString();
                string score = result.Score == -1 ? "NULL" : result.Score.ToString();
                string remarks = string.IsNullOrEmpty(result.Remarks) ? "NULL" : result.Remarks;

                dt.Rows.Add(result.ResultID, eventID, participantID, teamID, position, score, remarks);
            }

            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int eventID = EventIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(EventIDComboBox.Text);
            int participantID = ParticipantIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(ParticipantIDComboBox.Text);
            int teamID = TeamIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(TeamIDComboBox.Text);
            int position = string.IsNullOrWhiteSpace(PositionTextBox.Text) ? -1 : int.Parse(PositionTextBox.Text);
            float score = string.IsNullOrWhiteSpace(ScoreTextBox.Text) ? -1 : float.Parse(ScoreTextBox.Text);
            string remarks = RemarksTextBox.Text;

            EventResult newResult = new EventResult(-1, eventID, participantID, teamID, position, score, remarks);
            int isAdded = EventResultDL.StoreEventResult(newResult);

            if (isAdded == 1)
            {
                SuccessLabel.Text = "Result added successfully";
                SuccessLabel.ForeColor = Color.Green;
                ShowAllButton.PerformClick();
            }
            else
            {
                SuccessLabel.Text = "Failed to add result";
                SuccessLabel.ForeColor = Color.Red;
            }
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            List<EventResult> results = new List<EventResult>();

            EventResult r = EventResultDL.GetEventResultByID(int.Parse(ResultIDTextBox.Text));
            if (r != null)
            {
                results.Add(r);
                ShowDataGrid(results);
            }
            else
            {
                SuccessLabel.Text = "No Event Result Found";
                SuccessLabel.ForeColor = Color.Red;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int resultID = int.Parse(ResultIDTextBox.Text);
            int isDeleted = EventResultDL.DeleteEventResult(resultID);

            if (isDeleted == 1)
            {
                SuccessLabel.Text = "Result deleted successfully";
                SuccessLabel.ForeColor = Color.Green;
                ShowAllButton.PerformClick();
            }
            else
            {
                SuccessLabel.Text = "Failed to delete result";
                SuccessLabel.ForeColor = Color.Red;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int resultID = int.Parse(ResultIDTextBox.Text);
            int eventID = EventIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(EventIDComboBox.Text);
            int participantID = ParticipantIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(ParticipantIDComboBox.Text);
            int teamID = TeamIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(TeamIDComboBox.Text);
            int position = string.IsNullOrWhiteSpace(PositionTextBox.Text) ? -1 : int.Parse(PositionTextBox.Text);
            float score = string.IsNullOrWhiteSpace(ScoreTextBox.Text) ? -1 : float.Parse(ScoreTextBox.Text);
            string remarks = RemarksTextBox.Text;

            EventResult updatedResult = new EventResult(resultID, eventID, participantID, teamID, position, score, remarks);
            int isUpdated = EventResultDL.UpdateEventResult(updatedResult);

            if (isUpdated == 1)
            {
                SuccessLabel.Text = "Result updated successfully";
                SuccessLabel.ForeColor = Color.Green;
                ShowAllButton.PerformClick();
            }
            else
            {
                SuccessLabel.Text = "Failed to update result";
                SuccessLabel.ForeColor = Color.Red;
            }
        }

        private void SearchEventID_Click(object sender, EventArgs e)
        {
            if (EventIDComboBox.SelectedIndex != 0)
            {
                List<EventResult> resultList = EventResultDL.GetEventResultsByEventID(int.Parse(EventIDComboBox.Text));
                ShowDataGrid(resultList);
            }
            else
            {
                List<EventResult> resultList = EventResultDL.GetEventResultsByNullEventID();
                ShowDataGrid(resultList);
            }
        }

        private void SearchParticipantID_Click(object sender, EventArgs e)
        {
            if (ParticipantIDComboBox.SelectedIndex != 0)
            {
                List<EventResult> resultList = EventResultDL.GetEventResultsByParticipantID(int.Parse(ParticipantIDComboBox.Text));
                ShowDataGrid(resultList);
            }
            else
            {
                List<EventResult> resultList = EventResultDL.GetEventResultsByNullParticipantID();
                ShowDataGrid(resultList);
            }
        }

        private void SearchTeamID_Click(object sender, EventArgs e)
        {
            if (TeamIDComboBox.SelectedIndex != 0)
            {
                List<EventResult> resultList = EventResultDL.GetEventResultsByTeamID(int.Parse(TeamIDComboBox.Text));
                ShowDataGrid(resultList);
            }
            else
            {
                List<EventResult> resultList = EventResultDL.GetEventResultsByNullTeamID();
                ShowDataGrid(resultList);
            }
        }

        private void SearchFeeAmount_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PositionTextBox.Text))
            {
                List<EventResult> resultList = EventResultDL.GetEventResultsByPosition(int.Parse(PositionTextBox.Text));
                ShowDataGrid(resultList);
            }
            else
            {
                List<EventResult> resultList = EventResultDL.GetEventResultsByNullPosition();
                ShowDataGrid(resultList);
            }
        }

        private void SearchScore_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ScoreTextBox.Text))
            {
                List<EventResult> resultList = EventResultDL.GetEventResultsByScore(float.Parse(ScoreTextBox.Text));
                ShowDataGrid(resultList);
            }
            else
            {
                List<EventResult> resultList = EventResultDL.GetEventResultsByNullScore();
                ShowDataGrid(resultList);
            }
        }

        private void SearchRemarks_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(RemarksTextBox.Text))
            {
                List<EventResult> resultList = EventResultDL.GetEventResultsByRemarks(RemarksTextBox.Text);
                ShowDataGrid(resultList);
            }
            else
            {
                List<EventResult> resultList = EventResultDL.GetEventResultsByNullRemarks();
                ShowDataGrid(resultList);
            }
        }
    }
}