namespace ITEC_Event_Management_System.Reports
{
    partial class EventScheduleForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EventsHeading = new System.Windows.Forms.Label();
            this.ShowEditionsButton = new System.Windows.Forms.Button();
            this.ITECIDComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RetrieveButton = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.eventScheduleDataClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventScheduleDataClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.eventScheduleDataClassBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ITEC_Event_Management_System.Reports.EventScheduleReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(566, 87);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1020, 654);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EventsHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1728, 72);
            this.panel1.TabIndex = 24;
            // 
            // EventsHeading
            // 
            this.EventsHeading.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.EventsHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EventsHeading.AutoSize = true;
            this.EventsHeading.Font = new System.Drawing.Font("Product Sans Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsHeading.ForeColor = System.Drawing.Color.Tomato;
            this.EventsHeading.Location = new System.Drawing.Point(644, 9);
            this.EventsHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EventsHeading.Name = "EventsHeading";
            this.EventsHeading.Size = new System.Drawing.Size(311, 51);
            this.EventsHeading.TabIndex = 0;
            this.EventsHeading.Text = "Event Schedule";
            this.EventsHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowEditionsButton
            // 
            this.ShowEditionsButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ShowEditionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowEditionsButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowEditionsButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowEditionsButton.Location = new System.Drawing.Point(292, 338);
            this.ShowEditionsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowEditionsButton.Name = "ShowEditionsButton";
            this.ShowEditionsButton.Size = new System.Drawing.Size(130, 27);
            this.ShowEditionsButton.TabIndex = 45;
            this.ShowEditionsButton.Text = "Show Editions";
            this.ShowEditionsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowEditionsButton.UseVisualStyleBackColor = false;
            this.ShowEditionsButton.Click += new System.EventHandler(this.ShowEditionsButton_Click);
            // 
            // ITECIDComboBox
            // 
            this.ITECIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ITECIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITECIDComboBox.FormattingEnabled = true;
            this.ITECIDComboBox.Location = new System.Drawing.Point(149, 338);
            this.ITECIDComboBox.Name = "ITECIDComboBox";
            this.ITECIDComboBox.Size = new System.Drawing.Size(138, 26);
            this.ITECIDComboBox.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(75, 342);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "ITEC ID:";
            // 
            // RetrieveButton
            // 
            this.RetrieveButton.BackColor = System.Drawing.Color.Peru;
            this.RetrieveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetrieveButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetrieveButton.ForeColor = System.Drawing.Color.Transparent;
            this.RetrieveButton.Location = new System.Drawing.Point(179, 394);
            this.RetrieveButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RetrieveButton.Name = "RetrieveButton";
            this.RetrieveButton.Size = new System.Drawing.Size(98, 33);
            this.RetrieveButton.TabIndex = 43;
            this.RetrieveButton.Text = "Retrieve";
            this.RetrieveButton.UseVisualStyleBackColor = false;
            this.RetrieveButton.Click += new System.EventHandler(this.RetrieveButton_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(747, 184);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(577, 423);
            this.DataGrid.TabIndex = 47;
            this.DataGrid.Visible = false;
            // 
            // eventScheduleDataClassBindingSource
            // 
            this.eventScheduleDataClassBindingSource.DataSource = typeof(ITEC_Event_Management_System.Reports.EventScheduleDataClass);
            // 
            // EventScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 816);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.ShowEditionsButton);
            this.Controls.Add(this.ITECIDComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RetrieveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventScheduleForm";
            this.Text = "EventScheduleForm";
            this.Load += new System.EventHandler(this.EventScheduleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventScheduleDataClassBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource eventScheduleDataClassBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EventsHeading;
        private System.Windows.Forms.Button ShowEditionsButton;
        private System.Windows.Forms.ComboBox ITECIDComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RetrieveButton;
        private System.Windows.Forms.DataGridView DataGrid;
    }
}