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
            this.SignupButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SignInLabel = new System.Windows.Forms.Label();
            this.ITECHeading = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
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
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.LeftPanel.MinimumSize = new System.Drawing.Size(334, 599);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(334, 653);
            this.LeftPanel.TabIndex = 0;
            // 
            // LeftPicture
            // 
            this.LeftPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPicture.Image = global::ITEC_Event_Management_System.Properties.Resources.FrontPageImage;
            this.LeftPicture.Location = new System.Drawing.Point(0, 0);
            this.LeftPicture.Margin = new System.Windows.Forms.Padding(0);
            this.LeftPicture.MinimumSize = new System.Drawing.Size(334, 599);
            this.LeftPicture.Name = "LeftPicture";
            this.LeftPicture.Size = new System.Drawing.Size(334, 653);
            this.LeftPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftPicture.TabIndex = 0;
            this.LeftPicture.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TopPanel.Controls.Add(this.SignupButton);
            this.TopPanel.Controls.Add(this.LoginButton);
            this.TopPanel.Controls.Add(this.PasswordTextBox);
            this.TopPanel.Controls.Add(this.ErrorLabel);
            this.TopPanel.Controls.Add(this.SignUpLabel);
            this.TopPanel.Controls.Add(this.PasswordLabel);
            this.TopPanel.Controls.Add(this.UsernameTextBox);
            this.TopPanel.Controls.Add(this.UsernameLabel);
            this.TopPanel.Controls.Add(this.SignInLabel);
            this.TopPanel.Location = new System.Drawing.Point(365, 138);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TopPanel.MinimumSize = new System.Drawing.Size(550, 599);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(706, 599);
            this.TopPanel.TabIndex = 1;
            // 
            // SignupButton
            // 
            this.SignupButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SignupButton.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupButton.ForeColor = System.Drawing.Color.Transparent;
            this.SignupButton.Location = new System.Drawing.Point(423, 416);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(214, 54);
            this.SignupButton.TabIndex = 4;
            this.SignupButton.Text = "Sign up";
            this.SignupButton.UseVisualStyleBackColor = false;
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Chocolate;
            this.LoginButton.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.Transparent;
            this.LoginButton.Location = new System.Drawing.Point(423, 287);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(214, 54);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(187, 221);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(370, 28);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.PasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.ForeColor = System.Drawing.Color.Black;
            this.SignUpLabel.Location = new System.Drawing.Point(182, 433);
            this.SignUpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(217, 25);
            this.SignUpLabel.TabIndex = 0;
            this.SignUpLabel.Text = "Don\'t have an account?";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.PasswordLabel.Location = new System.Drawing.Point(30, 216);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(134, 35);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(187, 150);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(370, 28);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            this.UsernameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsernameTextBox_KeyDown);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.Black;
            this.UsernameLabel.Location = new System.Drawing.Point(26, 150);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(138, 33);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username:";
            // 
            // SignInLabel
            // 
            this.SignInLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignInLabel.AutoSize = true;
            this.SignInLabel.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.SignInLabel.Location = new System.Drawing.Point(276, 33);
            this.SignInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(173, 63);
            this.SignInLabel.TabIndex = 0;
            this.SignInLabel.Text = "Sign in";
            // 
            // ITECHeading
            // 
            this.ITECHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ITECHeading.AutoSize = true;
            this.ITECHeading.Font = new System.Drawing.Font("Arial Black", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITECHeading.ForeColor = System.Drawing.Color.DarkOrange;
            this.ITECHeading.Location = new System.Drawing.Point(463, 9);
            this.ITECHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ITECHeading.Name = "ITECHeading";
            this.ITECHeading.Size = new System.Drawing.Size(488, 83);
            this.ITECHeading.TabIndex = 0;
            this.ITECHeading.Text = "ITEC Manager";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Black;
            this.ErrorLabel.Location = new System.Drawing.Point(182, 304);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 24);
            this.ErrorLabel.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.ITECHeading);
            this.Controls.Add(this.LeftPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MinimumSize = new System.Drawing.Size(589, 381);
            this.Name = "Login";
            this.Text = "ITEC Event Manager";
            this.Load += new System.EventHandler(this.Login_Load);
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftPicture)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.PictureBox LeftPicture;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label ITECHeading;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Button SignupButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

