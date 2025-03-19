namespace ITEC_Event_Management_System
{
    partial class CommitteesAndMembers
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
            this.Heading = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CommitteeSuccessLabel = new System.Windows.Forms.Label();
            this.CommitteeShowAllButton = new System.Windows.Forms.Button();
            this.CommitteeDeleteButton = new System.Windows.Forms.Button();
            this.CommitteeUpdateButton = new System.Windows.Forms.Button();
            this.CommitteeRetrieveButton = new System.Windows.Forms.Button();
            this.CommitteeAddButton = new System.Windows.Forms.Button();
            this.CommitteeDataGrid = new System.Windows.Forms.DataGridView();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.ITECIDSearch = new System.Windows.Forms.Button();
            this.CommitteeNameSearch = new System.Windows.Forms.Button();
            this.ShowEditionsButton = new System.Windows.Forms.Button();
            this.ITECIDComboBox = new System.Windows.Forms.ComboBox();
            this.ITECIDLabel = new System.Windows.Forms.Label();
            this.CommitteeIDErrorLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.CommitteeIDLabel = new System.Windows.Forms.Label();
            this.CommitteeNameTextBox = new System.Windows.Forms.TextBox();
            this.CommitteeNameLabel = new System.Windows.Forms.Label();
            this.CommitteeIDTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MemberSuccessLabel = new System.Windows.Forms.Label();
            this.MemberShowAllButton = new System.Windows.Forms.Button();
            this.MemberDeleteButton = new System.Windows.Forms.Button();
            this.MemberUpdateButton = new System.Windows.Forms.Button();
            this.MemberRetrieveButton = new System.Windows.Forms.Button();
            this.MemberAddButton = new System.Windows.Forms.Button();
            this.MemberDataGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CommitteeIDSearch = new System.Windows.Forms.Button();
            this.MemberNameSearch = new System.Windows.Forms.Button();
            this.MemberShowAllCommittees = new System.Windows.Forms.Button();
            this.CommitteeIDComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MemberIDErrorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MemberIDLabel = new System.Windows.Forms.Label();
            this.MemberNameTextBox = new System.Windows.Forms.TextBox();
            this.MemberNameLabel = new System.Windows.Forms.Label();
            this.MemberIDTextBox = new System.Windows.Forms.TextBox();
            this.RoleIDSearch = new System.Windows.Forms.Button();
            this.MemberShowAllRoles = new System.Windows.Forms.Button();
            this.RoleIDComboBox = new System.Windows.Forms.ComboBox();
            this.RoleIDLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommitteeDataGrid)).BeginInit();
            this.DataPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberDataGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Heading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 72);
            this.panel1.TabIndex = 19;
            // 
            // Heading
            // 
            this.Heading.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.Heading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Product Sans Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.ForeColor = System.Drawing.Color.LimeGreen;
            this.Heading.Location = new System.Drawing.Point(534, 9);
            this.Heading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(232, 51);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "Committee";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonsPanel.Controls.Add(this.label1);
            this.ButtonsPanel.Controls.Add(this.CommitteeSuccessLabel);
            this.ButtonsPanel.Controls.Add(this.CommitteeShowAllButton);
            this.ButtonsPanel.Controls.Add(this.CommitteeDeleteButton);
            this.ButtonsPanel.Controls.Add(this.CommitteeUpdateButton);
            this.ButtonsPanel.Controls.Add(this.CommitteeRetrieveButton);
            this.ButtonsPanel.Controls.Add(this.CommitteeAddButton);
            this.ButtonsPanel.Location = new System.Drawing.Point(116, 244);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(499, 155);
            this.ButtonsPanel.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Message:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CommitteeSuccessLabel
            // 
            this.CommitteeSuccessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommitteeSuccessLabel.AutoSize = true;
            this.CommitteeSuccessLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitteeSuccessLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.CommitteeSuccessLabel.Location = new System.Drawing.Point(81, 121);
            this.CommitteeSuccessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CommitteeSuccessLabel.Name = "CommitteeSuccessLabel";
            this.CommitteeSuccessLabel.Size = new System.Drawing.Size(38, 17);
            this.CommitteeSuccessLabel.TabIndex = 10;
            this.CommitteeSuccessLabel.Text = "None";
            this.CommitteeSuccessLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CommitteeShowAllButton
            // 
            this.CommitteeShowAllButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CommitteeShowAllButton.BackColor = System.Drawing.Color.SteelBlue;
            this.CommitteeShowAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommitteeShowAllButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitteeShowAllButton.ForeColor = System.Drawing.Color.Transparent;
            this.CommitteeShowAllButton.Location = new System.Drawing.Point(191, 64);
            this.CommitteeShowAllButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CommitteeShowAllButton.Name = "CommitteeShowAllButton";
            this.CommitteeShowAllButton.Size = new System.Drawing.Size(121, 33);
            this.CommitteeShowAllButton.TabIndex = 10;
            this.CommitteeShowAllButton.Text = "Show All";
            this.CommitteeShowAllButton.UseVisualStyleBackColor = false;
            this.CommitteeShowAllButton.Click += new System.EventHandler(this.CommitteeShowAllButton_Click);
            // 
            // CommitteeDeleteButton
            // 
            this.CommitteeDeleteButton.BackColor = System.Drawing.Color.Brown;
            this.CommitteeDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommitteeDeleteButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitteeDeleteButton.ForeColor = System.Drawing.Color.Transparent;
            this.CommitteeDeleteButton.Location = new System.Drawing.Point(376, 11);
            this.CommitteeDeleteButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CommitteeDeleteButton.Name = "CommitteeDeleteButton";
            this.CommitteeDeleteButton.Size = new System.Drawing.Size(98, 33);
            this.CommitteeDeleteButton.TabIndex = 9;
            this.CommitteeDeleteButton.Text = "Delete";
            this.CommitteeDeleteButton.UseVisualStyleBackColor = false;
            this.CommitteeDeleteButton.Click += new System.EventHandler(this.CommitteeDeleteButton_Click);
            // 
            // CommitteeUpdateButton
            // 
            this.CommitteeUpdateButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CommitteeUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommitteeUpdateButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitteeUpdateButton.ForeColor = System.Drawing.Color.Transparent;
            this.CommitteeUpdateButton.Location = new System.Drawing.Point(260, 11);
            this.CommitteeUpdateButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CommitteeUpdateButton.Name = "CommitteeUpdateButton";
            this.CommitteeUpdateButton.Size = new System.Drawing.Size(98, 33);
            this.CommitteeUpdateButton.TabIndex = 8;
            this.CommitteeUpdateButton.Text = "Update";
            this.CommitteeUpdateButton.UseVisualStyleBackColor = false;
            this.CommitteeUpdateButton.Click += new System.EventHandler(this.CommitteeUpdateButton_Click);
            // 
            // CommitteeRetrieveButton
            // 
            this.CommitteeRetrieveButton.BackColor = System.Drawing.Color.Peru;
            this.CommitteeRetrieveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommitteeRetrieveButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitteeRetrieveButton.ForeColor = System.Drawing.Color.Transparent;
            this.CommitteeRetrieveButton.Location = new System.Drawing.Point(140, 11);
            this.CommitteeRetrieveButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CommitteeRetrieveButton.Name = "CommitteeRetrieveButton";
            this.CommitteeRetrieveButton.Size = new System.Drawing.Size(98, 33);
            this.CommitteeRetrieveButton.TabIndex = 7;
            this.CommitteeRetrieveButton.Text = "Retrieve";
            this.CommitteeRetrieveButton.UseVisualStyleBackColor = false;
            this.CommitteeRetrieveButton.Click += new System.EventHandler(this.CommitteeRetrieveButton_Click);
            // 
            // CommitteeAddButton
            // 
            this.CommitteeAddButton.BackColor = System.Drawing.Color.ForestGreen;
            this.CommitteeAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommitteeAddButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitteeAddButton.ForeColor = System.Drawing.Color.White;
            this.CommitteeAddButton.Location = new System.Drawing.Point(16, 11);
            this.CommitteeAddButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CommitteeAddButton.Name = "CommitteeAddButton";
            this.CommitteeAddButton.Size = new System.Drawing.Size(98, 33);
            this.CommitteeAddButton.TabIndex = 6;
            this.CommitteeAddButton.Text = "Add";
            this.CommitteeAddButton.UseVisualStyleBackColor = false;
            this.CommitteeAddButton.Click += new System.EventHandler(this.CommitteeAddButton_Click);
            // 
            // CommitteeDataGrid
            // 
            this.CommitteeDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CommitteeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CommitteeDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CommitteeDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CommitteeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CommitteeDataGrid.Location = new System.Drawing.Point(678, 78);
            this.CommitteeDataGrid.Name = "CommitteeDataGrid";
            this.CommitteeDataGrid.Size = new System.Drawing.Size(601, 316);
            this.CommitteeDataGrid.TabIndex = 22;
            this.CommitteeDataGrid.DoubleClick += new System.EventHandler(this.CommitteeDataGrid_DoubleClick);
            // 
            // DataPanel
            // 
            this.DataPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataPanel.Controls.Add(this.ITECIDSearch);
            this.DataPanel.Controls.Add(this.CommitteeNameSearch);
            this.DataPanel.Controls.Add(this.ShowEditionsButton);
            this.DataPanel.Controls.Add(this.ITECIDComboBox);
            this.DataPanel.Controls.Add(this.ITECIDLabel);
            this.DataPanel.Controls.Add(this.CommitteeIDErrorLabel);
            this.DataPanel.Controls.Add(this.ErrorLabel);
            this.DataPanel.Controls.Add(this.CommitteeIDLabel);
            this.DataPanel.Controls.Add(this.CommitteeNameTextBox);
            this.DataPanel.Controls.Add(this.CommitteeNameLabel);
            this.DataPanel.Controls.Add(this.CommitteeIDTextBox);
            this.DataPanel.Location = new System.Drawing.Point(116, 78);
            this.DataPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(499, 150);
            this.DataPanel.TabIndex = 20;
            // 
            // ITECIDSearch
            // 
            this.ITECIDSearch.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.ITECIDSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ITECIDSearch.FlatAppearance.BorderSize = 0;
            this.ITECIDSearch.Location = new System.Drawing.Point(448, 105);
            this.ITECIDSearch.Name = "ITECIDSearch";
            this.ITECIDSearch.Size = new System.Drawing.Size(24, 25);
            this.ITECIDSearch.TabIndex = 23;
            this.ITECIDSearch.UseVisualStyleBackColor = true;
            this.ITECIDSearch.Click += new System.EventHandler(this.ITECIDSearch_Click);
            // 
            // CommitteeNameSearch
            // 
            this.CommitteeNameSearch.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.CommitteeNameSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CommitteeNameSearch.FlatAppearance.BorderSize = 0;
            this.CommitteeNameSearch.Location = new System.Drawing.Point(447, 60);
            this.CommitteeNameSearch.Name = "CommitteeNameSearch";
            this.CommitteeNameSearch.Size = new System.Drawing.Size(24, 25);
            this.CommitteeNameSearch.TabIndex = 19;
            this.CommitteeNameSearch.UseVisualStyleBackColor = true;
            this.CommitteeNameSearch.Click += new System.EventHandler(this.CommitteeNameSearch_Click);
            // 
            // ShowEditionsButton
            // 
            this.ShowEditionsButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ShowEditionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowEditionsButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowEditionsButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowEditionsButton.Location = new System.Drawing.Point(296, 103);
            this.ShowEditionsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowEditionsButton.Name = "ShowEditionsButton";
            this.ShowEditionsButton.Size = new System.Drawing.Size(130, 27);
            this.ShowEditionsButton.TabIndex = 12;
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
            this.ITECIDComboBox.Location = new System.Drawing.Point(154, 104);
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
            this.ITECIDLabel.Location = new System.Drawing.Point(80, 107);
            this.ITECIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ITECIDLabel.Name = "ITECIDLabel";
            this.ITECIDLabel.Size = new System.Drawing.Size(69, 23);
            this.ITECIDLabel.TabIndex = 9;
            this.ITECIDLabel.Text = "ITEC ID:";
            // 
            // CommitteeIDErrorLabel
            // 
            this.CommitteeIDErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommitteeIDErrorLabel.AutoSize = true;
            this.CommitteeIDErrorLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitteeIDErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.CommitteeIDErrorLabel.Location = new System.Drawing.Point(295, 38);
            this.CommitteeIDErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CommitteeIDErrorLabel.Name = "CommitteeIDErrorLabel";
            this.CommitteeIDErrorLabel.Size = new System.Drawing.Size(136, 17);
            this.CommitteeIDErrorLabel.TabIndex = 8;
            this.CommitteeIDErrorLabel.Text = "ID can only be numeric";
            this.CommitteeIDErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CommitteeIDErrorLabel.Visible = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Black;
            this.ErrorLabel.Location = new System.Drawing.Point(188, 358);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 19);
            this.ErrorLabel.TabIndex = 8;
            // 
            // CommitteeIDLabel
            // 
            this.CommitteeIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommitteeIDLabel.AutoSize = true;
            this.CommitteeIDLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitteeIDLabel.ForeColor = System.Drawing.Color.Black;
            this.CommitteeIDLabel.Location = new System.Drawing.Point(29, 13);
            this.CommitteeIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CommitteeIDLabel.Name = "CommitteeIDLabel";
            this.CommitteeIDLabel.Size = new System.Drawing.Size(123, 23);
            this.CommitteeIDLabel.TabIndex = 0;
            this.CommitteeIDLabel.Text = "Committee ID:";
            // 
            // CommitteeNameTextBox
            // 
            this.CommitteeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitteeNameTextBox.Location = new System.Drawing.Point(153, 61);
            this.CommitteeNameTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CommitteeNameTextBox.Name = "CommitteeNameTextBox";
            this.CommitteeNameTextBox.Size = new System.Drawing.Size(278, 24);
            this.CommitteeNameTextBox.TabIndex = 0;
            this.CommitteeNameTextBox.TextChanged += new System.EventHandler(this.CommitteeNameTextBox_TextChanged);
            // 
            // CommitteeNameLabel
            // 
            this.CommitteeNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommitteeNameLabel.AutoSize = true;
            this.CommitteeNameLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitteeNameLabel.ForeColor = System.Drawing.Color.Black;
            this.CommitteeNameLabel.Location = new System.Drawing.Point(-4, 62);
            this.CommitteeNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CommitteeNameLabel.Name = "CommitteeNameLabel";
            this.CommitteeNameLabel.Size = new System.Drawing.Size(157, 23);
            this.CommitteeNameLabel.TabIndex = 0;
            this.CommitteeNameLabel.Text = "Committee Name*";
            // 
            // CommitteeIDTextBox
            // 
            this.CommitteeIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitteeIDTextBox.ForeColor = System.Drawing.Color.Gray;
            this.CommitteeIDTextBox.Location = new System.Drawing.Point(153, 12);
            this.CommitteeIDTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CommitteeIDTextBox.Name = "CommitteeIDTextBox";
            this.CommitteeIDTextBox.Size = new System.Drawing.Size(278, 24);
            this.CommitteeIDTextBox.TabIndex = 11;
            this.CommitteeIDTextBox.TabStop = false;
            this.CommitteeIDTextBox.Text = "auto increment";
            this.CommitteeIDTextBox.Click += new System.EventHandler(this.CommitteeIDTextBox_Click);
            this.CommitteeIDTextBox.TextChanged += new System.EventHandler(this.CommitteeIDTextBox_TextChanged);
            this.CommitteeIDTextBox.Leave += new System.EventHandler(this.CommitteeIDTextBox_Leave);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.MemberSuccessLabel);
            this.panel2.Controls.Add(this.MemberShowAllButton);
            this.panel2.Controls.Add(this.MemberDeleteButton);
            this.panel2.Controls.Add(this.MemberUpdateButton);
            this.panel2.Controls.Add(this.MemberRetrieveButton);
            this.panel2.Controls.Add(this.MemberAddButton);
            this.panel2.Location = new System.Drawing.Point(116, 705);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 155);
            this.panel2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Message:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MemberSuccessLabel
            // 
            this.MemberSuccessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemberSuccessLabel.AutoSize = true;
            this.MemberSuccessLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberSuccessLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.MemberSuccessLabel.Location = new System.Drawing.Point(81, 121);
            this.MemberSuccessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberSuccessLabel.Name = "MemberSuccessLabel";
            this.MemberSuccessLabel.Size = new System.Drawing.Size(38, 17);
            this.MemberSuccessLabel.TabIndex = 10;
            this.MemberSuccessLabel.Text = "None";
            this.MemberSuccessLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MemberShowAllButton
            // 
            this.MemberShowAllButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MemberShowAllButton.BackColor = System.Drawing.Color.SteelBlue;
            this.MemberShowAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberShowAllButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberShowAllButton.ForeColor = System.Drawing.Color.Transparent;
            this.MemberShowAllButton.Location = new System.Drawing.Point(191, 70);
            this.MemberShowAllButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MemberShowAllButton.Name = "MemberShowAllButton";
            this.MemberShowAllButton.Size = new System.Drawing.Size(121, 33);
            this.MemberShowAllButton.TabIndex = 10;
            this.MemberShowAllButton.Text = "Show All";
            this.MemberShowAllButton.UseVisualStyleBackColor = false;
            this.MemberShowAllButton.Click += new System.EventHandler(this.MemberShowAllButton_Click);
            // 
            // MemberDeleteButton
            // 
            this.MemberDeleteButton.BackColor = System.Drawing.Color.Brown;
            this.MemberDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberDeleteButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberDeleteButton.ForeColor = System.Drawing.Color.Transparent;
            this.MemberDeleteButton.Location = new System.Drawing.Point(376, 11);
            this.MemberDeleteButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MemberDeleteButton.Name = "MemberDeleteButton";
            this.MemberDeleteButton.Size = new System.Drawing.Size(98, 33);
            this.MemberDeleteButton.TabIndex = 9;
            this.MemberDeleteButton.Text = "Delete";
            this.MemberDeleteButton.UseVisualStyleBackColor = false;
            this.MemberDeleteButton.Click += new System.EventHandler(this.MemberDeleteButton_Click);
            // 
            // MemberUpdateButton
            // 
            this.MemberUpdateButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.MemberUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberUpdateButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberUpdateButton.ForeColor = System.Drawing.Color.Transparent;
            this.MemberUpdateButton.Location = new System.Drawing.Point(260, 11);
            this.MemberUpdateButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MemberUpdateButton.Name = "MemberUpdateButton";
            this.MemberUpdateButton.Size = new System.Drawing.Size(98, 33);
            this.MemberUpdateButton.TabIndex = 8;
            this.MemberUpdateButton.Text = "Update";
            this.MemberUpdateButton.UseVisualStyleBackColor = false;
            this.MemberUpdateButton.Click += new System.EventHandler(this.MemberUpdateButton_Click);
            // 
            // MemberRetrieveButton
            // 
            this.MemberRetrieveButton.BackColor = System.Drawing.Color.Peru;
            this.MemberRetrieveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberRetrieveButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberRetrieveButton.ForeColor = System.Drawing.Color.Transparent;
            this.MemberRetrieveButton.Location = new System.Drawing.Point(140, 11);
            this.MemberRetrieveButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MemberRetrieveButton.Name = "MemberRetrieveButton";
            this.MemberRetrieveButton.Size = new System.Drawing.Size(98, 33);
            this.MemberRetrieveButton.TabIndex = 7;
            this.MemberRetrieveButton.Text = "Retrieve";
            this.MemberRetrieveButton.UseVisualStyleBackColor = false;
            this.MemberRetrieveButton.Click += new System.EventHandler(this.MemberRetrieveButton_Click);
            // 
            // MemberAddButton
            // 
            this.MemberAddButton.BackColor = System.Drawing.Color.ForestGreen;
            this.MemberAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberAddButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberAddButton.ForeColor = System.Drawing.Color.White;
            this.MemberAddButton.Location = new System.Drawing.Point(16, 11);
            this.MemberAddButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MemberAddButton.Name = "MemberAddButton";
            this.MemberAddButton.Size = new System.Drawing.Size(98, 33);
            this.MemberAddButton.TabIndex = 6;
            this.MemberAddButton.Text = "Add";
            this.MemberAddButton.UseVisualStyleBackColor = false;
            this.MemberAddButton.Click += new System.EventHandler(this.MemberAddButton_Click);
            // 
            // MemberDataGrid
            // 
            this.MemberDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MemberDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MemberDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MemberDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MemberDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberDataGrid.Location = new System.Drawing.Point(678, 505);
            this.MemberDataGrid.Name = "MemberDataGrid";
            this.MemberDataGrid.Size = new System.Drawing.Size(601, 316);
            this.MemberDataGrid.TabIndex = 25;
            this.MemberDataGrid.DoubleClick += new System.EventHandler(this.MemberDataGrid_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.RoleIDSearch);
            this.panel3.Controls.Add(this.MemberShowAllRoles);
            this.panel3.Controls.Add(this.RoleIDComboBox);
            this.panel3.Controls.Add(this.RoleIDLabel);
            this.panel3.Controls.Add(this.CommitteeIDSearch);
            this.panel3.Controls.Add(this.MemberNameSearch);
            this.panel3.Controls.Add(this.MemberShowAllCommittees);
            this.panel3.Controls.Add(this.CommitteeIDComboBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.MemberNameTextBox);
            this.panel3.Controls.Add(this.MemberNameLabel);
            this.panel3.Controls.Add(this.MemberIDErrorLabel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.MemberIDLabel);
            this.panel3.Controls.Add(this.MemberIDTextBox);
            this.panel3.Location = new System.Drawing.Point(116, 505);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 194);
            this.panel3.TabIndex = 23;
            // 
            // CommitteeIDSearch
            // 
            this.CommitteeIDSearch.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.CommitteeIDSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CommitteeIDSearch.FlatAppearance.BorderSize = 0;
            this.CommitteeIDSearch.Location = new System.Drawing.Point(447, 63);
            this.CommitteeIDSearch.Name = "CommitteeIDSearch";
            this.CommitteeIDSearch.Size = new System.Drawing.Size(24, 25);
            this.CommitteeIDSearch.TabIndex = 23;
            this.CommitteeIDSearch.UseVisualStyleBackColor = true;
            this.CommitteeIDSearch.Click += new System.EventHandler(this.CommitteeIDSearch_Click);
            // 
            // MemberNameSearch
            // 
            this.MemberNameSearch.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.MemberNameSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MemberNameSearch.FlatAppearance.BorderSize = 0;
            this.MemberNameSearch.Location = new System.Drawing.Point(447, 107);
            this.MemberNameSearch.Name = "MemberNameSearch";
            this.MemberNameSearch.Size = new System.Drawing.Size(24, 25);
            this.MemberNameSearch.TabIndex = 19;
            this.MemberNameSearch.UseVisualStyleBackColor = true;
            this.MemberNameSearch.Click += new System.EventHandler(this.MemberNameSearch_Click);
            // 
            // MemberShowAllCommittees
            // 
            this.MemberShowAllCommittees.BackColor = System.Drawing.Color.DarkSlateGray;
            this.MemberShowAllCommittees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberShowAllCommittees.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberShowAllCommittees.ForeColor = System.Drawing.Color.Transparent;
            this.MemberShowAllCommittees.Location = new System.Drawing.Point(295, 61);
            this.MemberShowAllCommittees.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MemberShowAllCommittees.Name = "MemberShowAllCommittees";
            this.MemberShowAllCommittees.Size = new System.Drawing.Size(130, 27);
            this.MemberShowAllCommittees.TabIndex = 12;
            this.MemberShowAllCommittees.Text = "Show Committees";
            this.MemberShowAllCommittees.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MemberShowAllCommittees.UseVisualStyleBackColor = false;
            this.MemberShowAllCommittees.Click += new System.EventHandler(this.MemberShowAllCommittees_Click);
            // 
            // CommitteeIDComboBox
            // 
            this.CommitteeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CommitteeIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitteeIDComboBox.FormattingEnabled = true;
            this.CommitteeIDComboBox.Location = new System.Drawing.Point(153, 62);
            this.CommitteeIDComboBox.Name = "CommitteeIDComboBox";
            this.CommitteeIDComboBox.Size = new System.Drawing.Size(137, 26);
            this.CommitteeIDComboBox.TabIndex = 4;
            this.CommitteeIDComboBox.Click += new System.EventHandler(this.CommitteeIDComboBox_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Committee ID:";
            // 
            // MemberIDErrorLabel
            // 
            this.MemberIDErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemberIDErrorLabel.AutoSize = true;
            this.MemberIDErrorLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.MemberIDErrorLabel.Location = new System.Drawing.Point(295, 38);
            this.MemberIDErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberIDErrorLabel.Name = "MemberIDErrorLabel";
            this.MemberIDErrorLabel.Size = new System.Drawing.Size(136, 17);
            this.MemberIDErrorLabel.TabIndex = 8;
            this.MemberIDErrorLabel.Text = "ID can only be numeric";
            this.MemberIDErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.MemberIDErrorLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(188, 358);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 8;
            // 
            // MemberIDLabel
            // 
            this.MemberIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemberIDLabel.AutoSize = true;
            this.MemberIDLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDLabel.ForeColor = System.Drawing.Color.Black;
            this.MemberIDLabel.Location = new System.Drawing.Point(44, 13);
            this.MemberIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberIDLabel.Name = "MemberIDLabel";
            this.MemberIDLabel.Size = new System.Drawing.Size(105, 23);
            this.MemberIDLabel.TabIndex = 0;
            this.MemberIDLabel.Text = "Member ID:";
            // 
            // MemberNameTextBox
            // 
            this.MemberNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNameTextBox.Location = new System.Drawing.Point(153, 108);
            this.MemberNameTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MemberNameTextBox.Name = "MemberNameTextBox";
            this.MemberNameTextBox.Size = new System.Drawing.Size(278, 24);
            this.MemberNameTextBox.TabIndex = 0;
            this.MemberNameTextBox.TextChanged += new System.EventHandler(this.MemberNameTextBox_TextChanged);
            // 
            // MemberNameLabel
            // 
            this.MemberNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemberNameLabel.AutoSize = true;
            this.MemberNameLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNameLabel.ForeColor = System.Drawing.Color.Black;
            this.MemberNameLabel.Location = new System.Drawing.Point(10, 109);
            this.MemberNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberNameLabel.Name = "MemberNameLabel";
            this.MemberNameLabel.Size = new System.Drawing.Size(139, 23);
            this.MemberNameLabel.TabIndex = 0;
            this.MemberNameLabel.Text = "Member Name*";
            // 
            // MemberIDTextBox
            // 
            this.MemberIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDTextBox.ForeColor = System.Drawing.Color.Gray;
            this.MemberIDTextBox.Location = new System.Drawing.Point(153, 12);
            this.MemberIDTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MemberIDTextBox.Name = "MemberIDTextBox";
            this.MemberIDTextBox.Size = new System.Drawing.Size(278, 24);
            this.MemberIDTextBox.TabIndex = 11;
            this.MemberIDTextBox.TabStop = false;
            this.MemberIDTextBox.Text = "auto increment";
            this.MemberIDTextBox.Click += new System.EventHandler(this.MemberIDTextBox_Click);
            this.MemberIDTextBox.TextChanged += new System.EventHandler(this.MemberIDTextBox_TextChanged);
            this.MemberIDTextBox.Leave += new System.EventHandler(this.MemberIDTextBox_Leave);
            // 
            // RoleIDSearch
            // 
            this.RoleIDSearch.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.RoleIDSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RoleIDSearch.FlatAppearance.BorderSize = 0;
            this.RoleIDSearch.Location = new System.Drawing.Point(447, 149);
            this.RoleIDSearch.Name = "RoleIDSearch";
            this.RoleIDSearch.Size = new System.Drawing.Size(24, 25);
            this.RoleIDSearch.TabIndex = 27;
            this.RoleIDSearch.UseVisualStyleBackColor = true;
            this.RoleIDSearch.Click += new System.EventHandler(this.RoleIDSearch_Click);
            // 
            // MemberShowAllRoles
            // 
            this.MemberShowAllRoles.BackColor = System.Drawing.Color.DarkSlateGray;
            this.MemberShowAllRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberShowAllRoles.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberShowAllRoles.ForeColor = System.Drawing.Color.Transparent;
            this.MemberShowAllRoles.Location = new System.Drawing.Point(295, 147);
            this.MemberShowAllRoles.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MemberShowAllRoles.Name = "MemberShowAllRoles";
            this.MemberShowAllRoles.Size = new System.Drawing.Size(130, 27);
            this.MemberShowAllRoles.TabIndex = 26;
            this.MemberShowAllRoles.Text = "Show Roles";
            this.MemberShowAllRoles.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MemberShowAllRoles.UseVisualStyleBackColor = false;
            this.MemberShowAllRoles.Click += new System.EventHandler(this.MemberShowAllRoles_Click);
            // 
            // RoleIDComboBox
            // 
            this.RoleIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleIDComboBox.FormattingEnabled = true;
            this.RoleIDComboBox.Location = new System.Drawing.Point(153, 148);
            this.RoleIDComboBox.Name = "RoleIDComboBox";
            this.RoleIDComboBox.Size = new System.Drawing.Size(137, 26);
            this.RoleIDComboBox.TabIndex = 24;
            // 
            // RoleIDLabel
            // 
            this.RoleIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoleIDLabel.AutoSize = true;
            this.RoleIDLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleIDLabel.ForeColor = System.Drawing.Color.Black;
            this.RoleIDLabel.Location = new System.Drawing.Point(76, 151);
            this.RoleIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoleIDLabel.Name = "RoleIDLabel";
            this.RoleIDLabel.Size = new System.Drawing.Size(72, 23);
            this.RoleIDLabel.TabIndex = 25;
            this.RoleIDLabel.Text = "Role ID:";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(545, 436);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 51);
            this.label3.TabIndex = 26;
            this.label3.Text = "Members";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CommitteesAndMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MemberDataGrid);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.CommitteeDataGrid);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CommitteesAndMembers";
            this.Text = "CommitteesAndMembers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommitteeDataGrid)).EndInit();
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberDataGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CommitteeSuccessLabel;
        private System.Windows.Forms.Button CommitteeShowAllButton;
        private System.Windows.Forms.Button CommitteeDeleteButton;
        private System.Windows.Forms.Button CommitteeUpdateButton;
        private System.Windows.Forms.Button CommitteeRetrieveButton;
        private System.Windows.Forms.Button CommitteeAddButton;
        private System.Windows.Forms.DataGridView CommitteeDataGrid;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Button ITECIDSearch;
        private System.Windows.Forms.Button CommitteeNameSearch;
        private System.Windows.Forms.Button ShowEditionsButton;
        private System.Windows.Forms.ComboBox ITECIDComboBox;
        private System.Windows.Forms.Label ITECIDLabel;
        private System.Windows.Forms.Label CommitteeIDErrorLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label CommitteeIDLabel;
        private System.Windows.Forms.TextBox CommitteeNameTextBox;
        private System.Windows.Forms.Label CommitteeNameLabel;
        private System.Windows.Forms.TextBox CommitteeIDTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MemberSuccessLabel;
        private System.Windows.Forms.Button MemberShowAllButton;
        private System.Windows.Forms.Button MemberDeleteButton;
        private System.Windows.Forms.Button MemberUpdateButton;
        private System.Windows.Forms.Button MemberRetrieveButton;
        private System.Windows.Forms.Button MemberAddButton;
        private System.Windows.Forms.DataGridView MemberDataGrid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CommitteeIDSearch;
        private System.Windows.Forms.Button MemberNameSearch;
        private System.Windows.Forms.Button MemberShowAllCommittees;
        private System.Windows.Forms.ComboBox CommitteeIDComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MemberIDErrorLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MemberIDLabel;
        private System.Windows.Forms.TextBox MemberNameTextBox;
        private System.Windows.Forms.Label MemberNameLabel;
        private System.Windows.Forms.TextBox MemberIDTextBox;
        private System.Windows.Forms.Button RoleIDSearch;
        private System.Windows.Forms.Button MemberShowAllRoles;
        private System.Windows.Forms.ComboBox RoleIDComboBox;
        private System.Windows.Forms.Label RoleIDLabel;
        private System.Windows.Forms.Label label3;
    }
}