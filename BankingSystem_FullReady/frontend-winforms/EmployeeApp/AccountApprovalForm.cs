using System;
using System.Windows.Forms;
using EmployeeApp.Models;
using EmployeeApp.Services;

namespace EmployeeApp
{
    public partial class AccountApprovalForm : Form
    {
        private readonly Employee _employee;
        private readonly AccountService _accountService = new AccountService();

        public AccountApprovalForm(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
        }

        private void AccountApprovalForm_Load(object sender, EventArgs e)
        {
            LoadPendingAccounts();
        }

        private void LoadPendingAccounts()
        {
            dgvAccounts.AutoGenerateColumns = true;
            dgvAccounts.DataSource = _accountService.GetPendingAccounts();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 0)
                return;

            string accountID = dgvAccounts.SelectedRows[0].Cells["AccountID"].Value.ToString();

            Card card = _accountService.GenerateCard();
            _accountService.ApproveAccount(accountID, card);

            MessageBox.Show("Account approved and card generated.");
            LoadPendingAccounts();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 0)
                return;

            string accountID = dgvAccounts.SelectedRows[0].Cells["AccountID"].Value.ToString();

            _accountService.RejectAccount(accountID);
            MessageBox.Show("Account rejected.");
            LoadPendingAccounts();
        }
    }
}