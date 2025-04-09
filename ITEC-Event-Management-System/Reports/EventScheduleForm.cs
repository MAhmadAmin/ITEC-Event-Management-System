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
    public partial class EventScheduleForm : Form
    {
        bool toogleShowEditions = false;
        public EventScheduleForm()
        {
            InitializeComponent();
        }

        private void EventScheduleForm_Load(object sender, EventArgs e)
        {
            List<ITECEdition> editions = ITECEditionsDL.GetAllEditions();
            ITECIDComboBox.Items.Clear();
            ITECIDComboBox.Items.Add("None");
            foreach (ITECEdition edition in editions)
            {
                ITECIDComboBox.Items.Add(edition.ID);
            }
            ITECIDComboBox.SelectedIndex = 0;
            this.reportViewer1.RefreshReport();
        }

        private void ShowEditionsButton_Click(object sender, EventArgs e)
        {
            if (!toogleShowEditions)
            {
                reportViewer1.Hide();
                DataGrid.Show();
                ShowEditionsButton.Text = "Hide Editions";

                List<ITECEdition> editions = ITECEditionsDL.GetAllEditions();
                DataTable dt =
                    new DataTable();
                dt.Columns.Add("ITEC ID");
                dt.Columns.Add("Year");
                dt.Columns.Add("Theme");
                dt.Columns.Add("Description");
                foreach (ITECEdition edition in editions)
                {
                    string themeValue = string.IsNullOrEmpty(edition.theme) ? "NULL" : edition.theme;
                    string descriptionValue = string.IsNullOrEmpty(edition.description) ? "NULL" : edition.description;
                    dt.Rows.Add(edition.ID, edition.year, themeValue, descriptionValue);
                }
                DataGrid.DataSource = dt;
                DataGrid.Refresh();

                toogleShowEditions = true;
            }
            else
            {
                reportViewer1.Show();
                DataGrid.Hide();
                ShowEditionsButton.Text = "Show Editions";
                toogleShowEditions = false;
            }
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            if(ITECIDComboBox.SelectedIndex != 0)
            {
                List<EventScheduleDataClass> data = EventScheduleDL.GetData(int.Parse(ITECIDComboBox.Text));
                this.eventScheduleDataClassBindingSource.DataSource = data;
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
