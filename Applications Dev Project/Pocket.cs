using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications_Dev_Project
{
    public class Pocket
    {
        public Guid ID { get; set; } 
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public decimal SavingsGoal { get; set; }
        public DateTime GoalDeadline { get; set; }
        public List<Guid> Owners { get; set; }

        public Pocket(Guid iD, string name, decimal balance, decimal savingsGoal, DateTime goalDeadline, List<Guid> owners)
        {
            ID = iD;
            Name = name;
            Balance = balance;
            SavingsGoal = savingsGoal;
            GoalDeadline = goalDeadline;
            Owners = owners;
        }
        public Pocket(string name, decimal savingsGoal, DateTime goalDeadline)
        {
            ID = Guid.NewGuid();
            Name = name;
            Balance = 0;
            SavingsGoal = savingsGoal;
            GoalDeadline = goalDeadline;
            Owners = new List<Guid>();
            Owners.Add(DataStore.CurrentUser.ID);
        }
        public Pocket()
        {
            ID = Guid.NewGuid();
            Name = string.Empty;
            Balance = 0;
            SavingsGoal = 0;
            GoalDeadline = DateTime.MinValue;
            Owners = new List<Guid>();
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Pocket p) return false;

            return this.ID == p.ID;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

    }
}
