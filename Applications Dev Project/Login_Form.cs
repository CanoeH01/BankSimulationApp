using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Applications_Dev_Project
{
    public partial class Form_Login : System.Windows.Forms.Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;
            bool isAuthenticated = false;

            //Only allow access if the username and password are attached
            //to the same user in the system and the account is active 
            var foundUser = DataStore.Users.AllUsers.FirstOrDefault(user => user.Username == enteredUsername && user.Password == enteredPassword && user.AccountIsActive);
            if (foundUser is null)
            {
                MessageBox.Show("Error! Invalid Username or Password", "Invalid Login");
                //Empties the textbox where password was entered
                txtPassword.Text = "";
            }
            else
            {
                DataStore.CurrentUser = foundUser; //Set the current user to the one that logged in
                bool isLoggedOut = false;

                if (foundUser.Access == User.AccessLevel.Admin)    //Check to see if the account is an Admin
                {
                    this.Hide();    //Hides Login Form
                    AdminHomePage adminPage = new AdminHomePage();
                    adminPage.ShowDialog();
                    isLoggedOut = adminPage.DialogResult == DialogResult.Abort; //Check to see if the user logged out
                }
                else // Otherwise, the account is a User
                {
                    this.Hide();    //Hides Login Form
                    UserHomePage userPage = new UserHomePage();
                    userPage.ShowDialog();
                    isLoggedOut = userPage.DialogResult == DialogResult.Abort; //Check to see if the user logged out
                }

                if (isLoggedOut) //If the user logged out, show the login form again
                {
                    this.Show();
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
                else 
                    Close();

            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();    //Hides Login Form
            Register register = new Register(); //Opens Register Form (This form is empty at the moment)
            register.ShowDialog();
            this.Show();
        }

    }

}