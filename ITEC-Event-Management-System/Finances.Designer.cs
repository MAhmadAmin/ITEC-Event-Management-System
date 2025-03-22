namespace ITEC_Event_Management_System
{
    partial class Finances
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
            this.SearchFeeButton = new System.Windows.Forms.Panel();
            this.DutiesHeading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchAmount = new System.Windows.Forms.Button();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.ShowEditionsButton = new System.Windows.Forms.Button();
            this.ITECIDComboBox = new System.Windows.Forms.ComboBox();
            this.SearchEventID = new System.Windows.Forms.Button();
            this.ShowEventsButton = new System.Windows.Forms.Button();
            this.EventIDComboBox = new System.Windows.Forms.ComboBox();
            this.LabelEventID = new System.Windows.Forms.Label();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.SearchDescription = new System.Windows.Forms.Button();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SearchToID = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ToIDTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SearchToType = new System.Windows.Forms.Button();
            this.ToTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SearchFromID = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.FromIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchFromType = new System.Windows.Forms.Button();
            this.FromTypeComboBox = new System.Windows.Forms.ComboBox();
            this.LabelParticipantID = new System.Windows.Forms.Label();
            this.SearchEditionID = new System.Windows.Forms.Button();
            this.AmountErrorLabel = new System.Windows.Forms.Label();
            this.LabelFeeAmmount = new System.Windows.Forms.Label();
            this.SearchTypeID = new System.Windows.Forms.Button();
            this.ShowTypesButton = new System.Windows.Forms.Button();
            this.TypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.IDErrorLabel = new System.Windows.Forms.Label();
            this.LabelRegistrationID = new System.Windows.Forms.Label();
            this.TransactionIDTextBox = new System.Windows.Forms.TextBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RetrieveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.FromIDErrorLabel = new System.Windows.Forms.Label();
            this.ToIDErrorLabel = new System.Windows.Forms.Label();
            this.SearchFeeButton.SuspendLayout();
            this.DataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchFeeButton
            // 
            this.SearchFeeButton.Controls.Add(this.DutiesHeading);
            this.SearchFeeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchFeeButton.Location = new System.Drawing.Point(0, 0);
            this.SearchFeeButton.Name = "SearchFeeButton";
            this.SearchFeeButton.Size = new System.Drawing.Size(1737, 95);
            this.SearchFeeButton.TabIndex = 38;
            // 
            // DutiesHeading
            // 
            this.DutiesHeading.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.DutiesHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DutiesHeading.AutoSize = true;
            this.DutiesHeading.Font = new System.Drawing.Font("Product Sans Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DutiesHeading.ForeColor = System.Drawing.Color.DarkOrange;
            this.DutiesHeading.Location = new System.Drawing.Point(687, 35);
            this.DutiesHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DutiesHeading.Name = "DutiesHeading";
            this.DutiesHeading.Size = new System.Drawing.Size(191, 51);
            this.DutiesHeading.TabIndex = 0;
            this.DutiesHeading.Text = "Finances";
            this.DutiesHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(72, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Type ID:";
            // 
            // SearchAmount
            // 
            this.SearchAmount.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchAmount.FlatAppearance.BorderSize = 0;
            this.SearchAmount.Location = new System.Drawing.Point(439, 203);
            this.SearchAmount.Name = "SearchAmount";
            this.SearchAmount.Size = new System.Drawing.Size(24, 25);
            this.SearchAmount.TabIndex = 39;
            this.SearchAmount.UseVisualStyleBackColor = true;
            this.SearchAmount.Click += new System.EventHandler(this.SearchAmount_Click);
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTextBox.ForeColor = System.Drawing.Color.Black;
            this.AmountTextBox.Location = new System.Drawing.Point(155, 202);
            this.AmountTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(278, 24);
            this.AmountTextBox.TabIndex = 37;
            this.AmountTextBox.TabStop = false;
            this.AmountTextBox.TextChanged += new System.EventHandler(this.AmountTextBox_TextChanged);
            // 
            // ShowEditionsButton
            // 
            this.ShowEditionsButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ShowEditionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowEditionsButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowEditionsButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowEditionsButton.Location = new System.Drawing.Point(298, 66);
            this.ShowEditionsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowEditionsButton.Name = "ShowEditionsButton";
            this.ShowEditionsButton.Size = new System.Drawing.Size(130, 27);
            this.ShowEditionsButton.TabIndex = 35;
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
            this.ITECIDComboBox.Location = new System.Drawing.Point(152, 66);
            this.ITECIDComboBox.Name = "ITECIDComboBox";
            this.ITECIDComboBox.Size = new System.Drawing.Size(138, 26);
            this.ITECIDComboBox.TabIndex = 34;
            // 
            // SearchEventID
            // 
            this.SearchEventID.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchEventID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchEventID.FlatAppearance.BorderSize = 0;
            this.SearchEventID.Location = new System.Drawing.Point(438, 113);
            this.SearchEventID.Name = "SearchEventID";
            this.SearchEventID.Size = new System.Drawing.Size(24, 25);
            this.SearchEventID.TabIndex = 33;
            this.SearchEventID.UseVisualStyleBackColor = true;
            this.SearchEventID.Click += new System.EventHandler(this.SearchEventID_Click);
            // 
            // ShowEventsButton
            // 
            this.ShowEventsButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ShowEventsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowEventsButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowEventsButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowEventsButton.Location = new System.Drawing.Point(296, 111);
            this.ShowEventsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowEventsButton.Name = "ShowEventsButton";
            this.ShowEventsButton.Size = new System.Drawing.Size(130, 27);
            this.ShowEventsButton.TabIndex = 30;
            this.ShowEventsButton.Text = "Show Events";
            this.ShowEventsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowEventsButton.UseVisualStyleBackColor = false;
            this.ShowEventsButton.Click += new System.EventHandler(this.ShowEventsButton_Click);
            // 
            // EventIDComboBox
            // 
            this.EventIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventIDComboBox.FormattingEnabled = true;
            this.EventIDComboBox.Location = new System.Drawing.Point(153, 111);
            this.EventIDComboBox.Name = "EventIDComboBox";
            this.EventIDComboBox.Size = new System.Drawing.Size(138, 26);
            this.EventIDComboBox.TabIndex = 27;
            // 
            // LabelEventID
            // 
            this.LabelEventID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelEventID.AutoSize = true;
            this.LabelEventID.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEventID.ForeColor = System.Drawing.Color.Black;
            this.LabelEventID.Location = new System.Drawing.Point(68, 114);
            this.LabelEventID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelEventID.Name = "LabelEventID";
            this.LabelEventID.Size = new System.Drawing.Size(81, 23);
            this.LabelEventID.TabIndex = 31;
            this.LabelEventID.Text = "Event ID:";
            // 
            // DataPanel
            // 
            this.DataPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataPanel.Controls.Add(this.ToIDErrorLabel);
            this.DataPanel.Controls.Add(this.FromIDErrorLabel);
            this.DataPanel.Controls.Add(this.SearchDescription);
            this.DataPanel.Controls.Add(this.DescriptionTextBox);
            this.DataPanel.Controls.Add(this.DescriptionLabel);
            this.DataPanel.Controls.Add(this.SearchToID);
            this.DataPanel.Controls.Add(this.label7);
            this.DataPanel.Controls.Add(this.ToIDTextBox);
            this.DataPanel.Controls.Add(this.label8);
            this.DataPanel.Controls.Add(this.SearchToType);
            this.DataPanel.Controls.Add(this.ToTypeComboBox);
            this.DataPanel.Controls.Add(this.SearchFromID);
            this.DataPanel.Controls.Add(this.label5);
            this.DataPanel.Controls.Add(this.FromIDTextBox);
            this.DataPanel.Controls.Add(this.label3);
            this.DataPanel.Controls.Add(this.SearchFromType);
            this.DataPanel.Controls.Add(this.FromTypeComboBox);
            this.DataPanel.Controls.Add(this.ITECIDComboBox);
            this.DataPanel.Controls.Add(this.LabelParticipantID);
            this.DataPanel.Controls.Add(this.SearchEditionID);
            this.DataPanel.Controls.Add(this.ShowEditionsButton);
            this.DataPanel.Controls.Add(this.label2);
            this.DataPanel.Controls.Add(this.SearchAmount);
            this.DataPanel.Controls.Add(this.AmountErrorLabel);
            this.DataPanel.Controls.Add(this.LabelFeeAmmount);
            this.DataPanel.Controls.Add(this.AmountTextBox);
            this.DataPanel.Controls.Add(this.SearchEventID);
            this.DataPanel.Controls.Add(this.ShowEventsButton);
            this.DataPanel.Controls.Add(this.EventIDComboBox);
            this.DataPanel.Controls.Add(this.LabelEventID);
            this.DataPanel.Controls.Add(this.SearchTypeID);
            this.DataPanel.Controls.Add(this.ShowTypesButton);
            this.DataPanel.Controls.Add(this.TypeIDComboBox);
            this.DataPanel.Controls.Add(this.IDErrorLabel);
            this.DataPanel.Controls.Add(this.LabelRegistrationID);
            this.DataPanel.Controls.Add(this.TransactionIDTextBox);
            this.DataPanel.Location = new System.Drawing.Point(152, 138);
            this.DataPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(499, 499);
            this.DataPanel.TabIndex = 35;
            // 
            // SearchDescription
            // 
            this.SearchDescription.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchDescription.FlatAppearance.BorderSize = 0;
            this.SearchDescription.Location = new System.Drawing.Point(441, 435);
            this.SearchDescription.Name = "SearchDescription";
            this.SearchDescription.Size = new System.Drawing.Size(24, 25);
            this.SearchDescription.TabIndex = 64;
            this.SearchDescription.UseVisualStyleBackColor = true;
            this.SearchDescription.Click += new System.EventHandler(this.SearchDescription_Click);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.AcceptsReturn = true;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(155, 416);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(278, 61);
            this.DescriptionTextBox.TabIndex = 63;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.Black;
            this.DescriptionLabel.Location = new System.Drawing.Point(34, 417);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(106, 23);
            this.DescriptionLabel.TabIndex = 62;
            this.DescriptionLabel.Text = "Description:";
            // 
            // SearchToID
            // 
            this.SearchToID.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchToID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchToID.FlatAppearance.BorderSize = 0;
            this.SearchToID.Location = new System.Drawing.Point(440, 375);
            this.SearchToID.Name = "SearchToID";
            this.SearchToID.Size = new System.Drawing.Size(24, 25);
            this.SearchToID.TabIndex = 61;
            this.SearchToID.UseVisualStyleBackColor = true;
            this.SearchToID.Click += new System.EventHandler(this.SearchToID_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(90, 374);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 59;
            this.label7.Text = "To ID*";
            // 
            // ToIDTextBox
            // 
            this.ToIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToIDTextBox.ForeColor = System.Drawing.Color.Black;
            this.ToIDTextBox.Location = new System.Drawing.Point(154, 374);
            this.ToIDTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ToIDTextBox.Name = "ToIDTextBox";
            this.ToIDTextBox.Size = new System.Drawing.Size(278, 24);
            this.ToIDTextBox.TabIndex = 60;
            this.ToIDTextBox.TabStop = false;
            this.ToIDTextBox.TextChanged += new System.EventHandler(this.ToIDTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(70, 334);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 23);
            this.label8.TabIndex = 58;
            this.label8.Text = "To Type*";
            // 
            // SearchToType
            // 
            this.SearchToType.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchToType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchToType.FlatAppearance.BorderSize = 0;
            this.SearchToType.Location = new System.Drawing.Point(317, 337);
            this.SearchToType.Name = "SearchToType";
            this.SearchToType.Size = new System.Drawing.Size(24, 25);
            this.SearchToType.TabIndex = 57;
            this.SearchToType.UseVisualStyleBackColor = true;
            this.SearchToType.Click += new System.EventHandler(this.SearchToType_Click);
            // 
            // ToTypeComboBox
            // 
            this.ToTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTypeComboBox.FormattingEnabled = true;
            this.ToTypeComboBox.Location = new System.Drawing.Point(154, 335);
            this.ToTypeComboBox.Name = "ToTypeComboBox";
            this.ToTypeComboBox.Size = new System.Drawing.Size(137, 26);
            this.ToTypeComboBox.TabIndex = 56;
            this.ToTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ToTypeComboBox_SelectedIndexChanged);
            // 
            // SearchFromID
            // 
            this.SearchFromID.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchFromID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchFromID.FlatAppearance.BorderSize = 0;
            this.SearchFromID.Location = new System.Drawing.Point(440, 292);
            this.SearchFromID.Name = "SearchFromID";
            this.SearchFromID.Size = new System.Drawing.Size(24, 25);
            this.SearchFromID.TabIndex = 55;
            this.SearchFromID.UseVisualStyleBackColor = true;
            this.SearchFromID.Click += new System.EventHandler(this.SearchFromID_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(69, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 53;
            this.label5.Text = "From ID*";
            // 
            // FromIDTextBox
            // 
            this.FromIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromIDTextBox.ForeColor = System.Drawing.Color.Black;
            this.FromIDTextBox.Location = new System.Drawing.Point(154, 291);
            this.FromIDTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.FromIDTextBox.Name = "FromIDTextBox";
            this.FromIDTextBox.Size = new System.Drawing.Size(278, 24);
            this.FromIDTextBox.TabIndex = 54;
            this.FromIDTextBox.TabStop = false;
            this.FromIDTextBox.TextChanged += new System.EventHandler(this.FromIDTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(50, 253);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "From Type*";
            // 
            // SearchFromType
            // 
            this.SearchFromType.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchFromType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchFromType.FlatAppearance.BorderSize = 0;
            this.SearchFromType.Location = new System.Drawing.Point(317, 250);
            this.SearchFromType.Name = "SearchFromType";
            this.SearchFromType.Size = new System.Drawing.Size(24, 25);
            this.SearchFromType.TabIndex = 51;
            this.SearchFromType.UseVisualStyleBackColor = true;
            this.SearchFromType.Click += new System.EventHandler(this.SearchFromType_Click);
            // 
            // FromTypeComboBox
            // 
            this.FromTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromTypeComboBox.FormattingEnabled = true;
            this.FromTypeComboBox.Location = new System.Drawing.Point(154, 250);
            this.FromTypeComboBox.Name = "FromTypeComboBox";
            this.FromTypeComboBox.Size = new System.Drawing.Size(137, 26);
            this.FromTypeComboBox.TabIndex = 49;
            this.FromTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FromTypeComboBox_SelectedIndexChanged);
            // 
            // LabelParticipantID
            // 
            this.LabelParticipantID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelParticipantID.AutoSize = true;
            this.LabelParticipantID.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelParticipantID.ForeColor = System.Drawing.Color.Black;
            this.LabelParticipantID.Location = new System.Drawing.Point(78, 69);
            this.LabelParticipantID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelParticipantID.Name = "LabelParticipantID";
            this.LabelParticipantID.Size = new System.Drawing.Size(69, 23);
            this.LabelParticipantID.TabIndex = 0;
            this.LabelParticipantID.Text = "ITEC ID:";
            // 
            // SearchEditionID
            // 
            this.SearchEditionID.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchEditionID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchEditionID.FlatAppearance.BorderSize = 0;
            this.SearchEditionID.Location = new System.Drawing.Point(437, 66);
            this.SearchEditionID.Name = "SearchEditionID";
            this.SearchEditionID.Size = new System.Drawing.Size(24, 25);
            this.SearchEditionID.TabIndex = 19;
            this.SearchEditionID.UseVisualStyleBackColor = true;
            this.SearchEditionID.Click += new System.EventHandler(this.SearchEditionID_Click);
            // 
            // AmountErrorLabel
            // 
            this.AmountErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountErrorLabel.AutoSize = true;
            this.AmountErrorLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.AmountErrorLabel.Location = new System.Drawing.Point(264, 227);
            this.AmountErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AmountErrorLabel.Name = "AmountErrorLabel";
            this.AmountErrorLabel.Size = new System.Drawing.Size(168, 17);
            this.AmountErrorLabel.TabIndex = 38;
            this.AmountErrorLabel.Text = "Amount can only be numeric";
            this.AmountErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.AmountErrorLabel.Visible = false;
            // 
            // LabelFeeAmmount
            // 
            this.LabelFeeAmmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFeeAmmount.AutoSize = true;
            this.LabelFeeAmmount.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFeeAmmount.ForeColor = System.Drawing.Color.Black;
            this.LabelFeeAmmount.Location = new System.Drawing.Point(68, 203);
            this.LabelFeeAmmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFeeAmmount.Name = "LabelFeeAmmount";
            this.LabelFeeAmmount.Size = new System.Drawing.Size(83, 23);
            this.LabelFeeAmmount.TabIndex = 36;
            this.LabelFeeAmmount.Text = "Amount*";
            // 
            // SearchTypeID
            // 
            this.SearchTypeID.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchTypeID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchTypeID.FlatAppearance.BorderSize = 0;
            this.SearchTypeID.Location = new System.Drawing.Point(439, 161);
            this.SearchTypeID.Name = "SearchTypeID";
            this.SearchTypeID.Size = new System.Drawing.Size(24, 25);
            this.SearchTypeID.TabIndex = 23;
            this.SearchTypeID.UseVisualStyleBackColor = true;
            this.SearchTypeID.Click += new System.EventHandler(this.SearchTypeID_Click);
            // 
            // ShowTypesButton
            // 
            this.ShowTypesButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ShowTypesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowTypesButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowTypesButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowTypesButton.Location = new System.Drawing.Point(296, 159);
            this.ShowTypesButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowTypesButton.Name = "ShowTypesButton";
            this.ShowTypesButton.Size = new System.Drawing.Size(130, 27);
            this.ShowTypesButton.TabIndex = 12;
            this.ShowTypesButton.Text = "Show Types";
            this.ShowTypesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowTypesButton.UseVisualStyleBackColor = false;
            this.ShowTypesButton.Click += new System.EventHandler(this.ShowTypesButton_Click);
            // 
            // TypeIDComboBox
            // 
            this.TypeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeIDComboBox.FormattingEnabled = true;
            this.TypeIDComboBox.Location = new System.Drawing.Point(154, 160);
            this.TypeIDComboBox.Name = "TypeIDComboBox";
            this.TypeIDComboBox.Size = new System.Drawing.Size(137, 26);
            this.TypeIDComboBox.TabIndex = 4;
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
            // LabelRegistrationID
            // 
            this.LabelRegistrationID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRegistrationID.AutoSize = true;
            this.LabelRegistrationID.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegistrationID.ForeColor = System.Drawing.Color.Black;
            this.LabelRegistrationID.Location = new System.Drawing.Point(23, 18);
            this.LabelRegistrationID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelRegistrationID.Name = "LabelRegistrationID";
            this.LabelRegistrationID.Size = new System.Drawing.Size(126, 23);
            this.LabelRegistrationID.TabIndex = 0;
            this.LabelRegistrationID.Text = "Transaction ID:";
            // 
            // TransactionIDTextBox
            // 
            this.TransactionIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionIDTextBox.ForeColor = System.Drawing.Color.Gray;
            this.TransactionIDTextBox.Location = new System.Drawing.Point(153, 17);
            this.TransactionIDTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TransactionIDTextBox.Name = "TransactionIDTextBox";
            this.TransactionIDTextBox.Size = new System.Drawing.Size(278, 24);
            this.TransactionIDTextBox.TabIndex = 11;
            this.TransactionIDTextBox.TabStop = false;
            this.TransactionIDTextBox.Text = "auto increment";
            this.TransactionIDTextBox.Click += new System.EventHandler(this.TransactionIDTextBox_Click);
            this.TransactionIDTextBox.TextChanged += new System.EventHandler(this.TransactionIDTextBox_TextChanged);
            this.TransactionIDTextBox.Leave += new System.EventHandler(this.TransactionIDTextBox_Leave);
            // 
            // DataGrid
            // 
            this.DataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(697, 155);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(967, 638);
            this.DataGrid.TabIndex = 37;
            this.DataGrid.DoubleClick += new System.EventHandler(this.DataGrid_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 126);
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
            this.SuccessLabel.Location = new System.Drawing.Point(113, 126);
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
            this.ShowAllButton.Location = new System.Drawing.Point(198, 76);
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
            this.DeleteButton.Location = new System.Drawing.Point(381, 23);
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
            this.UpdateButton.Location = new System.Drawing.Point(265, 23);
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
            this.RetrieveButton.Location = new System.Drawing.Point(145, 23);
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
            this.AddButton.Location = new System.Drawing.Point(21, 23);
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
            this.ButtonsPanel.Location = new System.Drawing.Point(152, 656);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(499, 158);
            this.ButtonsPanel.TabIndex = 36;
            // 
            // FromIDErrorLabel
            // 
            this.FromIDErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FromIDErrorLabel.AutoSize = true;
            this.FromIDErrorLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromIDErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.FromIDErrorLabel.Location = new System.Drawing.Point(295, 316);
            this.FromIDErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FromIDErrorLabel.Name = "FromIDErrorLabel";
            this.FromIDErrorLabel.Size = new System.Drawing.Size(136, 17);
            this.FromIDErrorLabel.TabIndex = 65;
            this.FromIDErrorLabel.Text = "ID can only be numeric";
            this.FromIDErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.FromIDErrorLabel.Visible = false;
            // 
            // ToIDErrorLabel
            // 
            this.ToIDErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToIDErrorLabel.AutoSize = true;
            this.ToIDErrorLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToIDErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ToIDErrorLabel.Location = new System.Drawing.Point(295, 398);
            this.ToIDErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ToIDErrorLabel.Name = "ToIDErrorLabel";
            this.ToIDErrorLabel.Size = new System.Drawing.Size(136, 17);
            this.ToIDErrorLabel.TabIndex = 66;
            this.ToIDErrorLabel.Text = "ID can only be numeric";
            this.ToIDErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ToIDErrorLabel.Visible = false;
            // 
            // Finances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1737, 857);
            this.Controls.Add(this.SearchFeeButton);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.ButtonsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Finances";
            this.Text = "Finances";
            this.Load += new System.EventHandler(this.Finances_Load);
            this.SearchFeeButton.ResumeLayout(false);
            this.SearchFeeButton.PerformLayout();
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SearchFeeButton;
        private System.Windows.Forms.Label DutiesHeading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchAmount;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Button ShowEditionsButton;
        private System.Windows.Forms.ComboBox ITECIDComboBox;
        private System.Windows.Forms.Button SearchEventID;
        private System.Windows.Forms.Button ShowEventsButton;
        private System.Windows.Forms.ComboBox EventIDComboBox;
        private System.Windows.Forms.Label LabelEventID;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Label AmountErrorLabel;
        private System.Windows.Forms.Label LabelFeeAmmount;
        private System.Windows.Forms.Button SearchTypeID;
        private System.Windows.Forms.Button SearchEditionID;
        private System.Windows.Forms.Button ShowTypesButton;
        private System.Windows.Forms.ComboBox TypeIDComboBox;
        private System.Windows.Forms.Label IDErrorLabel;
        private System.Windows.Forms.Label LabelRegistrationID;
        private System.Windows.Forms.Label LabelParticipantID;
        private System.Windows.Forms.TextBox TransactionIDTextBox;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button RetrieveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button SearchToID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ToIDTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SearchToType;
        private System.Windows.Forms.ComboBox ToTypeComboBox;
        private System.Windows.Forms.Button SearchFromID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FromIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchFromType;
        private System.Windows.Forms.ComboBox FromTypeComboBox;
        private System.Windows.Forms.Button SearchDescription;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label ToIDErrorLabel;
        private System.Windows.Forms.Label FromIDErrorLabel;
    }
}