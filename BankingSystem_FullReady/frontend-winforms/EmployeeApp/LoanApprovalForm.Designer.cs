namespace EmployeeApp
{
    partial class LoanApprovalForm
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
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.SuspendLayout();

            // dgvLoans
            this.dgvLoans.AllowUserToAddRows = false;
            this.dgvLoans.AllowUserToDeleteRows = false;
            this.dgvLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoans.Location = new System.Drawing.Point(20, 20);
            this.dgvLoans.Size = new System.Drawing.Size(600, 300);
            this.dgvLoans.ReadOnly = true;
            this.dgvLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // btnApprove
            this.btnApprove.Location = new System.Drawing.Point(150, 340);
            this.btnApprove.Size = new System.Drawing.Size(140, 40);
            this.btnApprove.Text = "Approve Loan";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);

            // btnReject
            this.btnReject.Location = new System.Drawing.Point(330, 340);
            this.btnReject.Size = new System.Drawing.Size(140, 40);
            this.btnReject.Text = "Reject Loan";
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);

            // LoanApprovalForm
            this.ClientSize = new System.Drawing.Size(650, 410);
            this.Controls.Add(this.dgvLoans);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnReject);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Approvals";
            this.Load += new System.EventHandler(this.LoanApprovalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
    }
}