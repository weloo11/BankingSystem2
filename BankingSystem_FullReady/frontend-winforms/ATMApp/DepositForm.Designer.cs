namespace ATMApp
{
    partial class DepositForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnDeposit;

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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtAmount
            this.txtAmount.Location = new System.Drawing.Point(40, 40);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PlaceholderText = "Enter Amount";
            this.txtAmount.Size = new System.Drawing.Size(200, 27);

            // btnDeposit
            this.btnDeposit.Location = new System.Drawing.Point(40, 90);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(120, 30);
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnDeposit);
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
