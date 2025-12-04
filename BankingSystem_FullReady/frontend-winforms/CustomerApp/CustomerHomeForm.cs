using System;
using System.Windows.Forms;
using CustomerApp.Models;

namespace CustomerApp
{
    public partial class CustomerHomeForm : Form
    {
        private Customer _customer;
        private Account _account;

        public CustomerHomeForm()
        {
            InitializeComponent();
        }

        public CustomerHomeForm(Customer customer, Account account)
        {
            _customer = customer;
            _account = account;

            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            lblWelcome.Text = $"Welcome, {_customer.name}";
            lblBalance.Text = $"{_account.balance:0.00} {_account.currency}";
            lblStatus.Text = $"Account Status: {_account.status}";
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            var f = new AccountForm(_customer, _account);
            f.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            var f = new TransferForm(_customer, _account);
            f.Show();
        }

        private void btnCertificates_Click(object sender, EventArgs e)
        {
            var f = new CertificateForm(_account.accountID);
            f.Show();
        }


        private void btnLoans_Click(object sender, EventArgs e)
        {
            new LoanForm(_account).Show();
        }


        private void btnStatements_Click(object sender, EventArgs e)
        {
            var f = new MonthlyStatementForm(_account.accountID);
            f.Show();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void CustomerHomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}