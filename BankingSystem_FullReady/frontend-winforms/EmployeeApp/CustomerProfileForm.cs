using System;
using System.Windows.Forms;
using EmployeeApp.Services;

namespace EmployeeApp
{
    public partial class CustomerProfileForm : Form
    {
        private readonly CustomerService _customerService = new CustomerService();
        private readonly AccountService _accountService = new AccountService();
        private readonly string _customerID;

        public CustomerProfileForm(string customerID)
        {
            InitializeComponent();
            _customerID = customerID;
        }

        private void CustomerProfileForm_Load(object sender, EventArgs e)
        {
            var customer = _customerService.GetCustomer(_customerID);
            if (customer == null)
            {
                MessageBox.Show("Customer not found.");
                this.Close();
                return;
            }

            lblCustomerID.Text = customer.CustomerID;
            lblName.Text = customer.Name;
            lblEmail.Text = customer.Email;
            lblPhone.Text = customer.Phone;

            ReloadAccounts();
        }

        private void ReloadAccounts()
        {
            dgvAccounts.DataSource = _accountService.GetAccountsByCustomer(_customerID);
        }

        private void btnFreeze_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 0)
                return;

            string accountID = dgvAccounts.SelectedRows[0].Cells["AccountID"].Value.ToString();
            _accountService.UpdateStatus(accountID, "Suspended");
            MessageBox.Show("Account Frozen.");
            ReloadAccounts();
        }

        private void btnUnfreeze_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 0)
                return;

            string accountID = dgvAccounts.SelectedRows[0].Cells["AccountID"].Value.ToString();
            _accountService.UpdateStatus(accountID, "Active");
            MessageBox.Show("Account Unfrozen.");
            ReloadAccounts();
        }
    }
}