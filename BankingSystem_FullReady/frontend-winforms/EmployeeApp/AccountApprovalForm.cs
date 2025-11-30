using System;
using System.Windows.Forms;
using EmployeeApp.Services;
using EmployeeApp.Models;

namespace EmployeeApp
{
    public partial class AccountApprovalForm : Form
    {
        private readonly AccountService _accountService = new AccountService();
        private readonly Employee _employee;

        public AccountApprovalForm(Employee emp)
        {
            InitializeComponent();
            _employee = emp;
        }

        private void AccountApprovalForm_Load(object sender, EventArgs e)
        {
            LoadPendingAccounts();
        }

        private void LoadPendingAccounts()
        {
            dgvAccounts.DataSource = _accountService.GetPendingAccounts();
        }

        private string GetSelectedAccountID()
        {
            if (dgvAccounts.SelectedRows.Count == 0)
                return null;

            return dgvAccounts.SelectedRows[0].Cells["AccountID"].Value.ToString();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            string accountID = GetSelectedAccountID();
            if (accountID == null)
            {
                MessageBox.Show("Please select an account.");
                return;
            }

            _accountService.ApproveAccount(accountID, _employee.EmployeeID);
            MessageBox.Show("Account Approved!");
            LoadPendingAccounts();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            string accountID = GetSelectedAccountID();
            if (accountID == null)
            {
                MessageBox.Show("Please select an account.");
                return;
            }

            _accountService.RejectAccount(accountID, _employee.EmployeeID);
            MessageBox.Show("Account Rejected.");
            LoadPendingAccounts();
        }
    }
}