namespace ITEC_Event_Management_System
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SidePanel = new System.Windows.Forms.Panel();
            this.SidePanelButtonsPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AdminPanelHeadning = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.VenuesButton = new System.Windows.Forms.Button();
            this.EventsButton = new System.Windows.Forms.Button();
            this.ITECEditionsButton = new System.Windows.Forms.Button();
            this.AdminPictureBox = new System.Windows.Forms.PictureBox();
            this.SidePanel.SuspendLayout();
            this.SidePanelButtonsPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SidePanel.Controls.Add(this.LogoutButton);
            this.SidePanel.Controls.Add(this.SidePanelButtonsPanel);
            this.SidePanel.Controls.Add(this.AdminPictureBox);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(182, 729);
            this.SidePanel.TabIndex = 0;
            // 
            // SidePanelButtonsPanel
            // 
            this.SidePanelButtonsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SidePanelButtonsPanel.Controls.Add(this.VenuesButton);
            this.SidePanelButtonsPanel.Controls.Add(this.EventsButton);
            this.SidePanelButtonsPanel.Controls.Add(this.ITECEditionsButton);
            this.SidePanelButtonsPanel.Location = new System.Drawing.Point(3, 154);
            this.SidePanelButtonsPanel.Name = "SidePanelButtonsPanel";
            this.SidePanelButtonsPanel.Size = new System.Drawing.Size(173, 197);
            this.SidePanelButtonsPanel.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.AdminPanelHeadning);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(182, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(802, 59);
            this.TopPanel.TabIndex = 1;
            // 
            // AdminPanelHeadning
            // 
            this.AdminPanelHeadning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AdminPanelHeadning.AutoSize = true;
            this.AdminPanelHeadning.Font = new System.Drawing.Font("Arial Black", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPanelHeadning.ForeColor = System.Drawing.Color.DarkOrange;
            this.AdminPanelHeadning.Location = new System.Drawing.Point(253, 0);
            this.AdminPanelHeadning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdminPanelHeadning.Name = "AdminPanelHeadning";
            this.AdminPanelHeadning.Size = new System.Drawing.Size(281, 54);
            this.AdminPanelHeadning.TabIndex = 1;
            this.AdminPanelHeadning.Text = "Admin Panel";
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(182, 59);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(802, 670);
            this.MainPanel.TabIndex = 2;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Image = global::ITEC_Event_Management_System.Properties.Resources.LogoutIcon;
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(22, 597);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(129, 32);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Log out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // VenuesButton
            // 
            this.VenuesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VenuesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VenuesButton.FlatAppearance.BorderSize = 0;
            this.VenuesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VenuesButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenuesButton.ForeColor = System.Drawing.Color.White;
            this.VenuesButton.Image = global::ITEC_Event_Management_System.Properties.Resources.VenueIcon;
            this.VenuesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VenuesButton.Location = new System.Drawing.Point(3, 79);
            this.VenuesButton.Name = "VenuesButton";
            this.VenuesButton.Size = new System.Drawing.Size(167, 32);
            this.VenuesButton.TabIndex = 4;
            this.VenuesButton.Text = "          Venues";
            this.VenuesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VenuesButton.UseVisualStyleBackColor = true;
            this.VenuesButton.Click += new System.EventHandler(this.VenuesButton_Click);
            // 
            // EventsButton
            // 
            this.EventsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EventsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EventsButton.FlatAppearance.BorderSize = 0;
            this.EventsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsButton.ForeColor = System.Drawing.Color.White;
            this.EventsButton.Image = global::ITEC_Event_Management_System.Properties.Resources.Events;
            this.EventsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EventsButton.Location = new System.Drawing.Point(3, 41);
            this.EventsButton.Name = "EventsButton";
            this.EventsButton.Size = new System.Drawing.Size(167, 32);
            this.EventsButton.TabIndex = 3;
            this.EventsButton.Text = "          Events";
            this.EventsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EventsButton.UseVisualStyleBackColor = true;
            this.EventsButton.Click += new System.EventHandler(this.EventsButton_Click);
            // 
            // ITECEditionsButton
            // 
            this.ITECEditionsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ITECEditionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ITECEditionsButton.FlatAppearance.BorderSize = 0;
            this.ITECEditionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ITECEditionsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITECEditionsButton.ForeColor = System.Drawing.Color.White;
            this.ITECEditionsButton.Image = global::ITEC_Event_Management_System.Properties.Resources.ITECEdition24x24;
            this.ITECEditionsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ITECEditionsButton.Location = new System.Drawing.Point(3, 3);
            this.ITECEditionsButton.Name = "ITECEditionsButton";
            this.ITECEditionsButton.Size = new System.Drawing.Size(167, 32);
            this.ITECEditionsButton.TabIndex = 2;
            this.ITECEditionsButton.Text = "          ITEC Editions";
            this.ITECEditionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ITECEditionsButton.UseVisualStyleBackColor = true;
            this.ITECEditionsButton.Click += new System.EventHandler(this.ITECEditionsButton_Click);
            // 
            // AdminPictureBox
            // 
            this.AdminPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.AdminPictureBox.Image = global::ITEC_Event_Management_System.Properties.Resources.AdminTeamWhite;
            this.AdminPictureBox.Location = new System.Drawing.Point(0, 19);
            this.AdminPictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.AdminPictureBox.Name = "AdminPictureBox";
            this.AdminPictureBox.Size = new System.Drawing.Size(182, 112);
            this.AdminPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdminPictureBox.TabIndex = 1;
            this.AdminPictureBox.TabStop = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 729);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SidePanel);
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.SidePanel.ResumeLayout(false);
            this.SidePanelButtonsPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.PictureBox AdminPictureBox;
        private System.Windows.Forms.Button ITECEditionsButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label AdminPanelHeadning;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SidePanelButtonsPanel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button EventsButton;
        private System.Windows.Forms.Button VenuesButton;
    }
}