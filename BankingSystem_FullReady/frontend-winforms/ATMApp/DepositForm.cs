using System;
using System.Windows.Forms;
using ATMApp.Models;
using ATMApp.Services;

namespace ATMApp
{
    public partial class DepositForm : Form
    {
        private Account account;
        private string atmID;

        public DepositForm(Account acc, string atm)
        {
            InitializeComponent();
            account = acc;
            atmID = atm;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(txtAmount.Text);

            double newBalance = AccountServices.Deposit(account.accountID, amount);

            AccountServices.SaveTransaction(
                "T" + Guid.NewGuid().ToString("N").Substring(0, 5),
                account.accountID,
                atmID,
                amount,
                "Deposit"
            );

            MessageBox.Show("Success! New Balance: " + newBalance);
            this.Close();
        }
    }
}
