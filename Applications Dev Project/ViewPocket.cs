using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Applications_Dev_Project
{
    public partial class ViewPocket : Form
    {
        public Pocket MyPocket { get; set; }
        public ViewPocket(Pocket pocketToView)
        {
            InitializeComponent();
            // Initialize the form and display the pocket details
            MyPocket = pocketToView;
            UpdateUI();
        }

        private void UpdateUI()
        {
            lblPocketName.Text = MyPocket.Name;
            txtBalance.Text = MyPocket.Balance.ToString("C");
            txtGoal.Text = MyPocket.SavingsGoal.ToString("C");
            txtAddMember.Text = string.Empty;

            if (MyPocket.Owners.Any(ownerId => ownerId == DataStore.CurrentUser.ID) || DataStore.CurrentUser.Access == User.AccessLevel.Admin)
            {
                btnLeavePocket.Enabled = false;
                btnLeavePocket.Visible = false;

                btnDeletePocket.Enabled = true;
                btnDeletePocket.Visible = true;
                btnAddMembers.Enabled = true;
                btnAddMembers.Visible = true;
                btnSelectFromList.Enabled = true;
                btnSelectFromList.Visible = true;
                btnRemoveMember.Enabled = true;
                btnRemoveMember.Visible = true;
                btnSettings.Enabled = true;
                btnSettings.Visible = true;
                txtAddMember.Enabled = true;
                txtAddMember.Visible = true;
                btnPromote.Enabled = true;
                btnPromote.Visible = true;
                btnDemote.Enabled = true;
                btnDemote.Visible = true;
            }

            if (MyPocket.SavingsGoal > 0)
            {
                if (MyPocket.GoalDeadline < DateTime.Now)
                {
                    if (MyPocket.Balance >= MyPocket.SavingsGoal)
                    {
                        lblDeadline.Text = "Goal Reached!";
                        txtGoal.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblDeadline.Text = "Goal Missed...";
                        txtGoal.ForeColor = Color.Red;
                    }
                }
                else
                {
                    double progressPercent = Math.Round((double)(MyPocket.Balance / MyPocket.SavingsGoal) * 100);
                    progressPercent = Math.Min(progressPercent, 100); // Ensure it doesn't exceed 100%
                    lblDeadline.Text = $"By {MyPocket.GoalDeadline.ToShortDateString()}\n{progressPercent}% There!";
                }
            }
            else
            {
                lblDeadline.Text = "No savings goal set";
                txtGoal.Enabled = false;
                txtGoal.Visible = false;
                lblGoal.Enabled = false;
                lblGoal.Visible = false;
            }

            var pocketTransactions = DataStore.Transactions.AllTransactions
                                     .Where(transaction => transaction.TargetID == MyPocket.ID && (!(transaction is ScheduledTransaction st) || st.Executed))
                                     .OrderByDescending(transaction => transaction.Date)
                                     .Select(transaction => new
                                     {
                                         Time = transaction.Date.ToShortDateString() + " " + transaction.Date.ToShortTimeString(),
                                         PerformedBy = DataStore.Users.AllUsers.FirstOrDefault(user => user.ID == transaction.PerformedBy)?.Username ?? "Unknown",
                                         Action = transaction.IsDeposit ? '+' : '-',
                                         Amount = transaction.Amount.ToString("C")
                                     })
                                     .ToList();

            dgvTransactions.DataSource = null;
            dgvTransactions.DataSource = pocketTransactions;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTransactions.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            var pocketMembers = DataStore.Users.AllUsers
                            .Where(user => user.PocketsMemberOf.Contains(MyPocket.ID))
                            .Select(user => new
                            {
                                Username = user.Username,
                                IsOwner = MyPocket.Owners.Contains(user.ID) ? "Owner" : ""
                            })
                            .ToList();
            dgvPocketMembers.DataSource = null;
            dgvPocketMembers.DataSource = pocketMembers;
            dgvPocketMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPocketMembers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPocketMembers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            MakeTransaction makeTransaction = new MakeTransaction(MyPocket, true);
            makeTransaction.ShowDialog();
            UpdateUI();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            MakeTransaction makeTransaction = new MakeTransaction(MyPocket, false);
            makeTransaction.ShowDialog();
            UpdateUI();
        }

        private void btnAddMembers_Click(object sender, EventArgs e)
        {
            User NewMember = DataStore.Users.AllUsers
                             .Where(user => !user.PocketsMemberOf.Contains(MyPocket.ID) && user.AccountIsActive)
                             .FirstOrDefault(user => user.Username == txtAddMember.Text);

            if (NewMember is null)
            {
                MessageBox.Show("Member outside of pocket with username " + txtAddMember.Text + " could not be found", "Error");
            }
            else
            {
                NewMember.PocketsMemberOf.Add(MyPocket.ID);
                MessageBox.Show("Member added successfully", "Success");
            }
            UpdateUI();
        }

        private void btnSelectFromList_Click(object sender, EventArgs e)
        {
            SelectUser selectUser = new SelectUser(MyPocket);
            selectUser.ShowDialog();
            if (selectUser.DialogResult == DialogResult.OK)
            {
                txtAddMember.Text = (string)selectUser.Tag;
            }
        }

        private void btnLeavePocket_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to leave? you cannot rejoin unless you are added back by another member", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                DataStore.CurrentUser.PocketsMemberOf.Remove(MyPocket.ID);
                MessageBox.Show("You have left the pocket", "Success");
                Close();
            }
        }

        private void btnDeletePocket_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this pocket? This action cannot be undone, all money from the pocket will be refunded to your account.", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                DataStore.Pockets.AllPockets.Remove(MyPocket);
                DataStore.CurrentUser.Balance += MyPocket.Balance;
                MessageBox.Show("Pocket deleted successfully", "Success");
                Close();
            }
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            if (dgvPocketMembers.SelectedRows.Count == 1)
            {
                User userToRemove = DataStore.Users.AllUsers.FirstOrDefault(user => user.Username == dgvPocketMembers.CurrentRow.Cells[0].Value);
                if (userToRemove != null)
                {
                    userToRemove.PocketsMemberOf.Remove(MyPocket.ID);
                    MessageBox.Show("Member removed successfully", "Success");
                    UpdateUI();
                }
                else
                {
                    MessageBox.Show("Member not found", "Error");
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // feel free to add a pocket settings form implementation here, for editing the pocket
            ManagePocket managePocket = new ManagePocket(MyPocket);

            managePocket.ShowDialog();
            UpdateUI();
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            if (dgvPocketMembers.SelectedRows.Count == 1)
            {
                User userToPromote = DataStore.Users.AllUsers.FirstOrDefault(user => user.Username == dgvPocketMembers.CurrentRow.Cells[0].Value);
                if (userToPromote is not null && !MyPocket.Owners.Contains(userToPromote.ID))
                {
                    MyPocket.Owners.Add(userToPromote.ID);
                    UpdateUI();
                }
            }
        }

        private void btnDemote_Click(object sender, EventArgs e)
        {
            if (dgvPocketMembers.SelectedRows.Count == 1)
            {
                User userToDemote = DataStore.Users.AllUsers.FirstOrDefault(user => user.Username == dgvPocketMembers.CurrentRow.Cells[0].Value);
                if (userToDemote is not null && MyPocket.Owners.Contains(userToDemote.ID) && userToDemote.ID != DataStore.CurrentUser.ID)
                {
                    MyPocket.Owners.Remove(userToDemote.ID);
                    UpdateUI();
                }
            }
        }

        private void txtGoal_Click(object sender, EventArgs e)
        {
            var deposits = DataStore.Transactions.AllTransactions
                            .Where(t => t.TargetID == MyPocket.ID && (!(t is ScheduledTransaction st) || st.Executed) && t.IsDeposit)
                            .OrderBy(t => t.Date)
                            .ToList();

            if (deposits.Count < 2)
            {
                MessageBox.Show("Not enough data to predict.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime firstDepositDate = deposits.FirstOrDefault().Date;
            double days = DateTime.Now.Subtract(firstDepositDate).TotalDays;

            if (days < 1)
            {
                MessageBox.Show("Not enough data to predict.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalDeposited = deposits.Sum(d => d.Amount);
            decimal averagePerDay = totalDeposited / (decimal)days;

            decimal remaining = MyPocket.SavingsGoal - MyPocket.Balance;
            if (remaining <= 0)
            {
                MessageBox.Show("Goal already reached!", "Goal Reached", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            double estimatedDays = (double)(remaining / averagePerDay);
            DateTime predictedDate = DateTime.Now.AddDays(estimatedDays);

            MessageBox.Show($"Estimated date when goal will be reached: {predictedDate:MMMM dd, yyyy}", "Prediction", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
