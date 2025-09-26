using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Applications_Dev_Project
{
    public partial class MakeTransaction : Form
    {
        public MakeTransaction(Pocket pocket, bool isDeposit)
        {
            InitializeComponent();

            if (isDeposit)
            {
                lblFrom.Text = "From " + DataStore.CurrentUser.Username;
                lblFrom.Tag = DataStore.CurrentUser;
                lblSenderBalance.Text = DataStore.CurrentUser.Balance.ToString("C");
                numTransferAmount.Maximum = DataStore.CurrentUser.Balance;
                btnScheduleTransaction.Visible = true;
                btnScheduleTransaction.Enabled = true;

                lblTo.Text = "To " + pocket.Name;
                lblTo.Tag = pocket;
                lblReceiverBalance.Text = pocket.Balance.ToString("C");
            }
            else
            {
                lblFrom.Text = "From " + pocket.Name;
                lblFrom.Tag = pocket;
                lblSenderBalance.Text = pocket.Balance.ToString("C");
                numTransferAmount.Maximum = pocket.Balance;

                lblTo.Text = "To " + DataStore.CurrentUser.Username;
                lblTo.Tag = DataStore.CurrentUser.Username;
                lblReceiverBalance.Text = DataStore.CurrentUser.Balance.ToString("C");
            }
            btnTransfer.Tag = isDeposit;
        }

        public MakeTransaction(User user, bool isDeposit)
        {
            InitializeComponent();

            if (isDeposit)
            {
                lblFrom.Text = "From " + DataStore.CurrentUser.Username;
                lblFrom.Tag = DataStore.CurrentUser.Username;
                lblSenderBalance.Text = DataStore.CurrentUser.Balance.ToString("C");
                numTransferAmount.Maximum = DataStore.CurrentUser.Balance;

                lblTo.Text = "To " + user.Username;
                lblTo.Tag = user;
                lblReceiverBalance.Enabled = false;
                lblReceiverBalance.Visible = false;
            }
            else
            {
                lblFrom.Text = "From " + user.Username;
                lblFrom.Tag = user;
                lblSenderBalance.Text = user.Balance.ToString("C");
                numTransferAmount.Maximum = user.Balance;

                lblTo.Text = "To " + DataStore.CurrentUser.Username;
                lblTo.Tag = DataStore.CurrentUser.Username;

                lblSenderBalance.Enabled = false;
                lblSenderBalance.Visible = false;
            }
            btnScheduleTransaction.Visible = true;
            btnScheduleTransaction.Enabled = true;
            btnTransfer.Tag = isDeposit;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Transaction transaction;
            bool isDeposit = (bool)btnTransfer.Tag;
            decimal amount = numTransferAmount.Value;
            Guid performedBy = DataStore.CurrentUser.ID;

            if (amount >= 300)
            {
                ConfirmPassword confirmPassword = new ConfirmPassword();
                if (confirmPassword.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Transaction cancelled", "Cancelled");
                    this.Close();
                    return;
                }
            }

            if (lblFrom.Tag is Pocket)
            {
                Pocket pocket = (Pocket)lblFrom.Tag;
                transaction = new Transaction(isDeposit, amount, pocket.ID, performedBy);
                DataStore.CurrentUser.Balance += amount;
                pocket.Balance -= amount;
            }
            else if (lblTo.Tag is Pocket)
            {
                Pocket pocket = (Pocket)lblTo.Tag;
                transaction = new Transaction(isDeposit, amount, pocket.ID, performedBy);
                DataStore.CurrentUser.Balance -= amount;
                pocket.Balance += amount;
            }
            else
            {
                // if transaction is between two users, make two transactions, one for each user
                User otherUser = ((User)lblTo.Tag).Equals(DataStore.CurrentUser) ? ((User)lblFrom.Tag) : ((User)lblTo.Tag);

                // assume current user is the sender, as they cant withdraw from the other users account
                transaction = new Transaction(true, amount, otherUser.ID, performedBy);
                Transaction transaction1 = new Transaction(false, amount, performedBy, otherUser.ID);
                DataStore.CurrentUser.Balance -= amount;
                otherUser.Balance += amount;
                DataStore.Transactions.AllTransactions.Add(transaction1);
            }

            DataStore.Transactions.AllTransactions.Add(transaction);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Transaction successful!", "Success");
            Close();
        }

        private void btnScheduleTransaction_Click(object sender, EventArgs e)
        {
            ScheduleTransaction scheduleTransaction;

            if (lblTo.Tag is Pocket)
            {
                Pocket pocket = (Pocket)lblTo.Tag;
                scheduleTransaction = new ScheduleTransaction(pocket);
            }
            else
            {
                User otherUser = ((User)lblTo.Tag);
                scheduleTransaction = new ScheduleTransaction(otherUser);
            }
            scheduleTransaction.ShowDialog();

            this.Close();
        }
    }
}
