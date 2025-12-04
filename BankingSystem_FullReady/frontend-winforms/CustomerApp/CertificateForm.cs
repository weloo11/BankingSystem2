using System;
using System.Windows.Forms;
using CustomerApp.Services;
using CustomerApp.Models;

namespace CustomerApp
{
    public partial class CertificateForm : Form
    {
        private readonly CertificateService _service = new CertificateService();

        public CertificateForm(string accountID)
        {
            InitializeComponent();

            // Auto-fill account ID
            txtAccountID.Text = accountID;

            LoadData();
        }

        public CertificateForm() : this("")     // fallback no-argument constructor
        {
        }

        private void LoadData()
        {
            dataGridView1.DataSource = _service.GetAll();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtAmount.Text, out double amount))
            {
                MessageBox.Show("Enter a valid amount.");
                return;
            }

            // Auto interest calculation
            double interest =
                amount < 10000 ? 10 :
                amount < 50000 ? 12 : 14;

            var cert = new Certificate
            {
                certificateID = txtCertID.Text,
                accountID = txtAccountID.Text,
                issueDate = dateIssue.Value,
                expiryDate = dateExpiry.Value,
                amount = amount,
                interest = interest,
                status = "Pending"
            };

            _service.Insert(cert);
            LoadData();
            MessageBox.Show("Certificate created successfully!");
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            _service.UpdateStatus(txtCertID.Text, "Approved");
            LoadData();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            _service.UpdateStatus(txtCertID.Text, "Rejected");
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _service.Delete(txtCertID.Text);
            LoadData();
        }

        private void btnCountByStatus_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _service.CountByStatus();
        }

        private void btnSumApproved_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total approved: " + _service.SumApproved());
        }

        private void btnExpSoon_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _service.ExpiringSoon();
        }

        private void btnAvgInterest_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _service.AvgInterest();
        }
    }
}