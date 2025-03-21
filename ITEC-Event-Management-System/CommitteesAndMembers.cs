using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITEC_Event_Management_System.BL;
using ITEC_Event_Management_System.DL;
using MySql.Data.MySqlClient;

namespace ITEC_Event_Management_System
{
    public partial class CommitteesAndMembers : Form
    {
        bool isOtherDataTable = false;
        bool isOtherDataTable2 = false;
        public CommitteesAndMembers()
        {
            InitializeComponent();

            var itec_editions = DatabaseHelper.Instance.getData("SELECT itec_id FROM itec_editions");
            ITECIDComboBox.Items.Add("None");
            while (itec_editions.Read())
            {
                ITECIDComboBox.Items.Add(int.Parse(itec_editions["itec_id"].ToString()));
            }
            itec_editions.Close();
            ITECIDComboBox.SelectedIndex = 0;

            List<Lookup> lookups = LookupDataLayer.GetIDsByCategory("CommitteeRoles");
            RoleIDComboBox.Items.Add("None");
            foreach (Lookup lookup in lookups)
            {
                RoleIDComboBox.Items.Add(lookup.ID);
            }
            RoleIDComboBox.SelectedIndex = 0;

            List<Committee> committees = CommitteeDL.GetAllCommittees();
            CommitteeIDComboBox.Items.Add("None");
            foreach (Committee committee in committees)
            {
                CommitteeIDComboBox.Items.Add(committee.ID);
            }
            CommitteeIDComboBox.SelectedIndex = 0;


            UpdateCommitteeButtons();
            UpdateMemberButtons();
        }

        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        private void UpdateCommitteeButtons()
        {
            CommitteeSuccessLabel.Text = "None";
            CommitteeSuccessLabel.ForeColor = Color.Green;

            if ((CommitteeIDTextBox.Text == "auto increment" || CommitteeIDTextBox.Text == "") && !string.IsNullOrEmpty(CommitteeNameTextBox.Text))
            {
                CommitteeAddButton.Enabled = true;
                CommitteeAddButton.ForeColor = Color.White;
                CommitteeAddButton.BackColor = Color.ForestGreen;
            }
            else
            {

                CommitteeAddButton.Enabled = false;
                CommitteeAddButton.BackColor = Color.Gray;
            }

            if (CommitteeIDTextBox.Text != "" && CommitteeIDTextBox.Text != "auto increment" && IsNumeric(CommitteeIDTextBox.Text))
            {
                CommitteeDeleteButton.Enabled = true;
                CommitteeDeleteButton.ForeColor = Color.White;
                CommitteeDeleteButton.BackColor = Color.Brown;

                CommitteeRetrieveButton.Enabled = true;
                CommitteeRetrieveButton.BackColor = Color.Peru;
            }
            else
            {
                CommitteeDeleteButton.Enabled = false;
                CommitteeDeleteButton.BackColor = Color.Gray;

                CommitteeRetrieveButton.Enabled = false;
                CommitteeRetrieveButton.BackColor = Color.Gray;
            }



            if (CommitteeIDTextBox.Text != "" && CommitteeIDTextBox.Text != "auto increment" && IsNumeric(CommitteeIDTextBox.Text))
            {
                CommitteeUpdateButton.Enabled = true;
                CommitteeUpdateButton.BackColor = Color.RoyalBlue;
            }
            else
            {
                CommitteeUpdateButton.Enabled = false;
                CommitteeUpdateButton.BackColor = Color.Gray;
            }
        }

        private void UpdateMemberButtons()
        {
            MemberSuccessLabel.Text = "None";
            MemberSuccessLabel.ForeColor = Color.Green;

            if ((MemberIDTextBox.Text == "auto increment" || MemberIDTextBox.Text == "") && !string.IsNullOrEmpty(MemberNameTextBox.Text))
            {
                MemberAddButton.Enabled = true;
                MemberAddButton.ForeColor = Color.White;
                MemberAddButton.BackColor = Color.ForestGreen;
            }
            else
            {

                MemberAddButton.Enabled = false;
                MemberAddButton.BackColor = Color.Gray;
            }

            if (MemberIDTextBox.Text != "" && MemberIDTextBox.Text != "auto increment" && IsNumeric(MemberIDTextBox.Text))
            {
                MemberDeleteButton.Enabled = true;
                MemberDeleteButton.ForeColor = Color.White;
                MemberDeleteButton.BackColor = Color.Brown;

                MemberRetrieveButton.Enabled = true;
                MemberRetrieveButton.BackColor = Color.Peru;
            }
            else
            {
                MemberDeleteButton.Enabled = false;
                MemberDeleteButton.BackColor = Color.Gray;

                MemberRetrieveButton.Enabled = false;
                MemberRetrieveButton.BackColor = Color.Gray;
            }



            if (MemberIDTextBox.Text != "" && MemberIDTextBox.Text != "auto increment" && IsNumeric(MemberIDTextBox.Text))
            {
                MemberUpdateButton.Enabled = true;
                MemberUpdateButton.BackColor = Color.RoyalBlue;
            }
            else
            {
                MemberUpdateButton.Enabled = false;
                MemberUpdateButton.BackColor = Color.Gray;
            }
        }

