namespace Applications_Dev_Project
{
    partial class ViewPocket
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnWithdraw = new Button();
            btnDeposit = new Button();
            dgvTransactions = new DataGridView();
            lblDeadline = new Label();
            txtGoal = new TextBox();
            lblGoal = new Label();
            txtBalance = new TextBox();
            lblPocketName = new Label();
            lblMembers = new Label();
            btnAddMembers = new Button();
            txtAddMember = new TextBox();
            btnSelectFromList = new Button();
            btnLeavePocket = new Button();
            btnDeletePocket = new Button();
            btnRemoveMember = new Button();
            btnSettings = new Button();
            btnPromote = new Button();
            btnDemote = new Button();
            dgvPocketMembers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPocketMembers).BeginInit();
            SuspendLayout();
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(123, 452);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(94, 29);
            btnWithdraw.TabIndex = 15;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(23, 452);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(94, 29);
            btnDeposit.TabIndex = 14;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
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
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvTransactions.DefaultCellStyle = dataGridViewCellStyle1;
            dgvTransactions.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dgvTransactions.Location = new Point(23, 109);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.RowHeadersWidth = 51;
            dgvTransactions.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvTransactions.RowTemplate.Height = 29;
            dgvTransactions.ScrollBars = ScrollBars.Vertical;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Size = new Size(495, 324);
            dgvTransactions.TabIndex = 1;
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Location = new Point(799, 579);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(129, 20);
            lblDeadline.TabIndex = 12;
            lblDeadline.Text = "By [deadlineDate]";
            // 
            // txtGoal
            // 
            txtGoal.Cursor = Cursors.Hand;
            txtGoal.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            txtGoal.ForeColor = Color.Red;
            txtGoal.Location = new Point(750, 538);
            txtGoal.Name = "txtGoal";
            txtGoal.ReadOnly = true;
            txtGoal.Size = new Size(178, 38);
            txtGoal.TabIndex = 11;
            txtGoal.Text = "[balance]";
            txtGoal.TextAlign = HorizontalAlignment.Center;
            txtGoal.Click += txtGoal_Click;
            // 
            // lblGoal
            // 
            lblGoal.AutoSize = true;
            lblGoal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblGoal.Location = new Point(696, 545);
            lblGoal.Name = "lblGoal";
            lblGoal.Size = new Size(48, 25);
            lblGoal.TabIndex = 10;
            lblGoal.Text = "Goal";
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtBalance.Location = new Point(340, 56);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(178, 43);
            txtBalance.TabIndex = 9;
            txtBalance.Text = "[balance]";
            txtBalance.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPocketName
            // 
            lblPocketName.AutoSize = true;
            lblPocketName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPocketName.Location = new Point(23, 27);
            lblPocketName.Name = "lblPocketName";
            lblPocketName.Size = new Size(166, 31);
            lblPocketName.TabIndex = 8;
            lblPocketName.Text = "[pocketName]";
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Location = new Point(695, 86);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(71, 20);
            lblMembers.TabIndex = 17;
            lblMembers.Text = "Members";
            // 
            // btnAddMembers
            // 
            btnAddMembers.Enabled = false;
            btnAddMembers.Location = new Point(694, 485);
            btnAddMembers.Name = "btnAddMembers";
            btnAddMembers.Size = new Size(111, 29);
            btnAddMembers.TabIndex = 18;
            btnAddMembers.Text = "Add Member";
            btnAddMembers.UseVisualStyleBackColor = true;
            btnAddMembers.Visible = false;
            btnAddMembers.Click += btnAddMembers_Click;
            // 
            // txtAddMember
            // 
            txtAddMember.Enabled = false;
            txtAddMember.Location = new Point(694, 452);
            txtAddMember.Name = "txtAddMember";
            txtAddMember.PlaceholderText = "Username";
            txtAddMember.Size = new Size(236, 27);
            txtAddMember.TabIndex = 1;
            txtAddMember.Visible = false;
            // 
            // btnSelectFromList
            // 
            btnSelectFromList.Enabled = false;
            btnSelectFromList.Location = new Point(564, 452);
            btnSelectFromList.Name = "btnSelectFromList";
            btnSelectFromList.Size = new Size(124, 29);
            btnSelectFromList.TabIndex = 20;
            btnSelectFromList.Text = "Select From List";
            btnSelectFromList.UseVisualStyleBackColor = true;
            btnSelectFromList.Visible = false;
            btnSelectFromList.Click += btnSelectFromList_Click;
            // 
            // btnLeavePocket
            // 
            btnLeavePocket.Location = new Point(23, 541);
            btnLeavePocket.Name = "btnLeavePocket";
            btnLeavePocket.Size = new Size(133, 29);
            btnLeavePocket.TabIndex = 21;
            btnLeavePocket.Text = "Leave Pocket";
            btnLeavePocket.UseVisualStyleBackColor = true;
            btnLeavePocket.Click += btnLeavePocket_Click;
            // 
            // btnDeletePocket
            // 
            btnDeletePocket.Enabled = false;
            btnDeletePocket.Location = new Point(23, 581);
            btnDeletePocket.Name = "btnDeletePocket";
            btnDeletePocket.Size = new Size(133, 29);
            btnDeletePocket.TabIndex = 22;
            btnDeletePocket.Text = "Delete Pocket";
            btnDeletePocket.UseVisualStyleBackColor = true;
            btnDeletePocket.Visible = false;
            btnDeletePocket.Click += btnDeletePocket_Click;
            // 
            // btnRemoveMember
            // 
            btnRemoveMember.Enabled = false;
            btnRemoveMember.Location = new Point(803, 485);
            btnRemoveMember.Name = "btnRemoveMember";
            btnRemoveMember.Size = new Size(132, 29);
            btnRemoveMember.TabIndex = 23;
            btnRemoveMember.Text = "Remove Member";
            btnRemoveMember.UseVisualStyleBackColor = true;
            btnRemoveMember.Visible = false;
            btnRemoveMember.Click += btnRemoveMember_Click;
            // 
            // btnSettings
            // 
            btnSettings.Enabled = false;
            btnSettings.Location = new Point(428, 452);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(90, 29);
            btnSettings.TabIndex = 24;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Visible = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnPromote
            // 
            btnPromote.Enabled = false;
            btnPromote.Location = new Point(817, 44);
            btnPromote.Name = "btnPromote";
            btnPromote.Size = new Size(119, 29);
            btnPromote.TabIndex = 25;
            btnPromote.Text = "Promote User";
            btnPromote.UseVisualStyleBackColor = true;
            btnPromote.Visible = false;
            btnPromote.Click += btnPromote_Click;
            // 
            // btnDemote
            // 
            btnDemote.Enabled = false;
            btnDemote.Location = new Point(816, 77);
            btnDemote.Name = "btnDemote";
            btnDemote.Size = new Size(119, 29);
            btnDemote.TabIndex = 26;
            btnDemote.Text = "Demote User";
            btnDemote.UseVisualStyleBackColor = true;
            btnDemote.Visible = false;
            btnDemote.Click += btnDemote_Click;
            // 
            // dgvPocketMembers
            // 
            dgvPocketMembers.AllowUserToAddRows = false;
            dgvPocketMembers.AllowUserToDeleteRows = false;
            dgvPocketMembers.AllowUserToOrderColumns = true;
            dgvPocketMembers.AllowUserToResizeColumns = false;
            dgvPocketMembers.AllowUserToResizeRows = false;
            dgvPocketMembers.Anchor = AnchorStyles.None;
            dgvPocketMembers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPocketMembers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvPocketMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPocketMembers.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPocketMembers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPocketMembers.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dgvPocketMembers.Location = new Point(696, 109);
            dgvPocketMembers.Name = "dgvPocketMembers";
            dgvPocketMembers.ReadOnly = true;
            dgvPocketMembers.RowHeadersVisible = false;
            dgvPocketMembers.RowHeadersWidth = 51;
            dgvPocketMembers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPocketMembers.RowTemplate.Height = 29;
            dgvPocketMembers.ScrollBars = ScrollBars.Vertical;
            dgvPocketMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPocketMembers.Size = new Size(234, 324);
            dgvPocketMembers.TabIndex = 27;
            // 
            // ViewPocket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 633);
            Controls.Add(dgvPocketMembers);
            Controls.Add(btnDemote);
            Controls.Add(btnPromote);
            Controls.Add(btnSettings);
            Controls.Add(btnRemoveMember);
            Controls.Add(btnDeletePocket);
            Controls.Add(btnLeavePocket);
            Controls.Add(btnSelectFromList);
            Controls.Add(txtAddMember);
            Controls.Add(btnAddMembers);
            Controls.Add(lblMembers);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Controls.Add(dgvTransactions);
            Controls.Add(lblDeadline);
            Controls.Add(txtGoal);
            Controls.Add(lblGoal);
            Controls.Add(txtBalance);
            Controls.Add(lblPocketName);
            Name = "ViewPocket";
            Text = "ViewPocket";
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPocketMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWithdraw;
        private Button btnDeposit;
        private DataGridView dgvTransactions;
        private Label lblDeadline;
        private TextBox txtGoal;
        private Label lblGoal;
        private TextBox txtBalance;
        private Label lblPocketName;
        private Label lblMembers;
        private Button btnAddMembers;
        private TextBox txtAddMember;
        private Button btnSelectFromList;
        private Button btnLeavePocket;
        private Button btnDeletePocket;
        private Button btnRemoveMember;
        private Button btnSettings;
        private Button btnPromote;
        private Button btnDemote;
        private DataGridView dgvPocketMembers;
    }
}