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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(40, 60, 90);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 90;
            this.panelHeader.Controls.Add(this.lblTitle);

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Bank Employee Login";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 25);
            this.lblTitle.AutoSize = true;

            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Size = new System.Drawing.Size(400, 320);
            this.panelLogin.Controls.Add(this.txtEmployeeID);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.lblWelcome);

            // 
            // lblWelcome
            // 
            this.lblWelcome.Text = "Welcome Back";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(40, 60, 90);
            this.lblWelcome.Location = new System.Drawing.Point(110, 30);
            this.lblWelcome.AutoSize = true;

            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmployeeID.Location = new System.Drawing.Point(60, 110);
            this.txtEmployeeID.PlaceholderText = "Employee ID";
            this.txtEmployeeID.Size = new System.Drawing.Size(280, 34);
            this.txtEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(60, 170);
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(280, 34);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(60, 120, 200);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Location = new System.Drawing.Point(60, 230);
            this.btnLogin.Size = new System.Drawing.Size(280, 40);
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // 
            // LoginForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(230, 235, 245);
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLogin;
        public System.Windows.Forms.TextBox txtEmployeeID;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblWelcome;
    }
}