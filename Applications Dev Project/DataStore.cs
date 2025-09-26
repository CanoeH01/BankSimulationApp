using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications_Dev_Project
{
    // DataStore is a static class for file I/O operations for the entire application
    // It loads data as the application starts
    public static class DataStore
    {
        public static UserManager Users = new UserManager("users");
        public static PocketManager Pockets = new PocketManager("pockets");
        public static TransactionManager Transactions = new TransactionManager("transactions");
        public static ContactManager Contacts = new ContactManager("contacts");
        public static User CurrentUser = null; // This will be set when a user logs in

        // Save all data to their respective files, called on application exit, no matter where it happens
        public static void SaveAll()
        {
            Users.Save();
            Pockets.Save();
            Transactions.Save();
            Contacts.Save();
        }

        public static void ExecuteDueScheduledTransactions()
        {
            if (CurrentUser == null) return;

            var dueTransactions = Transactions.AllTransactions
                .OfType<ScheduledTransaction>()
                .Where(t => t.PerformedBy == CurrentUser.ID && !t.Executed && t.ScheduledDate <= DateTime.Now.Date)
                .ToList();

            foreach (var transaction in dueTransactions)
                transaction.Execute();
        }

    }
}
