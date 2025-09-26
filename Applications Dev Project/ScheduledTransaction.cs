using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications_Dev_Project
{
    internal class ScheduledTransaction : Transaction, ICloneable
    {
        public DateTime ScheduledDate { get; set; }
        public bool Executed { get; set; }
        public int? RepeatIntervalDays { get; set; }

        public ScheduledTransaction(Guid iD, DateTime date, bool isDeposit, decimal amount, Guid targetID, Guid performedBy, DateTime scheduleDate, bool executed, int? repeatIntervalDays)
            : base(iD, date, isDeposit, amount, targetID, performedBy)
        {
            ScheduledDate = scheduleDate;
            Executed = executed;
            RepeatIntervalDays = repeatIntervalDays;
        }
        public ScheduledTransaction(bool isDeposit, decimal amount, Guid targetID, Guid performedBy, DateTime scheduleDate, int? repeatIntervalDays)
            : base(isDeposit, amount, targetID, performedBy)
        {
            ScheduledDate = scheduleDate;
            RepeatIntervalDays = repeatIntervalDays;
            Executed = false;
        }
        public ScheduledTransaction(bool isDeposit, decimal amount, Guid targetID, Guid performedBy, DateTime scheduleDate)
        : base(isDeposit, amount, targetID, performedBy)
        {
            ScheduledDate = scheduleDate;
            Executed = false;
        }

        public object Clone()
        {
            return new ScheduledTransaction(ID, Date, IsDeposit, Amount, TargetID, PerformedBy, ScheduledDate, Executed, RepeatIntervalDays);
        }

        public Transaction CloneTransaction()
        {
            return new Transaction(ID, DateTime.Now, IsDeposit, Amount, TargetID, PerformedBy);
        }

        public void Execute()
        {
            if (!Executed)
            {
                var sender = DataStore.Users.AllUsers.FirstOrDefault(u => u.ID == PerformedBy);

                if (sender == null || sender.Balance < Amount)
                {
                    MessageBox.Show("Insufficient funds for scheduled transfer of " + Amount.ToString("C") + " Please add funds and log back in to transfer");
                    return;
                }

                var receiverUser = DataStore.Users.AllUsers.FirstOrDefault(u => u.ID == TargetID);
                var receiverPocket = DataStore.Pockets.AllPockets.FirstOrDefault(p => p.ID == TargetID);

                if (receiverUser != null)
                {
                    receiverUser.Balance += Amount;
                    MessageBox.Show($"Scheduled transfer of {Amount.ToString("C")} from {sender.Username} to {receiverUser.Username} has been executed.");
                }
                else
                {
                    receiverPocket.Balance += Amount;
                    MessageBox.Show($"Scheduled transfer of {Amount.ToString("C")} from {sender.Username} to {receiverPocket.Name} has been executed.");
                }

                sender.Balance -= Amount;
                Executed = true;

                // If RepeatIntervalDays is set, schedule the next execution
                if (RepeatIntervalDays.HasValue)
                {
                    DialogResult continueRecurring = MessageBox.Show($"Transaction scheduled for {ScheduledDate.ToShortDateString()} has been executed. Do you want to keep this schedule? it will transfer again in " + RepeatIntervalDays + " days.", "Transaction Executed", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (continueRecurring == DialogResult.No)
                    {
                        DataStore.Transactions.AllTransactions.RemoveAll(t => t.ID == ID);
                        RepeatIntervalDays = null; // Stop the recurring schedule
                    }
                    else
                    {
                        ScheduledDate = ScheduledDate.AddDays(RepeatIntervalDays.Value);
                        Executed = false; // Reset executed status for the next occurrence
                    }
                    // for recurring transactions, add a new transaction to the list, and delete the recurring if it doesnt continue
                    Transaction transaction = this.CloneTransaction();
                    DataStore.Transactions.AllTransactions.Add(transaction);
                }
            }
        }
    }
}
