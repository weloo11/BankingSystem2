using System;
using System.Windows.Forms;
using EmployeeApp.Models;

namespace EmployeeApp
{
    public partial class EmployeeHomeForm : Form
    {
        private readonly Employee _loggedEmployee;

        public EmployeeHomeForm(Employee emp)
        {
            InitializeComponent();
            _loggedEmployee = emp;
        }

        private void EmployeeHomeForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {_loggedEmployee.Name} ({_loggedEmployee.EmployeeID})";
        }

        private void btnApproveAccounts_Click(object sender, EventArgs e)
        {
            var form = new AccountApprovalForm(_loggedEmployee);
            form.Show();
        }

        private void btnApproveLoans_Click(object sender, EventArgs e)
        {
            var form = new LoanApprovalForm(_loggedEmployee);
            form.Show();
        }

        private void btnApproveCertificates_Click(object sender, EventArgs e)
        {
            var form = new CertificateApprovalForm(_loggedEmployee);
            form.Show();
        }
    }
}