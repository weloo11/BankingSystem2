namespace EmployeeApp
{
    partial class EmployeeHomeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnApproveAccounts = new System.Windows.Forms.Button();
            this.btnApproveLoans = new System.Windows.Forms.Button();
            this.btnApproveCertificates = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Text = "Welcome";

            // btnApproveAccounts
            this.btnApproveAccounts.Location = new System.Drawing.Point(20, 70);
            this.btnApproveAccounts.Size = new System.Drawing.Size(220, 40);
            this.btnApproveAccounts.Text = "Approve Customer Accounts";
            this.btnApproveAccounts.Click += new System.EventHandler(this.btnApproveAccounts_Click);

            // btnApproveLoans
            this.btnApproveLoans.Location = new System.Drawing.Point(20, 130);
            this.btnApproveLoans.Size = new System.Drawing.Size(220, 40);
            this.btnApproveLoans.Text = "Approve Loans";
            this.btnApproveLoans.Click += new System.EventHandler(this.btnApproveLoans_Click);

            // btnApproveCertificates
            this.btnApproveCertificates.Location = new System.Drawing.Point(20, 190);
            this.btnApproveCertificates.Size = new System.Drawing.Size(220, 40);
            this.btnApproveCertificates.Text = "Approve Certificates";
            this.btnApproveCertificates.Click += new System.EventHandler(this.btnApproveCertificates_Click);

            // EmployeeHomeForm
            this.ClientSize = new System.Drawing.Size(270, 260);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnApproveAccounts);
            this.Controls.Add(this.btnApproveLoans);
            this.Controls.Add(this.btnApproveCertificates);
            this.Name = "EmployeeHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Dashboard";
            this.Load += new System.EventHandler(this.EmployeeHomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        public System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnApproveAccounts;
        private System.Windows.Forms.Button btnApproveLoans;
        private System.Windows.Forms.Button btnApproveCertificates;
    }
}