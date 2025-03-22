namespace ITEC_Event_Management_System
{
    partial class EventParticipants
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
            this.AddButton = new System.Windows.Forms.Button();
            this.DutiesHeading = new System.Windows.Forms.Label();
            this.SearchFeeButton = new System.Windows.Forms.Panel();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.ShowParticipantsButton = new System.Windows.Forms.Button();
            this.ParticipantIDComboBox = new System.Windows.Forms.ComboBox();
            this.SearchEventID = new System.Windows.Forms.Button();
            this.ShowEventsButton = new System.Windows.Forms.Button();
            this.EventIDComboBox = new System.Windows.Forms.ComboBox();
            this.LabelEventID = new System.Windows.Forms.Label();
            this.SearchPaymentStatusStatues = new System.Windows.Forms.Button();
            this.SearchParticipantID = new System.Windows.Forms.Button();
            this.ShowPaymentStatusesButton = new System.Windows.Forms.Button();
            this.PaymentStatusIDComboBox = new System.Windows.Forms.ComboBox();
            this.LabelPaymentStatus = new System.Windows.Forms.Label();
            this.RegistrationIDErrorLabel = new System.Windows.Forms.Label();
            this.LabelRegistrationID = new System.Windows.Forms.Label();
            this.LabelParticipantID = new System.Windows.Forms.Label();
            this.RegistrationIDTextBox = new System.Windows.Forms.TextBox();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RetrieveButton = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.LabelFeeAmmount = new System.Windows.Forms.Label();
            this.FeeAmountTextBox = new System.Windows.Forms.TextBox();
            this.FeeErrorLabel = new System.Windows.Forms.Label();
            this.SearchFeeAmount = new System.Windows.Forms.Button();
            this.SearchFeeButton.SuspendLayout();
            this.DataPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
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
            // DutiesHeading
            // 
            this.DutiesHeading.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.DutiesHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DutiesHeading.AutoSize = true;
            this.DutiesHeading.Font = new System.Drawing.Font("Product Sans Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DutiesHeading.ForeColor = System.Drawing.Color.Red;
            this.DutiesHeading.Location = new System.Drawing.Point(536, 35);
            this.DutiesHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DutiesHeading.Name = "DutiesHeading";
            this.DutiesHeading.Size = new System.Drawing.Size(368, 51);
            this.DutiesHeading.TabIndex = 0;
            this.DutiesHeading.Text = "Event Participants";
            this.DutiesHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchFeeButton
            // 
            this.SearchFeeButton.Controls.Add(this.DutiesHeading);
            this.SearchFeeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchFeeButton.Location = new System.Drawing.Point(0, 0);
            this.SearchFeeButton.Name = "SearchFeeButton";
            this.SearchFeeButton.Size = new System.Drawing.Size(1434, 95);
            this.SearchFeeButton.TabIndex = 30;
            // 
            // DataPanel
            // 
            this.DataPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataPanel.Controls.Add(this.SearchFeeAmount);
            this.DataPanel.Controls.Add(this.FeeErrorLabel);
            this.DataPanel.Controls.Add(this.LabelFeeAmmount);
            this.DataPanel.Controls.Add(this.FeeAmountTextBox);
            this.DataPanel.Controls.Add(this.ShowParticipantsButton);
            this.DataPanel.Controls.Add(this.ParticipantIDComboBox);
            this.DataPanel.Controls.Add(this.SearchEventID);
            this.DataPanel.Controls.Add(this.ShowEventsButton);
            this.DataPanel.Controls.Add(this.EventIDComboBox);
            this.DataPanel.Controls.Add(this.LabelEventID);
            this.DataPanel.Controls.Add(this.SearchPaymentStatusStatues);
            this.DataPanel.Controls.Add(this.SearchParticipantID);
            this.DataPanel.Controls.Add(this.ShowPaymentStatusesButton);
            this.DataPanel.Controls.Add(this.PaymentStatusIDComboBox);
            this.DataPanel.Controls.Add(this.LabelPaymentStatus);
            this.DataPanel.Controls.Add(this.RegistrationIDErrorLabel);
            this.DataPanel.Controls.Add(this.LabelRegistrationID);
            this.DataPanel.Controls.Add(this.LabelParticipantID);
            this.DataPanel.Controls.Add(this.RegistrationIDTextBox);
            this.DataPanel.Location = new System.Drawing.Point(249, 158);
            this.DataPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(499, 334);
            this.DataPanel.TabIndex = 27;
            // 
            // ShowParticipantsButton
            // 
            this.ShowParticipantsButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ShowParticipantsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowParticipantsButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowParticipantsButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowParticipantsButton.Location = new System.Drawing.Point(295, 112);
            this.ShowParticipantsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowParticipantsButton.Name = "ShowParticipantsButton";
            this.ShowParticipantsButton.Size = new System.Drawing.Size(130, 27);
            this.ShowParticipantsButton.TabIndex = 35;
            this.ShowParticipantsButton.Text = "Show Participants";
            this.ShowParticipantsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowParticipantsButton.UseVisualStyleBackColor = false;
            this.ShowParticipantsButton.Click += new System.EventHandler(this.ShowParticipantsButton_Click);
            // 
            // ParticipantIDComboBox
            // 
            this.ParticipantIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParticipantIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParticipantIDComboBox.FormattingEnabled = true;
            this.ParticipantIDComboBox.Location = new System.Drawing.Point(152, 112);
            this.ParticipantIDComboBox.Name = "ParticipantIDComboBox";
            this.ParticipantIDComboBox.Size = new System.Drawing.Size(138, 26);
            this.ParticipantIDComboBox.TabIndex = 34;
            // 
            // SearchEventID
            // 
            this.SearchEventID.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchEventID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchEventID.FlatAppearance.BorderSize = 0;
            this.SearchEventID.Location = new System.Drawing.Point(438, 67);
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
            this.ShowEventsButton.Location = new System.Drawing.Point(296, 65);
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
            this.EventIDComboBox.Location = new System.Drawing.Point(153, 65);
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
            this.LabelEventID.Location = new System.Drawing.Point(67, 67);
            this.LabelEventID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelEventID.Name = "LabelEventID";
            this.LabelEventID.Size = new System.Drawing.Size(81, 23);
            this.LabelEventID.TabIndex = 31;
            this.LabelEventID.Text = "Event ID:";
            // 
            // SearchPaymentStatusStatues
            // 
            this.SearchPaymentStatusStatues.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchPaymentStatusStatues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchPaymentStatusStatues.FlatAppearance.BorderSize = 0;
            this.SearchPaymentStatusStatues.Location = new System.Drawing.Point(439, 161);
            this.SearchPaymentStatusStatues.Name = "SearchPaymentStatusStatues";
            this.SearchPaymentStatusStatues.Size = new System.Drawing.Size(24, 25);
            this.SearchPaymentStatusStatues.TabIndex = 23;
            this.SearchPaymentStatusStatues.UseVisualStyleBackColor = true;
            this.SearchPaymentStatusStatues.Click += new System.EventHandler(this.SearchPaymentStatusStatues_Click);
            // 
            // SearchParticipantID
            // 
            this.SearchParticipantID.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchParticipantID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchParticipantID.FlatAppearance.BorderSize = 0;
            this.SearchParticipantID.Location = new System.Drawing.Point(438, 112);
            this.SearchParticipantID.Name = "SearchParticipantID";
            this.SearchParticipantID.Size = new System.Drawing.Size(24, 25);
            this.SearchParticipantID.TabIndex = 19;
            this.SearchParticipantID.UseVisualStyleBackColor = true;
            this.SearchParticipantID.Click += new System.EventHandler(this.SearchParticipantID_Click);
            // 
            // ShowPaymentStatusesButton
            // 
            this.ShowPaymentStatusesButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ShowPaymentStatusesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPaymentStatusesButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPaymentStatusesButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowPaymentStatusesButton.Location = new System.Drawing.Point(296, 159);
            this.ShowPaymentStatusesButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowPaymentStatusesButton.Name = "ShowPaymentStatusesButton";
            this.ShowPaymentStatusesButton.Size = new System.Drawing.Size(130, 27);
            this.ShowPaymentStatusesButton.TabIndex = 12;
            this.ShowPaymentStatusesButton.Text = "Show Statuses";
            this.ShowPaymentStatusesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowPaymentStatusesButton.UseVisualStyleBackColor = false;
            this.ShowPaymentStatusesButton.Click += new System.EventHandler(this.ShowPaymentStatusesButton_Click);
            // 
            // PaymentStatusIDComboBox
            // 
            this.PaymentStatusIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentStatusIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentStatusIDComboBox.FormattingEnabled = true;
            this.PaymentStatusIDComboBox.Location = new System.Drawing.Point(154, 160);
            this.PaymentStatusIDComboBox.Name = "PaymentStatusIDComboBox";
            this.PaymentStatusIDComboBox.Size = new System.Drawing.Size(137, 26);
            this.PaymentStatusIDComboBox.TabIndex = 4;
            // 
            // LabelPaymentStatus
            // 
            this.LabelPaymentStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPaymentStatus.AutoSize = true;
            this.LabelPaymentStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPaymentStatus.ForeColor = System.Drawing.Color.Black;
            this.LabelPaymentStatus.Location = new System.Drawing.Point(10, 163);
            this.LabelPaymentStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPaymentStatus.Name = "LabelPaymentStatus";
            this.LabelPaymentStatus.Size = new System.Drawing.Size(139, 19);
            this.LabelPaymentStatus.TabIndex = 9;
            this.LabelPaymentStatus.Text = "Payment Status ID:";
            // 
            // RegistrationIDErrorLabel
            // 
            this.RegistrationIDErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrationIDErrorLabel.AutoSize = true;
            this.RegistrationIDErrorLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationIDErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.RegistrationIDErrorLabel.Location = new System.Drawing.Point(295, 43);
            this.RegistrationIDErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegistrationIDErrorLabel.Name = "RegistrationIDErrorLabel";
            this.RegistrationIDErrorLabel.Size = new System.Drawing.Size(136, 17);
            this.RegistrationIDErrorLabel.TabIndex = 8;
            this.RegistrationIDErrorLabel.Text = "ID can only be numeric";
            this.RegistrationIDErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.RegistrationIDErrorLabel.Visible = false;
            // 
            // LabelRegistrationID
            // 
            this.LabelRegistrationID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRegistrationID.AutoSize = true;
            this.LabelRegistrationID.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegistrationID.ForeColor = System.Drawing.Color.Black;
            this.LabelRegistrationID.Location = new System.Drawing.Point(16, 17);
            this.LabelRegistrationID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelRegistrationID.Name = "LabelRegistrationID";
            this.LabelRegistrationID.Size = new System.Drawing.Size(133, 23);
            this.LabelRegistrationID.TabIndex = 0;
            this.LabelRegistrationID.Text = "Registration ID:";
            // 
            // LabelParticipantID
            // 
            this.LabelParticipantID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelParticipantID.AutoSize = true;
            this.LabelParticipantID.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelParticipantID.ForeColor = System.Drawing.Color.Black;
            this.LabelParticipantID.Location = new System.Drawing.Point(25, 114);
            this.LabelParticipantID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelParticipantID.Name = "LabelParticipantID";
            this.LabelParticipantID.Size = new System.Drawing.Size(122, 23);
            this.LabelParticipantID.TabIndex = 0;
            this.LabelParticipantID.Text = "Participant ID:";
            // 
            // RegistrationIDTextBox
            // 
            this.RegistrationIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationIDTextBox.ForeColor = System.Drawing.Color.Gray;
            this.RegistrationIDTextBox.Location = new System.Drawing.Point(153, 17);
            this.RegistrationIDTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RegistrationIDTextBox.Name = "RegistrationIDTextBox";
            this.RegistrationIDTextBox.Size = new System.Drawing.Size(278, 24);
            this.RegistrationIDTextBox.TabIndex = 11;
            this.RegistrationIDTextBox.TabStop = false;
            this.RegistrationIDTextBox.Text = "auto increment";
            this.RegistrationIDTextBox.Click += new System.EventHandler(this.RegistrationIDTextBox_Click);
            this.RegistrationIDTextBox.TextChanged += new System.EventHandler(this.RegistrationIDTextBox_TextChanged);
            this.RegistrationIDTextBox.Leave += new System.EventHandler(this.RegistrationIDTextBox_Leave);
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
            this.ButtonsPanel.Location = new System.Drawing.Point(249, 532);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(499, 189);
            this.ButtonsPanel.TabIndex = 28;
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
            // DataGrid
            // 
            this.DataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(811, 146);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(601, 638);
            this.DataGrid.TabIndex = 29;
            // 
            // LabelFeeAmmount
            // 
            this.LabelFeeAmmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFeeAmmount.AutoSize = true;
            this.LabelFeeAmmount.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFeeAmmount.ForeColor = System.Drawing.Color.Black;
            this.LabelFeeAmmount.Location = new System.Drawing.Point(35, 207);
            this.LabelFeeAmmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFeeAmmount.Name = "LabelFeeAmmount";
            this.LabelFeeAmmount.Size = new System.Drawing.Size(112, 23);
            this.LabelFeeAmmount.TabIndex = 36;
            this.LabelFeeAmmount.Text = "Fee Amount:";
            // 
            // FeeAmountTextBox
            // 
            this.FeeAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeeAmountTextBox.ForeColor = System.Drawing.Color.Black;
            this.FeeAmountTextBox.Location = new System.Drawing.Point(153, 207);
            this.FeeAmountTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.FeeAmountTextBox.Name = "FeeAmountTextBox";
            this.FeeAmountTextBox.Size = new System.Drawing.Size(278, 24);
            this.FeeAmountTextBox.TabIndex = 37;
            this.FeeAmountTextBox.TabStop = false;
            this.FeeAmountTextBox.TextChanged += new System.EventHandler(this.FeeAmountTextBox_TextChanged);
            // 
            // FeeErrorLabel
            // 
            this.FeeErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FeeErrorLabel.AutoSize = true;
            this.FeeErrorLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.FeeErrorLabel.Location = new System.Drawing.Point(288, 232);
            this.FeeErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FeeErrorLabel.Name = "FeeErrorLabel";
            this.FeeErrorLabel.Size = new System.Drawing.Size(143, 17);
            this.FeeErrorLabel.TabIndex = 38;
            this.FeeErrorLabel.Text = "Fee can only be numeric";
            this.FeeErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.FeeErrorLabel.Visible = false;
            // 
            // SearchFeeAmount
            // 
            this.SearchFeeAmount.BackgroundImage = global::ITEC_Event_Management_System.Properties.Resources.SearchIconThickOrange;
            this.SearchFeeAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchFeeAmount.FlatAppearance.BorderSize = 0;
            this.SearchFeeAmount.Location = new System.Drawing.Point(439, 208);
            this.SearchFeeAmount.Name = "SearchFeeAmount";
            this.SearchFeeAmount.Size = new System.Drawing.Size(24, 25);
            this.SearchFeeAmount.TabIndex = 39;
            this.SearchFeeAmount.UseVisualStyleBackColor = true;
            this.SearchFeeAmount.Click += new System.EventHandler(this.button1_Click);
            // 
            // EventParticipants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1434, 863);
            this.Controls.Add(this.SearchFeeButton);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.DataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventParticipants";
            this.Text = "EventParticipants";
            this.Load += new System.EventHandler(this.EventParticipants_Load);
            this.SearchFeeButton.ResumeLayout(false);
            this.SearchFeeButton.PerformLayout();
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label DutiesHeading;
        private System.Windows.Forms.Panel SearchFeeButton;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Button ShowParticipantsButton;
        private System.Windows.Forms.ComboBox ParticipantIDComboBox;
        private System.Windows.Forms.Button SearchEventID;
        private System.Windows.Forms.Button ShowEventsButton;
        private System.Windows.Forms.ComboBox EventIDComboBox;
        private System.Windows.Forms.Label LabelEventID;
        private System.Windows.Forms.Button SearchPaymentStatusStatues;
        private System.Windows.Forms.Button SearchParticipantID;
        private System.Windows.Forms.Button ShowPaymentStatusesButton;
        private System.Windows.Forms.ComboBox PaymentStatusIDComboBox;
        private System.Windows.Forms.Label LabelPaymentStatus;
        private System.Windows.Forms.Label RegistrationIDErrorLabel;
        private System.Windows.Forms.Label LabelRegistrationID;
        private System.Windows.Forms.Label LabelParticipantID;
        private System.Windows.Forms.TextBox RegistrationIDTextBox;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button RetrieveButton;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button SearchFeeAmount;
        private System.Windows.Forms.Label FeeErrorLabel;
        private System.Windows.Forms.Label LabelFeeAmmount;
        private System.Windows.Forms.TextBox FeeAmountTextBox;
    }
}