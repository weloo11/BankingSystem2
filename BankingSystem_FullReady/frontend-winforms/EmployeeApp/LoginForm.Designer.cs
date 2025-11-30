namespace EmployeeApp
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(85, 20);
            this.lblTitle.Text = "Employee Login";

            // txtEmployeeID
            this.txtEmployeeID.Location = new System.Drawing.Point(50, 80);
            this.txtEmployeeID.Size = new System.Drawing.Size(200, 27);
            this.txtEmployeeID.PlaceholderText = "Employee ID";

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(50, 130);
            this.txtPassword.Size = new System.Drawing.Size(200, 27);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.PlaceholderText = "Password";

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(90, 180);
            this.btnLogin.Size = new System.Drawing.Size(120, 35);
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // LoginForm
            this.ClientSize = new System.Drawing.Size(300, 260);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.TextBox txtEmployeeID;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}