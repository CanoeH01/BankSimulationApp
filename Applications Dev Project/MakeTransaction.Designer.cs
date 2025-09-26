namespace Applications_Dev_Project
{
    partial class MakeTransaction
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
            lblFrom = new Label();
            lblSenderBalance = new Label();
            lblReceiverBalance = new Label();
            lblTo = new Label();
            numTransferAmount = new NumericUpDown();
            btnTransfer = new Button();
            btnScheduleTransaction = new Button();
            ((System.ComponentModel.ISupportInitialize)numTransferAmount).BeginInit();
            SuspendLayout();
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(12, 9);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(103, 20);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "From [Sender]";
            // 
            // lblSenderBalance
            // 
            lblSenderBalance.AutoSize = true;
            lblSenderBalance.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenderBalance.Location = new Point(44, 29);
            lblSenderBalance.Name = "lblSenderBalance";
            lblSenderBalance.Size = new Size(75, 20);
            lblSenderBalance.TabIndex = 1;
            lblSenderBalance.Text = "[Balance]";
            // 
            // lblReceiverBalance
            // 
            lblReceiverBalance.AutoSize = true;
            lblReceiverBalance.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblReceiverBalance.Location = new Point(36, 126);
            lblReceiverBalance.Name = "lblReceiverBalance";
            lblReceiverBalance.Size = new Size(75, 20);
            lblReceiverBalance.TabIndex = 3;
            lblReceiverBalance.Text = "[Balance]";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(12, 106);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(95, 20);
            lblTo.TabIndex = 2;
            lblTo.Text = "To [Receiver]";
            // 
            // numTransferAmount
            // 
            numTransferAmount.DecimalPlaces = 2;
            numTransferAmount.ImeMode = ImeMode.NoControl;
            numTransferAmount.Location = new Point(163, 71);
            numTransferAmount.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            numTransferAmount.Name = "numTransferAmount";
            numTransferAmount.Size = new Size(132, 27);
            numTransferAmount.TabIndex = 4;
            // 
            // btnTransfer
            // 
            btnTransfer.Location = new Point(180, 152);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(94, 29);
            btnTransfer.TabIndex = 5;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // btnScheduleTransaction
            // 
            btnScheduleTransaction.Enabled = false;
            btnScheduleTransaction.Location = new Point(327, 71);
            btnScheduleTransaction.Name = "btnScheduleTransaction";
            btnScheduleTransaction.Size = new Size(94, 29);
            btnScheduleTransaction.TabIndex = 6;
            btnScheduleTransaction.Text = "Schedule";
            btnScheduleTransaction.UseVisualStyleBackColor = true;
            btnScheduleTransaction.Visible = false;
            btnScheduleTransaction.Click += btnScheduleTransaction_Click;
            // 
            // MakeTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 193);
            Controls.Add(btnScheduleTransaction);
            Controls.Add(btnTransfer);
            Controls.Add(numTransferAmount);
            Controls.Add(lblReceiverBalance);
            Controls.Add(lblTo);
            Controls.Add(lblSenderBalance);
            Controls.Add(lblFrom);
            Name = "MakeTransaction";
            Text = "MakeTransaction";
            ((System.ComponentModel.ISupportInitialize)numTransferAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFrom;
        private Label lblSenderBalance;
        private Label lblReceiverBalance;
        private Label lblTo;
        private NumericUpDown numTransferAmount;
        private Button btnTransfer;
        private Button btnScheduleTransaction;
    }
}