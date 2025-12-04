namespace CustomerApp
{
    partial class LoanForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvLoans;

        private System.Windows.Forms.TextBox txtRequestAmount;
        private System.Windows.Forms.Button btnRequestLoan;

        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.Label lblPaymentTitle;
        private System.Windows.Forms.TextBox txtPayLoanID;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.Button btnPayLoan;

        private System.Windows.Forms.Label lblLoanID;
        private System.Windows.Forms.Label lblPayAmount;

        private System.Windows.Forms.Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvLoans = new System.Windows.Forms.DataGridView();

            this.txtRequestAmount = new System.Windows.Forms.TextBox();
            this.btnRequestLoan = new System.Windows.Forms.Button();
            this.lblRequest = new System.Windows.Forms.Label();

            this.lblPaymentTitle = new System.Windows.Forms.Label();
            this.txtPayLoanID = new System.Windows.Forms.TextBox();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.btnPayLoan = new System.Windows.Forms.Button();
            this.lblLoanID = new System.Windows.Forms.Label();
            this.lblPayAmount = new System.Windows.Forms.Label();

            this.btnRefresh = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.SuspendLayout();

            // ================================================================
            //  TITLE
            // ================================================================
            this.lblTitle.Text = "Loan Management";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 90, 180);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.AutoSize = true;

            // ================================================================
            //  LOANS TABLE
            // ================================================================
            this.dgvLoans.Location = new System.Drawing.Point(20, 60);
            this.dgvLoans.Size = new System.Drawing.Size(760, 280);
            this.dgvLoans.ReadOnly = true;
            this.dgvLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoans.MultiSelect = false;
            this.dgvLoans.AllowUserToAddRows = false;
            this.dgvLoans.AllowUserToDeleteRows = false;
            this.dgvLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoans_CellClick);

            // Columns MUST HAVE THESE NAMES
            this.dgvLoans.Columns.Add("LoanID", "Loan ID");
            this.dgvLoans.Columns.Add("Amount", "Amount");
            this.dgvLoans.Columns.Add("Interest", "Interest");
            this.dgvLoans.Columns.Add("TotalDue", "Total Due");
            this.dgvLoans.Columns.Add("Issue", "Issue Date");
            this.dgvLoans.Columns.Add("Due", "Due Date");
            this.dgvLoans.Columns.Add("Status", "Status");

            // ================================================================
            //  REQUEST LOAN SECTION
            // ================================================================
            this.lblRequest.Text = "Request New Loan";
            this.lblRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRequest.ForeColor = System.Drawing.Color.FromArgb(30, 90, 180);
            this.lblRequest.Location = new System.Drawing.Point(20, 355);
            this.lblRequest.AutoSize = true;

            this.txtRequestAmount.Location = new System.Drawing.Point(25, 390);
            this.txtRequestAmount.Size = new System.Drawing.Size(160, 28);
            this.txtRequestAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRequestAmount.PlaceholderText = "Loan amount";

            this.btnRequestLoan.Location = new System.Drawing.Point(200, 390);
            this.btnRequestLoan.Size = new System.Drawing.Size(140, 30);
            this.btnRequestLoan.Text = "Request Loan";
            this.btnRequestLoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRequestLoan.Click += new System.EventHandler(this.btnRequestLoan_Click);

            // ================================================================
            //  PAYMENT SECTION
            // ================================================================
            this.lblPaymentTitle.Text = "Pay Loan";
            this.lblPaymentTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPaymentTitle.ForeColor = System.Drawing.Color.FromArgb(30, 90, 180);
            this.lblPaymentTitle.Location = new System.Drawing.Point(20, 450);
            this.lblPaymentTitle.AutoSize = true;

            this.lblLoanID.Text = "Loan ID:";
            this.lblLoanID.Location = new System.Drawing.Point(25, 485);
            this.lblLoanID.AutoSize = true;
            this.lblLoanID.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.txtPayLoanID.Location = new System.Drawing.Point(100, 480);
            this.txtPayLoanID.Size = new System.Drawing.Size(180, 28);
            this.txtPayLoanID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPayLoanID.ReadOnly = true;

            this.lblPayAmount.Text = "Amount:";
            this.lblPayAmount.Location = new System.Drawing.Point(25, 525);
            this.lblPayAmount.AutoSize = true;
            this.lblPayAmount.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.txtPayAmount.Location = new System.Drawing.Point(100, 520);
            this.txtPayAmount.Size = new System.Drawing.Size(180, 28);
            this.txtPayAmount.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.btnPayLoan.Location = new System.Drawing.Point(300, 520);
            this.btnPayLoan.Size = new System.Drawing.Size(120, 30);
            this.btnPayLoan.Text = "Pay Loan";
            this.btnPayLoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPayLoan.Click += new System.EventHandler(this.btnPayLoan_Click);

            // ================================================================
            //  REFRESH BUTTON
            // ================================================================
            this.btnRefresh.Location = new System.Drawing.Point(640, 350);
            this.btnRefresh.Size = new System.Drawing.Size(140, 32);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // ================================================================
            //  FORM SETTINGS
            // ================================================================
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvLoans);

            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.txtRequestAmount);
            this.Controls.Add(this.btnRequestLoan);

            this.Controls.Add(this.lblPaymentTitle);
            this.Controls.Add(this.lblLoanID);
            this.Controls.Add(this.txtPayLoanID);
            this.Controls.Add(this.lblPayAmount);
            this.Controls.Add(this.txtPayAmount);
            this.Controls.Add(this.btnPayLoan);

            this.Controls.Add(this.btnRefresh);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Loan Management";

            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
