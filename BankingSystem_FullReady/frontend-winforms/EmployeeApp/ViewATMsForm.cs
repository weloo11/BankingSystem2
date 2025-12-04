using System;
using System.Windows.Forms;
using EmployeeApp.Services;

namespace EmployeeApp
{
    public partial class ViewATMsForm : Form
    {
        private ATMService _atmService = new ATMService();

        public ViewATMsForm()
        {
            InitializeComponent();
        }

        private void ViewATMsForm_Load(object sender, EventArgs e)
        {
            dgvATMs.DataSource = _atmService.GetATMWithTransactions();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            string atmID = txtATMID.Text.Trim();
            string newStatus = comboStatus.Text.Trim();

            if (string.IsNullOrEmpty(atmID))
            {
                MessageBox.Show("Please enter ATM ID.");
                return;
            }

            if (string.IsNullOrEmpty(newStatus))
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            _atmService.UpdateATMStatus(atmID, newStatus);
            MessageBox.Show("ATM Status Updated.");

            dgvATMs.DataSource = null;
            dgvATMs.DataSource = _atmService.GetATMWithTransactions();

        }
    }
}
