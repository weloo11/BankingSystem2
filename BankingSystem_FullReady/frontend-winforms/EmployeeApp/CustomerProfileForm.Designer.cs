namespace EmployeeApp
{
    partial class CustomerProfileForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblCustomerIDTitle = new System.Windows.Forms.Label();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.lblEmailTitle = new System.Windows.Forms.Label();
            this.lblPhoneTitle = new System.Windows.Forms.Label();

            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();

            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.btnFreeze = new System.Windows.Forms.Button();
            this.btnUnfreeze = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();

            // titles
            this.lblCustomerIDTitle.Text = "Customer ID:";
            this.lblCustomerIDTitle.Location = new System.Drawing.Point(20, 20);
            this.lblCustomerIDTitle.AutoSize = true;

            this.lblNameTitle.Text = "Name:";
            this.lblNameTitle.Location = new System.Drawing.Point(20, 45);
            this.lblNameTitle.AutoSize = true;

            this.lblEmailTitle.Text = "Email:";
            this.lblEmailTitle.Location = new System.Drawing.Point(20, 70);
            this.lblEmailTitle.AutoSize = true;

            this.lblPhoneTitle.Text = "Phone:";
            this.lblPhoneTitle.Location = new System.Drawing.Point(20, 95);
            this.lblPhoneTitle.AutoSize = true;

            // values
            this.lblCustomerID.Location = new System.Drawing.Point(120, 20);
            this.lblCustomerID.AutoSize = true;

            this.lblName.Location = new System.Drawing.Point(120, 45);
            this.lblName.AutoSize = true;

            this.lblEmail.Location = new System.Drawing.Point(120, 70);
            this.lblEmail.AutoSize = true;

            this.lblPhone.Location = new System.Drawing.Point(120, 95);
            this.lblPhone.AutoSize = true;

            // dgvAccounts
            this.dgvAccounts.Location = new System.Drawing.Point(20, 130);
            this.dgvAccounts.Size = new System.Drawing.Size(600, 250);
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // btnFreeze
            this.btnFreeze.Text = "Freeze Account";
            this.btnFreeze.Location = new System.Drawing.Point(20, 390);
            this.btnFreeze.Size = new System.Drawing.Size(150, 35);
            this.btnFreeze.Click += new System.EventHandler(this.btnFreeze_Click);

            // btnUnfreeze
            this.btnUnfreeze.Text = "Unfreeze Account";
            this.btnUnfreeze.Location = new System.Drawing.Point(180, 390);
            this.btnUnfreeze.Size = new System.Drawing.Size(150, 35);
            this.btnUnfreeze.Click += new System.EventHandler(this.btnUnfreeze_Click);

            // form
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.lblCustomerIDTitle);
            this.Controls.Add(this.lblNameTitle);
            this.Controls.Add(this.lblEmailTitle);
            this.Controls.Add(this.lblPhoneTitle);

            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);

            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.btnFreeze);
            this.Controls.Add(this.btnUnfreeze);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Profile";
            this.Load += new System.EventHandler(this.CustomerProfileForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCustomerIDTitle;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblEmailTitle;
        private System.Windows.Forms.Label lblPhoneTitle;

        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;

        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.Button btnFreeze;
        private System.Windows.Forms.Button btnUnfreeze;
    }
}