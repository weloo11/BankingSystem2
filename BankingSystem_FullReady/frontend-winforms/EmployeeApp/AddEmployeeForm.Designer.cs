namespace EmployeeApp
{
    partial class EmployeeHomeForm
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
            this.components = new System.ComponentModel.Container();

            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnProfileMenu = new System.Windows.Forms.Button();

            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnApproveAccounts = new System.Windows.Forms.Button();
            this.btnApproveLoans = new System.Windows.Forms.Button();
            this.btnApproveCertificates = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();

            this.contextProfile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.SuspendLayout();

            // ===========================
            // HEADER PANEL
            // ===========================
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(40, 60, 90);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 80;

            // Title label
            this.lblTitle.Text = "Employee Dashboard";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.AutoSize = true;

            // Profile menu button
            this.btnProfileMenu.Text = "Profile ▼";
            this.btnProfileMenu.BackColor = System.Drawing.Color.FromArgb(60, 120, 200);
            this.btnProfileMenu.ForeColor = System.Drawing.Color.White;
            this.btnProfileMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnProfileMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileMenu.FlatAppearance.BorderSize = 0;
            this.btnProfileMenu.Size = new System.Drawing.Size(180, 35);
            this.btnProfileMenu.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.btnProfileMenu.Location = new System.Drawing.Point(700, 20); // initial, moved at runtime
            this.btnProfileMenu.Click += new System.EventHandler(this.btnProfileMenu_Click);

            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnProfileMenu);

            // ===========================
            // PROFILE CONTEXT MENU
            // ===========================
            this.contextProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.viewProfileToolStripMenuItem,
                this.logoutToolStripMenuItem
            });

            this.viewProfileToolStripMenuItem.Text = "View Profile";
            this.viewProfileToolStripMenuItem.Click += new System.EventHandler(this.viewProfileToolStripMenuItem_Click);

            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);

            // ===========================
            // WELCOME LABEL
            // ===========================
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblWelcome.Location = new System.Drawing.Point(40, 110);
            this.lblWelcome.AutoSize = true;

            // ===========================
            // MAIN BUTTONS (STYLE + POSITION)
            // ===========================
            SetupButton(this.btnApproveAccounts, "Approve Customer Accounts", 160);
            this.btnApproveAccounts.Click += new System.EventHandler(this.btnApproveAccounts_Click);

            SetupButton(this.btnApproveLoans, "Approve Loans", 230);
            this.btnApproveLoans.Click += new System.EventHandler(this.btnApproveLoans_Click);

            SetupButton(this.btnApproveCertificates, "Approve Certificates", 300);
            this.btnApproveCertificates.Click += new System.EventHandler(this.btnApproveCertificates_Click);

            SetupButton(this.btnAddEmployee, "Add New Employee", 370);
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);

            // ===========================
            // FORM PROPERTIES
            // ===========================
            this.BackColor = System.Drawing.Color.FromArgb(230, 235, 245);
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnApproveAccounts);
            this.Controls.Add(this.btnApproveLoans);
            this.Controls.Add(this.btnApproveCertificates);
            this.Controls.Add(this.btnAddEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmployeeHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Dashboard";
            this.Load += new System.EventHandler(this.EmployeeHomeForm_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Helper to style buttons consistently
        private void SetupButton(System.Windows.Forms.Button button, string text, int top)
        {
            button.Text = text;
            button.BackColor = System.Drawing.Color.FromArgb(60, 120, 200);
            button.ForeColor = System.Drawing.Color.White;
            button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Size = new System.Drawing.Size(280, 50);
            button.Location = new System.Drawing.Point(20, top);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnProfileMenu;

        public System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnApproveAccounts;
        private System.Windows.Forms.Button btnApproveLoans;
        private System.Windows.Forms.Button btnApproveCertificates;
        private System.Windows.Forms.Button btnAddEmployee;

        private System.Windows.Forms.ContextMenuStrip contextProfile;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}