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
    public partial class SplitTransaction : Form
    {
        public decimal amountToSplit { get; set; }
        public User UserToSplitWith { get; set; }
        public SplitTransaction(string recipientName, decimal amount)
        {
            InitializeComponent();
            amountToSplit = amount;
            lblRecipientName.Text = recipientName;
            txtAmountToSplit.Text = amount.ToString("C");
        }


        private void btnSelectFromList_Click(object sender, EventArgs e)
        {
            SelectUser selectUser = new SelectUser();
            selectUser.ShowDialog();
            if (selectUser.DialogResult == DialogResult.OK)
            {
                txtSelectUser.Text = (string)selectUser.Tag;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserToSplitWith = DataStore.Users.AllUsers.FirstOrDefault(user => user.Username == txtSelectUser.Text);
            if (UserToSplitWith == null)
            {
                MessageBox.Show("User not found.");
            }
            else
            {
                txtSelectUser.Text = string.Empty;
                btnConfirmSplit.Enabled = true;
                btnAddUser.Text = "Change User";

                lblUserSplitWith.Text = UserToSplitWith.Username;

                numYourPortion.Maximum = amountToSplit;
                numOtherPortion.Maximum = amountToSplit;
                numYourPortion.Enabled = true;
                numYourPortion.Value = amountToSplit / 2;
                numOtherPortion.Enabled = true;
                numOtherPortion.Value = amountToSplit / 2;
            }
        }

        private void numYourPortion_ValueChanged(object sender, EventArgs e)
        {
            numOtherPortion.Value = amountToSplit - numYourPortion.Value;
        }

        private void numOtherPortion_ValueChanged(object sender, EventArgs e)
        {
            numYourPortion.Value = amountToSplit - numOtherPortion.Value;
        }

        private void btnConfirmSplit_Click(object sender, EventArgs e)
        {
            decimal amountSplit = numOtherPortion.Value;

            if (amountSplit > UserToSplitWith.Balance)
            {
                MessageBox.Show(UserToSplitWith.Username + " does not have enough balance to split this amount.");
            }
            else
            {
                Transaction transaction = new Transaction(false, amountSplit, UserToSplitWith.ID, DataStore.CurrentUser.ID);
                Transaction transaction1 = new Transaction(true, amountSplit, DataStore.CurrentUser.ID, UserToSplitWith.ID);

                DataStore.CurrentUser.Balance += amountSplit;
                UserToSplitWith.Balance -= amountSplit;

                DataStore.Transactions.AllTransactions.Add(transaction);
                DataStore.Transactions.AllTransactions.Add(transaction1);
                MessageBox.Show("Transaction split successfully!", "Success");
                Close();
            }
        }
    }
}
