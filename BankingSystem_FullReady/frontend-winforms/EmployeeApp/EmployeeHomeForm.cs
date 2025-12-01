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

            // Full-screen window
            this.WindowState = FormWindowState.Maximized;

            // Re-center controls when window size changes
            this.Resize += EmployeeHomeForm_Resize;
        }

        private void EmployeeHomeForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {_loggedEmployee.Name} ({_loggedEmployee.EmployeeID})";

            // Profile button text
            btnProfileMenu.Text = _loggedEmployee.Name + " ▼";

            // All employees can add employees now (no admin check)

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

            // Keep profile menu at top right
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

        private void btnProfileMenu_Click(object sender, EventArgs e)
        {
            // Open dropdown just below the button
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
            // Go back to login form
            var login = new LoginForm();
            login.Show();

            // Close only the dashboard
            this.Close();
        }
    }
}