        private void CommitteeIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumeric(CommitteeIDTextBox.Text) && CommitteeIDTextBox.Text != "")
            {
                CommitteeIDErrorLabel.Show();
            }
            else
            {
                CommitteeIDErrorLabel.Hide();
            }

            UpdateCommitteeButtons();
        }

        private void CommitteeIDTextBox_Leave(object sender, EventArgs e)
        {
            if (CommitteeIDTextBox.Text == "")

            {
                CommitteeIDTextBox.Text = "auto increment";

                CommitteeIDTextBox.Font = new Font(CommitteeIDTextBox.Font, FontStyle.Italic);
                CommitteeIDTextBox.ForeColor = Color.Gray;
                CommitteeIDErrorLabel.Hide();
            }
            UpdateCommitteeButtons();
        }

        private void CommitteeIDTextBox_Click(object sender, EventArgs e)
        {
            if (CommitteeIDTextBox.Text == "auto increment")
                CommitteeIDTextBox.Text = "";
            CommitteeIDTextBox.ForeColor = Color.Black;
            CommitteeIDTextBox.Font = new Font(CommitteeIDTextBox.Font, FontStyle.Regular);
        }

        private void CommitteeNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateCommitteeButtons();
        }

        private void CommitteeAddButton_Click(object sender, EventArgs e)
        {
            int ITECIDValue = ITECIDComboBox.Text == "None" ? -1 : int.Parse(ITECIDComboBox.Text);
            int result = CommitteeDL.StoreCommittee(new Committee(-1, ITECIDValue, CommitteeNameTextBox.Text));

            if (result == 1)
            {
                CommitteeSuccessLabel.Text = "Committee Added Successfully";
                CommitteeSuccessLabel.ForeColor = Color.ForestGreen;

                CommitteeNameTextBox.Text = "";
                ITECIDComboBox.SelectedIndex = 0;

                CommitteeShowAllButton.PerformClick();
            }
            else
            {
                CommitteeSuccessLabel.Text = "Committee Addition Failed";
                CommitteeSuccessLabel.ForeColor = Color.Red;
            }
        }

        private void ShowEditionsButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Itec_Editions";
            var reader = DatabaseHelper.Instance.getData(query);

            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);

            CommitteeDataGrid.DataSource = dt;
            CommitteeDataGrid.Refresh();
            reader.Close();
            isOtherDataTable = true;
        }

        private void CommitteeShowAllButton_Click(object sender, EventArgs e)
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

            CommitteeDataGrid.DataSource = dt;
            CommitteeDataGrid.Refresh();

            isOtherDataTable = false;
        }

        private void CommitteeRetrieveButton_Click(object sender, EventArgs e)
        {
            Committee committee = CommitteeDL.GetCommitteeByID(int.Parse(CommitteeIDTextBox.Text));

            if (committee != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("ITEC ID");
                dt.Columns.Add("Name");
                DataRow row = dt.NewRow();
                row["ID"] = committee.ID;
                row["ITEC ID"] = committee.ITECID == -1 ? "NULL" : committee.ITECID.ToString();
                row["Name"] = committee.Name;
                dt.Rows.Add(row);
                CommitteeDataGrid.DataSource = dt;

                isOtherDataTable = false;
            }
            else
            {
                MessageBox.Show("No Committee Found with the given ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CommitteeSuccessLabel.Text = "Committee Retrieval Failed";
                CommitteeSuccessLabel.ForeColor = Color.Red;
            }
        }

        private void CommitteeDeleteButton_Click(object sender, EventArgs e)
        {
            int result = CommitteeDL.DeleteCommittee(int.Parse(CommitteeIDTextBox.Text));
            if (result != 0)
            {
                CommitteeSuccessLabel.Text = "Committee Deleted Successfully";
                CommitteeSuccessLabel.ForeColor = Color.ForestGreen;
                CommitteeIDTextBox.Text = "auto increment";
                CommitteeIDErrorLabel.Hide();
                CommitteeIDTextBox.Font = new Font(CommitteeIDTextBox.Font, FontStyle.Italic);
                CommitteeIDTextBox.ForeColor = Color.Gray;
                CommitteeNameTextBox.Text = "";
                ITECIDComboBox.SelectedIndex = 0;
                CommitteeShowAllButton.PerformClick();
            }
            else
            {
                CommitteeSuccessLabel.Text = "Committee Deletion Failed";
                CommitteeSuccessLabel.ForeColor = Color.Red;

            }
        }

        private void CommitteeUpdateButton_Click(object sender, EventArgs e)
        {
            int ITECIDValue = ITECIDComboBox.Text == "None" ? -1 : int.Parse(ITECIDComboBox.Text);
            int result = CommitteeDL.UpdateCommittee(new Committee(int.Parse(CommitteeIDTextBox.Text), ITECIDValue, CommitteeNameTextBox.Text));
            if (result != 0)
            {
                CommitteeSuccessLabel.Text = "Committee Updated Successfully";
                CommitteeSuccessLabel.ForeColor = Color.ForestGreen;
                RetrieveCommitteeAT(int.Parse(CommitteeIDTextBox.Text));
            }
            else
            {
                CommitteeSuccessLabel.Text = "Committee Update Failed";
                CommitteeSuccessLabel.ForeColor = Color.Red;
            }
        }

        private void RetrieveCommitteeAT(int ID)
        {
            Committee committee = CommitteeDL.GetCommitteeByID(ID);
            if (committee != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("ITEC ID");
                dt.Columns.Add("Name");
                DataRow row = dt.NewRow();
                row["ID"] = committee.ID;
                row["ITEC ID"] = committee.ITECID == -1 ? "NULL" : committee.ITECID.ToString();
                row["Name"] = committee.Name;
                dt.Rows.Add(row);
                CommitteeDataGrid.DataSource = dt;
                isOtherDataTable = false;
            }
            else
            {
                MessageBox.Show("No Committee Found with the given ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CommitteeSuccessLabel.Text = "Committee Retrieval Failed";
                CommitteeSuccessLabel.ForeColor = Color.Red;
            }
        }

        private void CommitteeNameSearch_Click(object sender, EventArgs e)
        {
            if (CommitteeNameTextBox.Text == "")
            {
                MessageBox.Show("Please Enter a Name to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<Committee> committees = CommitteeDL.GetCommitteeByName(CommitteeNameTextBox.Text);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("ITEC ID");
            dt.Columns.Add("Name");
            foreach (var committee in committees)
            {
                DataRow row = dt.NewRow();
                row["ID"] = committee.ID;
                row["ITEC ID"] = committee.ITECID == -1 ? "NULL" : committee.ITECID.ToString();
                row["Name"] = committee.Name;
                dt.Rows.Add(row);
            }
            CommitteeDataGrid.DataSource = dt;
            CommitteeDataGrid.Refresh();
            isOtherDataTable = false;
        }

        private void ITECIDSearch_Click(object sender, EventArgs e)
        {
            if (ITECIDComboBox.Text == "None")
            {
                List<Committee> committees = CommitteeDL.GetCommitteeBYNULLITECID();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("ITEC ID");
                dt.Columns.Add("Name");
                foreach (var committee in committees)
                {
                    DataRow row = dt.NewRow();
                    row["ID"] = committee.ID;
                    row["ITEC ID"] = committee.ITECID == -1 ? "NULL" : committee.ITECID.ToString();
                    row["Name"] = committee.Name;
                    dt.Rows.Add(row);
                }
                CommitteeDataGrid.DataSource = dt;
                CommitteeDataGrid.Refresh();
                isOtherDataTable = false;
            }
            else
            {
                List<Committee> committees = CommitteeDL.GetCommitteeByITECID(int.Parse(ITECIDComboBox.Text));
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("ITEC ID");
                dt.Columns.Add("Name");
                foreach (var committee in committees)
                {
                    DataRow row = dt.NewRow();
                    row["ID"] = committee.ID;
                    row["ITEC ID"] = committee.ITECID == -1 ? "NULL" : committee.ITECID.ToString();
                    row["Name"] = committee.Name;
                    dt.Rows.Add(row);
                }
                CommitteeDataGrid.DataSource = dt;
                CommitteeDataGrid.Refresh();
                isOtherDataTable = false;
            }
        }

        private void CommitteeDataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (!isOtherDataTable)
            {
                CommitteeIDTextBox.Text = CommitteeDataGrid.CurrentRow.Cells[0].Value.ToString();
                ITECIDComboBox.Text = CommitteeDataGrid.CurrentRow.Cells[1].Value.ToString();
                CommitteeNameTextBox.Text = CommitteeDataGrid.CurrentRow.Cells[2].Value.ToString();
            }
            UpdateCommitteeButtons();

        }

        private void MemberIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumeric(MemberIDTextBox.Text) && MemberIDTextBox.Text != "")
            {
                MemberIDErrorLabel.Show();
            }
            else
            {
                MemberIDErrorLabel.Hide();
            }

            UpdateMemberButtons();
        }

        private void MemberIDTextBox_Click(object sender, EventArgs e)
        {
            if (MemberIDTextBox.Text == "auto increment")
                MemberIDTextBox.Text = "";
            MemberIDTextBox.ForeColor = Color.Black;
            MemberIDTextBox.Font = new Font(MemberIDTextBox.Font, FontStyle.Regular);
        }

        private void MemberIDTextBox_Leave(object sender, EventArgs e)
        {
            if (MemberIDTextBox.Text == "")

            {
                MemberIDTextBox.Text = "auto increment";

                MemberIDTextBox.Font = new Font(MemberIDTextBox.Font, FontStyle.Italic);
                MemberIDTextBox.ForeColor = Color.Gray;
                MemberIDErrorLabel.Hide();
            }
            UpdateMemberButtons();
        }

        private void CommitteeIDComboBox_Click(object sender, EventArgs e)
        {
            CommitteeIDComboBox.Items.Clear();
            List<Committee> committees = CommitteeDL.GetAllCommittees();
            CommitteeIDComboBox.Items.Add("None");
            foreach (Committee committee in committees)
            {
                CommitteeIDComboBox.Items.Add(committee.ID);
            }
            CommitteeIDComboBox.SelectedIndex = 0;
        }

        private void MemberShowAllCommittees_Click(object sender, EventArgs e)
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
            MemberDataGrid.DataSource = dt;
            MemberDataGrid.Refresh();
            isOtherDataTable2 = true;
        }

        private void MemberShowAllRoles_Click(object sender, EventArgs e)
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
            MemberDataGrid.DataSource = dt;
            MemberDataGrid.Refresh();
            isOtherDataTable2 = true;
        }

        private void MemberNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateMemberButtons();
        }

        private void MemberDataGrid_DoubleClick(object sender, EventArgs e)
        {
            if(!isOtherDataTable2)
            {
                MemberIDTextBox.Text = MemberDataGrid.CurrentRow.Cells[0].Value.ToString();
                CommitteeIDComboBox.Text = MemberDataGrid.CurrentRow.Cells[1].Value.ToString();
                MemberNameTextBox.Text = MemberDataGrid.CurrentRow.Cells[2].Value.ToString();
                RoleIDComboBox.Text = MemberDataGrid.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void MemberShowAllButton_Click(object sender, EventArgs e)
        {
            List<CommitteeMember> members = CommitteeMemberDL.GetAllCommitteeMembers();

            DataTable dt = new DataTable();
            dt.Columns.Add("Member ID");
            dt.Columns.Add("Committee ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Role ID");

            foreach(CommitteeMember member in members)
            {
                DataRow row = dt.NewRow();
                row["Member ID"] = member.ID;
                row["Committee ID"] = member.committeeID == -1 ? "NULL" : member.committeeID.ToString();
                row["Name"] = member.name;
                row["Role ID"] = member.roleID == -1 ? "NULL" : member.roleID.ToString();
                dt.Rows.Add(row);
            }

            MemberDataGrid.DataSource= dt;
            MemberDataGrid.Refresh();
            isOtherDataTable2 = false;
        }

        private void MemberAddButton_Click(object sender, EventArgs e)
        {
            int roleIDValue = RoleIDComboBox.Text == "None" ? -1 : int.Parse(RoleIDComboBox.Text);
            int committeeIDValue = CommitteeIDComboBox.Text == "None" ? -1 : int.Parse(CommitteeIDComboBox.Text);
            int result = CommitteeMemberDL.StoreMember(new CommitteeMember(-1, committeeIDValue, MemberNameTextBox.Text, roleIDValue));

            if (result == 1)
            {
                MemberSuccessLabel.Text = "Committee Member Added Successfully";
                MemberSuccessLabel.ForeColor = Color.ForestGreen;

                MemberNameTextBox.Text = "";
                CommitteeIDComboBox.SelectedIndex = 0;
                RoleIDComboBox.SelectedIndex = 0;

                MemberShowAllButton.PerformClick();
            }
            else
            {
                MemberSuccessLabel.Text = "Committee Member Addition Failed";
                MemberSuccessLabel.ForeColor = Color.Red;
                MessageBox.Show("Failed to add Committee Member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MemberRetrieveButton_Click(object sender, EventArgs e)
        {
            CommitteeMember member = CommitteeMemberDL.GetMemberByID(int.Parse(MemberIDTextBox.Text));

            if (member != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Member ID");
                dt.Columns.Add("Committee ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Role ID");
                DataRow row = dt.NewRow();
                row["Member ID"] = member.ID;
                row["Committee ID"] = member.committeeID == -1 ? "NULL" : member.committeeID.ToString();
                row["Name"] = member.name;
                row["Role ID"] = member.roleID == -1 ? "NULL" : member.roleID.ToString();
                dt.Rows.Add(row);
                MemberDataGrid.DataSource = dt;
                MemberDataGrid.Refresh();

                isOtherDataTable = false;
            }
            else
            {
                MessageBox.Show("No Committee Member Found with the given ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MemberSuccessLabel.Text = "Member Retrieval Failed";
                MemberSuccessLabel.ForeColor = Color.Red;
            }
        }

        private void MemberUpdateButton_Click(object sender, EventArgs e)
        {
            int roleIDValue = RoleIDComboBox.Text == "None" ? -1 : int.Parse(RoleIDComboBox.Text);
            int committeeIDValue = CommitteeIDComboBox.Text == "None" ? -1 : int.Parse(CommitteeIDComboBox.Text);
            int result = CommitteeMemberDL.UpdateMember(new CommitteeMember(int.Parse(MemberIDTextBox.Text), committeeIDValue, MemberNameTextBox.Text, roleIDValue));

            if (result == 0)
            {
                MemberSuccessLabel.Text = "Committee Member Update Failed";
                MemberSuccessLabel.ForeColor = Color.Red;
                MessageBox.Show("Failed to update Committee Member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MemberSuccessLabel.Text = "Committee Member Updated Successfully";
                MemberSuccessLabel.ForeColor = Color.ForestGreen;
                RetrieveMemberAT(int.Parse(MemberIDTextBox.Text));
            }            
        }

        public void RetrieveMemberAT(int memberID)
        {
            CommitteeMember member = CommitteeMemberDL.GetMemberByID(int.Parse(MemberIDTextBox.Text));

            if (member != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Member ID");
                dt.Columns.Add("Committee ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Role ID");
                DataRow row = dt.NewRow();
                row["Member ID"] = member.ID;
                row["Committee ID"] = member.committeeID == -1 ? "NULL" : member.committeeID.ToString();
                row["Name"] = member.name;
                row["Role ID"] = member.roleID == -1 ? "NULL" : member.roleID.ToString();
                dt.Rows.Add(row);
                MemberDataGrid.DataSource = dt;
                MemberDataGrid.Refresh();

                isOtherDataTable = false;
            }
            else
            {
                MessageBox.Show("No Committee Member Found with the given ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MemberSuccessLabel.Text = "Member Retrieval Failed";
                MemberSuccessLabel.ForeColor = Color.Red;
            }
        }

        private void MemberDeleteButton_Click(object sender, EventArgs e)
        {
            int result = CommitteeMemberDL.DeleteMember(int.Parse(MemberIDTextBox.Text));
            if (result != 0)
            {
                MemberSuccessLabel.Text = "Committee Member Deleted Successfully";
                MemberSuccessLabel.ForeColor = Color.ForestGreen;
                MemberIDTextBox.Text = "auto increment";
                MemberIDErrorLabel.Hide();
                MemberIDTextBox.Font = new Font(MemberIDTextBox.Font, FontStyle.Italic);
                MemberIDTextBox.ForeColor = Color.Gray;
                MemberNameTextBox.Text = "";
                CommitteeIDComboBox.SelectedIndex = 0;
                MemberIDErrorLabel.Hide();
                RoleIDComboBox.SelectedIndex = 0;
                MemberShowAllButton.PerformClick();
            }
            else
            {
                MemberSuccessLabel.Text = "Committee Deletion Failed";
                MemberSuccessLabel.ForeColor = Color.Red;
            }
        }

        private void CommitteeIDSearch_Click(object sender, EventArgs e)
        {
            List<CommitteeMember> members = new List<CommitteeMember>();

            DataTable dt = new DataTable();
            dt.Columns.Add("Member ID");
            dt.Columns.Add("Committee ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Role ID");

            if (CommitteeIDComboBox.Text == "None")
            {
                members = CommitteeMemberDL.GetMembersByNullCommitteeID();

                foreach (var member in members)
                {
                    DataRow row = dt.NewRow();
                    row["Member ID"] = member.ID;
                    row["Committee ID"] = member.committeeID == -1 ? "NULL" : member.committeeID.ToString();
                    row["Name"] = member.name;
                    row["Role ID"] = member.roleID == -1 ? "NULL" : member.roleID.ToString();
                    dt.Rows.Add(row);
                }
            }
            else
            {
                members = CommitteeMemberDL.GetMembersByCommitteeID(int.Parse(CommitteeIDComboBox.Text));
                foreach (var member in members)
                {
                    DataRow row = dt.NewRow();
                    row["Member ID"] = member.ID;
                    row["Committee ID"] = member.committeeID == -1 ? "NULL" : member.committeeID.ToString();
                    row["Name"] = member.name;
                    row["Role ID"] = member.roleID == -1 ? "NULL" : member.roleID.ToString();
                    dt.Rows.Add(row);
                }
            }

            MemberDataGrid.DataSource = dt;
            MemberDataGrid.Refresh();

            isOtherDataTable = false;

        }

        private void RoleIDSearch_Click(object sender, EventArgs e)
        {
            List<CommitteeMember> members = new List<CommitteeMember>();

            DataTable dt = new DataTable();
            dt.Columns.Add("Member ID");
            dt.Columns.Add("Committee ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Role ID");

            if (RoleIDComboBox.Text == "None")
            {
                members = CommitteeMemberDL.GetMembersByNullRoleID();

                foreach (var member in members)
                {
                    DataRow row = dt.NewRow();
                    row["Member ID"] = member.ID;
                    row["Committee ID"] = member.committeeID == -1 ? "NULL" : member.committeeID.ToString();
                    row["Name"] = member.name;
                    row["Role ID"] = member.roleID == -1 ? "NULL" : member.roleID.ToString();
                    dt.Rows.Add(row);
                }
            }
            else
            {
                members = CommitteeMemberDL.GetMembersByRoleID(int.Parse(RoleIDComboBox.Text));
                foreach (var member in members)
                {
                    DataRow row = dt.NewRow();
                    row["Member ID"] = member.ID;
                    row["Committee ID"] = member.committeeID == -1 ? "NULL" : member.committeeID.ToString();
                    row["Name"] = member.name;
                    row["Role ID"] = member.roleID == -1 ? "NULL" : member.roleID.ToString();
                    dt.Rows.Add(row);
                }
            }

            MemberDataGrid.DataSource = dt;
            MemberDataGrid.Refresh();

            isOtherDataTable = false;
        }

        private void MemberNameSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MemberNameTextBox.Text))
            {
                MessageBox.Show("Please enter a name to search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<CommitteeMember> members = CommitteeMemberDL.GetMembersByName(MemberNameTextBox.Text);
            DataTable dt = new DataTable();
            dt.Columns.Add("Member ID");
            dt.Columns.Add("Committee ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Role ID");

            foreach (var member in members)
            {
                DataRow row = dt.NewRow();
                row["Member ID"] = member.ID;
                row["Committee ID"] = member.committeeID == -1 ? "NULL" : member.committeeID.ToString();
                row["Name"] = member.name;
                row["Role ID"] = member.roleID == -1 ? "NULL" : member.roleID.ToString();
                dt.Rows.Add(row);
            }

            MemberDataGrid.DataSource = dt;
            MemberDataGrid.Refresh();
            isOtherDataTable2 = false;
        }

        private void CommitteesAndMembers_Load(object sender, EventArgs e)
        {

        }
    }
}
