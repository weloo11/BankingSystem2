namespace CustomerApp
{
    partial class CertificateForm
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

        private void InitializeComponent()
        {
            this.txtCertID = new System.Windows.Forms.TextBox();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dateIssue = new System.Windows.Forms.DateTimePicker();
            this.dateExpiry = new System.Windows.Forms.DateTimePicker();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnExpSoon = new System.Windows.Forms.Button();
            this.btnAvgInterest = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // txtCertID
            this.txtCertID.Location = new System.Drawing.Point(30, 30);
            this.txtCertID.Name = "txtCertID";
            this.txtCertID.Size = new System.Drawing.Size(160, 23);
            this.txtCertID.TabIndex = 0;
            this.txtCertID.PlaceholderText = "Certificate ID";

            // txtAccountID
            this.txtAccountID.Location = new System.Drawing.Point(30, 70);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(160, 23);
            this.txtAccountID.TabIndex = 1;
            this.txtAccountID.PlaceholderText = "Account ID";

            // txtAmount
            this.txtAmount.Location = new System.Drawing.Point(30, 110);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(160, 23);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.PlaceholderText = "Amount";

            // dateIssue
            this.dateIssue.Location = new System.Drawing.Point(30, 150);
            this.dateIssue.Name = "dateIssue";
            this.dateIssue.Size = new System.Drawing.Size(200, 23);

            // dateExpiry
            this.dateExpiry.Location = new System.Drawing.Point(30, 190);
            this.dateExpiry.Name = "dateExpiry";
            this.dateExpiry.Size = new System.Drawing.Size(200, 23);

            // buttons -----------------------

            this.btnCreate.Location = new System.Drawing.Point(250, 30);
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);

            this.btnApprove.Location = new System.Drawing.Point(250, 70);
            this.btnApprove.Text = "Approve";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);

            this.btnReject.Location = new System.Drawing.Point(250, 110);
            this.btnReject.Text = "Reject";
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);

            this.btnDelete.Location = new System.Drawing.Point(250, 150);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnCount.Location = new System.Drawing.Point(400, 30);
            this.btnCount.Text = "Count by Status";
            this.btnCount.Click += new System.EventHandler(this.btnCountByStatus_Click);

            this.btnSum.Location = new System.Drawing.Point(400, 70);
            this.btnSum.Text = "Sum Approved";
            this.btnSum.Click += new System.EventHandler(this.btnSumApproved_Click);

            this.btnExpSoon.Location = new System.Drawing.Point(400, 110);
            this.btnExpSoon.Text = "Expiring Soon";
            this.btnExpSoon.Click += new System.EventHandler(this.btnExpSoon_Click);

            this.btnAvgInterest.Location = new System.Drawing.Point(400, 150);
            this.btnAvgInterest.Text = "Avg Interest";
            this.btnAvgInterest.Click += new System.EventHandler(this.btnAvgInterest_Click);

            // datagrid
            this.dataGridView1.Location = new System.Drawing.Point(30, 240);
            this.dataGridView1.Size = new System.Drawing.Size(700, 300);
            this.dataGridView1.Name = "dataGridView1";

            // form
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtCertID);
            this.Controls.Add(this.txtAccountID);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dateIssue);
            this.Controls.Add(this.dateExpiry);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnExpSoon);
            this.Controls.Add(this.btnAvgInterest);
            this.Controls.Add(this.dataGridView1);

            this.Name = "CertificateForm";
            this.Text = "Certificates";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCertID;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dateIssue;
        private System.Windows.Forms.DateTimePicker dateExpiry;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnExpSoon;
        private System.Windows.Forms.Button btnAvgInterest;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}