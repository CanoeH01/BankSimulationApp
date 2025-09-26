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
    public partial class EditBalance : Form
    {
        bool isDeposit;
        public EditBalance()
        {
            InitializeComponent();
        }
        private void EditBalance_Load(object sender, EventArgs e)
        {
            txtCurrentBalance.Text = DataStore.CurrentUser.Balance.ToString("C");
        }
        private void EnableControls()
        {
            lblEditBalance.Visible = true;
            lblEditBalance.Enabled = true;
            numAmount.Visible = true;
            numAmount.Enabled = true;
            btnConfirmBalance.Enabled = true;
            btnConfirmBalance.Visible = true;
        }

        private void btnDepositMoney_Click(object sender, EventArgs e)
        {
            EnableControls();
            lblEditBalance.Text = "Deposit Amount";
            numAmount.Maximum = 10000000;
            isDeposit = true;
        }

        private void btnWithdrawMoney_Click(object sender, EventArgs e)
        {
            EnableControls();
            lblEditBalance.Text = "Withdrawal Amount";
            numAmount.Maximum = DataStore.CurrentUser.Balance;
            isDeposit = false;
        }

        private void btnConfirmBalance_Click(object sender, EventArgs e)
        {
            if (isDeposit)
            {
                DataStore.CurrentUser.Balance += numAmount.Value;
                MessageBox.Show("Deposited " + numAmount.Value.ToString("C") + " successfully" );
            }
            else
            { 
                DataStore.CurrentUser.Balance -= numAmount.Value;
                MessageBox.Show("Withdrew  " + numAmount.Value.ToString("C") + " successfully");
            }
            this.Close();
        }
    }
}
