namespace CustomerApp
{
    partial class CustomerHomeForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnCertificates;
        private System.Windows.Forms.Button btnLoans;
        private System.Windows.Forms.Button btnStatements;
        private System.Windows.Forms.Button btnLogout;


        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.SuspendLayout();

            // FORM SETTINGS
            this.BackColor = System.Drawing.Color.FromArgb(33, 90, 150);
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "CustomerHomeForm";
            this.Text = "Customer Dashboard";

            // WELCOME LABEL
            lblWelcome = new System.Windows.Forms.Label();
            lblWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblWelcome.ForeColor = System.Drawing.Color.White;
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new System.Drawing.Point(30, 30);

            // BALANCE LABEL
            lblBalance = new System.Windows.Forms.Label();
            lblBalance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblBalance.ForeColor = System.Drawing.Color.White;
            lblBalance.AutoSize = true;
            lblBalance.Location = new System.Drawing.Point(30, 90);

            // STATUS LABEL
            lblStatus = new System.Windows.Forms.Label();
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblStatus.ForeColor = System.Drawing.Color.White;
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(30, 140);

            // BUTTON FACTORY
            btnAccount = MakeButton("Account", 200);
            btnTransfer = MakeButton("Transfer", 260);
            btnCertificates = MakeButton("Certificates", 320);
            btnLoans = MakeButton("Loans", 380);
            btnStatements = MakeButton("Statements", 440);

            btnLogout = new System.Windows.Forms.Button();
            btnLogout.Text = "Logout";
            btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnLogout.Size = new System.Drawing.Size(180, 50);
            btnLogout.BackColor = System.Drawing.Color.Maroon;
            btnLogout.ForeColor = System.Drawing.Color.White;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Location = new System.Drawing.Point(30, 520);
            btnLogout.Click += new System.EventHandler(this.btnLogout_Click);


            // CLICK EVENTS
            btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            btnCertificates.Click += new System.EventHandler(this.btnCertificates_Click);
            btnLoans.Click += new System.EventHandler(this.btnLoans_Click);
            btnStatements.Click += new System.EventHandler(this.btnStatements_Click);

            // ADD CONTROLS
            this.Controls.Add(lblWelcome);
            this.Controls.Add(lblBalance);
            this.Controls.Add(lblStatus);

            this.Controls.Add(btnAccount);
            this.Controls.Add(btnTransfer);
            this.Controls.Add(btnCertificates);
            this.Controls.Add(btnLoans);
            this.Controls.Add(btnStatements);

            this.Controls.Add(btnLogout);

            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private System.Windows.Forms.Button MakeButton(string text, int y)
        {
            var btn = new System.Windows.Forms.Button();
            btn.Text = text;
            btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.White;
            btn.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            btn.Size = new System.Drawing.Size(180, 50);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Location = new System.Drawing.Point(30, y);
            return btn;
        }
    }
}
