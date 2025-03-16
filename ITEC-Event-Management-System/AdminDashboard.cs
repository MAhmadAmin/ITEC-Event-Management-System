using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEC_Event_Management_System
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadForm(new Participants());
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
            LoadForm(new ITECEditions());
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void EventsButton_Click(object sender, EventArgs e)
        {
            LoadForm(new Events());
        }

        private void VenuesButton_Click(object sender, EventArgs e)
        {
            LoadForm(new Venues());
        }
    }
}
