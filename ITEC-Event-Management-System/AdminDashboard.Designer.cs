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
            this.EditionButton = new System.Windows.Forms.Button();
            this.AdminPictureBox = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AdminPanelHeadning = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPictureBox)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SidePanel.Controls.Add(this.EditionButton);
            this.SidePanel.Controls.Add(this.AdminPictureBox);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(182, 624);
            this.SidePanel.TabIndex = 0;
            // 
            // EditionButton
            // 
            this.EditionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditionButton.FlatAppearance.BorderSize = 0;
            this.EditionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditionButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditionButton.ForeColor = System.Drawing.Color.White;
            this.EditionButton.Image = global::ITEC_Event_Management_System.Properties.Resources.ITECEdition24x24;
            this.EditionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditionButton.Location = new System.Drawing.Point(3, 144);
            this.EditionButton.Name = "EditionButton";
            this.EditionButton.Size = new System.Drawing.Size(176, 32);
            this.EditionButton.TabIndex = 2;
            this.EditionButton.Text = "ITEC Editions";
            this.EditionButton.UseVisualStyleBackColor = true;
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
            this.TopPanel.Size = new System.Drawing.Size(799, 59);
            this.TopPanel.TabIndex = 1;
            // 
            // AdminPanelHeadning
            // 
            this.AdminPanelHeadning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AdminPanelHeadning.AutoSize = true;
            this.AdminPanelHeadning.Font = new System.Drawing.Font("Arial Black", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPanelHeadning.ForeColor = System.Drawing.Color.DarkOrange;
            this.AdminPanelHeadning.Location = new System.Drawing.Point(251, 0);
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
            this.MainPanel.Size = new System.Drawing.Size(799, 565);
            this.MainPanel.TabIndex = 2;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 624);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SidePanel);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdminPictureBox)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.PictureBox AdminPictureBox;
        private System.Windows.Forms.Button EditionButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label AdminPanelHeadning;
        private System.Windows.Forms.Panel MainPanel;
    }
}