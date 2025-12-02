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

            this.WindowState = FormWindowState.Maximized;
            this.Resize += EmployeeHomeForm_Resize;
        }

        private void EmployeeHomeForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {_loggedEmployee.Name} ({_loggedEmployee.EmployeeID})";
            btnProfileMenu.Text = _loggedEmployee.Name + " ▼";

            CenterControls();
        }

        private void EmployeeHomeForm_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int centerX = (this.ClientSize.Width - btnApproveAccounts.Width) / 2;

            btnApproveAccounts.Left = centerX;
            btnApproveLoans.Left = centerX;
            btnApproveCertificates.Left = centerX;
            btnAddEmployee.Left = centerX;
            btnSearchCustomers.Left = centerX;

            btnProfileMenu.Left = this.ClientSize.Width - btnProfileMenu.Width - 20;
            lblWelcome.Left = 40;
        }

        private void btnApproveAccounts_Click(object sender, EventArgs e)
        {
            new AccountApprovalForm(_loggedEmployee).Show();
        }

        private void btnApproveLoans_Click(object sender, EventArgs e)
        {
            new LoanApprovalForm(_loggedEmployee).Show();
        }

        private void btnApproveCertificates_Click(object sender, EventArgs e)
        {
            new CertificateApprovalForm(_loggedEmployee).Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            new AddEmployeeForm().Show();
        }

        private void btnSearchCustomers_Click(object sender, EventArgs e)
        {
            new CustomerSearchForm().Show();
        }

        private void btnProfileMenu_Click(object sender, EventArgs e)
        {
            contextProfile.Show(btnProfileMenu, 0, btnProfileMenu.Height);
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info =
                $"Employee ID: {_loggedEmployee.EmployeeID}\n" +
                $"Name: {_loggedEmployee.Name}\n" +
                $"Email: {_loggedEmployee.Email}";

            MessageBox.Show(info, "Employee Profile");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}