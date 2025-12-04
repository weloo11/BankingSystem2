using System.Windows.Forms;

namespace CustomerApp
{
    partial class AccountForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel leftPanel;
        private Panel rightPanel;

        // Left labels
        private Label lblTitle;
        private Label lblNameTitle, lblEmailTitle, lblPhoneTitle, lblAddressTitle;
        private Label lblBalanceTitle, lblCurrencyTitle, lblTypeTitle, lblStatusTitle, lblOpenDateTitle;
        private Label lblCardNoTitle, lblCVVTitle, lblExpiryTitle;

        private Label lblName, lblEmail, lblPhone, lblAddress;
        private Label lblBalance, lblCurrency, lblType, lblStatus, lblOpenDate;
        private Label lblCardNo, lblCVV, lblExpiry;

        // Password controls
        private Label lblPassTitle;
        private Label lblOldPass, lblNewPass, lblConfirmPass;
        private TextBox txtOldPass, txtNewPass, txtConfirmPass;
        private Button btnChangePass;


        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.SuspendLayout();

            // FORM BASE
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "AccountForm";
            this.Text = "Account Details";

            // LEFT PANEL
            leftPanel = new Panel();
            leftPanel.BackColor = System.Drawing.Color.FromArgb(33, 90, 150);
            leftPanel.Size = new System.Drawing.Size(500, 650);
            leftPanel.Dock = DockStyle.Left;
            this.Controls.Add(leftPanel);

            // RIGHT PANEL (Password card)
            rightPanel = new Panel();
            rightPanel.BackColor = System.Drawing.Color.White;
            rightPanel.Size = new System.Drawing.Size(460, 500);
            rightPanel.Location = new System.Drawing.Point(520, 70);
            rightPanel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(rightPanel);

            // ===============================
            // LEFT PANEL CONTENT
            // ===============================

            lblTitle = MakeBigLabel("Account Details", 25, 20);
            leftPanel.Controls.Add(lblTitle);

            int y = 90;

            AddInfo("Name:", out lblNameTitle, out lblName, ref y);
            AddInfo("Email:", out lblEmailTitle, out lblEmail, ref y);
            AddInfo("Phone:", out lblPhoneTitle, out lblPhone, ref y);
            AddInfo("Address:", out lblAddressTitle, out lblAddress, ref y);

            y += 20;
            AddInfo("Balance:", out lblBalanceTitle, out lblBalance, ref y);
            AddInfo("Currency:", out lblCurrencyTitle, out lblCurrency, ref y);
            AddInfo("Type:", out lblTypeTitle, out lblType, ref y);
            AddInfo("Status:", out lblStatusTitle, out lblStatus, ref y);
            AddInfo("Open Date:", out lblOpenDateTitle, out lblOpenDate, ref y);

            y += 20;
            AddInfo("Card Number:", out lblCardNoTitle, out lblCardNo, ref y);
            AddInfo("CVV:", out lblCVVTitle, out lblCVV, ref y);
            AddInfo("Expiry:", out lblExpiryTitle, out lblExpiry, ref y);


            // ===============================
            // RIGHT PANEL — Password Box
            // ===============================

            lblPassTitle = new Label();
            lblPassTitle.Text = "Change Password";
            lblPassTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblPassTitle.Location = new System.Drawing.Point(20, 20);
            lblPassTitle.AutoSize = true;
            rightPanel.Controls.Add(lblPassTitle);

            lblOldPass = PasswordLabel("Old Password:", 80);
            txtOldPass = PasswordBox(110);

            lblNewPass = PasswordLabel("New Password:", 160);
            txtNewPass = PasswordBox(190);

            lblConfirmPass = PasswordLabel("Confirm Password:", 240);
            txtConfirmPass = PasswordBox(270);

            btnChangePass = new Button();
            btnChangePass.Text = "Change Password";
            btnChangePass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnChangePass.BackColor = System.Drawing.Color.FromArgb(33, 90, 150);
            btnChangePass.ForeColor = System.Drawing.Color.White;
            btnChangePass.FlatStyle = FlatStyle.Flat;
            btnChangePass.Location = new System.Drawing.Point(20, 330);
            btnChangePass.Size = new System.Drawing.Size(400, 45);
            btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            rightPanel.Controls.Add(btnChangePass);

            this.ResumeLayout(false);
            this.PerformLayout();
        }


        // ===============================
        // HELPER METHODS
        // ===============================

        private Label MakeBigLabel(string text, int y, int x)
        {
            var lbl = new Label();
            lbl.Text = text;
            lbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.White;
            lbl.AutoSize = true;
            lbl.Location = new System.Drawing.Point(x, y);
            return lbl;
        }

        private void AddInfo(string title, out Label lblT, out Label lblV, ref int y)
        {
            lblT = new Label();
            lblT.Text = title;
            lblT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblT.ForeColor = System.Drawing.Color.White;
            lblT.AutoSize = true;
            lblT.Location = new System.Drawing.Point(20, y);
            leftPanel.Controls.Add(lblT);

            lblV = new Label();
            lblV.Text = "-";
            lblV.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblV.ForeColor = System.Drawing.Color.White;
            lblV.AutoSize = true;
            lblV.Location = new System.Drawing.Point(200, y);
            leftPanel.Controls.Add(lblV);

            y += 35;
        }

        private Label PasswordLabel(string text, int y)
        {
            var lbl = new Label();
            lbl.Text = text;
            lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lbl.Location = new System.Drawing.Point(20, y);
            lbl.AutoSize = true;
            rightPanel.Controls.Add(lbl);
            return lbl;
        }

        private TextBox PasswordBox(int y)
        {
            var t = new TextBox();
            t.Size = new System.Drawing.Size(400, 30);
            t.Location = new System.Drawing.Point(20, y);
            t.UseSystemPasswordChar = true;
            rightPanel.Controls.Add(t);
            return t;
        }
    }
}
