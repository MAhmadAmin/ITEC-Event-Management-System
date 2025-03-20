namespace ITEC_Event_Management_System
{
    partial class Events
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.EventsHeading = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RetrieveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.SearchCategoryID = new System.Windows.Forms.Button();
            this.SearchITECID = new System.Windows.Forms.Button();
            this.SearchDescription = new System.Windows.Forms.Button();
            this.SearchDate = new System.Windows.Forms.Button();
            this.SearchName = new System.Windows.Forms.Button();
            this.ShowCategoriesButton = new System.Windows.Forms.Button();
            this.ShowEditionsButton = new System.Windows.Forms.Button();
            this.CategoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ITECIDComboBox = new System.Windows.Forms.ComboBox();
            this.ITECIDLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ParticipantErrorLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.EventIDLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.SearchCommitteeID = new System.Windows.Forms.Button();
            this.SearchVenueID = new System.Windows.Forms.Button();
            this.ShowCommitteesButton = new System.Windows.Forms.Button();
            this.ShowVenuesButton = new System.Windows.Forms.Button();
            this.CommitteeIDComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VenueIDComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.DataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EventsHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 95);
            this.panel1.TabIndex = 22;
            // 
            // EventsHeading
            // 
            this.EventsHeading.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.EventsHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EventsHeading.AutoSize = true;
            this.EventsHeading.Font = new System.Drawing.Font("Product Sans Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsHeading.ForeColor = System.Drawing.Color.Tomato;
            this.EventsHeading.Location = new System.Drawing.Point(556, 37);
            this.EventsHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EventsHeading.Name = "EventsHeading";
            this.EventsHeading.Size = new System.Drawing.Size(150, 51);
            this.EventsHeading.TabIndex = 0;
            this.EventsHeading.Text = "Events";
            this.EventsHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ButtonsPanel.Location = new System.Drawing.Point(207, 601);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(499, 189);
            this.ButtonsPanel.TabIndex = 20;
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
            // DataGrid
            // 
            this.DataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(769, 119);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(601, 638);
            this.DataGrid.TabIndex = 21;
            // 
            // DataPanel
            // 
            this.DataPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataPanel.Controls.Add(this.SearchCommitteeID);
            this.DataPanel.Controls.Add(this.SearchVenueID);
            this.DataPanel.Controls.Add(this.ShowCommitteesButton);
            this.DataPanel.Controls.Add(this.ShowVenuesButton);
            this.DataPanel.Controls.Add(this.CommitteeIDComboBox);
            this.DataPanel.Controls.Add(this.label2);
            this.DataPanel.Controls.Add(this.VenueIDComboBox);
            this.DataPanel.Controls.Add(this.label4);
            this.DataPanel.Controls.Add(this.LocationTextBox);
            this.DataPanel.Controls.Add(this.DatePicker);
            this.DataPanel.Controls.Add(this.SearchCategoryID);
            this.DataPanel.Controls.Add(this.SearchITECID);
            this.DataPanel.Controls.Add(this.SearchDescription);
            this.DataPanel.Controls.Add(this.SearchDate);
            this.DataPanel.Controls.Add(this.SearchName);
            this.DataPanel.Controls.Add(this.ShowCategoriesButton);
            this.DataPanel.Controls.Add(this.ShowEditionsButton);
            this.DataPanel.Controls.Add(this.CategoryIDComboBox);
            this.DataPanel.Controls.Add(this.label5);
            this.DataPanel.Controls.Add(this.ITECIDComboBox);
            this.DataPanel.Controls.Add(this.ITECIDLabel);
            this.DataPanel.Controls.Add(this.label3);
            this.DataPanel.Controls.Add(this.ParticipantErrorLabel);
            this.DataPanel.Controls.Add(this.ErrorLabel);
            this.DataPanel.Controls.Add(this.EventIDLabel);
            this.DataPanel.Controls.Add(this.NameTextBox);
            this.DataPanel.Controls.Add(this.NameLabel);
            this.DataPanel.Controls.Add(this.IDTextBox);
            this.DataPanel.Controls.Add(this.EmailLabel);
            this.DataPanel.Location = new System.Drawing.Point(207, 119);
            this.DataPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(499, 476);
            this.DataPanel.TabIndex = 19;
            // 
            // SearchCategoryID
            // 
            this.SearchCategoryID.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchCategoryID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchCategoryID.FlatAppearance.BorderSize = 0;
            this.SearchCategoryID.Location = new System.Drawing.Point(447, 325);
            this.SearchCategoryID.Name = "SearchCategoryID";
            this.SearchCategoryID.Size = new System.Drawing.Size(24, 25);
            this.SearchCategoryID.TabIndex = 24;
            this.SearchCategoryID.UseVisualStyleBackColor = true;
            // 
            // SearchITECID
            // 
            this.SearchITECID.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchITECID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchITECID.FlatAppearance.BorderSize = 0;
            this.SearchITECID.Location = new System.Drawing.Point(447, 272);
            this.SearchITECID.Name = "SearchITECID";
            this.SearchITECID.Size = new System.Drawing.Size(24, 25);
            this.SearchITECID.TabIndex = 23;
            this.SearchITECID.UseVisualStyleBackColor = true;
            // 
            // SearchDescription
            // 
            this.SearchDescription.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchDescription.FlatAppearance.BorderSize = 0;
            this.SearchDescription.Location = new System.Drawing.Point(447, 201);
            this.SearchDescription.Name = "SearchDescription";
            this.SearchDescription.Size = new System.Drawing.Size(24, 25);
            this.SearchDescription.TabIndex = 21;
            this.SearchDescription.UseVisualStyleBackColor = true;
            this.SearchDescription.Click += new System.EventHandler(this.button3_Click);
            // 
            // SearchDate
            // 
            this.SearchDate.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchDate.FlatAppearance.BorderSize = 0;
            this.SearchDate.Location = new System.Drawing.Point(447, 121);
            this.SearchDate.Name = "SearchDate";
            this.SearchDate.Size = new System.Drawing.Size(24, 25);
            this.SearchDate.TabIndex = 20;
            this.SearchDate.UseVisualStyleBackColor = true;
            // 
            // SearchName
            // 
            this.SearchName.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchName.FlatAppearance.BorderSize = 0;
            this.SearchName.Location = new System.Drawing.Point(447, 70);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(24, 25);
            this.SearchName.TabIndex = 19;
            this.SearchName.UseVisualStyleBackColor = true;
            // 
            // ShowCategoriesButton
            // 
            this.ShowCategoriesButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ShowCategoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowCategoriesButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCategoriesButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowCategoriesButton.Location = new System.Drawing.Point(296, 323);
            this.ShowCategoriesButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowCategoriesButton.Name = "ShowCategoriesButton";
            this.ShowCategoriesButton.Size = new System.Drawing.Size(130, 27);
            this.ShowCategoriesButton.TabIndex = 13;
            this.ShowCategoriesButton.Text = "Show Categories";
            this.ShowCategoriesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowCategoriesButton.UseVisualStyleBackColor = false;
            // 
            // ShowEditionsButton
            // 
            this.ShowEditionsButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ShowEditionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowEditionsButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowEditionsButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowEditionsButton.Location = new System.Drawing.Point(295, 270);
            this.ShowEditionsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowEditionsButton.Name = "ShowEditionsButton";
            this.ShowEditionsButton.Size = new System.Drawing.Size(130, 27);
            this.ShowEditionsButton.TabIndex = 12;
            this.ShowEditionsButton.Text = "Show Editions";
            this.ShowEditionsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowEditionsButton.UseVisualStyleBackColor = false;
            // 
            // CategoryIDComboBox
            // 
            this.CategoryIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryIDComboBox.FormattingEnabled = true;
            this.CategoryIDComboBox.Location = new System.Drawing.Point(153, 323);
            this.CategoryIDComboBox.Name = "CategoryIDComboBox";
            this.CategoryIDComboBox.Size = new System.Drawing.Size(138, 26);
            this.CategoryIDComboBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(2, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Event Category ID:";
            // 
            // ITECIDComboBox
            // 
            this.ITECIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ITECIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITECIDComboBox.FormattingEnabled = true;
            this.ITECIDComboBox.Location = new System.Drawing.Point(153, 271);
            this.ITECIDComboBox.Name = "ITECIDComboBox";
            this.ITECIDComboBox.Size = new System.Drawing.Size(137, 26);
            this.ITECIDComboBox.TabIndex = 4;
            // 
            // ITECIDLabel
            // 
            this.ITECIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ITECIDLabel.AutoSize = true;
            this.ITECIDLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITECIDLabel.ForeColor = System.Drawing.Color.Black;
            this.ITECIDLabel.Location = new System.Drawing.Point(79, 274);
            this.ITECIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ITECIDLabel.Name = "ITECIDLabel";
            this.ITECIDLabel.Size = new System.Drawing.Size(69, 23);
            this.ITECIDLabel.TabIndex = 9;
            this.ITECIDLabel.Text = "ITEC ID:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(43, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Description:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ParticipantErrorLabel
            // 
            this.ParticipantErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParticipantErrorLabel.AutoSize = true;
            this.ParticipantErrorLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParticipantErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ParticipantErrorLabel.Location = new System.Drawing.Point(295, 38);
            this.ParticipantErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ParticipantErrorLabel.Name = "ParticipantErrorLabel";
            this.ParticipantErrorLabel.Size = new System.Drawing.Size(136, 17);
            this.ParticipantErrorLabel.TabIndex = 8;
            this.ParticipantErrorLabel.Text = "ID can only be numeric";
            this.ParticipantErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ParticipantErrorLabel.Visible = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Black;
            this.ErrorLabel.Location = new System.Drawing.Point(188, 334);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 19);
            this.ErrorLabel.TabIndex = 8;
            // 
            // EventIDLabel
            // 
            this.EventIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventIDLabel.AutoSize = true;
            this.EventIDLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventIDLabel.ForeColor = System.Drawing.Color.Black;
            this.EventIDLabel.Location = new System.Drawing.Point(68, 13);
            this.EventIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EventIDLabel.Name = "EventIDLabel";
            this.EventIDLabel.Size = new System.Drawing.Size(81, 23);
            this.EventIDLabel.TabIndex = 0;
            this.EventIDLabel.Text = "Event ID:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(153, 71);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(278, 24);
            this.NameTextBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.Black;
            this.NameLabel.Location = new System.Drawing.Point(34, 72);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(115, 23);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Event Name*";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.ForeColor = System.Drawing.Color.Gray;
            this.IDTextBox.Location = new System.Drawing.Point(153, 12);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(278, 24);
            this.IDTextBox.TabIndex = 11;
            this.IDTextBox.TabStop = false;
            this.IDTextBox.Text = "auto increment";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.Black;
            this.EmailLabel.Location = new System.Drawing.Point(95, 124);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(53, 23);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Date:";
            // 
            // DatePicker
            // 
            this.DatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Location = new System.Drawing.Point(153, 123);
            this.DatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DatePicker.MinimumSize = new System.Drawing.Size(200, 24);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DatePicker.Size = new System.Drawing.Size(278, 24);
            this.DatePicker.TabIndex = 11;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.AcceptsReturn = true;
            this.LocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationTextBox.Location = new System.Drawing.Point(153, 173);
            this.LocationTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.LocationTextBox.Multiline = true;
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LocationTextBox.Size = new System.Drawing.Size(278, 72);
            this.LocationTextBox.TabIndex = 25;
            this.LocationTextBox.TextChanged += new System.EventHandler(this.LocationTextBox_TextChanged);
            // 
            // SearchCommitteeID
            // 
            this.SearchCommitteeID.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchCommitteeID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchCommitteeID.FlatAppearance.BorderSize = 0;
            this.SearchCommitteeID.Location = new System.Drawing.Point(447, 428);
            this.SearchCommitteeID.Name = "SearchCommitteeID";
            this.SearchCommitteeID.Size = new System.Drawing.Size(24, 25);
            this.SearchCommitteeID.TabIndex = 33;
            this.SearchCommitteeID.UseVisualStyleBackColor = true;
            // 
            // SearchVenueID
            // 
            this.SearchVenueID.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchVenueID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchVenueID.FlatAppearance.BorderSize = 0;
            this.SearchVenueID.Location = new System.Drawing.Point(447, 375);
            this.SearchVenueID.Name = "SearchVenueID";
            this.SearchVenueID.Size = new System.Drawing.Size(24, 25);
            this.SearchVenueID.TabIndex = 32;
            this.SearchVenueID.UseVisualStyleBackColor = true;
            // 
            // ShowCommitteesButton
            // 
            this.ShowCommitteesButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ShowCommitteesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowCommitteesButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCommitteesButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowCommitteesButton.Location = new System.Drawing.Point(296, 426);
            this.ShowCommitteesButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowCommitteesButton.Name = "ShowCommitteesButton";
            this.ShowCommitteesButton.Size = new System.Drawing.Size(130, 27);
            this.ShowCommitteesButton.TabIndex = 30;
            this.ShowCommitteesButton.Text = "Show Committees";
            this.ShowCommitteesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowCommitteesButton.UseVisualStyleBackColor = false;
            // 
            // ShowVenuesButton
            // 
            this.ShowVenuesButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ShowVenuesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowVenuesButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowVenuesButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowVenuesButton.Location = new System.Drawing.Point(295, 373);
            this.ShowVenuesButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowVenuesButton.Name = "ShowVenuesButton";
            this.ShowVenuesButton.Size = new System.Drawing.Size(130, 27);
            this.ShowVenuesButton.TabIndex = 29;
            this.ShowVenuesButton.Text = "Show Venues";
            this.ShowVenuesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowVenuesButton.UseVisualStyleBackColor = false;
            // 
            // CommitteeIDComboBox
            // 
            this.CommitteeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CommitteeIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitteeIDComboBox.FormattingEnabled = true;
            this.CommitteeIDComboBox.Location = new System.Drawing.Point(153, 426);
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
            this.label2.Location = new System.Drawing.Point(25, 430);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Committee ID:";
            // 
            // VenueIDComboBox
            // 
            this.VenueIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VenueIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenueIDComboBox.FormattingEnabled = true;
            this.VenueIDComboBox.Location = new System.Drawing.Point(153, 374);
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
            this.label4.Location = new System.Drawing.Point(62, 377);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Venue ID:";
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1400, 850);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.DataPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Events";
            this.Text = "Events";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EventsHeading;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button RetrieveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Button SearchCategoryID;
        private System.Windows.Forms.Button SearchITECID;
        private System.Windows.Forms.Button SearchDescription;
        private System.Windows.Forms.Button SearchDate;
        private System.Windows.Forms.Button SearchName;
        private System.Windows.Forms.Button ShowCategoriesButton;
        private System.Windows.Forms.Button ShowEditionsButton;
        private System.Windows.Forms.ComboBox CategoryIDComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ITECIDComboBox;
        private System.Windows.Forms.Label ITECIDLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ParticipantErrorLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label EventIDLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Button SearchCommitteeID;
        private System.Windows.Forms.Button SearchVenueID;
        private System.Windows.Forms.Button ShowCommitteesButton;
        private System.Windows.Forms.Button ShowVenuesButton;
        private System.Windows.Forms.ComboBox CommitteeIDComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox VenueIDComboBox;
        private System.Windows.Forms.Label label4;
    }
}