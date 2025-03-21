using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITEC_Event_Management_System.DL;
using ITEC_Event_Management_System.BL;

namespace ITEC_Event_Management_System
{
    public partial class TeamsAndParticipants : Form
    {
        bool isOtherTable1 = false;
        bool isOtherTable2 = false;

        public TeamsAndParticipants()
        {
            InitializeComponent();
        }

        private void TeamsAndParticipants_Load(object sender, EventArgs e)
        {
            UpdateTeamsButtons();
            UpdateParticipantsButtons();
            UpdateTeamsComboBoxes();
            UpdateParticipantsComboBoxes();
        }
        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        private void UpdateTeamsButtons()
        {
            TeamSuccessLabel.Text = "None";
            TeamSuccessLabel.ForeColor = Color.Green;

            if ((TeamIDTextBox.Text == "auto increment" || TeamIDTextBox.Text == "") && !string.IsNullOrEmpty(TeamNameTextBox.Text))
            {
                TeamAddButton.Enabled = true;
                TeamAddButton.ForeColor = Color.White;
                TeamAddButton.BackColor = Color.ForestGreen;
            }
            else
            {

                TeamAddButton.Enabled = false;
                TeamAddButton.BackColor = Color.Gray;
            }

            if (TeamIDTextBox.Text != "" && TeamIDTextBox.Text != "auto increment" && IsNumeric(TeamIDTextBox.Text))
            {
                TeamDeleteButton.Enabled = true;
                TeamDeleteButton.ForeColor = Color.White;
                TeamDeleteButton.BackColor = Color.Brown;

                TeamRetrieveButton.Enabled = true;
                TeamRetrieveButton.BackColor = Color.Peru;
            }
            else
            {
                TeamDeleteButton.Enabled = false;
                TeamDeleteButton.BackColor = Color.Gray;

                TeamRetrieveButton.Enabled = false;
                TeamRetrieveButton.BackColor = Color.Gray;
            }



            if (TeamIDTextBox.Text != "" && TeamIDTextBox.Text != "auto increment" && IsNumeric(TeamIDTextBox.Text))
            {
                TeamUpdateButton.Enabled = true;
                TeamUpdateButton.BackColor = Color.RoyalBlue;
            }
            else
            {
                TeamUpdateButton.Enabled = false;
                TeamUpdateButton.BackColor = Color.Gray;
            }
        }

        private void UpdateParticipantsButtons()
        {
            if(TeamIDComboBox.SelectedIndex != 0 && ParticipantIDComboBox.SelectedIndex != 0)
            {
                ParticipantAddButton.Enabled = true;
                ParticipantAddButton.ForeColor = Color.White;
                ParticipantAddButton.BackColor = Color.ForestGreen;

                ParticipantDeleteButton.Enabled = true;
                ParticipantDeleteButton.ForeColor = Color.White;
                ParticipantDeleteButton.BackColor = Color.Brown;

                ParticipantRetrieveButton.Enabled = true;
                ParticipantRetrieveButton.BackColor = Color.Peru;
            }

            else
            {
                ParticipantAddButton.Enabled = false;
                ParticipantAddButton.BackColor = Color.Gray;
                ParticipantDeleteButton.Enabled = false;
                ParticipantDeleteButton.BackColor = Color.Gray;
                ParticipantRetrieveButton.Enabled = false;
                ParticipantRetrieveButton.BackColor = Color.Gray;
            }
        }

        private void UpdateTeamsComboBoxes()
        {
            List<Event> events = EventDL.GetAllEvents();
            EventIDComboBox.Items.Clear();
            EventIDComboBox.Items.Add("None");
            foreach (Event ev in events)
            {
                EventIDComboBox.Items.Add(ev.ID);
            }
            EventIDComboBox.SelectedIndex = 0;
        }

        private void UpdateParticipantsComboBoxes()
        {
            List<Team> teams = TeamDL.GetAllTeams();
            TeamIDComboBox.Items.Clear();
            TeamIDComboBox.Items.Add("None");
            foreach (Team team in teams)
            {
                TeamIDComboBox.Items.Add(team.ID);
            }
            TeamIDComboBox.SelectedIndex = 0;

            List<Participant> participants = ParticipantDL.GetAllParticipants();
            ParticipantIDComboBox.Items.Clear();
            ParticipantIDComboBox.Items.Add("None");
            foreach(Participant participant in participants)
            {
                ParticipantIDComboBox.Items.Add(participant.ID);
            }
            ParticipantIDComboBox.SelectedIndex = 0;
        }

