using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applications_Dev_Project
{
    public partial class ScheduleTransaction : Form
    {
        public ScheduleTransaction(Pocket receiver)
        {
            InitializeComponent();
            lblFrom.Text = "From " + DataStore.CurrentUser.Username;
            lblTo.Text = "To " + receiver.Name;
            lblTo.Tag = receiver;
            lblReceiverBalance.Text = receiver.Balance.ToString("C");
            lblSenderBalance.Text = DataStore.CurrentUser.Balance.ToString("C");
            numTransferAmount.Maximum = DataStore.CurrentUser.Balance;
        }
        public ScheduleTransaction(User receiver)
        {
            InitializeComponent();
            lblFrom.Text = "From " + DataStore.CurrentUser.Username;
            lblTo.Text = "To " + receiver.Username;
            lblTo.Tag = receiver;
            lblSenderBalance.Text = DataStore.CurrentUser.Balance.ToString("C");
            lblReceiverBalance.Text = string.Empty;
            numTransferAmount.Maximum = DataStore.CurrentUser.Balance;
        }

        private void btnScheduleTransfer_Click(object sender, EventArgs e)
        {
            if (numTransferAmount.Value == 0)
            {
                MessageBox.Show("Please enter a valid amount to transfer.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numTransferAmount.Value >= 300)
            {
                ConfirmPassword confirmPassword = new ConfirmPassword();
                if (confirmPassword.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Transaction cancelled", "Cancelled");
                    this.Close();
                    return;
                }
            }

            decimal amount = numTransferAmount.Value;
            Guid senderId = DataStore.CurrentUser.ID;
            Guid receiverId = (lblTo.Tag as Pocket)?.ID ?? (lblTo.Tag as User)?.ID ?? Guid.Empty;
            DateTime scheduledDate = mthScheduledDate.SelectionStart;
            int repeatInterval = (int)numRepeatInterval.Value;

            if (lblTo.Tag is User)
            {
                if (repeatInterval == 0)
                {
                    ScheduledTransaction scheduledTransaction = new ScheduledTransaction(true, amount, receiverId, senderId, scheduledDate);
                    ScheduledTransaction scheduledTransaction1 = new ScheduledTransaction(false, amount, senderId, receiverId, scheduledDate);
                    DataStore.Transactions.AllTransactions.Add(scheduledTransaction);
                    DataStore.Transactions.AllTransactions.Add(scheduledTransaction1);
                }
                else
                {
                    ScheduledTransaction scheduledTransaction = new ScheduledTransaction(true, amount, receiverId, senderId, scheduledDate, repeatInterval);
                    ScheduledTransaction scheduledTransaction1 = new ScheduledTransaction(false, amount, senderId, receiverId, scheduledDate, repeatInterval);
                    DataStore.Transactions.AllTransactions.Add(scheduledTransaction);
                    DataStore.Transactions.AllTransactions.Add(scheduledTransaction1);
                }
            }
            else
            {
                if (repeatInterval == 0)
                {
                    ScheduledTransaction scheduledTransaction = new ScheduledTransaction(true, amount, receiverId, senderId, scheduledDate);
                    DataStore.Transactions.AllTransactions.Add(scheduledTransaction);
                }
                else
                {
                    ScheduledTransaction scheduledTransaction = new ScheduledTransaction(true, amount, receiverId, senderId, scheduledDate, repeatInterval);
                    DataStore.Transactions.AllTransactions.Add(scheduledTransaction);
                }
            }
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Transaction scheduled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
