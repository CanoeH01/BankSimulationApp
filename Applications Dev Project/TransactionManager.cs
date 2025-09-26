using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications_Dev_Project
{
    public class TransactionManager
    {
        public List<Transaction> AllTransactions { get; set; }

        private readonly string FilePath;

        public TransactionManager(string fileName)
        {
            AllTransactions = new List<Transaction>();
            FilePath = "../../../data/" + fileName + ".csv";
            Load();
        }

        public void Save()
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
                foreach (Transaction transaction in AllTransactions)
                    if (transaction is ScheduledTransaction scheduledTransaction)
                        writer.WriteLine(string.Join(",",
                            "Scheduled",
                            scheduledTransaction.ID.ToString(),
                            scheduledTransaction.Date.ToString("o"),
                            scheduledTransaction.IsDeposit,
                            scheduledTransaction.Amount.ToString(CultureInfo.InvariantCulture),
                            scheduledTransaction.TargetID.ToString(),
                            scheduledTransaction.PerformedBy.ToString(),
                            scheduledTransaction.ScheduledDate.ToString("o"),
                            scheduledTransaction.Executed,
                            scheduledTransaction.RepeatIntervalDays.ToString()
                        ));
                    else
                        writer.WriteLine(string.Join(",",
                            "Transaction",
                            transaction.ID.ToString(),
                            transaction.Date.ToString("o"),
                            transaction.IsDeposit,
                            transaction.Amount.ToString(CultureInfo.InvariantCulture),
                            transaction.TargetID.ToString(),
                            transaction.PerformedBy.ToString()
                        )); 
        }

        public void Load()
        {
            if (!File.Exists(FilePath))
            {
                // create empty file for future saving and loading 
                File.Create(FilePath).Dispose();  // Dispose prevents file lock
                return;
            }

            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] transactionData = line.Split(','); // should be of size 7 if regular transaction, if scheduled, size should be 10

                    Guid id = Guid.Parse(transactionData[1]);
                    DateTime date = DateTime.Parse(transactionData[2]);
                    bool isDeposit = bool.Parse(transactionData[3]);
                    decimal amount = decimal.Parse(transactionData[4], CultureInfo.InvariantCulture);
                    Guid pocketID = Guid.Parse(transactionData[5]);
                    Guid performedBy = Guid.Parse(transactionData[6]);

                    if (transactionData[0] == "Scheduled")
                    {
                        DateTime scheduledDate = DateTime.Parse(transactionData[7]);
                        bool executed = bool.Parse(transactionData[8]);
                        int? repeatIntervalDays = transactionData[9] == "" ? null : (int?)int.Parse(transactionData[9]);
                        AllTransactions.Add(new ScheduledTransaction(id, date, isDeposit, amount, pocketID, performedBy, scheduledDate, executed, repeatIntervalDays));
                    }
                    else 
                        AllTransactions.Add(new Transaction(id, date, isDeposit, amount, pocketID, performedBy));
                    
                }
            }
        }


    }
}