        private void TeamIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateParticipantsButtons();
        }

        private void ParticipantIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateParticipantsButtons();
        }

        private void TeamIDTextBox_Click(object sender, EventArgs e)
        {

            if (TeamIDTextBox.Text == "auto increment")
                TeamIDTextBox.Text = "";
            TeamIDTextBox.ForeColor = Color.Black;
            TeamIDTextBox.Font = new Font(TeamIDTextBox.Font, FontStyle.Regular);
        }

        private void TeamIDTextBox_Leave(object sender, EventArgs e)
        {
            if (TeamIDTextBox.Text == "")

            {
                TeamIDTextBox.Text = "auto increment";

                TeamIDTextBox.Font = new Font(TeamIDTextBox.Font, FontStyle.Italic);
                TeamIDTextBox.ForeColor = Color.Gray;
                TeamIDErrorLabel.Hide();
            }
            UpdateTeamsButtons();
        }

        private void TeamIDTextBox_TextChanged(object sender, EventArgs e)
        {

            if (!IsNumeric(TeamIDTextBox.Text) && TeamIDTextBox.Text != "")
            {
                TeamIDErrorLabel.Show();
            }
            else
            {
                TeamIDErrorLabel.Hide();
            }

            UpdateTeamsButtons();
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

            TeamsDataGrid.DataSource = dt;
            TeamsDataGrid.Refresh();
            isOtherTable1 = true;
        }

        private void TeamNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTeamsButtons();
        }

        private void TeamAddButton_Click(object sender, EventArgs e)
        {
            int eventID = EventIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(EventIDComboBox.SelectedItem.ToString());
            Team team = new Team(-1, eventID, TeamNameTextBox.Text);
            int result = TeamDL.StoreTeam(team);
            if (result == 1)
            {
                TeamSuccessLabel.Text = "Success";
                TeamSuccessLabel.ForeColor = Color.Green;
                //RetrieveAt(int.Parse(TeamIDTextBox.Text));
                TeamShowAllButton.PerformClick();

                TeamIDTextBox.Text = "";
                TeamNameTextBox.Text = "";
                EventIDComboBox.SelectedIndex = 0;

                UpdateParticipantsComboBoxes();
            }
            else
            {
                TeamSuccessLabel.Text = "Failed";
                TeamSuccessLabel.ForeColor = Color.Red;
            }
        }

        private void RetrieveAt(int ID)
        {
            Team team = TeamDL.GetTeamByID(ID);
            if (team != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Event ID");
                dt.Columns.Add("Name");


                string eventID = team.EventID == -1 ? "NULL" : team.EventID.ToString();

                dt.Rows.Add(team.ID, eventID, team.Name);

                TeamsDataGrid.DataSource = dt;
                TeamsDataGrid.Refresh();
                isOtherTable1 = false;
            }
        }

        private void TeamShowAllButton_Click(object sender, EventArgs e)
        {
            List<Team> teams = TeamDL.GetAllTeams();

            if (teams.Count > 0)
            {

                DataTable dt = new DataTable();

                dt.Columns.Add("ID");
                dt.Columns.Add("Event ID");
                dt.Columns.Add("Name");
                foreach (Team team in teams)
                {
                    string eventID = team.EventID == -1 ? "NULL" : team.EventID.ToString();
                    dt.Rows.Add(team.ID, eventID, team.Name);
                }
                TeamsDataGrid.DataSource = dt;
                TeamsDataGrid.Refresh();
                isOtherTable1 = false;
            }
            else
            {
                TeamSuccessLabel.Text = "No teams found";
                TeamSuccessLabel.ForeColor = Color.Red;
            }
        }

        private void TeamRetrieveButton_Click(object sender, EventArgs e)
        {
            RetrieveAt(int.Parse(TeamIDTextBox.Text));
        }

        private void TeamDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Are you sure you want to delete this team?", "Delete Team", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                int result = TeamDL.DeleteTeam(int.Parse(TeamIDTextBox.Text));
                if (result == 1)
                {
                    TeamSuccessLabel.Text = "Success";
                    TeamSuccessLabel.ForeColor = Color.Green;
                    TeamShowAllButton.PerformClick();

                    UpdateParticipantsComboBoxes();

                }
                else
                {
                    TeamSuccessLabel.Text = "Failed";
                    TeamSuccessLabel.ForeColor = Color.Red;
                }
            }
        }

        private void TeamUpdateButton_Click(object sender, EventArgs e)
        {
            int eventID = EventIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(EventIDComboBox.SelectedItem.ToString());
            Team team = new Team(int.Parse(TeamIDTextBox.Text), eventID, TeamNameTextBox.Text);
            int result = TeamDL.UpdateTeam(team);
            if (result == 1)
            {
                TeamSuccessLabel.Text = "Success";
                TeamSuccessLabel.ForeColor = Color.Green;
                TeamShowAllButton.PerformClick();
            }
            else
            {
                TeamSuccessLabel.Text = "Failed";
                TeamSuccessLabel.ForeColor = Color.Red;
            }
        }

        private void TeamsDataGrid_DoubleClick(object sender, EventArgs e)
        {
            if(!isOtherTable1)
            {
                TeamIDTextBox.Text = TeamsDataGrid.CurrentRow.Cells[0].Value.ToString();
                TeamNameTextBox.Text = TeamsDataGrid.CurrentRow.Cells[2].Value.ToString();
                EventIDComboBox.Text = TeamsDataGrid.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void ShowTeamsButton_Click(object sender, EventArgs e)
        {
            List<Team> teams = TeamDL.GetAllTeams();

            if (teams.Count > 0)
            {

                DataTable dt = new DataTable();

                dt.Columns.Add("ID");
                dt.Columns.Add("Event ID");
                dt.Columns.Add("Name");
                foreach (Team team in teams)
                {
                    string eventID = team.EventID == -1 ? "NULL" : team.EventID.ToString();
                    dt.Rows.Add(team.ID, eventID, team.Name);
                }
                ParticipantsDataGrid.DataSource = dt;
                ParticipantsDataGrid.Refresh();
                isOtherTable2 = true;
            }
            else
            {
                ParticipantSuccessLabel.Text = "No teams found";
                ParticipantSuccessLabel.ForeColor = Color.Red;
            }

        }

        private void SearchTeamName_Click(object sender, EventArgs e)
        {
            List<Team> teams = TeamDL.GetTeamsByNameLike(TeamNameTextBox.Text);

                DataTable dt = new DataTable();

                dt.Columns.Add("ID");
                dt.Columns.Add("Event ID");
                dt.Columns.Add("Name");
                foreach (Team team in teams)
                {
                    string eventID = team.EventID == -1 ? "NULL" : team.EventID.ToString();
                    dt.Rows.Add(team.ID, eventID, team.Name);
                }
                TeamsDataGrid.DataSource = dt;
                TeamsDataGrid.Refresh();
                isOtherTable1 = false;
        }

        private void SearchEventID_Click(object sender, EventArgs e)
        {
            List<Team> teams = new List<Team>();
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Event ID");
            dt.Columns.Add("Name");

            if (EventIDComboBox.SelectedIndex == 0)
            {
                teams = TeamDL.GetTeamsByEventIDNull();
            }
            else
            {
                teams = TeamDL.GetTeamsByEventID(EventIDComboBox.SelectedIndex);
            }
            
            foreach (Team team in teams)
            {
                string eventID = team.EventID == -1 ? "NULL" : team.EventID.ToString();
                dt.Rows.Add(team.ID, eventID, team.Name);
            }
            TeamsDataGrid.DataSource = dt;
            TeamsDataGrid.Refresh();
            isOtherTable1 = false;
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

            ParticipantsDataGrid.DataSource = dataTable;
            ParticipantsDataGrid.Refresh();
            isOtherTable2 = true;
        }

        private void ParticipantShowAllButton_Click(object sender, EventArgs e)
        {
            List<TeamParticipant> teamParticipants = TeamParticipantDL.GetAllTeamParticipants();

            DataTable dt = new DataTable();
            dt.Columns.Add("Team ID");
            dt.Columns.Add("Participant ID");

            foreach(TeamParticipant participant in teamParticipants)
            {
                dt.Rows.Add(participant.TeamID, participant.ParticipantID);
            }

            ParticipantsDataGrid.DataSource = dt;
            ParticipantsDataGrid.Refresh();
            isOtherTable2 = false;
        }

        private void ParticipantAddButton_Click(object sender, EventArgs e)
        {
            int result = TeamParticipantDL.StoreTeamParticipant(new TeamParticipant(int.Parse(TeamIDComboBox.Text), int.Parse(ParticipantIDComboBox.Text)));

            if(result == 1)
            {
                ParticipantSuccessLabel.Text = "Participant Added to Team";
                ParticipantSuccessLabel.ForeColor = Color.Green;
                ParticipantShowAllButton.PerformClick();
            }
            else if(result == -1)
            {
                ParticipantSuccessLabel.Text = "Participant Already exists in Team";
                ParticipantSuccessLabel.ForeColor = Color.Red;
                MessageBox.Show("Participant already exists in Team", "Already Exists", MessageBoxButtons.OK);
            }
            else
            {
                ParticipantSuccessLabel.Text = "Failed to Add Particpant to Team";
                ParticipantSuccessLabel.ForeColor = Color.Red;
            }
        }

        private void ParticipantRetrieveButton_Click(object sender, EventArgs e)
        {
            TeamParticipant teamParticipant = TeamParticipantDL.GetTeamParticipant(new TeamParticipant(int.Parse(TeamIDComboBox.Text), int.Parse(ParticipantIDComboBox.Text)));

            DataTable dt = new DataTable();
            dt.Columns.Add("Team ID");
            dt.Columns.Add("Participant ID");

            if(teamParticipant != null)
                dt.Rows.Add(teamParticipant.TeamID, teamParticipant.ParticipantID);

            ParticipantsDataGrid.DataSource = dt;
            ParticipantsDataGrid.Refresh();
            isOtherTable2 = false;
        }

        private void SearchTeamID_Click(object sender, EventArgs e)
        {
            List<TeamParticipant> teamParticipants = new List<TeamParticipant>();
            DataTable dt = new DataTable();
            dt.Columns.Add("Team ID");
            dt.Columns.Add("Participant ID");

            if (TeamIDComboBox.SelectedIndex == 0)
                teamParticipants = TeamParticipantDL.GetTeamParticipantsByNullTeamID();
            else
                teamParticipants = TeamParticipantDL.GetTeamParticipantsByTeamID(int.Parse(TeamIDComboBox.Text));

            foreach (TeamParticipant participant in teamParticipants)
            {
                dt.Rows.Add(participant.TeamID, participant.ParticipantID);
            }

            ParticipantsDataGrid.DataSource = dt;
            ParticipantsDataGrid.Refresh();
            isOtherTable2 = false;
        }

        private void SearchParticipant_Click(object sender, EventArgs e)
        {
            List<TeamParticipant> teamParticipants = new List<TeamParticipant>();
            DataTable dt = new DataTable();
            dt.Columns.Add("Team ID");
            dt.Columns.Add("Participant ID");

            if (ParticipantIDComboBox.SelectedIndex == 0)
                teamParticipants = TeamParticipantDL.GetTeamParticipantsByNullParticipantID();
            else
                teamParticipants = TeamParticipantDL.GetTeamParticipantsByParticipantID(int.Parse(ParticipantIDComboBox.Text));

            foreach (TeamParticipant participant in teamParticipants)
            {
                dt.Rows.Add(participant.TeamID, participant.ParticipantID);
            }

            ParticipantsDataGrid.DataSource = dt;
            ParticipantsDataGrid.Refresh();
            isOtherTable2 = false;
        }

        private void ParticipantDeleteButton_Click(object sender, EventArgs e)
        {
            int result = TeamParticipantDL.DeleteParticipant(new TeamParticipant(int.Parse(TeamIDComboBox.Text), int.Parse(ParticipantIDComboBox.Text)));
            if(result == 1)
            {
                ParticipantSuccessLabel.Text = "Participant Deleted from Team Successfully";
                ParticipantSuccessLabel.ForeColor = Color.Green;
                ParticipantShowAllButton.PerformClick();
            }
            else if(result == -1)
            {
                ParticipantSuccessLabel.Text = "This participant does not exists in team";
                ParticipantSuccessLabel.ForeColor = Color.Red;
                MessageBox.Show($"{ParticipantIDComboBox.Text} participant does not exists in {TeamIDComboBox.Text} Team", "Failed Attempt to Delete", MessageBoxButtons.OK);
            }
            else
            {
                ParticipantSuccessLabel.Text = "Failed to delte participant";
                ParticipantSuccessLabel.ForeColor = Color.Red;
            }
        }

        private void ParticipantsDataGrid_DoubleClick(object sender, EventArgs e)
        {
            if(!isOtherTable2)
            {
                TeamIDComboBox.Text = ParticipantsDataGrid.CurrentRow.Cells[0].Value.ToString();
                ParticipantIDComboBox.Text = ParticipantsDataGrid.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
