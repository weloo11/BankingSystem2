namespace ATMApp
{
    partial class ATMWindow
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtATMID;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnEnterATM;
        private System.Windows.Forms.Button btnVerifyAccount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;

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
            this.txtATMID = new System.Windows.Forms.TextBox();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnEnterATM = new System.Windows.Forms.Button();
            this.btnVerifyAccount = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtATMID
            this.txtATMID.Location = new System.Drawing.Point(40, 40);
            this.txtATMID.Name = "txtATMID";
            this.txtATMID.PlaceholderText = "Enter ATM ID";
            this.txtATMID.Size = new System.Drawing.Size(200, 27);

            // btnEnterATM
            this.btnEnterATM.Location = new System.Drawing.Point(270, 40);
            this.btnEnterATM.Name = "btnEnterATM";
            this.btnEnterATM.Size = new System.Drawing.Size(120, 27);
            this.btnEnterATM.Text = "Verify ATM";
            this.btnEnterATM.Click += new System.EventHandler(this.btnEnterATM_Click);

            // txtAccountID
            this.txtAccountID.Location = new System.Drawing.Point(40, 90);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.PlaceholderText = "Enter Account ID";
            this.txtAccountID.Size = new System.Drawing.Size(200, 27);

            // txtCardNo
            this.txtCardNo.Location = new System.Drawing.Point(40, 130);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.PlaceholderText = "Enter Card Number";
            this.txtCardNo.Size = new System.Drawing.Size(200, 27);

            // btnVerifyAccount
            this.btnVerifyAccount.Location = new System.Drawing.Point(270, 130);
            this.btnVerifyAccount.Name = "btnVerifyAccount";
            this.btnVerifyAccount.Size = new System.Drawing.Size(120, 27);
            this.btnVerifyAccount.Text = "Verify Account";
            this.btnVerifyAccount.Click += new System.EventHandler(this.btnVerifyAccount_Click);

            // lblBalance
            this.lblBalance.Location = new System.Drawing.Point(40, 180);
            this.lblBalance.Size = new System.Drawing.Size(300, 27);
            this.lblBalance.Text = "Balance: ---";

            // btnDeposit
            this.btnDeposit.Location = new System.Drawing.Point(40, 230);
            this.btnDeposit.Size = new System.Drawing.Size(120, 30);
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);

            // btnWithdraw
            this.btnWithdraw.Location = new System.Drawing.Point(180, 230);
            this.btnWithdraw.Size = new System.Drawing.Size(120, 30);
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(420, 300);
            this.Controls.Add(this.txtATMID);
            this.Controls.Add(this.btnEnterATM);
            this.Controls.Add(this.txtAccountID);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.btnVerifyAccount);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Text = "ATM System";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
