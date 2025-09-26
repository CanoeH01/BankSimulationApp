using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications_Dev_Project
{
    public class Contact
    {
        public Guid ID { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime TimeSent { get; set; }
        public Guid SenderID { get; set; }
        public bool IsResolved { get; set; }

        public Contact(Guid id, string subject, string message, DateTime dateTime, Guid senderID, bool isResolved)
        {
            ID = id;
            Subject = subject;
            Message = message;
            TimeSent = dateTime;
            SenderID = senderID;
            IsResolved = isResolved;
        }
        public Contact(string subject, string message, Guid senderID)
        {
            ID = Guid.NewGuid(); // Generate a new unique ID
            Subject = subject;
            Message = message;
            TimeSent = DateTime.Now;
            SenderID = senderID;
            IsResolved = false;
        }
    }
}
