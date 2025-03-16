namespace ITEC_Event_Management_System
{
    partial class Venues
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
            this.VenuesHeading = new System.Windows.Forms.Label();
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
            this.CapacityErrorLabel = new System.Windows.Forms.Label();
            this.IDErrorLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.CapacityTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.CapacityLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.DataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VenuesHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 95);
            this.panel1.TabIndex = 14;
            // 
            // VenuesHeading
            // 
            this.VenuesHeading.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.VenuesHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VenuesHeading.AutoSize = true;
            this.VenuesHeading.Font = new System.Drawing.Font("Product Sans Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenuesHeading.ForeColor = System.Drawing.Color.Purple;
            this.VenuesHeading.Location = new System.Drawing.Point(456, 37);
            this.VenuesHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VenuesHeading.Name = "VenuesHeading";
            this.VenuesHeading.Size = new System.Drawing.Size(257, 51);
            this.VenuesHeading.TabIndex = 0;
            this.VenuesHeading.Text = "ITEC Venues";
            this.VenuesHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ButtonsPanel.Location = new System.Drawing.Point(102, 500);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(499, 239);
            this.ButtonsPanel.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(325, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Message:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Visible = false;
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SuccessLabel.AutoSize = true;
            this.SuccessLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.SuccessLabel.Location = new System.Drawing.Point(393, 160);
            this.SuccessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(38, 17);
            this.SuccessLabel.TabIndex = 10;
            this.SuccessLabel.Text = "None";
            this.SuccessLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.SuccessLabel.Visible = false;
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShowAllButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ShowAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAllButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowAllButton.Location = new System.Drawing.Point(177, 118);
            this.ShowAllButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(121, 33);
            this.ShowAllButton.TabIndex = 8;
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
            this.DeleteButton.TabIndex = 7;
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
            this.UpdateButton.TabIndex = 6;
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
            this.RetrieveButton.TabIndex = 5;
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
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(669, 101);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(475, 638);
            this.DataGrid.TabIndex = 13;
            this.DataGrid.DoubleClick += new System.EventHandler(this.DataGrid_DoubleClick_1);
            // 
            // DataPanel
            // 
            this.DataPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataPanel.Controls.Add(this.CapacityErrorLabel);
            this.DataPanel.Controls.Add(this.IDErrorLabel);
            this.DataPanel.Controls.Add(this.ErrorLabel);
            this.DataPanel.Controls.Add(this.IDLabel);
            this.DataPanel.Controls.Add(this.NameTextBox);
            this.DataPanel.Controls.Add(this.LocationTextBox);
            this.DataPanel.Controls.Add(this.CapacityTextBox);
            this.DataPanel.Controls.Add(this.NameLabel);
            this.DataPanel.Controls.Add(this.IDTextBox);
            this.DataPanel.Controls.Add(this.LocationLabel);
            this.DataPanel.Controls.Add(this.CapacityLabel);
            this.DataPanel.Location = new System.Drawing.Point(102, 149);
            this.DataPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(463, 310);
            this.DataPanel.TabIndex = 11;
            // 
            // CapacityErrorLabel
            // 
            this.CapacityErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CapacityErrorLabel.AutoSize = true;
            this.CapacityErrorLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapacityErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.CapacityErrorLabel.Location = new System.Drawing.Point(283, 171);
            this.CapacityErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CapacityErrorLabel.Name = "CapacityErrorLabel";
            this.CapacityErrorLabel.Size = new System.Drawing.Size(148, 17);
            this.CapacityErrorLabel.TabIndex = 8;
            this.CapacityErrorLabel.Text = "Year can only be numeric";
            this.CapacityErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CapacityErrorLabel.Visible = false;
            // 
            // IDErrorLabel
            // 
            this.IDErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDErrorLabel.AutoSize = true;
            this.IDErrorLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.IDErrorLabel.Location = new System.Drawing.Point(295, 69);
            this.IDErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDErrorLabel.Name = "IDErrorLabel";
            this.IDErrorLabel.Size = new System.Drawing.Size(136, 17);
            this.IDErrorLabel.TabIndex = 8;
            this.IDErrorLabel.Text = "ID can only be nemeric";
            this.IDErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.IDErrorLabel.Visible = false;
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
            // IDLabel
            // 
            this.IDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.Color.Black;
            this.IDLabel.Location = new System.Drawing.Point(117, 43);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(32, 23);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(153, 96);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(278, 24);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.AcceptsReturn = true;
            this.LocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationTextBox.Location = new System.Drawing.Point(153, 195);
            this.LocationTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.LocationTextBox.Multiline = true;
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LocationTextBox.Size = new System.Drawing.Size(278, 93);
            this.LocationTextBox.TabIndex = 3;
            this.LocationTextBox.TextChanged += new System.EventHandler(this.LocationTextBox_TextChanged);
            // 
            // CapacityTextBox
            // 
            this.CapacityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapacityTextBox.Location = new System.Drawing.Point(153, 146);
            this.CapacityTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CapacityTextBox.Name = "CapacityTextBox";
            this.CapacityTextBox.Size = new System.Drawing.Size(278, 24);
            this.CapacityTextBox.TabIndex = 2;
            this.CapacityTextBox.TextChanged += new System.EventHandler(this.CapacityTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.Black;
            this.NameLabel.Location = new System.Drawing.Point(89, 95);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(62, 23);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.ForeColor = System.Drawing.Color.Gray;
            this.IDTextBox.Location = new System.Drawing.Point(153, 44);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(278, 24);
            this.IDTextBox.TabIndex = 0;
            this.IDTextBox.TabStop = false;
            this.IDTextBox.Text = "auto increment";
            this.IDTextBox.Click += new System.EventHandler(this.IDTextBox_Click);
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            this.IDTextBox.Leave += new System.EventHandler(this.IDTextBox_Leave);
            // 
            // LocationLabel
            // 
            this.LocationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.ForeColor = System.Drawing.Color.Black;
            this.LocationLabel.Location = new System.Drawing.Point(68, 195);
            this.LocationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(81, 23);
            this.LocationLabel.TabIndex = 0;
            this.LocationLabel.Text = "Location:";
            // 
            // CapacityLabel
            // 
            this.CapacityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CapacityLabel.AutoSize = true;
            this.CapacityLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapacityLabel.ForeColor = System.Drawing.Color.Black;
            this.CapacityLabel.Location = new System.Drawing.Point(69, 147);
            this.CapacityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CapacityLabel.Name = "CapacityLabel";
            this.CapacityLabel.Size = new System.Drawing.Size(82, 23);
            this.CapacityLabel.TabIndex = 0;
            this.CapacityLabel.Text = "Capacity:";
            // 
            // Venues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1200, 850);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.DataPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venues";
            this.Text = "Venues";
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
        private System.Windows.Forms.Label VenuesHeading;
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
        private System.Windows.Forms.Label CapacityErrorLabel;
        private System.Windows.Forms.Label IDErrorLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.TextBox CapacityTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label CapacityLabel;
    }
}