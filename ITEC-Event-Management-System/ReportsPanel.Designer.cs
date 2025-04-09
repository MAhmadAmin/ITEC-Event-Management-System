namespace ITEC_Event_Management_System
{
    partial class ReportsPanel
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.IncomeandExpensesButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ParticipantsButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.EventSchedulesButton = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TopPanel.Controls.Add(this.EventSchedulesButton);
            this.TopPanel.Controls.Add(this.IncomeandExpensesButton);
            this.TopPanel.Controls.Add(this.button1);
            this.TopPanel.Controls.Add(this.ParticipantsButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1665, 76);
            this.TopPanel.TabIndex = 0;
            // 
            // IncomeandExpensesButton
            // 
            this.IncomeandExpensesButton.BackColor = System.Drawing.Color.ForestGreen;
            this.IncomeandExpensesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncomeandExpensesButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeandExpensesButton.ForeColor = System.Drawing.Color.White;
            this.IncomeandExpensesButton.Location = new System.Drawing.Point(429, 28);
            this.IncomeandExpensesButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IncomeandExpensesButton.Name = "IncomeandExpensesButton";
            this.IncomeandExpensesButton.Size = new System.Drawing.Size(180, 33);
            this.IncomeandExpensesButton.TabIndex = 9;
            this.IncomeandExpensesButton.Text = "Income n Expenses";
            this.IncomeandExpensesButton.UseVisualStyleBackColor = false;
            this.IncomeandExpensesButton.Click += new System.EventHandler(this.IncomeandExpensesButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(207, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Committee Assignments";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ParticipantsButton
            // 
            this.ParticipantsButton.BackColor = System.Drawing.Color.ForestGreen;
            this.ParticipantsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParticipantsButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParticipantsButton.ForeColor = System.Drawing.Color.White;
            this.ParticipantsButton.Location = new System.Drawing.Point(23, 28);
            this.ParticipantsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ParticipantsButton.Name = "ParticipantsButton";
            this.ParticipantsButton.Size = new System.Drawing.Size(180, 33);
            this.ParticipantsButton.TabIndex = 7;
            this.ParticipantsButton.Text = "Participants";
            this.ParticipantsButton.UseVisualStyleBackColor = false;
            this.ParticipantsButton.Click += new System.EventHandler(this.ParticipantsButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 76);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1665, 781);
            this.MainPanel.TabIndex = 1;
            // 
            // EventSchedulesButton
            // 
            this.EventSchedulesButton.BackColor = System.Drawing.Color.ForestGreen;
            this.EventSchedulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventSchedulesButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventSchedulesButton.ForeColor = System.Drawing.Color.White;
            this.EventSchedulesButton.Location = new System.Drawing.Point(613, 28);
            this.EventSchedulesButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EventSchedulesButton.Name = "EventSchedulesButton";
            this.EventSchedulesButton.Size = new System.Drawing.Size(180, 33);
            this.EventSchedulesButton.TabIndex = 10;
            this.EventSchedulesButton.Text = "Event Schedules";
            this.EventSchedulesButton.UseVisualStyleBackColor = false;
            this.EventSchedulesButton.Click += new System.EventHandler(this.EventSchedulesButton_Click);
            // 
            // ReportsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 857);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsPanel";
            this.Text = "ReportsPanel";
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button ParticipantsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button IncomeandExpensesButton;
        private System.Windows.Forms.Button EventSchedulesButton;
    }
}