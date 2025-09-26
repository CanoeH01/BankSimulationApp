using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applications_Dev_Project
{
    public partial class ContactSupport : Form
    {
        public ContactSupport()
        {
            InitializeComponent();
        }
        public ContactSupport(Contact contactToView)    //From AdminPage
        {
            InitializeComponent();
            txtMessageFrom.Tag = contactToView;
        }


        private void ContactSupport_Load(object sender, EventArgs e)
        {
            //Adjust what is and is not visible on the form depending on whether it is the Admin or User using the form
            Contact myContact = (Contact)txtMessageFrom.Tag;

            if (DataStore.CurrentUser.Access == User.AccessLevel.Admin)
            {
                txtSubject.Enabled = false;
                txtQuery.Enabled = false;
                txtMessageFrom.Enabled = false;
                btnSubmitQuery.Visible = false;
                btnDeleteMessage.Visible = true;
                btnResolve.Enabled = true;
                btnResolve.Visible = true;
                lblMessageFrom.Visible = true;

                txtSubject.Text = myContact.Subject;
                txtQuery.Text = myContact.Message;
                var contactSender = DataStore.Users.AllUsers.FirstOrDefault(user => user.ID == myContact.SenderID);
                txtMessageFrom.Text = contactSender?.Username ?? "[Deleted User]";
            }
            else if (DataStore.CurrentUser.Access == User.AccessLevel.User)
            {
                txtSubject.Enabled = true;
                txtQuery.Enabled = true;
                txtMessageFrom.Enabled = false;

                btnSubmitQuery.Visible = true;
                btnDeleteMessage.Visible = false;
                btnResolve.Enabled = false;
                btnResolve.Visible = false;

                lblMessageFrom.Visible = false;
                txtMessageFrom.Visible = false;
            }
        }

        private void btnSubmitQuery_Click(object sender, EventArgs e)   //Only Visible to User. Add the new query based on the proved information
        {
            string subject = txtSubject.Text;
            string queryMessage = txtQuery.Text;

            Guid senderID = DataStore.CurrentUser.ID;
            Contact newContact = new Contact(subject, queryMessage, senderID);
            DataStore.Contacts.AllContacts.Add(newContact);

            MessageBox.Show("Your query has been submitted successfully!", "Success");
            Close();
        }

        private void btnDeleteMessage_Click(object sender, EventArgs e)     //Only Visible to Admin. Delete the query
        {
            Contact myContact = (Contact)txtMessageFrom.Tag;
            DataStore.Contacts.AllContacts.RemoveAll(contact => contact.ID == myContact.ID);

            MessageBox.Show("Message Deleted successfully.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            Contact myContact = (Contact)txtMessageFrom.Tag;
            myContact.IsResolved = true;
            this.Close();
        }
    }
}
