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
    public partial class CommitteeAssignmentReportForm : Form
    {
        bool toogleShowCommittees =  false;
        public CommitteeAssignmentReportForm()
        {
            InitializeComponent();
        }

        private void CommitteeAssignmentReportForm_Load(object sender, EventArgs e)
        {
            List<Committee> committees = CommitteeDL.GetAllCommittees();
            CommitteeIDComboBox.Items.Add("None");
            foreach (Committee committee in committees)
            {
                CommitteeIDComboBox.Items.Add(committee.ID);
            }
            CommitteeIDComboBox.SelectedIndex = 0;
            this.reportViewer1.RefreshReport();
        }

        private void ShowCommitteesButton_Click(object sender, EventArgs e)
        {
            if (!toogleShowCommittees)
            {
                reportViewer1.Hide();
                DataGrid.Show();
                ShowCommitteesButton.Text = "Hide Committees";
                toogleShowCommittees = true;

                List<Committee> AllCommittees = CommitteeDL.GetAllCommittees();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("ITEC ID");
                dt.Columns.Add("Name");

                foreach (var committee in AllCommittees)
                {
                    DataRow row = dt.NewRow();
                    row["ID"] = committee.ID;
                    row["ITEC ID"] = committee.ITECID == -1 ? "NULL" : committee.ITECID.ToString();
                    row["Name"] = committee.Name;
                    dt.Rows.Add(row);
                }

                DataGrid.DataSource = dt;
                DataGrid.Refresh();
            }
            else
            {
                reportViewer1.Show();
                DataGrid.Hide();
                ShowCommitteesButton.Text = "Show Committees";
                toogleShowCommittees = false;
            }
        
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            if (CommitteeIDComboBox.SelectedIndex != 0)
            {
                List <CommitteeAssignmentDataClass> assignmetns = CommitteeAssignmentDL.GetDuties(int.Parse(CommitteeIDComboBox.Text));
                this.committeeAssignmentDataClassBindingSource1.DataSource = assignmetns;
                this.committeeAssignmentDataClassBindingSource.DataSource = assignmetns;
                reportViewer1.RefreshReport();
            }

        }
    }
}
