namespace ITEC_Event_Management_System
{
    partial class VenueAllocations
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
            this.SearchVenues = new System.Windows.Forms.Button();
            this.ShowVenuesButton = new System.Windows.Forms.Button();
            this.VenueIDComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchEventsButton = new System.Windows.Forms.Button();
            this.SearchDateTime = new System.Windows.Forms.Button();
            this.ShowEventsButton = new System.Windows.Forms.Button();
            this.EventIDComboBox = new System.Windows.Forms.ComboBox();
            this.ITECIDLabel = new System.Windows.Forms.Label();
            this.IDErrorLabel = new System.Windows.Forms.Label();
            this.EventIDLabel = new System.Windows.Forms.Label();
            this.AllocationIDTextBox = new System.Windows.Forms.TextBox();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RetrieveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.AllocationHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.ButtonsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchVenues
            // 
            this.SearchVenues.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchVenues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchVenues.FlatAppearance.BorderSize = 0;
            this.SearchVenues.Location = new System.Drawing.Point(447, 128);
            this.SearchVenues.Name = "SearchVenues";
            this.SearchVenues.Size = new System.Drawing.Size(24, 25);
            this.SearchVenues.TabIndex = 32;
            this.SearchVenues.UseVisualStyleBackColor = true;
            // 
            // ShowVenuesButton
            // 
            this.ShowVenuesButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ShowVenuesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowVenuesButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowVenuesButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowVenuesButton.Location = new System.Drawing.Point(295, 126);
            this.ShowVenuesButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowVenuesButton.Name = "ShowVenuesButton";
            this.ShowVenuesButton.Size = new System.Drawing.Size(130, 27);
            this.ShowVenuesButton.TabIndex = 29;
            this.ShowVenuesButton.Text = "Show Venues";
            this.ShowVenuesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowVenuesButton.UseVisualStyleBackColor = false;
            // 
            // VenueIDComboBox
            // 
            this.VenueIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VenueIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenueIDComboBox.FormattingEnabled = true;
            this.VenueIDComboBox.Location = new System.Drawing.Point(153, 127);
            this.VenueIDComboBox.Name = "VenueIDComboBox";
            this.VenueIDComboBox.Size = new System.Drawing.Size(137, 26);
            this.VenueIDComboBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(62, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Venue ID:";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateTimePicker.Location = new System.Drawing.Point(153, 179);
            this.DateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.MinimumSize = new System.Drawing.Size(200, 24);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateTimePicker.Size = new System.Drawing.Size(278, 24);
            this.DateTimePicker.TabIndex = 11;
            this.DateTimePicker.Value = new System.DateTime(2025, 3, 20, 0, 0, 0, 0);
            // 
            // SearchEventsButton
            // 
            this.SearchEventsButton.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchEventsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchEventsButton.FlatAppearance.BorderSize = 0;
            this.SearchEventsButton.Location = new System.Drawing.Point(447, 76);
            this.SearchEventsButton.Name = "SearchEventsButton";
            this.SearchEventsButton.Size = new System.Drawing.Size(24, 25);
            this.SearchEventsButton.TabIndex = 23;
            this.SearchEventsButton.UseVisualStyleBackColor = true;
            // 
            // SearchDateTime
            // 
            this.SearchDateTime.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchDateTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchDateTime.FlatAppearance.BorderSize = 0;
            this.SearchDateTime.Location = new System.Drawing.Point(447, 177);
            this.SearchDateTime.Name = "SearchDateTime";
            this.SearchDateTime.Size = new System.Drawing.Size(24, 25);
            this.SearchDateTime.TabIndex = 20;
            this.SearchDateTime.UseVisualStyleBackColor = true;
            // 
            // ShowEventsButton
            // 
            this.ShowEventsButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ShowEventsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowEventsButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowEventsButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowEventsButton.Location = new System.Drawing.Point(295, 74);
            this.ShowEventsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowEventsButton.Name = "ShowEventsButton";
            this.ShowEventsButton.Size = new System.Drawing.Size(130, 27);
            this.ShowEventsButton.TabIndex = 12;
            this.ShowEventsButton.Text = "Show Events";
            this.ShowEventsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowEventsButton.UseVisualStyleBackColor = false;
            // 
            // EventIDComboBox
            // 
            this.EventIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventIDComboBox.FormattingEnabled = true;
            this.EventIDComboBox.Location = new System.Drawing.Point(153, 75);
            this.EventIDComboBox.Name = "EventIDComboBox";
            this.EventIDComboBox.Size = new System.Drawing.Size(137, 26);
            this.EventIDComboBox.TabIndex = 4;
            // 
            // ITECIDLabel
            // 
            this.ITECIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ITECIDLabel.AutoSize = true;
            this.ITECIDLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITECIDLabel.ForeColor = System.Drawing.Color.Black;
            this.ITECIDLabel.Location = new System.Drawing.Point(67, 78);
            this.ITECIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ITECIDLabel.Name = "ITECIDLabel";
            this.ITECIDLabel.Size = new System.Drawing.Size(81, 23);
            this.ITECIDLabel.TabIndex = 9;
            this.ITECIDLabel.Text = "Event ID:";
            // 
            // IDErrorLabel
            // 
            this.IDErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDErrorLabel.AutoSize = true;
            this.IDErrorLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.IDErrorLabel.Location = new System.Drawing.Point(295, 38);
            this.IDErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDErrorLabel.Name = "IDErrorLabel";
            this.IDErrorLabel.Size = new System.Drawing.Size(136, 17);
            this.IDErrorLabel.TabIndex = 8;
            this.IDErrorLabel.Text = "ID can only be numeric";
            this.IDErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.IDErrorLabel.Visible = false;
            // 
            // EventIDLabel
            // 
            this.EventIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventIDLabel.AutoSize = true;
            this.EventIDLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventIDLabel.ForeColor = System.Drawing.Color.Black;
            this.EventIDLabel.Location = new System.Drawing.Point(33, 13);
            this.EventIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EventIDLabel.Name = "EventIDLabel";
            this.EventIDLabel.Size = new System.Drawing.Size(116, 23);
            this.EventIDLabel.TabIndex = 0;
            this.EventIDLabel.Text = "Allocation ID:";
            // 
            // AllocationIDTextBox
            // 
            this.AllocationIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllocationIDTextBox.ForeColor = System.Drawing.Color.Gray;
            this.AllocationIDTextBox.Location = new System.Drawing.Point(153, 12);
            this.AllocationIDTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AllocationIDTextBox.Name = "AllocationIDTextBox";
            this.AllocationIDTextBox.Size = new System.Drawing.Size(278, 24);
            this.AllocationIDTextBox.TabIndex = 11;
            this.AllocationIDTextBox.TabStop = false;
            this.AllocationIDTextBox.Text = "auto increment";
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.DateTimeLabel.Location = new System.Drawing.Point(19, 179);
            this.DateTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(129, 23);
            this.DateTimeLabel.TabIndex = 0;
            this.DateTimeLabel.Text = "Date and Time:";
            // 
            // DataGrid
            // 
            this.DataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(763, 150);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(601, 638);
            this.DataGrid.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Message:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SuccessLabel.AutoSize = true;
            this.SuccessLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.SuccessLabel.Location = new System.Drawing.Point(94, 149);
            this.SuccessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(38, 17);
            this.SuccessLabel.TabIndex = 10;
            this.SuccessLabel.Text = "None";
            this.SuccessLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShowAllButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ShowAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAllButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowAllButton.Location = new System.Drawing.Point(179, 99);
            this.ShowAllButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(121, 33);
            this.ShowAllButton.TabIndex = 10;
            this.ShowAllButton.Text = "Show All";
            this.ShowAllButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Brown;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteButton.Location = new System.Drawing.Point(362, 46);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(98, 33);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.Transparent;
            this.UpdateButton.Location = new System.Drawing.Point(246, 46);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(98, 33);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            // 
            // RetrieveButton
            // 
            this.RetrieveButton.BackColor = System.Drawing.Color.Peru;
            this.RetrieveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetrieveButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetrieveButton.ForeColor = System.Drawing.Color.Transparent;
            this.RetrieveButton.Location = new System.Drawing.Point(126, 46);
            this.RetrieveButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RetrieveButton.Name = "RetrieveButton";
            this.RetrieveButton.Size = new System.Drawing.Size(98, 33);
            this.RetrieveButton.TabIndex = 7;
            this.RetrieveButton.Text = "Retrieve";
            this.RetrieveButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.ForestGreen;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(2, 46);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(98, 33);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonsPanel.Controls.Add(this.label1);
            this.ButtonsPanel.Controls.Add(this.SuccessLabel);
            this.ButtonsPanel.Controls.Add(this.ShowAllButton);
            this.ButtonsPanel.Controls.Add(this.DeleteButton);
            this.ButtonsPanel.Controls.Add(this.UpdateButton);
            this.ButtonsPanel.Controls.Add(this.RetrieveButton);
            this.ButtonsPanel.Controls.Add(this.AddButton);
            this.ButtonsPanel.Location = new System.Drawing.Point(201, 479);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(499, 189);
            this.ButtonsPanel.TabIndex = 24;
            // 
            // AllocationHeading
            // 
            this.AllocationHeading.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.AllocationHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AllocationHeading.AutoSize = true;
            this.AllocationHeading.Font = new System.Drawing.Font("Product Sans Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllocationHeading.ForeColor = System.Drawing.Color.Tomato;
            this.AllocationHeading.Location = new System.Drawing.Point(490, 30);
            this.AllocationHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AllocationHeading.Name = "AllocationHeading";
            this.AllocationHeading.Size = new System.Drawing.Size(342, 51);
            this.AllocationHeading.TabIndex = 0;
            this.AllocationHeading.Text = "Venue Allocation";
            this.AllocationHeading.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AllocationHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 95);
            this.panel1.TabIndex = 26;
            // 
            // DataPanel
            // 
            this.DataPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataPanel.Controls.Add(this.SearchVenues);
            this.DataPanel.Controls.Add(this.ShowVenuesButton);
            this.DataPanel.Controls.Add(this.VenueIDComboBox);
            this.DataPanel.Controls.Add(this.label4);
            this.DataPanel.Controls.Add(this.DateTimePicker);
            this.DataPanel.Controls.Add(this.SearchEventsButton);
            this.DataPanel.Controls.Add(this.SearchDateTime);
            this.DataPanel.Controls.Add(this.ShowEventsButton);
            this.DataPanel.Controls.Add(this.EventIDComboBox);
            this.DataPanel.Controls.Add(this.ITECIDLabel);
            this.DataPanel.Controls.Add(this.IDErrorLabel);
            this.DataPanel.Controls.Add(this.EventIDLabel);
            this.DataPanel.Controls.Add(this.AllocationIDTextBox);
            this.DataPanel.Controls.Add(this.DateTimeLabel);
            this.DataPanel.Location = new System.Drawing.Point(201, 150);
            this.DataPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(499, 262);
            this.DataPanel.TabIndex = 23;
            // 
            // VenueAllocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1358, 837);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VenueAllocations";
            this.Text = "VenueAllocations";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SearchVenues;
        private System.Windows.Forms.Button ShowVenuesButton;
        private System.Windows.Forms.ComboBox VenueIDComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button SearchEventsButton;
        private System.Windows.Forms.Button SearchDateTime;
        private System.Windows.Forms.Button ShowEventsButton;
        private System.Windows.Forms.ComboBox EventIDComboBox;
        private System.Windows.Forms.Label ITECIDLabel;
        private System.Windows.Forms.Label IDErrorLabel;
        private System.Windows.Forms.Label EventIDLabel;
        private System.Windows.Forms.TextBox AllocationIDTextBox;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button RetrieveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Label AllocationHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DataPanel;
    }
}