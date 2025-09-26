using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Applications_Dev_Project
{
    public partial class EditUser : Form
    {
        private User selectedUser;

        public EditUser()  //Constructor that is used by the UserHomePage Form
        {
            this.selectedUser = DataStore.CurrentUser;   //Sets selectedUser as the user that logged in
            InitializeComponent();
            DisplayUserData();
        }

        public EditUser(User user)  //Constructer that is used by the AdminHomePage Form
        {
            this.selectedUser = user;   //Sets selectedUser as the user that was selected from the list view
            InitializeComponent();
            DisplayUserData();
        }

        private void DisplayUserData()
        {
            //Display the data of the user on the Form
            txtFirstName.Text = selectedUser.FirstName;
            txtLastName.Text = selectedUser.LastName;
            txtUsername.Text = selectedUser.Username;

            //Show if the account is "Active" or "Suspended"
            txtAccountStatus.Text = selectedUser.AccountIsActive ? "Active" : "Suspended";
            btnAccountStatus.Text = selectedUser.AccountIsActive ? "Suspend Account" : "Activate Account";

            //The groupbox hiding the password is only visible when editing your own account
            if (DataStore.CurrentUser.Equals(selectedUser))
            {
                groupBoxPassword.Visible = true;
                txtPassword.Text = DataStore.CurrentUser.Password;
            }
            else
            {
                groupBoxPassword.Visible = false;
                txtPassword.Text = selectedUser.Password;
            }


            //Add all options to the combobox
            foreach (User.AccessLevel level in Enum.GetValues(typeof(User.AccessLevel)))
                comboBoxAccess.Items.Add(level.ToString());

            //Set the default option in the combobox to match the access level of the selected account
            comboBoxAccess.SelectedIndex = (int)selectedUser.Access;

            //Only allow the admins to see them
            bool isAdmin = DataStore.CurrentUser.Access == User.AccessLevel.Admin;
            lblAccountStatus.Visible = isAdmin;
            btnAccountStatus.Visible = isAdmin;
            txtAccountStatus.Visible = isAdmin;
            groupBoxAccess.Visible = isAdmin;
        }


        public void SaveDetails()   //Save the new details
        {
            selectedUser.FirstName = txtFirstName.Text;
            selectedUser.LastName = txtLastName.Text;
            selectedUser.Username = txtUsername.Text;
            selectedUser.Access = (User.AccessLevel)Enum.Parse(typeof(User.AccessLevel), comboBoxAccess.SelectedItem.ToString());
            selectedUser.Password = txtPassword.Text;
        }


        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            SaveDetails();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAccountStatus_Click(object sender, EventArgs e)
        {
            selectedUser.EditAccountStatus();
            txtAccountStatus.Text = selectedUser.AccountIsActive ? "Active" : "Suspended";
            btnAccountStatus.Text = selectedUser.AccountIsActive ? "Suspend Account" : "Activate Account";
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this account?",
                                        "Confirm Deletion",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                selectedUser.DeleteAccount();

                MessageBox.Show("User account deleted successfully.");
                this.DialogResult = selectedUser.Equals(DataStore.CurrentUser) ? DialogResult.Abort : DialogResult.OK;
                this.Close();
            }
        }
    }

}
