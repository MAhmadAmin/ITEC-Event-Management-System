using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITEC_Event_Management_System.Reports;

namespace ITEC_Event_Management_System
{
    public partial class AdminDashboard : Form
    {
        Color nonActiveColor = Color.Indigo;
        Color ActiveColor = Color.Purple;
        
        

        public AdminDashboard(string username)
        {
            InitializeComponent();
            HowdyLabel.Text = $"Howdy, {username}!";
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            //LoadForm(new ReportsPanel());
            //ShowActive(ReportsButton);
        }

        private void UpdateButtons()
        {
            var buttons = new List<Button> {ITECEditionsButton, EventsButton, VenuesButton, ParticipantsButton, CommitteeAndMembersButton, SponsorsButton, EventCategoriesButton, VenueAllocationButton, TeamsAndParticipantsButton, DutiesButton, EventParticipantsButton, EventResultsButton, FinancesButton, ReportsButton};
            foreach (var button in buttons)
            {
                button.BackColor = nonActiveColor;
            }
        }

        private void ShowActive (Button button)
        {
            UpdateButtons();
            button.BackColor = ActiveColor;
        }

        private void LoadForm(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form fh = Form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(fh);
            this.MainPanel.Tag = fh;
            fh.Show();
        }

        private void ITECEditionsButton_Click(object sender, EventArgs e)
        {
            ShowActive(ITECEditionsButton);
            LoadForm(new ITECEditions());
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void EventsButton_Click(object sender, EventArgs e)
        {
            ShowActive(EventsButton);
            LoadForm(new Events());
        }

        private void VenuesButton_Click(object sender, EventArgs e)
        {
            ShowActive(VenuesButton);
            LoadForm(new Venues());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowActive(ParticipantsButton);
            LoadForm(new Participants());

        }

        private void CommitteeAndMembersButton_Click(object sender, EventArgs e)
        {

            ShowActive(CommitteeAndMembersButton);
            LoadForm(new CommitteesAndMembers());
        }

        private void SponsorsButton_Click(object sender, EventArgs e)
        {
            ShowActive(SponsorsButton);
            LoadForm(new Sponsors());
        }

        private void EventCategoriesButton_Click(object sender, EventArgs e)
        {
            ShowActive(EventCategoriesButton);
            LoadForm(new EventCategories());
        }

        private void VenueAllocationButton_Click(object sender, EventArgs e)
        {
            ShowActive(VenueAllocationButton);
            LoadForm(new VenueAllocations());
        }

        private void TeamsAndParticipantsButton_Click(object sender, EventArgs e)
        {
            ShowActive(TeamsAndParticipantsButton);
            LoadForm(new TeamsAndParticipants());
        }

        private void DutiesButton_Click(object sender, EventArgs e)
        {
            ShowActive(DutiesButton);
            LoadForm(new Duties());
        }

        private void EventParticipantsButton_Click(object sender, EventArgs e)
        {
            ShowActive(EventParticipantsButton);
            LoadForm(new EventParticipants());
        }

        private void EventResultsButton_Click(object sender, EventArgs e)
        {
            ShowActive(EventResultsButton);
            LoadForm(new EventResults());
        }

        private void FinancesButton_Click(object sender, EventArgs e)
        {
            ShowActive(FinancesButton);
            LoadForm(new Finances());
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            ShowActive(ReportsButton);
            LoadForm(new ReportsPanel());
        }
    }
}
