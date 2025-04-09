namespace ITEC_Event_Management_System.Reports
{
    partial class CommitteeAssignmentReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ShowCommitteesButton = new System.Windows.Forms.Button();
            this.CommitteeIDComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RetrieveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EventsHeading = new System.Windows.Forms.Label();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.committeeAssignmentDataClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.committeeAssignmentDataClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.committeeAssignmentDataClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.committeeAssignmentDataClassBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowCommitteesButton
            // 
            this.ShowCommitteesButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ShowCommitteesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowCommitteesButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCommitteesButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowCommitteesButton.Location = new System.Drawing.Point(342, 288);
            this.ShowCommitteesButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowCommitteesButton.Name = "ShowCommitteesButton";
            this.ShowCommitteesButton.Size = new System.Drawing.Size(130, 27);
            this.ShowCommitteesButton.TabIndex = 34;
            this.ShowCommitteesButton.Text = "Show Committees";
            this.ShowCommitteesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowCommitteesButton.UseVisualStyleBackColor = false;
            this.ShowCommitteesButton.Click += new System.EventHandler(this.ShowCommitteesButton_Click);
            // 
            // CommitteeIDComboBox
            // 
            this.CommitteeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CommitteeIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitteeIDComboBox.FormattingEnabled = true;
            this.CommitteeIDComboBox.Location = new System.Drawing.Point(199, 288);
            this.CommitteeIDComboBox.Name = "CommitteeIDComboBox";
            this.CommitteeIDComboBox.Size = new System.Drawing.Size(138, 26);
            this.CommitteeIDComboBox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(71, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Committee ID:";
            // 
            // RetrieveButton
            // 
            this.RetrieveButton.BackColor = System.Drawing.Color.Peru;
            this.RetrieveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetrieveButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetrieveButton.ForeColor = System.Drawing.Color.Transparent;
            this.RetrieveButton.Location = new System.Drawing.Point(199, 343);
            this.RetrieveButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RetrieveButton.Name = "RetrieveButton";
            this.RetrieveButton.Size = new System.Drawing.Size(98, 33);
            this.RetrieveButton.TabIndex = 32;
            this.RetrieveButton.Text = "Retrieve";
            this.RetrieveButton.UseVisualStyleBackColor = false;
            this.RetrieveButton.Click += new System.EventHandler(this.RetrieveButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EventsHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1647, 72);
            this.panel1.TabIndex = 36;
            // 
            // EventsHeading
            // 
            this.EventsHeading.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.EventsHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EventsHeading.AutoSize = true;
            this.EventsHeading.Font = new System.Drawing.Font("Product Sans Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsHeading.ForeColor = System.Drawing.Color.Tomato;
            this.EventsHeading.Location = new System.Drawing.Point(501, 9);
            this.EventsHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EventsHeading.Name = "EventsHeading";
            this.EventsHeading.Size = new System.Drawing.Size(607, 51);
            this.EventsHeading.TabIndex = 0;
            this.EventsHeading.Text = "Committee Assignment Report";
            this.EventsHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGrid
            // 
            this.DataGrid.Location = new System.Drawing.Point(661, 128);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(826, 582);
            this.DataGrid.TabIndex = 38;
            this.DataGrid.Visible = false;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.committeeAssignmentDataClassBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ITEC_Event_Management_System.Reports.CommitteeAssignReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(477, 89);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1137, 653);
            this.reportViewer1.TabIndex = 39;
            // 
            // committeeAssignmentDataClassBindingSource
            // 
            this.committeeAssignmentDataClassBindingSource.DataSource = typeof(ITEC_Event_Management_System.Reports.CommitteeAssignmentDataClass);
            // 
            // committeeAssignmentDataClassBindingSource1
            // 
            this.committeeAssignmentDataClassBindingSource1.DataSource = typeof(ITEC_Event_Management_System.Reports.CommitteeAssignmentDataClass);
            // 
            // CommitteeAssignmentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 839);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ShowCommitteesButton);
            this.Controls.Add(this.CommitteeIDComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RetrieveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CommitteeAssignmentReportForm";
            this.Text = "CommitteeAssignmentReportForm";
            this.Load += new System.EventHandler(this.CommitteeAssignmentReportForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.committeeAssignmentDataClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.committeeAssignmentDataClassBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ShowCommitteesButton;
        private System.Windows.Forms.ComboBox CommitteeIDComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RetrieveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EventsHeading;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.BindingSource committeeAssignmentDataClassBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource committeeAssignmentDataClassBindingSource;
    }
}