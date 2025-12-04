namespace CustomerApp
{
    partial class TransferForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Label lblTransferTitle;
        private System.Windows.Forms.Label lblToCard;
        private System.Windows.Forms.TextBox txtToCardNo;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnTransfer;

        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnTransfers;
        private System.Windows.Forms.Button btnDeposits;
        private System.Windows.Forms.Button btnWithdrawals;

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
            this.dgvTransactions = new System.Windows.Forms.DataGridView();

            this.lblTransferTitle = new System.Windows.Forms.Label();
            this.lblToCard = new System.Windows.Forms.Label();
            this.txtToCardNo = new System.Windows.Forms.TextBox();

            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();

            this.btnTransfer = new System.Windows.Forms.Button();

            this.btnAll = new System.Windows.Forms.Button();
            this.btnTransfers = new System.Windows.Forms.Button();
            this.btnDeposits = new System.Windows.Forms.Button();
            this.btnWithdrawals = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();

            // ============================================================
            // TITLE
            // ============================================================
            this.lblTitle.Text = "Money Transfers & Transactions";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 90, 180);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.AutoSize = true;

            // ============================================================
            // DATAGRIDVIEW
            // ============================================================
            this.dgvTransactions.Location = new System.Drawing.Point(20, 60);
            this.dgvTransactions.Size = new System.Drawing.Size(760, 300);
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.MultiSelect = false;
            this.dgvTransactions.AutoGenerateColumns = false;

            var colType = new System.Windows.Forms.DataGridViewTextBoxColumn
            {
                HeaderText = "Type",
                DataPropertyName = "Type",
                ReadOnly = true
            };

            var colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn
            {
                HeaderText = "Amount",
                DataPropertyName = "Amount",
                ReadOnly = true
            };

            var colDate = new System.Windows.Forms.DataGridViewTextBoxColumn
            {
                HeaderText = "Date",
                DataPropertyName = "Date",
                ReadOnly = true
            };

            var colAccount = new System.Windows.Forms.DataGridViewTextBoxColumn
            {
                HeaderText = "Account",
                DataPropertyName = "AccountID",   // IMPORTANT
                ReadOnly = true
            };

            var colCard = new System.Windows.Forms.DataGridViewTextBoxColumn
            {
                HeaderText = "Card",
                DataPropertyName = "CardNo",      // IMPORTANT
                ReadOnly = true
            };

            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                colType, colAmount, colDate, colAccount, colCard
            });

            // ============================================================
            // FILTER BUTTONS
            // ============================================================
            this.btnAll.Text = "All";
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAll.Location = new System.Drawing.Point(20, 370);
            this.btnAll.Size = new System.Drawing.Size(100, 32);
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);

            this.btnTransfers.Text = "Transfers";
            this.btnTransfers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTransfers.Location = new System.Drawing.Point(130, 370);
            this.btnTransfers.Size = new System.Drawing.Size(120, 32);
            this.btnTransfers.Click += new System.EventHandler(this.btnTransfers_Click);

            this.btnDeposits.Text = "Deposits";
            this.btnDeposits.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeposits.Location = new System.Drawing.Point(260, 370);
            this.btnDeposits.Size = new System.Drawing.Size(120, 32);
            this.btnDeposits.Click += new System.EventHandler(this.btnDeposits_Click);

            this.btnWithdrawals.Text = "Withdrawals";
            this.btnWithdrawals.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnWithdrawals.Location = new System.Drawing.Point(390, 370);
            this.btnWithdrawals.Size = new System.Drawing.Size(150, 32);
            this.btnWithdrawals.Click += new System.EventHandler(this.btnWithdrawals_Click);

            // ============================================================
            // TRANSFER SECTION
            // ============================================================
            this.lblTransferTitle.Text = "Make a Transfer";
            this.lblTransferTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTransferTitle.ForeColor = System.Drawing.Color.FromArgb(30, 90, 180);
            this.lblTransferTitle.Location = new System.Drawing.Point(20, 430);
            this.lblTransferTitle.AutoSize = true;

            this.lblToCard.Text = "To Card No:";
            this.lblToCard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblToCard.Location = new System.Drawing.Point(25, 470);
            this.lblToCard.AutoSize = true;

            this.txtToCardNo.Location = new System.Drawing.Point(120, 465);
            this.txtToCardNo.Size = new System.Drawing.Size(200, 28);

            this.lblAmount.Text = "Amount:";
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAmount.Location = new System.Drawing.Point(25, 510);
            this.lblAmount.AutoSize = true;

            this.txtAmount.Location = new System.Drawing.Point(120, 505);
            this.txtAmount.Size = new System.Drawing.Size(200, 28);

            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTransfer.Location = new System.Drawing.Point(340, 505);
            this.btnTransfer.Size = new System.Drawing.Size(120, 32);
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);

            // ============================================================
            // FORM
            // ============================================================
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.dgvTransactions);

            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnTransfers);
            this.Controls.Add(this.btnDeposits);
            this.Controls.Add(this.btnWithdrawals);

            this.Controls.Add(this.lblTransferTitle);
            this.Controls.Add(this.lblToCard);
            this.Controls.Add(this.txtToCardNo);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnTransfer);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Money Transfer";

            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
} 