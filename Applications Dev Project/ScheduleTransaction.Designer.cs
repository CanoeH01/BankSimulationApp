namespace Applications_Dev_Project
{
    partial class ScheduleTransaction
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
            btnScheduleTransfer = new Button();
            numTransferAmount = new NumericUpDown();
            lblReceiverBalance = new Label();
            lblTo = new Label();
            lblSenderBalance = new Label();
            lblFrom = new Label();
            mthScheduledDate = new MonthCalendar();
            lblRepeat1 = new Label();
            numRepeatInterval = new NumericUpDown();
            lblRepeat2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numTransferAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRepeatInterval).BeginInit();
            SuspendLayout();
            // 
            // btnScheduleTransfer
            // 
            btnScheduleTransfer.Location = new Point(156, 456);
            btnScheduleTransfer.Name = "btnScheduleTransfer";
            btnScheduleTransfer.Size = new Size(139, 29);
            btnScheduleTransfer.TabIndex = 11;
            btnScheduleTransfer.Text = "Schedule Transfer";
            btnScheduleTransfer.UseVisualStyleBackColor = true;
            btnScheduleTransfer.Click += btnScheduleTransfer_Click;
            // 
            // numTransferAmount
            // 
            numTransferAmount.DecimalPlaces = 2;
            numTransferAmount.ImeMode = ImeMode.NoControl;
            numTransferAmount.Location = new Point(163, 70);
            numTransferAmount.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            numTransferAmount.Name = "numTransferAmount";
            numTransferAmount.Size = new Size(132, 27);
            numTransferAmount.TabIndex = 10;
            // 
            // lblReceiverBalance
            // 
            lblReceiverBalance.AutoSize = true;
            lblReceiverBalance.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblReceiverBalance.Location = new Point(36, 125);
            lblReceiverBalance.Name = "lblReceiverBalance";
            lblReceiverBalance.Size = new Size(75, 20);
            lblReceiverBalance.TabIndex = 9;
            lblReceiverBalance.Text = "[Balance]";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(12, 105);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(95, 20);
            lblTo.TabIndex = 8;
            lblTo.Text = "To [Receiver]";
            // 
            // lblSenderBalance
            // 
            lblSenderBalance.AutoSize = true;
            lblSenderBalance.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenderBalance.Location = new Point(44, 29);
            lblSenderBalance.Name = "lblSenderBalance";
            lblSenderBalance.Size = new Size(75, 20);
            lblSenderBalance.TabIndex = 7;
            lblSenderBalance.Text = "[Balance]";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(12, 9);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(103, 20);
            lblFrom.TabIndex = 6;
            lblFrom.Text = "From [Sender]";
            // 
            // mthScheduledDate
            // 
            mthScheduledDate.Location = new Point(85, 171);
            mthScheduledDate.MaxSelectionCount = 1;
            mthScheduledDate.Name = "mthScheduledDate";
            mthScheduledDate.TabIndex = 12;
            // 
            // lblRepeat1
            // 
            lblRepeat1.AutoSize = true;
            lblRepeat1.Location = new Point(111, 392);
            lblRepeat1.Name = "lblRepeat1";
            lblRepeat1.Size = new Size(95, 20);
            lblRepeat1.TabIndex = 13;
            lblRepeat1.Text = "Repeat every";
            // 
            // numRepeatInterval
            // 
            numRepeatInterval.Location = new Point(212, 390);
            numRepeatInterval.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            numRepeatInterval.Name = "numRepeatInterval";
            numRepeatInterval.Size = new Size(56, 27);
            numRepeatInterval.TabIndex = 14;
            // 
            // lblRepeat2
            // 
            lblRepeat2.AutoSize = true;
            lblRepeat2.Location = new Point(274, 392);
            lblRepeat2.Name = "lblRepeat2";
            lblRepeat2.Size = new Size(39, 20);
            lblRepeat2.TabIndex = 15;
            lblRepeat2.Text = "days";
            // 
            // ScheduleTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 497);
            Controls.Add(lblRepeat2);
            Controls.Add(numRepeatInterval);
            Controls.Add(lblRepeat1);
            Controls.Add(mthScheduledDate);
            Controls.Add(btnScheduleTransfer);
            Controls.Add(numTransferAmount);
            Controls.Add(lblReceiverBalance);
            Controls.Add(lblTo);
            Controls.Add(lblSenderBalance);
            Controls.Add(lblFrom);
            Name = "ScheduleTransaction";
            Text = "ScheduleTransaction";
            ((System.ComponentModel.ISupportInitialize)numTransferAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRepeatInterval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnScheduleTransfer;
        private NumericUpDown numTransferAmount;
        private Label lblReceiverBalance;
        private Label lblTo;
        private Label lblSenderBalance;
        private Label lblFrom;
        private MonthCalendar mthScheduledDate;
        private Label lblRepeat1;
        private NumericUpDown numRepeatInterval;
        private Label lblRepeat2;
    }
}