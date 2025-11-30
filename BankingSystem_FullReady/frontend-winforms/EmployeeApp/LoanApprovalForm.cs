using System;
using System.Windows.Forms;
using EmployeeApp.Services;
using EmployeeApp.Models;

namespace EmployeeApp
{
    public partial class LoanApprovalForm : Form
    {
        private readonly LoanService _loanService = new LoanService();
        private readonly Employee _employee;

        public LoanApprovalForm(Employee emp)
        {
            InitializeComponent();
            _employee = emp;
        }

        private void LoanApprovalForm_Load(object sender, EventArgs e)
        {
            LoadPendingLoans();
        }

        private void LoadPendingLoans()
        {
            dgvLoans.DataSource = _loanService.GetPendingLoans();
        }

        private string GetSelectedLoanID()
        {
            if (dgvLoans.SelectedRows.Count == 0)
                return null;

            return dgvLoans.SelectedRows[0].Cells["LoanID"].Value.ToString();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            string loanID = GetSelectedLoanID();
            if (loanID == null)
            {
                MessageBox.Show("Select a loan first.");
                return;
            }

            _loanService.ApproveLoan(loanID);
            MessageBox.Show("Loan Approved!");
            LoadPendingLoans();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            string loanID = GetSelectedLoanID();
            if (loanID == null)
            {
                MessageBox.Show("Select a loan first.");
                return;
            }

            _loanService.RejectLoan(loanID);
            MessageBox.Show("Loan Rejected.");
            LoadPendingLoans();
        }
    }
}