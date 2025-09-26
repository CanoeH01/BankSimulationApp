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
    public partial class ManagePocket : Form
    {
        public Pocket pocket { get; set; }
        public ManagePocket()
        {
            pocket = new Pocket();
            InitializeComponent();
        }
        public ManagePocket(Pocket editPocket)
        {
            pocket = editPocket;
            InitializeComponent();
            UpdateUI();
        }

        private void UpdateUI()
        {
            txtName.Text = pocket.Name;
            numSavingsGoal.Value = pocket.SavingsGoal;
            mthDeadline.SelectionStart = pocket.GoalDeadline;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name for the pocket.", "Error");
            }
            else
            {
                pocket.Name = txtName.Text;
                pocket.SavingsGoal = numSavingsGoal.Value;
                // if pocket is being edited, then don't change the owner, only if its a new pocket
                if (pocket.Owners.Count == 0)
                    pocket.Owners.Add(DataStore.CurrentUser.ID);
                
                // if savings goal is 0, then its no deadline, no goal
                pocket.GoalDeadline = (pocket.SavingsGoal > 0) ? mthDeadline.SelectionStart : DateTime.MinValue;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
