using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications_Dev_Project
{
    public class User
    {
        // Used an enum instead of a bool in case we add more than two access levels
        public enum AccessLevel
        {
            User,
            Admin
        }

        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
        public List<Guid> PocketsMemberOf { get; set; }
        public AccessLevel Access { get; set; }
        public bool AccountIsActive { get; set; } 

        public User(Guid id, string firstName, string lastName, string username, string password, decimal balance, List<Guid> pockets, AccessLevel access, bool accountIsActive = true)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Username = username;   
            Password = password;
            Balance = balance;
            PocketsMemberOf = pockets;
            Access = access;
            AccountIsActive = accountIsActive;
        }

        public User(string firstName, string lastName, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            Balance = 0;
            PocketsMemberOf = new List<Guid>();
            ID = Guid.NewGuid();
            Access = AccessLevel.User;
            AccountIsActive = true;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not User u) return false;

            return this.ID == u.ID;
        }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public void EditAccountStatus() //Function to suspend or activate an account
        {
            AccountIsActive = !AccountIsActive;
        }

        public void DeleteAccount()
        {
            DataStore.Users.AllUsers.RemoveAll(u => u.ID == this.ID);
        }

    }
}
