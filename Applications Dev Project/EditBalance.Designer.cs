namespace Applications_Dev_Project
{
    partial class EditBalance
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
            lblCurrentBalance = new Label();
            txtCurrentBalance = new TextBox();
            btnDepositMoney = new Button();
            btnWithdrawMoney = new Button();
            btnConfirmBalance = new Button();
            lblEditBalance = new Label();
            numAmount = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Location = new Point(20, 22);
            lblCurrentBalance.Margin = new Padding(2, 0, 2, 0);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(113, 20);
            lblCurrentBalance.TabIndex = 0;
            lblCurrentBalance.Text = "Current Balance";
            // 
            // txtCurrentBalance
            // 
            txtCurrentBalance.Location = new Point(165, 22);
            txtCurrentBalance.Margin = new Padding(2);
            txtCurrentBalance.Name = "txtCurrentBalance";
            txtCurrentBalance.ReadOnly = true;
            txtCurrentBalance.Size = new Size(121, 27);
            txtCurrentBalance.TabIndex = 9999;
            // 
            // btnDepositMoney
            // 
            btnDepositMoney.Location = new Point(20, 64);
            btnDepositMoney.Margin = new Padding(2);
            btnDepositMoney.Name = "btnDepositMoney";
            btnDepositMoney.Size = new Size(107, 27);
            btnDepositMoney.TabIndex = 1;
            btnDepositMoney.Text = "Deposit";
            btnDepositMoney.UseVisualStyleBackColor = true;
            btnDepositMoney.Click += btnDepositMoney_Click;
            // 
            // btnWithdrawMoney
            // 
            btnWithdrawMoney.Location = new Point(174, 64);
            btnWithdrawMoney.Margin = new Padding(2);
            btnWithdrawMoney.Name = "btnWithdrawMoney";
            btnWithdrawMoney.Size = new Size(110, 27);
            btnWithdrawMoney.TabIndex = 4;
            btnWithdrawMoney.Text = "Withdraw";
            btnWithdrawMoney.UseVisualStyleBackColor = true;
            btnWithdrawMoney.Click += btnWithdrawMoney_Click;
            // 
            // btnConfirmBalance
            // 
            btnConfirmBalance.Enabled = false;
            btnConfirmBalance.Location = new Point(195, 165);
            btnConfirmBalance.Margin = new Padding(2);
            btnConfirmBalance.Name = "btnConfirmBalance";
            btnConfirmBalance.Size = new Size(90, 27);
            btnConfirmBalance.TabIndex = 99;
            btnConfirmBalance.TabStop = false;
            btnConfirmBalance.Text = "Confirm";
            btnConfirmBalance.UseVisualStyleBackColor = true;
            btnConfirmBalance.Visible = false;
            btnConfirmBalance.Click += btnConfirmBalance_Click;
            // 
            // lblEditBalance
            // 
            lblEditBalance.AutoSize = true;
            lblEditBalance.Location = new Point(20, 120);
            lblEditBalance.Margin = new Padding(2, 0, 2, 0);
            lblEditBalance.Name = "lblEditBalance";
            lblEditBalance.Size = new Size(142, 20);
            lblEditBalance.TabIndex = 6;
            lblEditBalance.Text = "Withdrawal Amount";
            lblEditBalance.Visible = false;
            // 
            // numAmount
            // 
            numAmount.DecimalPlaces = 2;
            numAmount.Enabled = false;
            numAmount.Location = new Point(174, 118);
            numAmount.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(112, 27);
            numAmount.TabIndex = 2;
            numAmount.Visible = false;
            // 
            // EditBalance
            // 
            AcceptButton = btnConfirmBalance;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 243);
            Controls.Add(numAmount);
            Controls.Add(lblEditBalance);
            Controls.Add(btnConfirmBalance);
            Controls.Add(btnWithdrawMoney);
            Controls.Add(btnDepositMoney);
            Controls.Add(txtCurrentBalance);
            Controls.Add(lblCurrentBalance);
            Margin = new Padding(2);
            Name = "EditBalance";
            Text = "EditBalance";
            Load += EditBalance_Load;
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentBalance;
        private TextBox txtCurrentBalance;
        private Button btnDepositMoney;
        private Button btnWithdrawMoney;
        private Button btnConfirmBalance;
        private Label lblEditBalance;
        private NumericUpDown numAmount;
    }
}