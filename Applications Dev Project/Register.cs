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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtRegisterFirstName.Text.Trim();
            string lastName = txtRegisterLastName.Text;
            string username = txtRegisterUsername.Text.Trim();
            string password = txtRegisterPassword.Text;
            string confirmPassword = txtRegisterPasswordConfirm.Text;

            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("Please enter a first name", "Error");
            }
            else if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please enter a last name", "Error");
            }
            else if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username", "Error");
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a password", "Error");
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match", "Error");
            }
            // usernames must be unique
            else if (DataStore.Users.AllUsers.Any(user => user.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Username taken, please choose a unique username", "Error");
            }
            else
            {
                User newUser = new User(firstName, lastName, username, password);
                DataStore.Users.AllUsers.Add(newUser);
                MessageBox.Show("Registration successful for user " + newUser.Username + ". Please login.", "Success");
                Close();
            }
        }

    }
}
