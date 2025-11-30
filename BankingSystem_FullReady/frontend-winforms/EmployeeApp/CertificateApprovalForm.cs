using System;
using System.Windows.Forms;
using EmployeeApp.Services;
using EmployeeApp.Models;

namespace EmployeeApp
{
    public partial class CertificateApprovalForm : Form
    {
        private readonly CertificateService _certService = new CertificateService();
        private readonly Employee _employee;

        public CertificateApprovalForm(Employee emp)
        {
            InitializeComponent();
            _employee = emp;
        }

        private void CertificateApprovalForm_Load(object sender, EventArgs e)
        {
            LoadPendingCertificates();
        }

        private void LoadPendingCertificates()
        {
            dgvCertificates.DataSource = _certService.GetPendingCertificates();
        }

        private string GetSelectedCertificateID()
        {
            if (dgvCertificates.SelectedRows.Count == 0)
                return null;

            return dgvCertificates.SelectedRows[0].Cells["CertificateID"].Value.ToString();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            string certID = GetSelectedCertificateID();
            if (certID == null)
            {
                MessageBox.Show("Select a certificate.");
                return;
            }

            _certService.ApproveCertificate(certID);
            MessageBox.Show("Certificate Approved!");
            LoadPendingCertificates();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            string certID = GetSelectedCertificateID();
            if (certID == null)
            {
                MessageBox.Show("Select a certificate.");
                return;
            }

            _certService.RejectCertificate(certID);
            MessageBox.Show("Certificate Rejected.");
            LoadPendingCertificates();
        }
    }
}