namespace EmployeeApp
{
    partial class AccountApprovalForm
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
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();

            // dgvAccounts
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounts.Location = new System.Drawing.Point(20, 20);
            this.dgvAccounts.Size = new System.Drawing.Size(600, 300);
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // btnApprove
            this.btnApprove.Location = new System.Drawing.Point(150, 340);
            this.btnApprove.Size = new System.Drawing.Size(140, 40);
            this.btnApprove.Text = "Approve Account";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);

            // btnReject
            this.btnReject.Location = new System.Drawing.Point(330, 340);
            this.btnReject.Size = new System.Drawing.Size(140, 40);
            this.btnReject.Text = "Reject Account";
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);

            // AccountApprovalForm
            this.ClientSize = new System.Drawing.Size(650, 410);
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnReject);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Approvals";
            this.Load += new System.EventHandler(this.AccountApprovalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
    }
}