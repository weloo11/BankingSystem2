namespace ATMApp
{
    partial class WithdrawForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAmount;
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtAmount
            this.txtAmount.Location = new System.Drawing.Point(40, 40);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PlaceholderText = "Enter Amount";
            this.txtAmount.Size = new System.Drawing.Size(200, 27);

            // btnWithdraw
            this.btnWithdraw.Location = new System.Drawing.Point(40, 90);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(120, 30);
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnWithdraw);
            this.Text = "Withdraw";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
