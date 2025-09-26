using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applications_Dev_Project
{
    public partial class UserHomePage : Form
    {
        public UserHomePage()
        {
            InitializeComponent();
            DataStore.ExecuteDueScheduledTransactions(); //Execute any scheduled transactions for the current user
            UpdateUI();
        }

        private void UpdateUI()
        {
            // Update the dashboard with the current user's information
            lblWelcomeMessage.Text = $"Welcome, {DataStore.CurrentUser.FirstName} {DataStore.CurrentUser.LastName}";
            txtUserBalance.Text = DataStore.CurrentUser.Balance.ToString("C");
            txtAddMember.Text = string.Empty;

            // Check if the user has a low balance and display a warning if necessary
            if (DataStore.CurrentUser.Balance < 15)
            {
                lblBalanceWarning.Visible = true;
                lblBalanceWarning.Enabled = true;
            }
            else
            {
                lblBalanceWarning.Visible = false;
                lblBalanceWarning.Enabled = false;
            }

            // Display the user's pockets
            var userPockets = DataStore.CurrentUser.PocketsMemberOf
                .Select(pocketId => DataStore.Pockets.AllPockets.FirstOrDefault(p => p.ID == pocketId))
                .Where(pocket => pocket != null)
                .Select(pocket => new { pocket.ID, pocket.Name, Balance = pocket.Balance.ToString("C") })
                .OrderByDescending(pocket => pocket.Name)
                .ToList();

            dgvUserPockets.DataSource = null;
            dgvUserPockets.DataSource = userPockets;
            dgvUserPockets.Columns["ID"].Visible = false;
            dgvUserPockets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUserPockets.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUserPockets.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUserPockets.Tag = userPockets; // Store the userPockets list in the DataGridView's Tag property for later use

            // Display the user's net worth
            decimal netWorth = DataStore.CurrentUser.PocketsMemberOf
                .Select(pocketId => DataStore.Pockets.AllPockets.FirstOrDefault(p => p.ID == pocketId))
                .Where(pocket => pocket != null)
                .Sum(pocket => pocket.Balance);
            netWorth += DataStore.CurrentUser.Balance;
            txtNetWorth.Text = netWorth.ToString("C");


            // Display the user's transactions
            var userTransactions = DataStore.Transactions.AllTransactions
                                     .Where(transaction => transaction.PerformedBy == DataStore.CurrentUser.ID && (!(transaction is ScheduledTransaction st) || st.Executed))
                                     .OrderByDescending(transaction => transaction.Date)
                                     .Select(transaction => new
                                     {
                                         Time = transaction.Date.ToShortDateString() + " " + transaction.Date.ToShortTimeString(),
                                         PerformedBy = DataStore.Pockets.AllPockets.FirstOrDefault(pocket => pocket.ID == transaction.TargetID)?.Name
                                                    ?? DataStore.Users.AllUsers.FirstOrDefault(user => user.ID == transaction.TargetID).Username,
                                         Action = transaction.IsDeposit ? '-' : '+',
                                         Amount = transaction.Amount.ToString("C")
                                     })
                                     .ToList();

            dgvTransactions.DataSource = null;
            dgvTransactions.DataSource = userTransactions;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTransactions.Columns["PerformedBy"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTransactions.Columns["Amount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser();
            editUser.ShowDialog();

            if (editUser.DialogResult == DialogResult.Abort)
                btnLogout_Click(sender, e);

            UpdateUI();


        }

        private void btnNewPocket_Click(object sender, EventArgs e)
        {
            ManagePocket newPocket = new ManagePocket();  //Opens ManagePocket Form
            newPocket.ShowDialog();

            if (newPocket.DialogResult == DialogResult.OK)
            {
                DataStore.Pockets.AllPockets.Add(newPocket.pocket);
                DataStore.CurrentUser.PocketsMemberOf.Add(newPocket.pocket.ID);
                MessageBox.Show("New pocket created successfully!");
                UpdateUI();
            }
        }

        private void dgvUserPockets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pocket pocketToView = DataStore.CurrentUser.PocketsMemberOf
                                  .Select(pocketId => DataStore.Pockets.AllPockets.FirstOrDefault(p => p.ID == pocketId))
                                  .FirstOrDefault(pocket => pocket != null && pocket.ID == Guid.Parse(dgvUserPockets.CurrentRow.Cells["ID"].Value.ToString()));

            ViewPocket viewPocket = new ViewPocket(pocketToView);
            viewPocket.ShowDialog();
            UpdateUI();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            Close();
        }

        private void btnSelectFromList_Click(object sender, EventArgs e)
        {
            SelectUser selectUser = new SelectUser();
            selectUser.ShowDialog();
            if (selectUser.DialogResult == DialogResult.OK)
            {
                txtAddMember.Text = (string)selectUser.Tag;
            }
        }

        private void btnPayUser_Click(object sender, EventArgs e)
        {
            User selectedUser = DataStore.Users.AllUsers.FirstOrDefault(user => user.Username == txtAddMember.Text);
            if (selectedUser == null)
            {
                MessageBox.Show("User not found.");
            }
            else
            {
                MakeTransaction makeTransaction = new MakeTransaction(selectedUser, true);
                makeTransaction.ShowDialog();
            }
            UpdateUI();
        }

        private void btnGenerateBalanceReport_Click(object sender, EventArgs e)
        {
            string netWorth = txtNetWorth.Text;
            dynamic userPockets = dgvUserPockets.Tag;

            StringBuilder report = new StringBuilder();
            report.AppendLine("Balance Report");
            report.AppendLine($"User: {DataStore.CurrentUser.FirstName} {DataStore.CurrentUser.LastName}");
            report.AppendLine($"Username: {DataStore.CurrentUser.Username}");
            report.AppendLine($"Date: {DateTime.Now.ToShortDateString()}");
            report.AppendLine("Pockets:");

            foreach (var pocket in userPockets)
            {
                report.AppendLine($"- {pocket.Name}: {pocket.Balance}");
            }

            report.AppendLine();
            report.AppendLine($"Total Balance: {netWorth}");

            string fileName = $"BalanceReport_{DataStore.CurrentUser.Username}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
            File.WriteAllText(path, report.ToString());

            MessageBox.Show($"Report saved to Desktop as:\n{fileName}", "Report Generated");
        }

        private void btnSplitTransaction_Click(object sender, EventArgs e)
        {
            if ((char)dgvTransactions.CurrentRow.Cells["Action"].Value == '-' && dgvTransactions.SelectedRows.Count == 1)
            {
                string paymentName = dgvTransactions.CurrentRow.Cells["PerformedBy"].Value.ToString();
                decimal paymentAmount = decimal.Parse(dgvTransactions.CurrentRow.Cells["Amount"].Value.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture);

                SplitTransaction splitTransaction = new SplitTransaction(paymentName, paymentAmount);
                splitTransaction.ShowDialog();
                UpdateUI();
            }
        }

        private void btnContactSupport_Click(object sender, EventArgs e)
        {
            ContactSupport contactSupport = new ContactSupport();
            contactSupport.ShowDialog();
        }

        private void btnEditbalance_Click(object sender, EventArgs e)
        {
            EditBalance editBalance = new EditBalance();
            editBalance.ShowDialog();
            UpdateUI();
        }
    }
}
