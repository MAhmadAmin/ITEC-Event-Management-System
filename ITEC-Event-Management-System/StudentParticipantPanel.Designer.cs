namespace ITEC_Event_Management_System
{
    partial class StudentParticipantPanel
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
            this.LeftPicture = new System.Windows.Forms.PictureBox();
            this.WelcomeBackLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.AddErrorLabel = new System.Windows.Forms.Label();
            this.NameErrorLabel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.ITECIDComboBox = new System.Windows.Forms.ComboBox();
            this.InstituteTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ITECIDLabel = new System.Windows.Forms.Label();
            this.ContactErrorLabel = new System.Windows.Forms.Label();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPicture)).BeginInit();
            this.DataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LeftPicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 675);
            this.panel1.TabIndex = 0;
            // 
            // LeftPicture
            // 
            this.LeftPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPicture.Image = global::ITEC_Event_Management_System.Properties.Resources.favpng_earth_globe_world_icon;
            this.LeftPicture.Location = new System.Drawing.Point(0, 0);
            this.LeftPicture.Margin = new System.Windows.Forms.Padding(0);
            this.LeftPicture.MinimumSize = new System.Drawing.Size(250, 487);
            this.LeftPicture.Name = "LeftPicture";
            this.LeftPicture.Size = new System.Drawing.Size(316, 675);
            this.LeftPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LeftPicture.TabIndex = 1;
            this.LeftPicture.TabStop = false;
            // 
            // WelcomeBackLabel
            // 
            this.WelcomeBackLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WelcomeBackLabel.AutoSize = true;
            this.WelcomeBackLabel.Font = new System.Drawing.Font("Arial Black", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBackLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.WelcomeBackLabel.Location = new System.Drawing.Point(341, 57);
            this.WelcomeBackLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeBackLabel.Name = "WelcomeBackLabel";
            this.WelcomeBackLabel.Size = new System.Drawing.Size(423, 67);
            this.WelcomeBackLabel.TabIndex = 1;
            this.WelcomeBackLabel.Text = "Welcome Back,";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.ForestGreen;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(172, 372);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(194, 33);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Become Participant";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DataPanel
            // 
            this.DataPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataPanel.Controls.Add(this.AddErrorLabel);
            this.DataPanel.Controls.Add(this.NameErrorLabel);
            this.DataPanel.Controls.Add(this.LogOutButton);
            this.DataPanel.Controls.Add(this.ITECIDComboBox);
            this.DataPanel.Controls.Add(this.AddButton);
            this.DataPanel.Controls.Add(this.InstituteTextBox);
            this.DataPanel.Controls.Add(this.label4);
            this.DataPanel.Controls.Add(this.ITECIDLabel);
            this.DataPanel.Controls.Add(this.ContactErrorLabel);
            this.DataPanel.Controls.Add(this.ContactTextBox);
            this.DataPanel.Controls.Add(this.label3);
            this.DataPanel.Controls.Add(this.NameTextBox);
            this.DataPanel.Controls.Add(this.EmailTextBox);
            this.DataPanel.Controls.Add(this.NameLabel);
            this.DataPanel.Controls.Add(this.EmailLabel);
            this.DataPanel.Location = new System.Drawing.Point(379, 123);
            this.DataPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(499, 513);
            this.DataPanel.TabIndex = 17;
            // 
            // AddErrorLabel
            // 
            this.AddErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddErrorLabel.AutoSize = true;
            this.AddErrorLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.AddErrorLabel.Location = new System.Drawing.Point(295, 420);
            this.AddErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddErrorLabel.Name = "AddErrorLabel";
            this.AddErrorLabel.Size = new System.Drawing.Size(115, 17);
            this.AddErrorLabel.TabIndex = 19;
            this.AddErrorLabel.Text = "Already Registered";
            this.AddErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.AddErrorLabel.Visible = false;
            // 
            // NameErrorLabel
            // 
            this.NameErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameErrorLabel.AutoSize = true;
            this.NameErrorLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.NameErrorLabel.Location = new System.Drawing.Point(258, 100);
            this.NameErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameErrorLabel.Name = "NameErrorLabel";
            this.NameErrorLabel.Size = new System.Drawing.Size(173, 17);
            this.NameErrorLabel.TabIndex = 18;
            this.NameErrorLabel.Text = "Name Cannot Contain Numer";
            this.NameErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.NameErrorLabel.Visible = false;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.DarkRed;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.Color.Transparent;
            this.LogOutButton.Location = new System.Drawing.Point(353, 483);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(130, 27);
            this.LogOutButton.TabIndex = 12;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // ITECIDComboBox
            // 
            this.ITECIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ITECIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITECIDComboBox.FormattingEnabled = true;
            this.ITECIDComboBox.Location = new System.Drawing.Point(153, 295);
            this.ITECIDComboBox.Name = "ITECIDComboBox";
            this.ITECIDComboBox.Size = new System.Drawing.Size(137, 26);
            this.ITECIDComboBox.TabIndex = 4;
            // 
            // InstituteTextBox
            // 
            this.InstituteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstituteTextBox.Location = new System.Drawing.Point(153, 244);
            this.InstituteTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.InstituteTextBox.Name = "InstituteTextBox";
            this.InstituteTextBox.Size = new System.Drawing.Size(278, 24);
            this.InstituteTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(61, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Institute:";
            // 
            // ITECIDLabel
            // 
            this.ITECIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ITECIDLabel.AutoSize = true;
            this.ITECIDLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITECIDLabel.ForeColor = System.Drawing.Color.Black;
            this.ITECIDLabel.Location = new System.Drawing.Point(79, 298);
            this.ITECIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ITECIDLabel.Name = "ITECIDLabel";
            this.ITECIDLabel.Size = new System.Drawing.Size(69, 23);
            this.ITECIDLabel.TabIndex = 9;
            this.ITECIDLabel.Text = "ITEC ID:";
            // 
            // ContactErrorLabel
            // 
            this.ContactErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactErrorLabel.AutoSize = true;
            this.ContactErrorLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ContactErrorLabel.Location = new System.Drawing.Point(297, 216);
            this.ContactErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContactErrorLabel.Name = "ContactErrorLabel";
            this.ContactErrorLabel.Size = new System.Drawing.Size(136, 17);
            this.ContactErrorLabel.TabIndex = 16;
            this.ContactErrorLabel.Text = "Invalid Contact Format";
            this.ContactErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ContactErrorLabel.Visible = false;
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactTextBox.Location = new System.Drawing.Point(153, 188);
            this.ContactTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(278, 24);
            this.ContactTextBox.TabIndex = 2;
            this.ContactTextBox.TextChanged += new System.EventHandler(this.ContactTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(68, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Contact*";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(153, 75);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(278, 24);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Enabled = false;
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(153, 132);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(278, 24);
            this.EmailTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.Black;
            this.NameLabel.Location = new System.Drawing.Point(87, 74);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(66, 23);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name*";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.Black;
            this.EmailLabel.Location = new System.Drawing.Point(86, 133);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(62, 23);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email*";
            // 
            // StudentParticipantPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 675);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.WelcomeBackLabel);
            this.Controls.Add(this.panel1);
            this.Name = "StudentParticipantPanel";
            this.Text = "StudentParticipantPanel";
            this.Load += new System.EventHandler(this.StudentParticipantPanel_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftPicture)).EndInit();
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox LeftPicture;
        private System.Windows.Forms.Label WelcomeBackLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.ComboBox ITECIDComboBox;
        private System.Windows.Forms.TextBox InstituteTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ITECIDLabel;
        private System.Windows.Forms.Label ContactErrorLabel;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label NameErrorLabel;
        private System.Windows.Forms.Label AddErrorLabel;
    }
}