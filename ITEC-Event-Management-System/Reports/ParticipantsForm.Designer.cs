namespace ITEC_Event_Management_System.Reports
{
    partial class ParticipantsForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.participantClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RetrieveButton = new System.Windows.Forms.Button();
            this.ITECIDLabel = new System.Windows.Forms.Label();
            this.ITECIDComboBox = new System.Windows.Forms.ComboBox();
            this.RoleIDLabel = new System.Windows.Forms.Label();
            this.RoleIDComboBox = new System.Windows.Forms.ComboBox();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.EventIDComboBox = new System.Windows.Forms.ComboBox();
            this.EventIDLabel = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EventsHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.participantClassBindingSource1)).BeginInit();
            this.DataPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // participantClassBindingSource1
            // 
            this.participantClassBindingSource1.DataSource = typeof(ITEC_Event_Management_System.Reports.ParticipantClass);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "ParticipantsDataset";
            reportDataSource2.Value = this.participantClassBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ITEC_Event_Management_System.Reports.ParticipantsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(519, 102);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1018, 625);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // RetrieveButton
            // 
            this.RetrieveButton.BackColor = System.Drawing.Color.Peru;
            this.RetrieveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetrieveButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetrieveButton.ForeColor = System.Drawing.Color.Transparent;
            this.RetrieveButton.Location = new System.Drawing.Point(118, 231);
            this.RetrieveButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RetrieveButton.Name = "RetrieveButton";
            this.RetrieveButton.Size = new System.Drawing.Size(98, 33);
            this.RetrieveButton.TabIndex = 7;
            this.RetrieveButton.Text = "Retrieve";
            this.RetrieveButton.UseVisualStyleBackColor = false;
            this.RetrieveButton.Click += new System.EventHandler(this.RetrieveButton_Click);
            // 
            // ITECIDLabel
            // 
            this.ITECIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ITECIDLabel.AutoSize = true;
            this.ITECIDLabel.Enabled = false;
            this.ITECIDLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITECIDLabel.ForeColor = System.Drawing.Color.Black;
            this.ITECIDLabel.Location = new System.Drawing.Point(74, 41);
            this.ITECIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ITECIDLabel.Name = "ITECIDLabel";
            this.ITECIDLabel.Size = new System.Drawing.Size(69, 23);
            this.ITECIDLabel.TabIndex = 9;
            this.ITECIDLabel.Text = "ITEC ID:";
            // 
            // ITECIDComboBox
            // 
            this.ITECIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ITECIDComboBox.Enabled = false;
            this.ITECIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITECIDComboBox.FormattingEnabled = true;
            this.ITECIDComboBox.Location = new System.Drawing.Point(161, 38);
            this.ITECIDComboBox.Name = "ITECIDComboBox";
            this.ITECIDComboBox.Size = new System.Drawing.Size(137, 26);
            this.ITECIDComboBox.TabIndex = 4;
            this.ITECIDComboBox.SelectedIndexChanged += new System.EventHandler(this.ITECIDComboBox_SelectedIndexChanged);
            // 
            // RoleIDLabel
            // 
            this.RoleIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoleIDLabel.AutoSize = true;
            this.RoleIDLabel.Enabled = false;
            this.RoleIDLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleIDLabel.ForeColor = System.Drawing.Color.Black;
            this.RoleIDLabel.Location = new System.Drawing.Point(74, 92);
            this.RoleIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoleIDLabel.Name = "RoleIDLabel";
            this.RoleIDLabel.Size = new System.Drawing.Size(72, 23);
            this.RoleIDLabel.TabIndex = 19;
            this.RoleIDLabel.Text = "Role ID:";
            // 
            // RoleIDComboBox
            // 
            this.RoleIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleIDComboBox.Enabled = false;
            this.RoleIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleIDComboBox.FormattingEnabled = true;
            this.RoleIDComboBox.Location = new System.Drawing.Point(161, 89);
            this.RoleIDComboBox.Name = "RoleIDComboBox";
            this.RoleIDComboBox.Size = new System.Drawing.Size(138, 26);
            this.RoleIDComboBox.TabIndex = 5;
            this.RoleIDComboBox.SelectedIndexChanged += new System.EventHandler(this.RoleIDComboBox_SelectedIndexChanged);
            // 
            // DataPanel
            // 
            this.DataPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataPanel.Controls.Add(this.EventIDComboBox);
            this.DataPanel.Controls.Add(this.EventIDLabel);
            this.DataPanel.Controls.Add(this.radioButton3);
            this.DataPanel.Controls.Add(this.radioButton2);
            this.DataPanel.Controls.Add(this.radioButton1);
            this.DataPanel.Controls.Add(this.RoleIDComboBox);
            this.DataPanel.Controls.Add(this.RoleIDLabel);
            this.DataPanel.Controls.Add(this.ITECIDComboBox);
            this.DataPanel.Controls.Add(this.ITECIDLabel);
            this.DataPanel.Controls.Add(this.RetrieveButton);
            this.DataPanel.Location = new System.Drawing.Point(71, 220);
            this.DataPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(366, 299);
            this.DataPanel.TabIndex = 17;
            // 
            // EventIDComboBox
            // 
            this.EventIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventIDComboBox.Enabled = false;
            this.EventIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventIDComboBox.FormattingEnabled = true;
            this.EventIDComboBox.Location = new System.Drawing.Point(161, 141);
            this.EventIDComboBox.Name = "EventIDComboBox";
            this.EventIDComboBox.Size = new System.Drawing.Size(138, 26);
            this.EventIDComboBox.TabIndex = 23;
            this.EventIDComboBox.SelectedIndexChanged += new System.EventHandler(this.EventIDComboBox_SelectedIndexChanged);
            // 
            // EventIDLabel
            // 
            this.EventIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventIDLabel.AutoSize = true;
            this.EventIDLabel.Enabled = false;
            this.EventIDLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventIDLabel.ForeColor = System.Drawing.Color.Black;
            this.EventIDLabel.Location = new System.Drawing.Point(74, 144);
            this.EventIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EventIDLabel.Name = "EventIDLabel";
            this.EventIDLabel.Size = new System.Drawing.Size(81, 23);
            this.EventIDLabel.TabIndex = 24;
            this.EventIDLabel.Text = "Event ID:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(49, 147);
            this.radioButton3.MaximumSize = new System.Drawing.Size(20, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(49, 98);
            this.radioButton2.MaximumSize = new System.Drawing.Size(20, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(49, 47);
            this.radioButton1.MaximumSize = new System.Drawing.Size(20, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EventsHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1572, 72);
            this.panel1.TabIndex = 23;
            // 
            // EventsHeading
            // 
            this.EventsHeading.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.EventsHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EventsHeading.AutoSize = true;
            this.EventsHeading.Font = new System.Drawing.Font("Product Sans Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsHeading.ForeColor = System.Drawing.Color.Tomato;
            this.EventsHeading.Location = new System.Drawing.Point(566, 9);
            this.EventsHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EventsHeading.Name = "EventsHeading";
            this.EventsHeading.Size = new System.Drawing.Size(390, 51);
            this.EventsHeading.TabIndex = 0;
            this.EventsHeading.Text = "Participants Report";
            this.EventsHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParticipantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 830);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParticipantsForm";
            this.Text = "ParticipantsForm";
            this.Load += new System.EventHandler(this.ParticipantsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.participantClassBindingSource1)).EndInit();
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource participantClassBindingSource1;
        private System.Windows.Forms.Button RetrieveButton;
        private System.Windows.Forms.Label ITECIDLabel;
        private System.Windows.Forms.ComboBox ITECIDComboBox;
        private System.Windows.Forms.Label RoleIDLabel;
        private System.Windows.Forms.ComboBox RoleIDComboBox;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox EventIDComboBox;
        private System.Windows.Forms.Label EventIDLabel;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EventsHeading;
    }
}