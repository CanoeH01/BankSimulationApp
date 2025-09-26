using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications_Dev_Project
{
    public class ContactManager
    {
        public List<Contact> AllContacts { get; set; }
        private readonly string FilePath;

        public ContactManager(string fileName)
        {
            AllContacts = new List<Contact>();
            FilePath = "../../../data/" + fileName + ".csv";
            Load();
        }

        public void Save()
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                foreach (Contact contact in AllContacts)
                {
                    contact.Message = contact.Message.Replace(",", "-"); // Replace commas in message to avoid CSV issues
                    contact.Subject = contact.Subject.Replace(",", "-"); // Replace commas in subject to avoid CSV issues
                    writer.WriteLine(string.Join(",",
                        contact.ID.ToString(),
                        contact.Subject,
                        contact.Message,
                        contact.TimeSent.ToString("o"),
                        contact.SenderID.ToString(),
                        contact.IsResolved
                    ));
                }
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
                    string[] contactData = line.Split(','); // size should be 6

                    Guid id = Guid.Parse(contactData[0]);
                    string subject = contactData[1];
                    string message = contactData[2];
                    DateTime dateTime = DateTime.Parse(contactData[3]);
                    Guid senderID = Guid.Parse(contactData[4]);
                    bool isResolved = bool.Parse(contactData[5]);

                    AllContacts.Add(new Contact(id, subject, message, dateTime, senderID, isResolved));
                }
            }
        }
    }
}
