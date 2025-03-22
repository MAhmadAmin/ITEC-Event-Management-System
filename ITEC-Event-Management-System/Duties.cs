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
    public partial class Duties : Form
    {
        bool isOtherTable = false;
        public Duties()
        {
            InitializeComponent();
        }

        private void Duties_Load(object sender, EventArgs e)
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
            if ((IDTextBox.Text == "auto increment" || IDTextBox.Text == "") && AssignedToComboBox.SelectedIndex !=0)
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

            if (IDTextBox.Text != "" && IDTextBox.Text != "auto increment" && IsNumeric(IDTextBox.Text) && AssignedToComboBox.SelectedIndex != 0)
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
            List<Committee> committees = CommitteeDL.GetAllCommittees();
            CommitteeIDComboBox.Items.Add("None");
            foreach (Committee committee in committees)
            {
                CommitteeIDComboBox.Items.Add(committee.ID);
            }
            CommitteeIDComboBox.SelectedIndex = 0;

            List<Lookup> lookups = LookupDataLayer.GetIDsByCategory("CommitteeRoles");
            AssignedToComboBox.Items.Add("None");
            foreach (Lookup lookup in lookups)
            {
                AssignedToComboBox.Items.Add(lookup.value);
            }
            AssignedToComboBox.SelectedIndex = 0;

            List<Lookup> lookups2 = LookupDataLayer.GetIDsByCategory("DutyStatus");
            StatusIDComboBox.Items.Add("None");
            foreach (Lookup lookup in lookups2)
            {
                StatusIDComboBox.Items.Add(lookup.ID);
            }
            StatusIDComboBox.SelectedIndex = 0;
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

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumeric(IDTextBox.Text) && IDTextBox.Text != "")
                IDErrorLabel.Show();
            else
                IDErrorLabel.Hide();

            UpdateButtons();
        }

        private void AssignedToComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void ShowCommitteesButton_Click(object sender, EventArgs e)
        {
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

            isOtherTable = true;
        }

        private void ShowRolesButton_Click(object sender, EventArgs e)
        {
            List<Lookup> lookups = LookupDataLayer.GetIDsByCategory("CommitteeRoles");

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

        private void ShowStatusesButton_Click(object sender, EventArgs e)
        {
            List<Lookup> lookups = LookupDataLayer.GetIDsByCategory("DutyStatus");

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
            List <Duty> duties = DutyDL.GetAllDuties();

            ShowDutiesData(duties);
        }

        private void ShowDutiesData(List<Duty> duties)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Duty ID");
            dt.Columns.Add("Committee ID");
            dt.Columns.Add("Assigned To");
            dt.Columns.Add("Task Description");
            dt.Columns.Add("Deadline");
            dt.Columns.Add("Status ID");

            foreach(Duty d in duties)
            {
                string committeeID = d.CommitteeID == -1 ? "NULL" : d.CommitteeID.ToString();
                string taskDescription = d.TaskDescription == null ? "NULL" : d.TaskDescription.ToString();
                string statusID = d.StatusID == -1 ? "NULL" : d.StatusID.ToString();
                string deadline = d.Deadline.ToShortDateString();
                dt.Rows.Add(d.ID, committeeID, d.AssignedTo, taskDescription, deadline, statusID);
            }
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int committeeID = CommitteeIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(CommitteeIDComboBox.Text);
            string taskDescription = string.IsNullOrWhiteSpace(DescriptionTextBox.Text ) ? null : DescriptionTextBox.Text;
            int statusID = StatusIDComboBox.SelectedIndex == 0 ? -1 : int.Parse (StatusIDComboBox.Text);

            int result = DutyDL.StoreDuty(new Duty(-1, committeeID, AssignedToComboBox.Text.ToString(), taskDescription, DeadlinePicker.Value, statusID));
            
            if (result == 1)
            {
                SuccessLabel.ForeColor = Color.Green;
                SuccessLabel.Text = "Duty Added Successfully";
                ShowAllButton.PerformClick();
            }
            else
            {
                SuccessLabel.ForeColor = Color.Red;
                SuccessLabel.Text = "Failed to Add Duty";
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int dutyID = int.Parse(IDTextBox.Text);
            int committeeID = CommitteeIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(CommitteeIDComboBox.Text);
            string taskDescription = string.IsNullOrWhiteSpace(DescriptionTextBox.Text) ? null : DescriptionTextBox.Text;
            int statusID = StatusIDComboBox.SelectedIndex == 0 ? -1 : int.Parse(StatusIDComboBox.Text);

            Duty updatedDuty = new Duty(dutyID, committeeID, AssignedToComboBox.Text.ToString(), taskDescription, DeadlinePicker.Value, statusID);
            int result = DutyDL.UpdateDuty(updatedDuty);

            if (result == 1)
            {
                SuccessLabel.ForeColor = Color.Green;
                SuccessLabel.Text = "Duty Updated Successfully";
                RetrieveButton.PerformClick();
            }
            else if(result == -1)
            {
                SuccessLabel.ForeColor = Color.Red;
                SuccessLabel.Text = "Duty does not exists";
            }
            else
            {
                SuccessLabel.ForeColor = Color.Red;
                SuccessLabel.Text = "Failed to Update Duty";
            }
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            List<Duty> duties = new List<Duty>();
            duties.Add(DutyDL.GetDutyByID(int.Parse(IDTextBox.Text)));
            ShowDutiesData(duties);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int dutyID = int.Parse(IDTextBox.Text);
            int result = DutyDL.DeleteDuty(dutyID);

            if (result == 1)
            {
                SuccessLabel.ForeColor = Color.Green;
                SuccessLabel.Text = "Duty Deleted Successfully";
                ShowAllButton.PerformClick();
            }
            else if (result == -1)
            {
                SuccessLabel.ForeColor = Color.Red;
                SuccessLabel.Text = "Duty does not exist";
            }
            else
            {
                SuccessLabel.ForeColor = Color.Red;
                SuccessLabel.Text = "Failed to Delete Duty";
            }
        }

        private void SearchCommitteeID_Click(object sender, EventArgs e)
        {
            List<Duty> duties = new List<Duty>();
            if (CommitteeIDComboBox.SelectedIndex == 0)
                duties = DutyDL.GetDutiesByNullCommitteeID();
            else
                duties = DutyDL.GetDutiesByCommitteeID(int.Parse(CommitteeIDComboBox.Text));
            ShowDutiesData(duties);            
        }

        private void SearchAssignedToRoles_Click(object sender, EventArgs e)
        {
            List<Duty> duties = DutyDL.GetDutiesByAssignedTo(AssignedToComboBox.Text);
            ShowDutiesData(duties);
        }

        private void SearchDescription_Click(object sender, EventArgs e)
        {
            List<Duty> duties = new List<Duty>();
            if (string.IsNullOrWhiteSpace(DescriptionTextBox.Text))
                duties = DutyDL.GetDutiesByNullDescription();
            else
                duties = DutyDL.GetDutiesByDescriptionLike(DescriptionTextBox.Text);
            ShowDutiesData(duties);
        }

        private void SearchDeadline_Click(object sender, EventArgs e)
        {
            List<Duty> duties = DutyDL.GetDutiesByDate(DeadlinePicker.Value);
            ShowDutiesData(duties);
        }

        private void SearchStatues_Click(object sender, EventArgs e)
        {
            List<Duty> duties = new List<Duty>();
            if (StatusIDComboBox.SelectedIndex == 0)
                duties = DutyDL.GetDutiesByNullStatusID();
            else
                duties = DutyDL.GetDutiesByStatusID(int.Parse(StatusIDComboBox.Text));
            ShowDutiesData(duties);
        }

        private void DataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (!isOtherTable)
            {
                IDTextBox.Text = DataGrid.CurrentRow.Cells[0].Value.ToString();
                CommitteeIDComboBox.Text = DataGrid.CurrentRow.Cells[1].Value.ToString();
                AssignedToComboBox.Text = DataGrid.CurrentRow.Cells[2].Value.ToString();
                DescriptionTextBox.Text = DataGrid.CurrentRow.Cells[3].Value.ToString() == "NULL" ? "" : DataGrid.CurrentRow.Cells[3].Value.ToString();
                DeadlinePicker.Value = DateTime.Parse(DataGrid.CurrentRow.Cells[4].Value.ToString());
                StatusIDComboBox.Text = DataGrid.CurrentRow.Cells[5].Value.ToString();
            }
        }
    }
}
