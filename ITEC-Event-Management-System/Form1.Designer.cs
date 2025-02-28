namespace ITEC_Event_Management_System
{
    partial class Login
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LeftPicture = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ITECHeading = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPicture)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.LeftPicture);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(668, 1112);
            this.LeftPanel.TabIndex = 0;
            // 
            // LeftPicture
            // 
            this.LeftPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPicture.Image = global::ITEC_Event_Management_System.Properties.Resources.FrontPageImage;
            this.LeftPicture.Location = new System.Drawing.Point(0, 0);
            this.LeftPicture.Margin = new System.Windows.Forms.Padding(0);
            this.LeftPicture.Name = "LeftPicture";
            this.LeftPicture.Size = new System.Drawing.Size(668, 1112);
            this.LeftPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftPicture.TabIndex = 0;
            this.LeftPicture.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.textBox1);
            this.TopPanel.Controls.Add(this.ITECHeading);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TopPanel.Location = new System.Drawing.Point(867, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1101, 1112);
            this.TopPanel.TabIndex = 1;
            // 
            // ITECHeading
            // 
            this.ITECHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ITECHeading.AutoSize = true;
            this.ITECHeading.Font = new System.Drawing.Font("Arial Black", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITECHeading.ForeColor = System.Drawing.Color.DarkOrange;
            this.ITECHeading.Location = new System.Drawing.Point(335, 46);
            this.ITECHeading.Name = "ITECHeading";
            this.ITECHeading.Size = new System.Drawing.Size(555, 95);
            this.ITECHeading.TabIndex = 0;
            this.ITECHeading.Text = "ITEC Manager";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 338);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(735, 38);
            this.textBox1.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1968, 1112);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.MinimumSize = new System.Drawing.Size(2000, 1200);
            this.Name = "Login";
            this.Text = "ITEC Event Manager";
            this.Load += new System.EventHandler(this.Login_Load);
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftPicture)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.PictureBox LeftPicture;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label ITECHeading;
        private System.Windows.Forms.TextBox textBox1;
    }
}

