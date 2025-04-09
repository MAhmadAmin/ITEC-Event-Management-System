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

namespace ITEC_Event_Management_System.Reports
{
    public partial class ParticipantsForm : Form
    {
        public ParticipantsForm()
        {
            InitializeComponent();
        }

        private void ParticipantsForm_Load(object sender, EventArgs e)
        {
            UpdateButtons();
            LoadComboBoxes();
            //this.reportViewer2.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ParticipantClass> participants = new List<ParticipantClass>()
                {
                    new ParticipantClass() { ID = 1, name = "Ahmad", email = "ahmadamin1005@gmail.com"}
                };

            this.participantClassBindingSource1.DataSource = participants;

            this.reportViewer1.RefreshReport();
        }

        
        private void UpdateButtons()
        {
            if ((radioButton1.Checked && ITECIDComboBox.SelectedIndex != 0) || (radioButton2.Checked && RoleIDComboBox.SelectedIndex != 0) || (radioButton3.Checked && EventIDComboBox.SelectedIndex != 0))
            {
                RetrieveButton.Enabled = true;
                RetrieveButton.BackColor = Color.Peru;
            }
            else
            {
                RetrieveButton.Enabled = false;
                RetrieveButton.BackColor = Color.Gray;
            }
        }

        private void LoadComboBoxes()
        {
            List<ITECEdition> editions = ITECEditionsDL.GetAllEditions();
            ITECIDComboBox.Items.Add("None");
            foreach (ITECEdition edition in editions)
            {
                ITECIDComboBox.Items.Add(edition.ID);
            }
            ITECIDComboBox.SelectedIndex = 0;

            List<Event> events = EventDL.GetAllEvents();
            EventIDComboBox.Items.Add("None");
            foreach (Event evn in events)
            {
                EventIDComboBox.Items.Add(evn.ID);
            }
            EventIDComboBox.SelectedIndex = 0;

            //List<Lookup> lookups = LookupDataLayer.GetIDsByCategory("ParticipantRoles");
            ////RoleIDComboBox.Items.Add("None");
            //foreach (Lookup lookup in lookups)
            //{
            //    RoleIDComboBox.Items.Add(lookup.ID);
            //}
            ////RoleIDComboBox.SelectedIndex = 0;

            RoleIDComboBox.Items.Clear();
            RoleIDComboBox.Items.Add("None");
            string query = "SELECT * FROM Roles";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                RoleIDComboBox.Items.Add(reader.GetInt16("role_id"));
            }
            RoleIDComboBox.SelectedIndex = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                ITECIDLabel.Enabled = true;
                ITECIDComboBox.Enabled = true;
            }
            else
            {
                ITECIDLabel.Enabled =false;
                ITECIDComboBox.Enabled=false;
            }
            UpdateButtons();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                RoleIDComboBox.Enabled = true;
                RoleIDLabel.Enabled = true;
            }
            else
            {
                RoleIDLabel.Enabled = false;
                RoleIDComboBox.Enabled = false;
            }
            UpdateButtons();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked)
            {
                EventIDComboBox.Enabled = true;
                EventIDLabel.Enabled=true;
            }
            else
            {
                EventIDLabel.Enabled=false;
                EventIDComboBox.Enabled=false;
            }
            UpdateButtons();
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            UpdateButtons();
            if (radioButton1.Checked && ITECIDComboBox.SelectedIndex != 0)
            {
                List<ParticipantClass> participants = ParticipantsReportDL.GetByITECID(int.Parse(ITECIDComboBox.Text));

                this.participantClassBindingSource1.DataSource = participants;

                this.reportViewer1.RefreshReport();
            }

            else if (radioButton2.Checked && RoleIDComboBox.SelectedIndex != 0)
            {
                List<ParticipantClass> participants = ParticipantsReportDL.GetByRoleID(int.Parse(RoleIDComboBox.Text));

                this.participantClassBindingSource1.DataSource = participants;

                this.reportViewer1.RefreshReport();
            }
            else if (radioButton3.Checked && EventIDComboBox.SelectedIndex != 0)
            {
                List<ParticipantClass> participants = ParticipantsReportDL.GetByEventID(int.Parse(EventIDComboBox.Text));

                this.participantClassBindingSource1.DataSource = participants;

                this.reportViewer1.RefreshReport();
            }
        }

        private void ITECIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void RoleIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void EventIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }
    }
}
