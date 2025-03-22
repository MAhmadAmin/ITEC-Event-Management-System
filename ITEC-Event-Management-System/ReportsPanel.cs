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
    public partial class ReportsPanel : Form
    {
        public ReportsPanel()
        {
            InitializeComponent();
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

        private void ParticipantsButton_Click(object sender, EventArgs e)
        {
            LoadForm(new ParticipantsForm());
        }
    }
}
