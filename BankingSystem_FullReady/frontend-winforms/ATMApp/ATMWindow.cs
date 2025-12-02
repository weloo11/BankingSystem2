using System;
using System.Windows.Forms;
using ATMApp.Models;
using ATMApp.Services;

namespace ATMApp
{
    public partial class ATMWindow : Form
    {
        private string currentATM = "";
        private Account currentAccount = null;

        public ATMWindow()
        {
            InitializeComponent();
        }

        private void btnEnterATM_Click(object sender, EventArgs e)
        {
            string atmID = txtATMID.Text.Trim();

            if (!AccountServices.ValidateATM(atmID))
            {
                MessageBox.Show("ATM not found.");
                return;
            }

            currentATM = atmID;
            MessageBox.Show("ATM Verified. Enter Account Info.");
        }

        private void btnVerifyAccount_Click(object sender, EventArgs e)
        {
            string acc = txtAccountID.Text.Trim();
            string card = txtCardNo.Text.Trim();

            var account = AccountServices.ValidateAccount(acc, card);

            if (account == null)
            {
                MessageBox.Show("Invalid account or card.");
                return;
            }

            currentAccount = account;
            lblBalance.Text = "Balance: " + account.balance.ToString();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            var form = new DepositForm(currentAccount, currentATM);
            form.ShowDialog();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            var form = new WithdrawForm(currentAccount, currentATM);
            form.ShowDialog();
        }
    }
}
