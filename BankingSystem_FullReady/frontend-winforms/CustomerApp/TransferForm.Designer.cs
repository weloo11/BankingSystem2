using System.ComponentModel;

namespace CustomerApp
{
    partial class TransferForm
    {
        private IContainer components = null;

        private System.Windows.Forms.TextBox txtToCardNo;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnTransfer;

        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnTransfers;
        private System.Windows.Forms.Button btnDeposits;
        private System.Windows.Forms.Button btnWithdrawals;

        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblHistory;

        private System.Windows.Forms.DataGridView dgvTransactions;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();

            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();

            this.lblCard = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();

            this.txtToCardNo = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();

            this.btnTransfer = new System.Windows.Forms.Button();

            this.btnAll = new System.Windows.Forms.Button();
            this.btnTransfers = new System.Windows.Forms.Button();
            this.btnDeposits = new System.Windows.Forms.Button();
            this.btnWithdrawals = new System.Windows.Forms.Button();

            this.dgvTransactions = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();

            // ----------------------------
            // FORM SETTINGS
            // ----------------------------
            this.BackColor = System.Drawing.Color.FromArgb(220, 235, 250);
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Text = "Transfer Money";

            // ----------------------------
            // PANELS
            // ----------------------------
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(30, 90, 160);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 60;

            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(90, 140, 200);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height = 6;

            // ----------------------------
            // LABELS
            // ----------------------------
            this.lblCard.Text = "Receiver Card Number:";
            this.lblCard.Location = new System.Drawing.Point(40, 80);

            this.lblAmount.Text = "Amount:";
            this.lblAmount.Location = new System.Drawing.Point(40, 140);

            this.lblHistory.Text = "Transaction History";
            this.lblHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHistory.Location = new System.Drawing.Point(40, 260);

            // ----------------------------
            // INPUTS
            // ----------------------------
            this.txtToCardNo.Location = new System.Drawing.Point(40, 105);
            this.txtToCardNo.Size = new System.Drawing.Size(300, 27);

            this.txtAmount.Location = new System.Drawing.Point(40, 165);
            this.txtAmount.Size = new System.Drawing.Size(300, 27);

            // ----------------------------
            // TRANSFER BUTTON
            // ----------------------------
            this.btnTransfer.Text = "Transfer Money";
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(30, 110, 190);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Size = new System.Drawing.Size(300, 40);
            this.btnTransfer.Location = new System.Drawing.Point(40, 205);
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);

            // ----------------------------
            // FILTER BUTTONS
            // ----------------------------
            this.btnAll.Text = "All";
            this.btnAll.Location = new System.Drawing.Point(40, 310);
            this.btnAll.Size = new System.Drawing.Size(80, 35);
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);

            this.btnTransfers.Text = "Transfers";
            this.btnTransfers.Location = new System.Drawing.Point(130, 310);
            this.btnTransfers.Size = new System.Drawing.Size(100, 35);
            this.btnTransfers.Click += new System.EventHandler(this.btnTransfers_Click);

            this.btnDeposits.Text = "Deposits";
            this.btnDeposits.Location = new System.Drawing.Point(240, 310);
            this.btnDeposits.Size = new System.Drawing.Size(100, 35);
            this.btnDeposits.Click += new System.EventHandler(this.btnDeposits_Click);

            this.btnWithdrawals.Text = "Withdrawals";
            this.btnWithdrawals.Location = new System.Drawing.Point(350, 310);
            this.btnWithdrawals.Size = new System.Drawing.Size(120, 35);
            this.btnWithdrawals.Click += new System.EventHandler(this.btnWithdrawals_Click);

            // ----------------------------
            // TRANSACTION GRID
            // ----------------------------
            this.dgvTransactions.Location = new System.Drawing.Point(40, 360);
            this.dgvTransactions.Size = new System.Drawing.Size(820, 300);
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // ----------------------------
            // ADD CONTROLS
            // ----------------------------
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);

            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblHistory);

            this.Controls.Add(this.txtToCardNo);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnTransfer);

            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnTransfers);
            this.Controls.Add(this.btnDeposits);
            this.Controls.Add(this.btnWithdrawals);

            this.Controls.Add(this.dgvTransactions);

            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
