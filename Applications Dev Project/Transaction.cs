using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications_Dev_Project
{
    public class Transaction
    {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeposit { get; set; }
        public decimal Amount { get; set; }
        public Guid TargetID { get; set; }
        public Guid PerformedBy { get; set; }  // id of user who perfomed transaction
        

        public Transaction(Guid iD, DateTime date, bool isDeposit, decimal amount, Guid targetID, Guid performedBy)
        {
            ID = iD;
            Date = date;
            IsDeposit = isDeposit;
            Amount = amount;
            TargetID = targetID;
            PerformedBy = performedBy;
        }
        public Transaction(bool isDeposit, decimal amount, Guid targetID, Guid performedBy)
        {
            ID = Guid.NewGuid();
            Date = DateTime.Now;
            IsDeposit = isDeposit;
            Amount = amount;
            TargetID = targetID;
            PerformedBy = performedBy;
        }
        public Transaction()
        {
            ID = Guid.NewGuid();
            Date = DateTime.Now;
            IsDeposit = false;
            Amount = 0;
            TargetID = Guid.Empty;
            PerformedBy = Guid.Empty;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Transaction t) return false;

            return this.ID == t.ID;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}
