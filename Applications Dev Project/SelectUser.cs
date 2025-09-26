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
    public partial class SelectUser : Form
    {
        public SelectUser(Pocket myPocket)
        {
            InitializeComponent();
            
            var usersNotInPocket = DataStore.Users.AllUsers
                .Where(user => !user.PocketsMemberOf.Contains(myPocket.ID) && user.AccountIsActive)
                .Select(user => user.Username)
                .ToArray();


            lstUsers.Items.Clear(); 
            lstUsers.Items.AddRange(usersNotInPocket);
        }

        public SelectUser()
        {
            InitializeComponent();

            var allActiveUsers = DataStore.Users.AllUsers
                .Where(user => user.ID != DataStore.CurrentUser.ID && user.AccountIsActive)
                .Select(user => user.Username)
                .ToArray();


            lstUsers.Items.Clear();
            lstUsers.Items.AddRange(allActiveUsers);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItems.Count == 1)
            {
                this.Tag = lstUsers.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
