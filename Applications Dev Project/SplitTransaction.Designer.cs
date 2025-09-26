namespace Applications_Dev_Project
{
    partial class SplitTransaction
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
            lblRecipientName = new Label();
            txtAmountToSplit = new TextBox();
            lblYou = new Label();
            numYourPortion = new NumericUpDown();
            lblUserSplitWith = new Label();
            numOtherPortion = new NumericUpDown();
            btnSelectFromList = new Button();
            txtSelectUser = new TextBox();
            btnAddUser = new Button();
            btnConfirmSplit = new Button();
            ((System.ComponentModel.ISupportInitialize)numYourPortion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOtherPortion).BeginInit();
            SuspendLayout();
            // 
            // lblRecipientName
            // 
            lblRecipientName.AutoSize = true;
            lblRecipientName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipientName.Location = new Point(12, 19);
            lblRecipientName.Name = "lblRecipientName";
            lblRecipientName.Size = new Size(188, 31);
            lblRecipientName.TabIndex = 9;
            lblRecipientName.Text = "[recipientName]";
            // 
            // txtAmountToSplit
            // 
            txtAmountToSplit.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            txtAmountToSplit.ForeColor = SystemColors.ControlText;
            txtAmountToSplit.Location = new Point(306, 80);
            txtAmountToSplit.Name = "txtAmountToSplit";
            txtAmountToSplit.ReadOnly = true;
            txtAmountToSplit.Size = new Size(178, 38);
            txtAmountToSplit.TabIndex = 12;
            txtAmountToSplit.Text = "[amount]";
            txtAmountToSplit.TextAlign = HorizontalAlignment.Center;
            // 
            // lblYou
            // 
            lblYou.AutoSize = true;
            lblYou.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblYou.Location = new Point(24, 166);
            lblYou.Name = "lblYou";
            lblYou.Size = new Size(35, 20);
            lblYou.TabIndex = 13;
            lblYou.Text = "You";
            // 
            // numYourPortion
            // 
            numYourPortion.DecimalPlaces = 2;
            numYourPortion.Enabled = false;
            numYourPortion.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numYourPortion.Location = new Point(68, 189);
            numYourPortion.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numYourPortion.Name = "numYourPortion";
            numYourPortion.Size = new Size(150, 27);
            numYourPortion.TabIndex = 14;
            numYourPortion.ValueChanged += numYourPortion_ValueChanged;
            // 
            // lblUserSplitWith
            // 
            lblUserSplitWith.AutoSize = true;
            lblUserSplitWith.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserSplitWith.Location = new Point(24, 288);
            lblUserSplitWith.Name = "lblUserSplitWith";
            lblUserSplitWith.Size = new Size(79, 20);
            lblUserSplitWith.TabIndex = 15;
            lblUserSplitWith.Text = "Split with:";
            // 
            // numOtherPortion
            // 
            numOtherPortion.DecimalPlaces = 2;
            numOtherPortion.Enabled = false;
            numOtherPortion.Location = new Point(68, 324);
            numOtherPortion.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numOtherPortion.Name = "numOtherPortion";
            numOtherPortion.Size = new Size(150, 27);
            numOtherPortion.TabIndex = 16;
            numOtherPortion.ValueChanged += numOtherPortion_ValueChanged;
            // 
            // btnSelectFromList
            // 
            btnSelectFromList.Location = new Point(360, 324);
            btnSelectFromList.Name = "btnSelectFromList";
            btnSelectFromList.Size = new Size(124, 29);
            btnSelectFromList.TabIndex = 29;
            btnSelectFromList.Text = "Select From List";
            btnSelectFromList.UseVisualStyleBackColor = true;
            btnSelectFromList.Click += btnSelectFromList_Click;
            // 
            // txtSelectUser
            // 
            txtSelectUser.Location = new Point(490, 324);
            txtSelectUser.Name = "txtSelectUser";
            txtSelectUser.PlaceholderText = "Username";
            txtSelectUser.Size = new Size(241, 27);
            txtSelectUser.TabIndex = 1;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(620, 357);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(111, 29);
            btnAddUser.TabIndex = 27;
            btnAddUser.Text = "Choose User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnConfirmSplit
            // 
            btnConfirmSplit.Enabled = false;
            btnConfirmSplit.Location = new Point(68, 390);
            btnConfirmSplit.Name = "btnConfirmSplit";
            btnConfirmSplit.Size = new Size(94, 29);
            btnConfirmSplit.TabIndex = 30;
            btnConfirmSplit.Text = "Confirm";
            btnConfirmSplit.UseVisualStyleBackColor = true;
            btnConfirmSplit.Click += btnConfirmSplit_Click;
            // 
            // SplitTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
            Controls.Add(btnConfirmSplit);
            Controls.Add(btnSelectFromList);
            Controls.Add(txtSelectUser);
            Controls.Add(btnAddUser);
            Controls.Add(numOtherPortion);
            Controls.Add(lblUserSplitWith);
            Controls.Add(numYourPortion);
            Controls.Add(lblYou);
            Controls.Add(txtAmountToSplit);
            Controls.Add(lblRecipientName);
            Name = "SplitTransaction";
            Text = "SplitTransaction";
            ((System.ComponentModel.ISupportInitialize)numYourPortion).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOtherPortion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecipientName;
        private TextBox txtAmountToSplit;
        private Label lblYou;
        private NumericUpDown numYourPortion;
        private Label lblUserSplitWith;
        private NumericUpDown numOtherPortion;
        private Button btnSelectFromList;
        private TextBox txtSelectUser;
        private Button btnAddUser;
        private Button btnConfirmSplit;
    }
}