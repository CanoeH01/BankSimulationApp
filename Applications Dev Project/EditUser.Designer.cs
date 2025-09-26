namespace Applications_Dev_Project
{
    partial class EditUser
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblUserName = new Label();
            groupBoxAccess = new GroupBox();
            comboBoxAccess = new ComboBox();
            lblAccess = new Label();
            txtUsername = new TextBox();
            btnSaveDetails = new Button();
            groupBoxPassword = new GroupBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnAccountStatus = new Button();
            lblAccountStatus = new Label();
            txtAccountStatus = new TextBox();
            btnDeleteAccount = new Button();
            groupBoxAccess.SuspendLayout();
            groupBoxPassword.SuspendLayout();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(178, 28);
            txtFirstName.Margin = new Padding(2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(178, 85);
            txtLastName.Margin = new Padding(2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(24, 28);
            lblFirstName.Margin = new Padding(2, 0, 2, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 25);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(24, 85);
            lblLastName.Margin = new Padding(2, 0, 2, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 25);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(22, 145);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(91, 25);
            lblUserName.TabIndex = 5;
            lblUserName.Text = "Username";
            // 
            // groupBoxAccess
            // 
            groupBoxAccess.Controls.Add(comboBoxAccess);
            groupBoxAccess.Controls.Add(lblAccess);
            groupBoxAccess.Location = new Point(11, 360);
            groupBoxAccess.Margin = new Padding(2);
            groupBoxAccess.Name = "groupBoxAccess";
            groupBoxAccess.Padding = new Padding(2);
            groupBoxAccess.Size = new Size(355, 76);
            groupBoxAccess.TabIndex = 6;
            groupBoxAccess.TabStop = false;
            // 
            // comboBoxAccess
            // 
            comboBoxAccess.FormattingEnabled = true;
            comboBoxAccess.Location = new Point(165, 35);
            comboBoxAccess.Margin = new Padding(2);
            comboBoxAccess.Name = "comboBoxAccess";
            comboBoxAccess.Size = new Size(150, 33);
            comboBoxAccess.TabIndex = 2;
            // 
            // lblAccess
            // 
            lblAccess.AutoSize = true;
            lblAccess.Location = new Point(12, 35);
            lblAccess.Margin = new Padding(2, 0, 2, 0);
            lblAccess.Name = "lblAccess";
            lblAccess.Size = new Size(65, 25);
            lblAccess.TabIndex = 1;
            lblAccess.Text = "Access";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(176, 145);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 31);
            txtUsername.TabIndex = 8;
            // 
            // btnSaveDetails
            // 
            btnSaveDetails.Location = new Point(438, 28);
            btnSaveDetails.Margin = new Padding(2);
            btnSaveDetails.Name = "btnSaveDetails";
            btnSaveDetails.Size = new Size(188, 34);
            btnSaveDetails.TabIndex = 9;
            btnSaveDetails.Text = "Save Details";
            btnSaveDetails.UseVisualStyleBackColor = true;
            btnSaveDetails.Click += btnSaveDetails_Click;
            // 
            // groupBoxPassword
            // 
            groupBoxPassword.Controls.Add(txtPassword);
            groupBoxPassword.Controls.Add(lblPassword);
            groupBoxPassword.Location = new Point(11, 261);
            groupBoxPassword.Margin = new Padding(2);
            groupBoxPassword.Name = "groupBoxPassword";
            groupBoxPassword.Padding = new Padding(2);
            groupBoxPassword.Size = new Size(355, 88);
            groupBoxPassword.TabIndex = 10;
            groupBoxPassword.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(165, 38);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 12;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 38);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password";
            // 
            // btnAccountStatus
            // 
            btnAccountStatus.Location = new Point(438, 82);
            btnAccountStatus.Margin = new Padding(2);
            btnAccountStatus.Name = "btnAccountStatus";
            btnAccountStatus.Size = new Size(188, 34);
            btnAccountStatus.TabIndex = 11;
            btnAccountStatus.Text = "Suspend Account";
            btnAccountStatus.UseVisualStyleBackColor = true;
            btnAccountStatus.Click += btnAccountStatus_Click;
            // 
            // lblAccountStatus
            // 
            lblAccountStatus.AutoSize = true;
            lblAccountStatus.Location = new Point(22, 214);
            lblAccountStatus.Margin = new Padding(2, 0, 2, 0);
            lblAccountStatus.Name = "lblAccountStatus";
            lblAccountStatus.Size = new Size(130, 25);
            lblAccountStatus.TabIndex = 12;
            lblAccountStatus.Text = "Account Status";
            // 
            // txtAccountStatus
            // 
            txtAccountStatus.Location = new Point(176, 211);
            txtAccountStatus.Margin = new Padding(2);
            txtAccountStatus.Name = "txtAccountStatus";
            txtAccountStatus.ReadOnly = true;
            txtAccountStatus.Size = new Size(150, 31);
            txtAccountStatus.TabIndex = 13;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(438, 140);
            btnDeleteAccount.Margin = new Padding(2);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(188, 34);
            btnDeleteAccount.TabIndex = 14;
            btnDeleteAccount.Text = "Delete Account";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 466);
            Controls.Add(btnDeleteAccount);
            Controls.Add(txtAccountStatus);
            Controls.Add(lblAccountStatus);
            Controls.Add(btnAccountStatus);
            Controls.Add(groupBoxPassword);
            Controls.Add(btnSaveDetails);
            Controls.Add(txtUsername);
            Controls.Add(groupBoxAccess);
            Controls.Add(lblUserName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Margin = new Padding(2);
            Name = "EditUser";
            Text = "EditUser";
            groupBoxAccess.ResumeLayout(false);
            groupBoxAccess.PerformLayout();
            groupBoxPassword.ResumeLayout(false);
            groupBoxPassword.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblUserName;
        private GroupBox groupBoxAccess;
        private Label lblAccess;
        private TextBox txtUsername;
        private ComboBox comboBoxAccess;
        private Button btnSaveDetails;
        private GroupBox groupBoxPassword;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnAccountStatus;
        private Label lblAccountStatus;
        private TextBox txtAccountStatus;
        private Button btnDeleteAccount;
    }
}