namespace ITEC_Event_Management_System
{
    partial class Signup
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
            this.components = new System.ComponentModel.Container();
            this.ITECHeading = new System.Windows.Forms.Label();
            this.SignupButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LogInLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SignInLabel = new System.Windows.Forms.Label();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.ToggleShowPassword = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SignupRole = new System.Windows.Forms.ComboBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.AccountTypeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.UsernameErrorLabel = new System.Windows.Forms.Label();
            this.EmailErrorLabel = new System.Windows.Forms.Label();
            this.PasswordErrorLabel = new System.Windows.Forms.Label();
            this.DataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ITECHeading
            // 
            this.ITECHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ITECHeading.AutoSize = true;
            this.ITECHeading.Font = new System.Drawing.Font("Arial Black", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITECHeading.ForeColor = System.Drawing.Color.DarkOrange;
            this.ITECHeading.Location = new System.Drawing.Point(325, 9);
            this.ITECHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ITECHeading.Name = "ITECHeading";
            this.ITECHeading.Size = new System.Drawing.Size(488, 83);
            this.ITECHeading.TabIndex = 1;
            this.ITECHeading.Text = "ITEC Manager";
            // 
            // SignupButton
            // 
            this.SignupButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SignupButton.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupButton.ForeColor = System.Drawing.Color.Transparent;
            this.SignupButton.Location = new System.Drawing.Point(400, 472);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(214, 54);
            this.SignupButton.TabIndex = 6;
            this.SignupButton.Text = "Sign up";
            this.SignupButton.UseVisualStyleBackColor = false;
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Chocolate;
            this.LoginButton.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.Transparent;
            this.LoginButton.Location = new System.Drawing.Point(34, 44);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(214, 54);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(244, 264);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(370, 28);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // LogInLabel
            // 
            this.LogInLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLabel.ForeColor = System.Drawing.Color.Black;
            this.LogInLabel.Location = new System.Drawing.Point(28, 8);
            this.LogInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(201, 20);
            this.LogInLabel.TabIndex = 0;
            this.LogInLabel.Text = "Already have an account?";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.PasswordLabel.Location = new System.Drawing.Point(122, 263);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(118, 29);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(244, 139);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(370, 28);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            this.UsernameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsernameTextBox_KeyDown);
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.Black;
            this.UsernameLabel.Location = new System.Drawing.Point(116, 138);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(124, 29);
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
            this.SignInLabel.Location = new System.Drawing.Point(425, 22);
            this.SignInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(186, 63);
            this.SignInLabel.TabIndex = 0;
            this.SignInLabel.Text = "Sign up";
            // 
            // DataPanel
            // 
            this.DataPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataPanel.Controls.Add(this.ToggleShowPassword);
            this.DataPanel.Controls.Add(this.PasswordErrorLabel);
            this.DataPanel.Controls.Add(this.EmailErrorLabel);
            this.DataPanel.Controls.Add(this.UsernameErrorLabel);
            this.DataPanel.Controls.Add(this.ErrorLabel);
            this.DataPanel.Controls.Add(this.SignupRole);
            this.DataPanel.Controls.Add(this.SignupButton);
            this.DataPanel.Controls.Add(this.SignInLabel);
            this.DataPanel.Controls.Add(this.UsernameLabel);
            this.DataPanel.Controls.Add(this.EmailTextBox);
            this.DataPanel.Controls.Add(this.ConfirmPasswordTextBox);
            this.DataPanel.Controls.Add(this.PasswordTextBox);
            this.DataPanel.Controls.Add(this.EmailLabel);
            this.DataPanel.Controls.Add(this.UsernameTextBox);
            this.DataPanel.Controls.Add(this.ConfirmPasswordLabel);
            this.DataPanel.Controls.Add(this.AccountTypeLabel);
            this.DataPanel.Controls.Add(this.PasswordLabel);
            this.DataPanel.Location = new System.Drawing.Point(53, 112);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(654, 577);
            this.DataPanel.TabIndex = 3;
            // 
            // ToggleShowPassword
            // 
            this.ToggleShowPassword.AutoSize = true;
            this.ToggleShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleShowPassword.ForeColor = System.Drawing.Color.Red;
            this.ToggleShowPassword.Location = new System.Drawing.Point(479, 389);
            this.ToggleShowPassword.Name = "ToggleShowPassword";
            this.ToggleShowPassword.Size = new System.Drawing.Size(129, 20);
            this.ToggleShowPassword.TabIndex = 9;
            this.ToggleShowPassword.Text = "Show Password";
            this.ToggleShowPassword.Click += new System.EventHandler(this.ToggleShowPassword_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Black;
            this.ErrorLabel.Location = new System.Drawing.Point(251, 441);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 24);
            this.ErrorLabel.TabIndex = 8;
            // 
            // SignupRole
            // 
            this.SignupRole.BackColor = System.Drawing.SystemColors.Window;
            this.SignupRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SignupRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupRole.FormattingEnabled = true;
            this.SignupRole.Items.AddRange(new object[] {
            "Student Participant",
            "Sponsor"});
            this.SignupRole.Location = new System.Drawing.Point(244, 386);
            this.SignupRole.Name = "SignupRole";
            this.SignupRole.Size = new System.Drawing.Size(216, 28);
            this.SignupRole.TabIndex = 5;
            this.SignupRole.SelectedIndexChanged += new System.EventHandler(this.SignupRole_SelectedIndexChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(244, 203);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(370, 28);
            this.EmailTextBox.TabIndex = 2;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            this.EmailTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmailTextBox_KeyDown);
            this.EmailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(244, 325);
            this.ConfirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '*';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(370, 28);
            this.ConfirmPasswordTextBox.TabIndex = 4;
            this.ConfirmPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfirmPasswordTextBox_KeyDown_1);
            this.ConfirmPasswordTextBox.Leave += new System.EventHandler(this.ConfirmPasswordTextBox_Leave);
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.Black;
            this.EmailLabel.Location = new System.Drawing.Point(159, 202);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(81, 29);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email: ";
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(36, 325);
            this.ConfirmPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(204, 29);
            this.ConfirmPasswordLabel.TabIndex = 0;
            this.ConfirmPasswordLabel.Text = "Confirm Password:";
            // 
            // AccountTypeLabel
            // 
            this.AccountTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountTypeLabel.AutoSize = true;
            this.AccountTypeLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.AccountTypeLabel.Location = new System.Drawing.Point(85, 383);
            this.AccountTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccountTypeLabel.Name = "AccountTypeLabel";
            this.AccountTypeLabel.Size = new System.Drawing.Size(154, 29);
            this.AccountTypeLabel.TabIndex = 0;
            this.AccountTypeLabel.Text = "Account Type:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 140);
            this.label1.TabIndex = 4;
            this.label1.Text = "You can create only Student\r\nParticipant or Sponsor account.\r\n\r\nTo get a Faculty " +
    "account,\r\ncontact the management.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ITEC_Event_Management_System.Properties.Resources.InfoIcon;
            this.pictureBox1.Location = new System.Drawing.Point(98, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InfoPanel.Controls.Add(this.pictureBox1);
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Location = new System.Drawing.Point(769, 159);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(308, 273);
            this.InfoPanel.TabIndex = 8;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginPanel.Controls.Add(this.LogInLabel);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Location = new System.Drawing.Point(798, 529);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(256, 101);
            this.LoginPanel.TabIndex = 9;
            // 
            // UsernameErrorLabel
            // 
            this.UsernameErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameErrorLabel.AutoSize = true;
            this.UsernameErrorLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.UsernameErrorLabel.Location = new System.Drawing.Point(444, 171);
            this.UsernameErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameErrorLabel.Name = "UsernameErrorLabel";
            this.UsernameErrorLabel.Size = new System.Drawing.Size(170, 21);
            this.UsernameErrorLabel.TabIndex = 8;
            this.UsernameErrorLabel.Text = "This user already exists";
            this.UsernameErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.UsernameErrorLabel.Visible = false;
            // 
            // EmailErrorLabel
            // 
            this.EmailErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailErrorLabel.AutoSize = true;
            this.EmailErrorLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.EmailErrorLabel.Location = new System.Drawing.Point(458, 235);
            this.EmailErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailErrorLabel.Name = "EmailErrorLabel";
            this.EmailErrorLabel.Size = new System.Drawing.Size(150, 21);
            this.EmailErrorLabel.TabIndex = 8;
            this.EmailErrorLabel.Text = "Invalid email format";
            this.EmailErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.EmailErrorLabel.Visible = false;
            // 
            // PasswordErrorLabel
            // 
            this.PasswordErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordErrorLabel.AutoSize = true;
            this.PasswordErrorLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.PasswordErrorLabel.Location = new System.Drawing.Point(424, 357);
            this.PasswordErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordErrorLabel.Name = "PasswordErrorLabel";
            this.PasswordErrorLabel.Size = new System.Drawing.Size(190, 21);
            this.PasswordErrorLabel.TabIndex = 8;
            this.PasswordErrorLabel.Text = "Password does not match";
            this.PasswordErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.PasswordErrorLabel.Visible = false;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 686);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.ITECHeading);
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ITECHeading;
        private System.Windows.Forms.Button SignupButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox SignupRole;
        private System.Windows.Forms.Label AccountTypeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label ToggleShowPassword;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label UsernameErrorLabel;
        private System.Windows.Forms.Label PasswordErrorLabel;
        private System.Windows.Forms.Label EmailErrorLabel;
    }
}