namespace ITEC_Event_Management_System
{
    partial class Duties
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
            this.SearchCommitteeID = new System.Windows.Forms.Button();
            this.ShowCommitteesButton = new System.Windows.Forms.Button();
            this.CommitteeIDComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DeadlinePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchStatues = new System.Windows.Forms.Button();
            this.SearchDescription = new System.Windows.Forms.Button();
            this.SearchDeadline = new System.Windows.Forms.Button();
            this.ShowStatusesButton = new System.Windows.Forms.Button();
            this.StatusIDComboBox = new System.Windows.Forms.ComboBox();
            this.ITECIDLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDErrorLabel = new System.Windows.Forms.Label();
            this.LabelDutyID = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RetrieveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.DutiesHeading = new System.Windows.Forms.Label();
            this.LabelAssignedTo = new System.Windows.Forms.Panel();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.ShowRolesButton = new System.Windows.Forms.Button();
            this.AssignedToComboBox = new System.Windows.Forms.ComboBox();
            this.SearchAssignedToRoles = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.ButtonsPanel.SuspendLayout();
            this.LabelAssignedTo.SuspendLayout();
            this.DataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchCommitteeID
            // 
            this.SearchCommitteeID.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchCommitteeID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchCommitteeID.FlatAppearance.BorderSize = 0;
            this.SearchCommitteeID.Location = new System.Drawing.Point(447, 67);
            this.SearchCommitteeID.Name = "SearchCommitteeID";
            this.SearchCommitteeID.Size = new System.Drawing.Size(24, 25);
            this.SearchCommitteeID.TabIndex = 33;
            this.SearchCommitteeID.UseVisualStyleBackColor = true;
            this.SearchCommitteeID.Click += new System.EventHandler(this.SearchCommitteeID_Click);
            // 
            // ShowCommitteesButton
            // 
            this.ShowCommitteesButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ShowCommitteesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowCommitteesButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCommitteesButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowCommitteesButton.Location = new System.Drawing.Point(296, 65);
            this.ShowCommitteesButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowCommitteesButton.Name = "ShowCommitteesButton";
            this.ShowCommitteesButton.Size = new System.Drawing.Size(130, 27);
            this.ShowCommitteesButton.TabIndex = 30;
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
            this.CommitteeIDComboBox.Location = new System.Drawing.Point(153, 65);
            this.CommitteeIDComboBox.Name = "CommitteeIDComboBox";
            this.CommitteeIDComboBox.Size = new System.Drawing.Size(138, 26);
            this.CommitteeIDComboBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Committee ID:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.AcceptsReturn = true;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(152, 155);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(278, 72);
            this.DescriptionTextBox.TabIndex = 25;
            // 
            // DeadlinePicker
            // 
            this.DeadlinePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeadlinePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeadlinePicker.Location = new System.Drawing.Point(152, 249);
            this.DeadlinePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DeadlinePicker.MinimumSize = new System.Drawing.Size(200, 24);
            this.DeadlinePicker.Name = "DeadlinePicker";
            this.DeadlinePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DeadlinePicker.Size = new System.Drawing.Size(278, 24);
            this.DeadlinePicker.TabIndex = 11;
            this.DeadlinePicker.Value = new System.DateTime(2025, 3, 20, 0, 0, 0, 0);
            // 
            // SearchStatues
            // 
            this.SearchStatues.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchStatues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchStatues.FlatAppearance.BorderSize = 0;
            this.SearchStatues.Location = new System.Drawing.Point(446, 298);
            this.SearchStatues.Name = "SearchStatues";
            this.SearchStatues.Size = new System.Drawing.Size(24, 25);
            this.SearchStatues.TabIndex = 23;
            this.SearchStatues.UseVisualStyleBackColor = true;
            this.SearchStatues.Click += new System.EventHandler(this.SearchStatues_Click);
            // 
            // SearchDescription
            // 
            this.SearchDescription.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchDescription.FlatAppearance.BorderSize = 0;
            this.SearchDescription.Location = new System.Drawing.Point(446, 183);
            this.SearchDescription.Name = "SearchDescription";
            this.SearchDescription.Size = new System.Drawing.Size(24, 25);
            this.SearchDescription.TabIndex = 21;
            this.SearchDescription.UseVisualStyleBackColor = true;
            this.SearchDescription.Click += new System.EventHandler(this.SearchDescription_Click);
            // 
            // SearchDeadline
            // 
            this.SearchDeadline.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchDeadline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchDeadline.FlatAppearance.BorderSize = 0;
            this.SearchDeadline.Location = new System.Drawing.Point(446, 249);
            this.SearchDeadline.Name = "SearchDeadline";
            this.SearchDeadline.Size = new System.Drawing.Size(24, 25);
            this.SearchDeadline.TabIndex = 20;
            this.SearchDeadline.UseVisualStyleBackColor = true;
            this.SearchDeadline.Click += new System.EventHandler(this.SearchDeadline_Click);
            // 
            // ShowStatusesButton
            // 
            this.ShowStatusesButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ShowStatusesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowStatusesButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowStatusesButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowStatusesButton.Location = new System.Drawing.Point(294, 296);
            this.ShowStatusesButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowStatusesButton.Name = "ShowStatusesButton";
            this.ShowStatusesButton.Size = new System.Drawing.Size(130, 27);
            this.ShowStatusesButton.TabIndex = 12;
            this.ShowStatusesButton.Text = "Show Statuses";
            this.ShowStatusesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowStatusesButton.UseVisualStyleBackColor = false;
            this.ShowStatusesButton.Click += new System.EventHandler(this.ShowStatusesButton_Click);
            // 
            // StatusIDComboBox
            // 
            this.StatusIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusIDComboBox.FormattingEnabled = true;
            this.StatusIDComboBox.Location = new System.Drawing.Point(152, 297);
            this.StatusIDComboBox.Name = "StatusIDComboBox";
            this.StatusIDComboBox.Size = new System.Drawing.Size(137, 26);
            this.StatusIDComboBox.TabIndex = 4;
            // 
            // ITECIDLabel
            // 
            this.ITECIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ITECIDLabel.AutoSize = true;
            this.ITECIDLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITECIDLabel.ForeColor = System.Drawing.Color.Black;
            this.ITECIDLabel.Location = new System.Drawing.Point(61, 300);
            this.ITECIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ITECIDLabel.Name = "ITECIDLabel";
            this.ITECIDLabel.Size = new System.Drawing.Size(86, 23);
            this.ITECIDLabel.TabIndex = 9;
            this.ITECIDLabel.Text = "Status ID:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Description:";
            // 
            // IDErrorLabel
            // 
            this.IDErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDErrorLabel.AutoSize = true;
            this.IDErrorLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.IDErrorLabel.Location = new System.Drawing.Point(295, 43);
            this.IDErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDErrorLabel.Name = "IDErrorLabel";
            this.IDErrorLabel.Size = new System.Drawing.Size(136, 17);
            this.IDErrorLabel.TabIndex = 8;
            this.IDErrorLabel.Text = "ID can only be numeric";
            this.IDErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.IDErrorLabel.Visible = false;
            // 
            // LabelDutyID
            // 
            this.LabelDutyID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDutyID.AutoSize = true;
            this.LabelDutyID.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDutyID.ForeColor = System.Drawing.Color.Black;
            this.LabelDutyID.Location = new System.Drawing.Point(75, 17);
            this.LabelDutyID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelDutyID.Name = "LabelDutyID";
            this.LabelDutyID.Size = new System.Drawing.Size(74, 23);
            this.LabelDutyID.TabIndex = 0;
            this.LabelDutyID.Text = "Duty ID:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.ForeColor = System.Drawing.Color.Gray;
            this.IDTextBox.Location = new System.Drawing.Point(153, 17);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(278, 24);
            this.IDTextBox.TabIndex = 11;
            this.IDTextBox.TabStop = false;
            this.IDTextBox.Text = "auto increment";
            this.IDTextBox.Click += new System.EventHandler(this.IDTextBox_Click);
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            this.IDTextBox.Leave += new System.EventHandler(this.IDTextBox_Leave);
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.Black;
            this.EmailLabel.Location = new System.Drawing.Point(61, 249);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(86, 23);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Deadline:";
            // 
            // DataGrid
            // 
            this.DataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(809, 158);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(601, 638);
            this.DataGrid.TabIndex = 25;
            this.DataGrid.DoubleClick += new System.EventHandler(this.DataGrid_DoubleClick);
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
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
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
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
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
            this.RetrieveButton.Click += new System.EventHandler(this.RetrieveButton_Click);
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
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
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
            this.ButtonsPanel.Location = new System.Drawing.Point(247, 581);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(499, 189);
            this.ButtonsPanel.TabIndex = 24;
            // 
            // DutiesHeading
            // 
            this.DutiesHeading.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.DutiesHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DutiesHeading.AutoSize = true;
            this.DutiesHeading.Font = new System.Drawing.Font("Product Sans Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DutiesHeading.ForeColor = System.Drawing.Color.Tomato;
            this.DutiesHeading.Location = new System.Drawing.Point(721, 37);
            this.DutiesHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DutiesHeading.Name = "DutiesHeading";
            this.DutiesHeading.Size = new System.Drawing.Size(146, 51);
            this.DutiesHeading.TabIndex = 0;
            this.DutiesHeading.Text = "Duties";
            this.DutiesHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelAssignedTo
            // 
            this.LabelAssignedTo.Controls.Add(this.DutiesHeading);
            this.LabelAssignedTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelAssignedTo.Location = new System.Drawing.Point(0, 0);
            this.LabelAssignedTo.Name = "LabelAssignedTo";
            this.LabelAssignedTo.Size = new System.Drawing.Size(1731, 95);
            this.LabelAssignedTo.TabIndex = 26;
            // 
            // DataPanel
            // 
            this.DataPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataPanel.Controls.Add(this.ShowRolesButton);
            this.DataPanel.Controls.Add(this.AssignedToComboBox);
            this.DataPanel.Controls.Add(this.SearchCommitteeID);
            this.DataPanel.Controls.Add(this.ShowCommitteesButton);
            this.DataPanel.Controls.Add(this.CommitteeIDComboBox);
            this.DataPanel.Controls.Add(this.label2);
            this.DataPanel.Controls.Add(this.DescriptionTextBox);
            this.DataPanel.Controls.Add(this.DeadlinePicker);
            this.DataPanel.Controls.Add(this.SearchStatues);
            this.DataPanel.Controls.Add(this.SearchDescription);
            this.DataPanel.Controls.Add(this.SearchDeadline);
            this.DataPanel.Controls.Add(this.SearchAssignedToRoles);
            this.DataPanel.Controls.Add(this.ShowStatusesButton);
            this.DataPanel.Controls.Add(this.StatusIDComboBox);
            this.DataPanel.Controls.Add(this.ITECIDLabel);
            this.DataPanel.Controls.Add(this.label3);
            this.DataPanel.Controls.Add(this.IDErrorLabel);
            this.DataPanel.Controls.Add(this.LabelDutyID);
            this.DataPanel.Controls.Add(this.NameLabel);
            this.DataPanel.Controls.Add(this.IDTextBox);
            this.DataPanel.Controls.Add(this.EmailLabel);
            this.DataPanel.Location = new System.Drawing.Point(247, 158);
            this.DataPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(499, 397);
            this.DataPanel.TabIndex = 23;
            // 
            // ShowRolesButton
            // 
            this.ShowRolesButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ShowRolesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowRolesButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowRolesButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowRolesButton.Location = new System.Drawing.Point(295, 112);
            this.ShowRolesButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowRolesButton.Name = "ShowRolesButton";
            this.ShowRolesButton.Size = new System.Drawing.Size(130, 27);
            this.ShowRolesButton.TabIndex = 35;
            this.ShowRolesButton.Text = "Show Roles";
            this.ShowRolesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowRolesButton.UseVisualStyleBackColor = false;
            this.ShowRolesButton.Click += new System.EventHandler(this.ShowRolesButton_Click);
            // 
            // AssignedToComboBox
            // 
            this.AssignedToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AssignedToComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignedToComboBox.FormattingEnabled = true;
            this.AssignedToComboBox.Location = new System.Drawing.Point(152, 112);
            this.AssignedToComboBox.Name = "AssignedToComboBox";
            this.AssignedToComboBox.Size = new System.Drawing.Size(138, 26);
            this.AssignedToComboBox.TabIndex = 34;
            this.AssignedToComboBox.SelectedIndexChanged += new System.EventHandler(this.AssignedToComboBox_SelectedIndexChanged);
            // 
            // SearchAssignedToRoles
            // 
            this.SearchAssignedToRoles.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchAssignedToRoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchAssignedToRoles.FlatAppearance.BorderSize = 0;
            this.SearchAssignedToRoles.Location = new System.Drawing.Point(447, 112);
            this.SearchAssignedToRoles.Name = "SearchAssignedToRoles";
            this.SearchAssignedToRoles.Size = new System.Drawing.Size(24, 25);
            this.SearchAssignedToRoles.TabIndex = 19;
            this.SearchAssignedToRoles.UseVisualStyleBackColor = true;
            this.SearchAssignedToRoles.Click += new System.EventHandler(this.SearchAssignedToRoles_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.Black;
            this.NameLabel.Location = new System.Drawing.Point(35, 114);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(112, 23);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Assigned to*";
            // 
            // Duties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1731, 853);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.LabelAssignedTo);
            this.Controls.Add(this.DataPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Duties";
            this.Text = "Duties";
            this.Load += new System.EventHandler(this.Duties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            this.LabelAssignedTo.ResumeLayout(false);
            this.LabelAssignedTo.PerformLayout();
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchCommitteeID;
        private System.Windows.Forms.Button ShowCommitteesButton;
        private System.Windows.Forms.ComboBox CommitteeIDComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.DateTimePicker DeadlinePicker;
        private System.Windows.Forms.Button SearchStatues;
        private System.Windows.Forms.Button SearchDescription;
        private System.Windows.Forms.Button SearchDeadline;
        private System.Windows.Forms.Button ShowStatusesButton;
        private System.Windows.Forms.ComboBox StatusIDComboBox;
        private System.Windows.Forms.Label ITECIDLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IDErrorLabel;
        private System.Windows.Forms.Label LabelDutyID;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button RetrieveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Label DutiesHeading;
        private System.Windows.Forms.Panel LabelAssignedTo;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Button SearchAssignedToRoles;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button ShowRolesButton;
        private System.Windows.Forms.ComboBox AssignedToComboBox;
    }
}