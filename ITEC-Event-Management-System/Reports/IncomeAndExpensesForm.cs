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
    public partial class IncomeAndExpensesForm : Form
    {
        bool toggleShowEvents = false;
        public IncomeAndExpensesForm()
        {
            InitializeComponent();
        }

        private void IncomeAndExpensesForm_Load(object sender, EventArgs e)
        {
            List<Event> events = EventDL.GetAllEvents();
            EventIDComboBox.Items.Add("None");
            foreach (Event evn in events)
            {
                EventIDComboBox.Items.Add(evn.ID);
            }
            EventIDComboBox.SelectedIndex = 0;
        }

        private void ShowCommitteesButton_Click(object sender, EventArgs e)
        {

            if (!toggleShowEvents)
            {
                reportViewer1.Hide();
                DataGrid.Show();
                ShowCommitteesButton.Text = "Hide Events";

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

                toggleShowEvents = true;
            }
            else
            {
                reportViewer1.Show();
                DataGrid.Hide();
                ShowCommitteesButton.Text = "Show Committees";
                toggleShowEvents = false;
            }           

        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            if (EventIDComboBox.SelectedIndex != 0) {
                List<IncomeAndExpenceDataClass> data = IncomeAndExpenceDL.GetData(int.Parse(EventIDComboBox.Text));
                this.incomeAndExpenceDataClassBindingSource.DataSource = data;
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
