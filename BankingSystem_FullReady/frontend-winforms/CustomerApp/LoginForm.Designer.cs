namespace CustomerApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label lblAppTitle;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSignIn;
        private System.Windows.Forms.TabPage tabSignUp;

        // SIGN IN CONTROLS
        private System.Windows.Forms.Label lblSignInTitle;
        private System.Windows.Forms.TextBox txtSignInUser;
        private System.Windows.Forms.TextBox txtSignInPass;
        private System.Windows.Forms.Button btnShowSignInPass;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblSignInStatus;

        // SIGN UP CONTROLS
        private System.Windows.Forms.Label lblSignUpTitle;
        private System.Windows.Forms.TextBox txtSignUpName;
        private System.Windows.Forms.TextBox txtSignUpEmail;
        private System.Windows.Forms.TextBox txtSignUpPhone;
        private System.Windows.Forms.TextBox txtSignUpAddress;
        private System.Windows.Forms.TextBox txtSignUpPass;
        private System.Windows.Forms.Button btnShowSignUpPass;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblSignUpStatus;


        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // MAIN FORM
            this.ClientSize = new System.Drawing.Size(820, 520);
            this.Name = "LoginForm";
            this.Text = "BankApp - Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

            // ============================================
            // LEFT BLUE PANEL
            // ============================================
            this.leftPanel = new System.Windows.Forms.Panel();
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Width = 220;
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(30, 90, 200);

            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblAppTitle.Text = "BankApp";
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Location = new System.Drawing.Point(30, 40);

            this.leftPanel.Controls.Add(this.lblAppTitle);

            // ============================================
            // TAB CONTROL
            // ============================================
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;

            this.tabSignIn = new System.Windows.Forms.TabPage();
            this.tabSignIn.Text = "Sign In";
            this.tabSignIn.Padding = new System.Windows.Forms.Padding(20);

            this.tabSignUp = new System.Windows.Forms.TabPage();
            this.tabSignUp.Text = "Sign Up";
            this.tabSignUp.Padding = new System.Windows.Forms.Padding(20);

            this.tabControl1.Controls.Add(this.tabSignIn);
            this.tabControl1.Controls.Add(this.tabSignUp);

            // ============================================
            // SIGN IN TAB ELEMENTS
            // ============================================
            this.lblSignInTitle = new System.Windows.Forms.Label();
            this.lblSignInTitle.Text = "Welcome Back";
            this.lblSignInTitle.AutoSize = true;
            this.lblSignInTitle.Location = new System.Drawing.Point(10, 10);

            this.txtSignInUser = new System.Windows.Forms.TextBox();
            this.txtSignInUser.PlaceholderText = "Email";
            this.txtSignInUser.Location = new System.Drawing.Point(14, 60);
            this.txtSignInUser.Width = 420;
            this.txtSignInUser.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.txtSignInPass = new System.Windows.Forms.TextBox();
            this.txtSignInPass.PlaceholderText = "Password";
            this.txtSignInPass.Location = new System.Drawing.Point(14, 120);
            this.txtSignInPass.Width = 320;
            this.txtSignInPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSignInPass.UseSystemPasswordChar = true;

            this.btnShowSignInPass = new System.Windows.Forms.Button();
            this.btnShowSignInPass.Text = "Show";
            this.btnShowSignInPass.Location = new System.Drawing.Point(344, 120);
            this.btnShowSignInPass.Size = new System.Drawing.Size(90, 30);

            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.Location = new System.Drawing.Point(14, 180);
            this.btnSignIn.Size = new System.Drawing.Size(420, 45);

            this.lblSignInStatus = new System.Windows.Forms.Label();
            this.lblSignInStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSignInStatus.AutoSize = false;
            this.lblSignInStatus.Width = 420;
            this.lblSignInStatus.Height = 30;
            this.lblSignInStatus.Location = new System.Drawing.Point(14, 240);

            this.tabSignIn.Controls.Add(this.lblSignInTitle);
            this.tabSignIn.Controls.Add(this.txtSignInUser);
            this.tabSignIn.Controls.Add(this.txtSignInPass);
            this.tabSignIn.Controls.Add(this.btnShowSignInPass);
            this.tabSignIn.Controls.Add(this.btnSignIn);
            this.tabSignIn.Controls.Add(this.lblSignInStatus);

            // ============================================
            // SIGN UP TAB ELEMENTS
            // ============================================
            this.lblSignUpTitle = new System.Windows.Forms.Label();
            this.lblSignUpTitle.Text = "Create Account";
            this.lblSignUpTitle.AutoSize = true;
            this.lblSignUpTitle.Location = new System.Drawing.Point(10, 10);

            this.txtSignUpName = new System.Windows.Forms.TextBox();
            this.txtSignUpName.PlaceholderText = "Full Name";
            this.txtSignUpName.Location = new System.Drawing.Point(14, 60);
            this.txtSignUpName.Width = 420;
            this.txtSignUpName.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.txtSignUpEmail = new System.Windows.Forms.TextBox();
            this.txtSignUpEmail.PlaceholderText = "Email";
            this.txtSignUpEmail.Location = new System.Drawing.Point(14, 110);
            this.txtSignUpEmail.Width = 420;
            this.txtSignUpEmail.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.txtSignUpPhone = new System.Windows.Forms.TextBox();
            this.txtSignUpPhone.PlaceholderText = "Phone";
            this.txtSignUpPhone.Location = new System.Drawing.Point(14, 160);
            this.txtSignUpPhone.Width = 420;
            this.txtSignUpPhone.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.txtSignUpAddress = new System.Windows.Forms.TextBox();
            this.txtSignUpAddress.PlaceholderText = "Address";
            this.txtSignUpAddress.Location = new System.Drawing.Point(14, 210);
            this.txtSignUpAddress.Width = 420;
            this.txtSignUpAddress.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.txtSignUpPass = new System.Windows.Forms.TextBox();
            this.txtSignUpPass.PlaceholderText = "Password";
            this.txtSignUpPass.Location = new System.Drawing.Point(14, 260);
            this.txtSignUpPass.Width = 320;
            this.txtSignUpPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSignUpPass.UseSystemPasswordChar = true;

            this.btnShowSignUpPass = new System.Windows.Forms.Button();
            this.btnShowSignUpPass.Text = "Show";
            this.btnShowSignUpPass.Location = new System.Drawing.Point(344, 260);
            this.btnShowSignUpPass.Size = new System.Drawing.Size(90, 30);

            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSignUp.Text = "Create Account";
            this.btnSignUp.Location = new System.Drawing.Point(14, 320);
            this.btnSignUp.Size = new System.Drawing.Size(420, 45);

            this.lblSignUpStatus = new System.Windows.Forms.Label();
            this.lblSignUpStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSignUpStatus.AutoSize = false;
            this.lblSignUpStatus.Width = 420;
            this.lblSignUpStatus.Height = 30;
            this.lblSignUpStatus.Location = new System.Drawing.Point(14, 380);

            this.tabSignUp.Controls.Add(this.lblSignUpTitle);
            this.tabSignUp.Controls.Add(this.txtSignUpName);
            this.tabSignUp.Controls.Add(this.txtSignUpEmail);
            this.tabSignUp.Controls.Add(this.txtSignUpPhone);
            this.tabSignUp.Controls.Add(this.txtSignUpAddress);
            this.tabSignUp.Controls.Add(this.txtSignUpPass);
            this.tabSignUp.Controls.Add(this.btnShowSignUpPass);
            this.tabSignUp.Controls.Add(this.btnSignUp);
            this.tabSignUp.Controls.Add(this.lblSignUpStatus);

            // ============================================
            // ADD CONTROLS TO FORM
            // ============================================
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.leftPanel);

            this.ResumeLayout(false);
        }
    }
}
