namespace Applications_Dev_Project
{
    partial class AdminHomePage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabsForAdminHome = new TabControl();
            tabHome = new TabPage();
            btnEditbalance = new Button();
            btnSplitTransaction = new Button();
            btnGenerateBalanceReport = new Button();
            lblBalanceWarning = new Label();
            txtNetWorth = new TextBox();
            lblNetWorth = new Label();
            btnSelectFromList = new Button();
            txtAddMember = new TextBox();
            btnPayUser = new Button();
            dgvTransactions = new DataGridView();
            btnLogout = new Button();
            dgvUserPockets = new DataGridView();
            btnNewPocket = new Button();
            txtUserBalance = new TextBox();
            lblUserBalance = new Label();
            lblWelcomeMessage = new Label();
            btnEditProfile = new Button();
            tabViewUsers = new TabPage();
            dgvUsers = new DataGridView();
            btnEditUser = new Button();
            tabContact = new TabPage();
            dgvContacts = new DataGridView();
            btnMessage = new Button();
            tabsForAdminHome.SuspendLayout();
            tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUserPockets).BeginInit();
            tabViewUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tabContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            SuspendLayout();
            // 
            // tabsForAdminHome
            // 
            tabsForAdminHome.Controls.Add(tabHome);
            tabsForAdminHome.Controls.Add(tabViewUsers);
            tabsForAdminHome.Controls.Add(tabContact);
            tabsForAdminHome.Location = new Point(11, 0);
            tabsForAdminHome.Margin = new Padding(2);
            tabsForAdminHome.Name = "tabsForAdminHome";
            tabsForAdminHome.SelectedIndex = 0;
            tabsForAdminHome.Size = new Size(1070, 606);
            tabsForAdminHome.TabIndex = 0;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(btnEditbalance);
            tabHome.Controls.Add(btnSplitTransaction);
            tabHome.Controls.Add(btnGenerateBalanceReport);
            tabHome.Controls.Add(lblBalanceWarning);
            tabHome.Controls.Add(txtNetWorth);
            tabHome.Controls.Add(lblNetWorth);
            tabHome.Controls.Add(btnSelectFromList);
            tabHome.Controls.Add(txtAddMember);
            tabHome.Controls.Add(btnPayUser);
            tabHome.Controls.Add(dgvTransactions);
            tabHome.Controls.Add(btnLogout);
            tabHome.Controls.Add(dgvUserPockets);
            tabHome.Controls.Add(btnNewPocket);
            tabHome.Controls.Add(txtUserBalance);
            tabHome.Controls.Add(lblUserBalance);
            tabHome.Controls.Add(lblWelcomeMessage);
            tabHome.Controls.Add(btnEditProfile);
            tabHome.Location = new Point(4, 29);
            tabHome.Name = "tabHome";
            tabHome.Size = new Size(1062, 573);
            tabHome.TabIndex = 3;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
            // 
            // btnEditbalance
            // 
            btnEditbalance.Location = new Point(15, 483);
            btnEditbalance.Margin = new Padding(2);
            btnEditbalance.Name = "btnEditbalance";
            btnEditbalance.Size = new Size(164, 27);
            btnEditbalance.TabIndex = 52;
            btnEditbalance.Text = "Deposit/Withdraw";
            btnEditbalance.UseVisualStyleBackColor = true;
            btnEditbalance.Click += btnEditbalance_Click;
            // 
            // btnSplitTransaction
            // 
            btnSplitTransaction.Location = new Point(369, 481);
            btnSplitTransaction.Name = "btnSplitTransaction";
            btnSplitTransaction.Size = new Size(141, 29);
            btnSplitTransaction.TabIndex = 50;
            btnSplitTransaction.Text = "Split Transaction";
            btnSplitTransaction.UseVisualStyleBackColor = true;
            btnSplitTransaction.Click += btnSplitTransaction_Click;
            // 
            // btnGenerateBalanceReport
            // 
            btnGenerateBalanceReport.Location = new Point(15, 537);
            btnGenerateBalanceReport.Name = "btnGenerateBalanceReport";
            btnGenerateBalanceReport.Size = new Size(251, 29);
            btnGenerateBalanceReport.TabIndex = 49;
            btnGenerateBalanceReport.Text = "Generate Balance Report";
            btnGenerateBalanceReport.UseVisualStyleBackColor = true;
            btnGenerateBalanceReport.Click += btnGenerateBalanceReport_Click;
            // 
            // lblBalanceWarning
            // 
            lblBalanceWarning.AutoSize = true;
            lblBalanceWarning.Enabled = false;
            lblBalanceWarning.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBalanceWarning.ForeColor = Color.Red;
            lblBalanceWarning.Location = new Point(213, 52);
            lblBalanceWarning.Name = "lblBalanceWarning";
            lblBalanceWarning.Size = new Size(101, 20);
            lblBalanceWarning.TabIndex = 48;
            lblBalanceWarning.Text = "Balance Low!";
            lblBalanceWarning.Visible = false;
            // 
            // txtNetWorth
            // 
            txtNetWorth.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtNetWorth.Location = new Point(923, 118);
            txtNetWorth.Name = "txtNetWorth";
            txtNetWorth.ReadOnly = true;
            txtNetWorth.Size = new Size(125, 30);
            txtNetWorth.TabIndex = 47;
            // 
            // lblNetWorth
            // 
            lblNetWorth.AutoSize = true;
            lblNetWorth.Location = new Point(803, 121);
            lblNetWorth.Name = "lblNetWorth";
            lblNetWorth.Size = new Size(114, 20);
            lblNetWorth.TabIndex = 46;
            lblNetWorth.Text = "Total Net Worth";
            // 
            // btnSelectFromList
            // 
            btnSelectFromList.Location = new Point(657, 7);
            btnSelectFromList.Name = "btnSelectFromList";
            btnSelectFromList.Size = new Size(124, 29);
            btnSelectFromList.TabIndex = 45;
            btnSelectFromList.Text = "Select From List";
            btnSelectFromList.UseVisualStyleBackColor = true;
            btnSelectFromList.Click += btnSelectFromList_Click;
            // 
            // txtAddMember
            // 
            txtAddMember.Location = new Point(787, 7);
            txtAddMember.Name = "txtAddMember";
            txtAddMember.PlaceholderText = "Username";
            txtAddMember.Size = new Size(241, 27);
            txtAddMember.TabIndex = 44;
            // 
            // btnPayUser
            // 
            btnPayUser.Location = new Point(917, 40);
            btnPayUser.Name = "btnPayUser";
            btnPayUser.Size = new Size(111, 29);
            btnPayUser.TabIndex = 43;
            btnPayUser.Text = "Transfer Funds";
            btnPayUser.UseVisualStyleBackColor = false;
            btnPayUser.Click += btnPayUser_Click;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AllowUserToOrderColumns = true;
            dgvTransactions.AllowUserToResizeColumns = false;
            dgvTransactions.AllowUserToResizeRows = false;
            dgvTransactions.Anchor = AnchorStyles.None;
            dgvTransactions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTransactions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvTransactions.DefaultCellStyle = dataGridViewCellStyle1;
            dgvTransactions.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dgvTransactions.Location = new Point(15, 151);
            dgvTransactions.MultiSelect = false;
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.RowHeadersWidth = 51;
            dgvTransactions.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvTransactions.RowTemplate.Height = 29;
            dgvTransactions.ScrollBars = ScrollBars.Vertical;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Size = new Size(495, 324);
            dgvTransactions.TabIndex = 42;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(954, 537);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 41;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvUserPockets
            // 
            dgvUserPockets.AllowUserToAddRows = false;
            dgvUserPockets.AllowUserToDeleteRows = false;
            dgvUserPockets.AllowUserToResizeColumns = false;
            dgvUserPockets.AllowUserToResizeRows = false;
            dgvUserPockets.Anchor = AnchorStyles.None;
            dgvUserPockets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserPockets.ColumnHeadersVisible = false;
            dgvUserPockets.Cursor = Cursors.Hand;
            dgvUserPockets.Location = new Point(621, 151);
            dgvUserPockets.MultiSelect = false;
            dgvUserPockets.Name = "dgvUserPockets";
            dgvUserPockets.RowHeadersVisible = false;
            dgvUserPockets.RowHeadersWidth = 51;
            dgvUserPockets.RowTemplate.Height = 29;
            dgvUserPockets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUserPockets.Size = new Size(427, 324);
            dgvUserPockets.TabIndex = 40;
            dgvUserPockets.CellClick += dgvUserPockets_CellClick;
            // 
            // btnNewPocket
            // 
            btnNewPocket.Location = new Point(621, 119);
            btnNewPocket.Name = "btnNewPocket";
            btnNewPocket.Size = new Size(143, 29);
            btnNewPocket.TabIndex = 39;
            btnNewPocket.Text = "Create New Pocket";
            btnNewPocket.UseVisualStyleBackColor = true;
            btnNewPocket.Click += btnNewPocket_Click;
            // 
            // txtUserBalance
            // 
            txtUserBalance.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserBalance.Location = new Point(82, 47);
            txtUserBalance.Name = "txtUserBalance";
            txtUserBalance.ReadOnly = true;
            txtUserBalance.Size = new Size(125, 30);
            txtUserBalance.TabIndex = 38;
            // 
            // lblUserBalance
            // 
            lblUserBalance.AutoSize = true;
            lblUserBalance.Location = new Point(15, 50);
            lblUserBalance.Name = "lblUserBalance";
            lblUserBalance.Size = new Size(61, 20);
            lblUserBalance.TabIndex = 37;
            lblUserBalance.Text = "Balance";
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Location = new Point(15, 14);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(78, 20);
            lblWelcomeMessage.TabIndex = 36;
            lblWelcomeMessage.Text = "Welcome, ";
            // 
            // btnEditProfile
            // 
            btnEditProfile.Location = new Point(15, 89);
            btnEditProfile.Margin = new Padding(2);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(90, 27);
            btnEditProfile.TabIndex = 35;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = true;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // tabViewUsers
            // 
            tabViewUsers.Controls.Add(dgvUsers);
            tabViewUsers.Controls.Add(btnEditUser);
            tabViewUsers.Location = new Point(4, 29);
            tabViewUsers.Margin = new Padding(2);
            tabViewUsers.Name = "tabViewUsers";
            tabViewUsers.Padding = new Padding(2);
            tabViewUsers.Size = new Size(1062, 573);
            tabViewUsers.TabIndex = 1;
            tabViewUsers.Text = "Users";
            tabViewUsers.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.Height = 29;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1062, 537);
            dgvUsers.TabIndex = 2;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(968, 542);
            btnEditUser.Margin = new Padding(2);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(90, 27);
            btnEditUser.TabIndex = 1;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // tabContact
            // 
            tabContact.Controls.Add(dgvContacts);
            tabContact.Controls.Add(btnMessage);
            tabContact.Location = new Point(4, 29);
            tabContact.Margin = new Padding(2);
            tabContact.Name = "tabContact";
            tabContact.Padding = new Padding(2);
            tabContact.Size = new Size(1062, 573);
            tabContact.TabIndex = 2;
            tabContact.Text = "Support Requests";
            tabContact.UseVisualStyleBackColor = true;
            // 
            // dgvContacts
            // 
            dgvContacts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContacts.Location = new Point(4, 4);
            dgvContacts.Margin = new Padding(2);
            dgvContacts.MultiSelect = false;
            dgvContacts.Name = "dgvContacts";
            dgvContacts.RowHeadersWidth = 62;
            dgvContacts.RowTemplate.Height = 33;
            dgvContacts.ScrollBars = ScrollBars.Vertical;
            dgvContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContacts.Size = new Size(1054, 534);
            dgvContacts.TabIndex = 1;
            // 
            // btnMessage
            // 
            btnMessage.Location = new Point(925, 542);
            btnMessage.Margin = new Padding(2);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new Size(133, 27);
            btnMessage.TabIndex = 0;
            btnMessage.Text = "View Message";
            btnMessage.UseVisualStyleBackColor = true;
            btnMessage.Click += btnMessage_Click;
            // 
            // AdminHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 627);
            Controls.Add(tabsForAdminHome);
            Margin = new Padding(2);
            Name = "AdminHomePage";
            Text = "AdminHomePage";
            tabsForAdminHome.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUserPockets).EndInit();
            tabViewUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tabContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabsForAdminHome;
        private TabPage tabViewUsers;
        private Button btnEditUser;
        private TabPage tabContact;
        private DataGridView dgvUsers;
        private DataGridView dgvContacts;
        private Button btnMessage;
        private TabPage tabHome;
        private Button btnEditbalance;
        private Button btnSplitTransaction;
        private Button btnGenerateBalanceReport;
        private Label lblBalanceWarning;
        private TextBox txtNetWorth;
        private Label lblNetWorth;
        private Button btnSelectFromList;
        private TextBox txtAddMember;
        private Button btnPayUser;
        private DataGridView dgvTransactions;
        private Button btnLogout;
        private DataGridView dgvUserPockets;
        private Button btnNewPocket;
        private TextBox txtUserBalance;
        private Label lblUserBalance;
        private Label lblWelcomeMessage;
        private Button btnEditProfile;
    }
}