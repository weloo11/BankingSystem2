namespace CustomerApp
{
    partial class MonthlyStatementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();

            this.panelSummary = new System.Windows.Forms.Panel();
            this.lblDeposited = new System.Windows.Forms.Label();
            this.lblWithdrawn = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();

            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            this.panelLeft.SuspendLayout();
            this.panelSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();

            this.SuspendLayout();

            // ============================================================
            // LEFT PANEL
            // ============================================================
            this.panelLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.comboYear);
            this.panelLeft.Controls.Add(this.comboMonth);
            this.panelLeft.Controls.Add(this.btnGenerate);
            this.panelLeft.Controls.Add(this.lblMonth);
            this.panelLeft.Controls.Add(this.lblYear);
            this.panelLeft.Location = new System.Drawing.Point(20, 20);
            this.panelLeft.Size = new System.Drawing.Size(250, 220);

            // Month label
            this.lblMonth.Text = "Select Month";
            this.lblMonth.Location = new System.Drawing.Point(20, 20);

            // Month dropdown
            this.comboMonth.Location = new System.Drawing.Point(20, 45);
            this.comboMonth.Size = new System.Drawing.Size(200, 23);

            // Year label
            this.lblYear.Text = "Select Year";
            this.lblYear.Location = new System.Drawing.Point(20, 85);

            // Year dropdown
            this.comboYear.Location = new System.Drawing.Point(20, 110);
            this.comboYear.Size = new System.Drawing.Size(200, 23);

            // Generate button
            this.btnGenerate.Text = "Generate Statement";
            this.btnGenerate.Location = new System.Drawing.Point(20, 150);
            this.btnGenerate.Size = new System.Drawing.Size(200, 40);
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);

            // ============================================================
            // SUMMARY PANEL
            // ============================================================
            this.panelSummary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSummary.Location = new System.Drawing.Point(300, 20);
            this.panelSummary.Size = new System.Drawing.Size(500, 220);

            // Deposited
            this.lblDeposited.Text = "Deposited: 0";
            this.lblDeposited.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDeposited.Location = new System.Drawing.Point(20, 40);

            // Withdrawn
            this.lblWithdrawn.Text = "Withdrawn: 0";
            this.lblWithdrawn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWithdrawn.Location = new System.Drawing.Point(20, 90);

            // Balance
            this.lblBalance.Text = "Balance: 0";
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBalance.Location = new System.Drawing.Point(20, 140);

            this.panelSummary.Controls.Add(this.lblDeposited);
            this.panelSummary.Controls.Add(this.lblWithdrawn);
            this.panelSummary.Controls.Add(this.lblBalance);

            // ============================================================
            // DATA GRID VIEW
            // ============================================================
            this.dataGridView1.Location = new System.Drawing.Point(20, 260);
            this.dataGridView1.Size = new System.Drawing.Size(780, 300);

            // ============================================================
            // FORM
            // ============================================================
            this.ClientSize = new System.Drawing.Size(840, 600);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.dataGridView1);
            this.Text = "Monthly Statements";
            this.Load += new System.EventHandler(this.MonthlyStatementForm_Load);

            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelSummary.ResumeLayout(false);
            this.panelSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelSummary;

        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.ComboBox comboYear;

        private System.Windows.Forms.Button btnGenerate;

        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;

        private System.Windows.Forms.Label lblDeposited;
        private System.Windows.Forms.Label lblWithdrawn;
        private System.Windows.Forms.Label lblBalance;

        private System.Windows.Forms.DataGridView dataGridView1;
    }
}