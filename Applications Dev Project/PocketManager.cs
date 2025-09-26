using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications_Dev_Project
{
    public class PocketManager
    {
        public List<Pocket> AllPockets { get; set; }

        private readonly string FilePath;

        public PocketManager(string fileName)
        {
            AllPockets = new List<Pocket>();
            FilePath = "../../../data/" + fileName + ".csv";
            Load();
        }

        public void Save()
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
                foreach (Pocket pocket in AllPockets)
                {
                    string joinedOwners = string.Join("|", pocket.Owners.Select(id => id.ToString()));

                    writer.WriteLine(string.Join(",",
                        pocket.ID.ToString(),
                        pocket.Name,
                        pocket.Balance.ToString(CultureInfo.InvariantCulture),
                        pocket.SavingsGoal.ToString(CultureInfo.InvariantCulture),
                        pocket.GoalDeadline.ToString("o"),
                        joinedOwners
                    ));
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
                    string[] pocketData = line.Split(','); // should be of size 6
                    Guid id = Guid.Parse(pocketData[0]);
                    string name = pocketData[1];
                    decimal balance = decimal.Parse(pocketData[2], CultureInfo.InvariantCulture);
                    decimal savingsGoal = decimal.Parse(pocketData[3], CultureInfo.InvariantCulture);
                    DateTime goalDeadline = DateTime.Parse(pocketData[4]);

                    // Split the string by '|' and parse each ID to a Guid
                    List<Guid> owners = (string.IsNullOrWhiteSpace(pocketData[5])) ? new List<Guid>() : pocketData[5].Split('|').Select(id => Guid.Parse(id)).ToList();

                    AllPockets.Add(new Pocket(id, name, balance, savingsGoal, goalDeadline, owners));
                }
            }
        }


    }

}
