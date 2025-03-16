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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SidePanelButtonsPanel = new System.Windows.Forms.Panel();
            this.ITECEditionsButton = new System.Windows.Forms.Button();
            this.AdminPictureBox = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AdminPanelHeadning = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SIgnup = new System.Windows.Forms.Button();
            this.SidePanel.SuspendLayout();
            this.SidePanelButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPictureBox)).BeginInit();
            this.TopPanel.SuspendLayout();
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
            this.LogoutButton.Location = new System.Drawing.Point(28, 676);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(129, 32);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Log out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // SidePanelButtonsPanel
            // 
            this.SidePanelButtonsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SidePanelButtonsPanel.Controls.Add(this.SIgnup);
            this.SidePanelButtonsPanel.Controls.Add(this.ITECEditionsButton);
            this.SidePanelButtonsPanel.Location = new System.Drawing.Point(3, 154);
            this.SidePanelButtonsPanel.Name = "SidePanelButtonsPanel";
            this.SidePanelButtonsPanel.Size = new System.Drawing.Size(173, 197);
            this.SidePanelButtonsPanel.TabIndex = 0;
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
            this.ITECEditionsButton.Text = "ITEC Editions";
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
            // SIgnup
            // 
            this.SIgnup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SIgnup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SIgnup.FlatAppearance.BorderSize = 0;
            this.SIgnup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SIgnup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIgnup.ForeColor = System.Drawing.Color.White;
            this.SIgnup.Image = global::ITEC_Event_Management_System.Properties.Resources.ITECEdition24x24;
            this.SIgnup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SIgnup.Location = new System.Drawing.Point(3, 55);
            this.SIgnup.Name = "SIgnup";
            this.SIgnup.Size = new System.Drawing.Size(167, 32);
            this.SIgnup.TabIndex = 2;
            this.SIgnup.Text = "Signup";
            this.SIgnup.UseVisualStyleBackColor = true;
            this.SIgnup.Click += new System.EventHandler(this.ITECEditionsButton_Click);
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
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.SidePanel.ResumeLayout(false);
            this.SidePanelButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdminPictureBox)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
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
        private System.Windows.Forms.Button SIgnup;
    }
}