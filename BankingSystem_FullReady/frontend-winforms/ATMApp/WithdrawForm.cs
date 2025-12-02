using System;
using System.Windows.Forms;
using ATMApp.Models;
using ATMApp.Services;

namespace ATMApp
{
    public partial class WithdrawForm : Form
    {
        private Account account;
        private string atmID;

        public WithdrawForm(Account acc, string atm)
        {
            InitializeComponent();
            account = acc;
            atmID = atm;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(txtAmount.Text);

            try
            {
                double newBalance = AccountServices.Withdraw(account.accountID, amount);

                AccountServices.SaveTransaction(
                    "T" + Guid.NewGuid().ToString("N").Substring(0, 5),
                    account.accountID,
                    atmID,
                    amount,
                    "Withdraw"
                );

                MessageBox.Show("Success! New Balance: " + newBalance);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
