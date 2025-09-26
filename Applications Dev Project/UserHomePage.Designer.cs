namespace Applications_Dev_Project
{
    partial class UserHomePage
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
            btnEditProfile = new Button();
            lblWelcomeMessage = new Label();
            lblUserBalance = new Label();
            txtUserBalance = new TextBox();
            btnNewPocket = new Button();
            dgvUserPockets = new DataGridView();
            btnLogout = new Button();
            dgvTransactions = new DataGridView();
            btnSelectFromList = new Button();
            txtAddMember = new TextBox();
            btnPayUser = new Button();
            txtNetWorth = new TextBox();
            lblNetWorth = new Label();
            lblBalanceWarning = new Label();
            btnGenerateBalanceReport = new Button();
            btnSplitTransaction = new Button();
            btnContactSupport = new Button();
            btnEditbalance = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUserPockets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // btnEditProfile
            // 
            btnEditProfile.Location = new Point(28, 102);
            btnEditProfile.Margin = new Padding(2);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(90, 27);
            btnEditProfile.TabIndex = 0;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = true;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Location = new Point(28, 27);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(78, 20);
            lblWelcomeMessage.TabIndex = 1;
            lblWelcomeMessage.Text = "Welcome, ";
            // 
            // lblUserBalance
            // 
            lblUserBalance.AutoSize = true;
            lblUserBalance.Location = new Point(28, 63);
            lblUserBalance.Name = "lblUserBalance";
            lblUserBalance.Size = new Size(61, 20);
            lblUserBalance.TabIndex = 2;
            lblUserBalance.Text = "Balance";
            // 
            // txtUserBalance
            // 
            txtUserBalance.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserBalance.Location = new Point(95, 60);
            txtUserBalance.Name = "txtUserBalance";
            txtUserBalance.ReadOnly = true;
            txtUserBalance.Size = new Size(125, 30);
            txtUserBalance.TabIndex = 3;
            // 
            // btnNewPocket
            // 
            btnNewPocket.Location = new Point(634, 132);
            btnNewPocket.Name = "btnNewPocket";
            btnNewPocket.Size = new Size(143, 29);
            btnNewPocket.TabIndex = 4;
            btnNewPocket.Text = "Create New Pocket";
            btnNewPocket.UseVisualStyleBackColor = true;
            btnNewPocket.Click += btnNewPocket_Click;
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
            dgvUserPockets.Location = new Point(634, 164);
            dgvUserPockets.MultiSelect = false;
            dgvUserPockets.Name = "dgvUserPockets";
            dgvUserPockets.RowHeadersVisible = false;
            dgvUserPockets.RowHeadersWidth = 51;
            dgvUserPockets.RowTemplate.Height = 29;
            dgvUserPockets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUserPockets.Size = new Size(427, 324);
            dgvUserPockets.TabIndex = 5;
            dgvUserPockets.CellClick += dgvUserPockets_CellClick;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(967, 550);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
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
            dgvTransactions.Location = new Point(28, 164);
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
            dgvTransactions.TabIndex = 7;
            // 
            // btnSelectFromList
            // 
            btnSelectFromList.Location = new Point(670, 20);
            btnSelectFromList.Name = "btnSelectFromList";
            btnSelectFromList.Size = new Size(124, 29);
            btnSelectFromList.TabIndex = 26;
            btnSelectFromList.Text = "Select From List";
            btnSelectFromList.UseVisualStyleBackColor = true;
            btnSelectFromList.Click += btnSelectFromList_Click;
            // 
            // txtAddMember
            // 
            txtAddMember.Location = new Point(800, 20);
            txtAddMember.Name = "txtAddMember";
            txtAddMember.PlaceholderText = "Username";
            txtAddMember.Size = new Size(241, 27);
            txtAddMember.TabIndex = 25;
            // 
            // btnPayUser
            // 
            btnPayUser.Location = new Point(930, 53);
            btnPayUser.Name = "btnPayUser";
            btnPayUser.Size = new Size(111, 29);
            btnPayUser.TabIndex = 24;
            btnPayUser.Text = "Transfer Funds";
            btnPayUser.UseVisualStyleBackColor = false;
            btnPayUser.Click += btnPayUser_Click;
            // 
            // txtNetWorth
            // 
            txtNetWorth.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtNetWorth.Location = new Point(936, 131);
            txtNetWorth.Name = "txtNetWorth";
            txtNetWorth.ReadOnly = true;
            txtNetWorth.Size = new Size(125, 30);
            txtNetWorth.TabIndex = 28;
            // 
            // lblNetWorth
            // 
            lblNetWorth.AutoSize = true;
            lblNetWorth.Location = new Point(816, 134);
            lblNetWorth.Name = "lblNetWorth";
            lblNetWorth.Size = new Size(114, 20);
            lblNetWorth.TabIndex = 27;
            lblNetWorth.Text = "Total Net Worth";
            // 
            // lblBalanceWarning
            // 
            lblBalanceWarning.AutoSize = true;
            lblBalanceWarning.Enabled = false;
            lblBalanceWarning.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBalanceWarning.ForeColor = Color.Red;
            lblBalanceWarning.Location = new Point(226, 65);
            lblBalanceWarning.Name = "lblBalanceWarning";
            lblBalanceWarning.Size = new Size(101, 20);
            lblBalanceWarning.TabIndex = 29;
            lblBalanceWarning.Text = "Balance Low!";
            lblBalanceWarning.Visible = false;
            // 
            // btnGenerateBalanceReport
            // 
            btnGenerateBalanceReport.Location = new Point(28, 550);
            btnGenerateBalanceReport.Name = "btnGenerateBalanceReport";
            btnGenerateBalanceReport.Size = new Size(251, 29);
            btnGenerateBalanceReport.TabIndex = 30;
            btnGenerateBalanceReport.Text = "Generate Balance Report";
            btnGenerateBalanceReport.UseVisualStyleBackColor = true;
            btnGenerateBalanceReport.Click += btnGenerateBalanceReport_Click;
            // 
            // btnSplitTransaction
            // 
            btnSplitTransaction.Location = new Point(382, 494);
            btnSplitTransaction.Name = "btnSplitTransaction";
            btnSplitTransaction.Size = new Size(141, 29);
            btnSplitTransaction.TabIndex = 31;
            btnSplitTransaction.Text = "Split Transaction";
            btnSplitTransaction.UseVisualStyleBackColor = true;
            btnSplitTransaction.Click += btnSplitTransaction_Click;
            // 
            // btnContactSupport
            // 
            btnContactSupport.Location = new Point(816, 550);
            btnContactSupport.Name = "btnContactSupport";
            btnContactSupport.Size = new Size(130, 29);
            btnContactSupport.TabIndex = 32;
            btnContactSupport.Text = "Contact Support";
            btnContactSupport.UseVisualStyleBackColor = true;
            btnContactSupport.Click += btnContactSupport_Click;
            // 
            // btnEditbalance
            // 
            btnEditbalance.Location = new Point(28, 496);
            btnEditbalance.Margin = new Padding(2);
            btnEditbalance.Name = "btnEditbalance";
            btnEditbalance.Size = new Size(164, 27);
            btnEditbalance.TabIndex = 34;
            btnEditbalance.Text = "Deposit/Withdraw";
            btnEditbalance.UseVisualStyleBackColor = true;
            btnEditbalance.Click += btnEditbalance_Click;
            // 
            // UserHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 591);
            Controls.Add(btnEditbalance);
            Controls.Add(btnContactSupport);
            Controls.Add(btnSplitTransaction);
            Controls.Add(btnGenerateBalanceReport);
            Controls.Add(lblBalanceWarning);
            Controls.Add(txtNetWorth);
            Controls.Add(lblNetWorth);
            Controls.Add(btnSelectFromList);
            Controls.Add(txtAddMember);
            Controls.Add(btnPayUser);
            Controls.Add(dgvTransactions);
            Controls.Add(btnLogout);
            Controls.Add(dgvUserPockets);
            Controls.Add(btnNewPocket);
            Controls.Add(txtUserBalance);
            Controls.Add(lblUserBalance);
            Controls.Add(lblWelcomeMessage);
            Controls.Add(btnEditProfile);
            Margin = new Padding(2);
            Name = "UserHomePage";
            Text = "UserHomePage";
            ((System.ComponentModel.ISupportInitialize)dgvUserPockets).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditProfile;
        private Label lblWelcomeMessage;
        private Label lblUserBalance;
        private TextBox txtUserBalance;
        private Button btnNewPocket;
        private DataGridView dgvUserPockets;
        private Button btnLogout;
        private DataGridView dgvTransactions;
        private Button btnSelectFromList;
        private TextBox txtAddMember;
        private Button btnPayUser;
        private TextBox txtNetWorth;
        private Label lblNetWorth;
        private Label lblBalanceWarning;
        private Button btnGenerateBalanceReport;
        private Button btnSplitTransaction;
        private Button btnContactSupport;
        private Button btnEditbalance;
    }
}