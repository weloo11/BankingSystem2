using System;
using System.Windows.Forms;
using EmployeeApp.Services;

namespace EmployeeApp
{
    public partial class CustomerSearchForm : Form
    {
        private readonly CustomerService _service = new CustomerService();

        public CustomerSearchForm()
        {
            InitializeComponent();
        }

        private void CustomerSearchForm_Load(object sender, EventArgs e)
        {
            dgvCustomers.AutoGenerateColumns = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var text = txtSearch.Text.Trim();
            var results = _service.SearchCustomer(text);
            dgvCustomers.DataSource = results;
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string customerID = dgvCustomers.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
            new CustomerProfileForm(customerID).Show();
        }
    }
}