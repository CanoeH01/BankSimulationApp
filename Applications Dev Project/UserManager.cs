using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications_Dev_Project
{
    public class UserManager
    {
        public List<User> AllUsers { get; set; }

        private readonly string FilePath;

        public UserManager(string fileName)
        {
            AllUsers = new List<User>();
            FilePath = "../../../data/" + fileName + ".csv";
            Load();
        }

        public void Save()
        {
            // this using statement makes sure the file is closed after writing, instead of opening and closing it manually
            using (StreamWriter writer = new StreamWriter(FilePath))
                foreach (User user in AllUsers)
                {
                    // Convert the list of Guids to a string with '|' as the separator, for writing to csv file
                    string joinedPockets = string.Join("|", user.PocketsMemberOf.Select(id => id.ToString()));
                    writer.WriteLine($"{user.FirstName},{user.LastName},{user.Username},{user.Password},{user.Balance.ToString(CultureInfo.InvariantCulture)},{joinedPockets},{user.Access},{user.AccountIsActive},{user.ID}");
                }
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
                    string[] userData = line.Split(','); // should be of size 9
                    string firstName = userData[0];
                    string lastName = userData[1];
                    string username = userData[2];
                    string password = userData[3];
                    decimal balance = decimal.Parse(userData[4], CultureInfo.InvariantCulture);
                    // Split the string by '|' and parse each ID to a Guid
                    List<Guid> pockets = (string.IsNullOrWhiteSpace(userData[5])) ? new List<Guid>() : userData[5].Split('|').Select(id => Guid.Parse(id)).ToList();
                    User.AccessLevel access = (User.AccessLevel)Enum.Parse(typeof(User.AccessLevel), userData[6]);
                    bool accountIsActive = bool.Parse(userData[7]);
                    Guid id;

                    if (string.IsNullOrWhiteSpace(userData[8]) || !Guid.TryParse(userData[8], out id) || id == Guid.Empty)
                        id = Guid.NewGuid();
                    

                    AllUsers.Add(new User(id, firstName, lastName, username, password, balance, pockets, access, accountIsActive));
                }
            }
        }


    }
}

