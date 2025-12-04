using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using CustomerApp.Models;
using CustomerApp.Services;

namespace CustomerApp
{
    public partial class LoginForm : Form
    {
        // ---------- PREMIUM BLUE THEME COLORS ----------
        private Color PrimaryBlue = Color.FromArgb(30, 90, 200);
        private Color DarkBlue = Color.FromArgb(20, 60, 150);
        private Color LightBlue = Color.FromArgb(80, 140, 240);

        public LoginForm()
        {
            InitializeComponent();
            WireRuntimeEvents();
            ApplyStyling();
        }

        // ---------- GRADIENT BACKGROUND ----------
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(220, 235, 255),
                Color.FromArgb(180, 200, 240),
                90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        // ---------- SHARED UI STYLE METHODS ----------
        private void StyleTextbox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.None;
            txt.BackColor = Color.White;
            txt.ForeColor = Color.Black;
            txt.Font = new Font("Segoe UI", 12);

            Panel underline = new Panel();
            underline.Height = 2;
            underline.Dock = DockStyle.Bottom;
            underline.BackColor = PrimaryBlue;

            txt.Controls.Add(underline);
            underline.BringToFront();
        }

        private void StyleButton(Button btn)
        {
            btn.BackColor = PrimaryBlue;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            btn.MouseEnter += (s, e) => btn.BackColor = DarkBlue;
            btn.MouseLeave += (s, e) => btn.BackColor = PrimaryBlue;
        }

        private void ApplyStyling()
        {
            // STYLE TEXTBOXES
            StyleTextbox(txtSignInUser);
            StyleTextbox(txtSignInPass);

            StyleTextbox(txtSignUpName);
            StyleTextbox(txtSignUpEmail);
            StyleTextbox(txtSignUpPhone);
            StyleTextbox(txtSignUpAddress);
            StyleTextbox(txtSignUpPass);

            // STYLE BUTTONS
            StyleButton(btnSignIn);
            StyleButton(btnSignUp);

            // TITLES
            lblSignInTitle.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblSignInTitle.ForeColor = DarkBlue;

            lblSignUpTitle.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblSignUpTitle.ForeColor = DarkBlue;

            // SHOW PASSWORD BUTTONS
            btnShowSignInPass.BackColor = LightBlue;
            btnShowSignInPass.FlatStyle = FlatStyle.Flat;
            btnShowSignInPass.FlatAppearance.BorderSize = 0;

            btnShowSignUpPass.BackColor = LightBlue;
            btnShowSignUpPass.FlatStyle = FlatStyle.Flat;
            btnShowSignUpPass.FlatAppearance.BorderSize = 0;
        }

        // ===============================================================
        // ALL YOUR EXISTING WORKING LOGIC BELOW — UNTOUCHED
        // ===============================================================

        private void WireRuntimeEvents()
        {
            btnShowSignInPass.Click -= BtnShowSignInPass_Click;
            btnShowSignInPass.Click += BtnShowSignInPass_Click;

            btnSignIn.Click -= BtnSignIn_Click;
            btnSignIn.Click += BtnSignIn_Click;

            btnShowSignUpPass.Click -= BtnShowSignUpPass_Click;
            btnShowSignUpPass.Click += BtnShowSignUpPass_Click;

            btnSignUp.Click -= BtnSignUp_Click;
            btnSignUp.Click += BtnSignUp_Click;
        }

        // ===============================================================
        // ID GENERATION
        // ===============================================================
        private async Task<string> GenerateNextCustomerID(IMongoDatabase db)
        {
            var customers = db.GetCollection<Customer>("Customer");
            var all = await customers.Find(_ => true).ToListAsync();

            if (!all.Any())
                return "C001";

            int max = 0;
            foreach (var c in all)
            {
                if (c.customerID != null &&
                    c.customerID.StartsWith("C") &&
                    int.TryParse(c.customerID.Substring(1), out int num))
                {
                    if (num > max) max = num;
                }
            }

            return $"C{(max + 1):000}";
        }

        private async Task<string> GenerateNextAccountID(IMongoDatabase db)
        {
            var accounts = db.GetCollection<Account>("Account");
            var all = await accounts.Find(_ => true).ToListAsync();

            if (!all.Any())
                return "A001";

            int max = 0;
            foreach (var a in all)
            {
                if (a.accountID != null &&
                    a.accountID.StartsWith("A") &&
                    int.TryParse(a.accountID.Substring(1), out int num))
                {
                    if (num > max) max = num;
                }
            }

            return $"A{(max + 1):000}";
        }

        // ===============================================================
        // CARD GENERATION
        // ===============================================================
        private string GenerateCardNumber()
        {
            Random r = new Random();
            return $"{r.Next(1000, 9999)}{r.Next(1000, 9999)}{r.Next(1000, 9999)}{r.Next(1000, 9999)}";
        }

        private string GeneratePin() => new Random().Next(1000, 9999).ToString();
        private string GenerateCVV() => new Random().Next(100, 999).ToString();

        // ===============================================================
        // GET RANDOM EMPLOYEE
        // ===============================================================
        private async Task<string> GetRandomEmployeeID(IMongoDatabase db)
        {
            var employees = db.GetCollection<Employee>("Employee");
            var list = await employees.Find(_ => true).ToListAsync();

            if (list.Count == 0)
                return "";

            Random rnd = new Random();
            return list[rnd.Next(list.Count)].employeeID;
        }

        // ===============================================================
        // SIGN-IN
        // ===============================================================
        private void BtnShowSignInPass_Click(object sender, EventArgs e)
        {
            txtSignInPass.UseSystemPasswordChar = !txtSignInPass.UseSystemPasswordChar;
            btnShowSignInPass.Text = txtSignInPass.UseSystemPasswordChar ? "Show" : "Hide";
        }

        private async void BtnSignIn_Click(object sender, EventArgs e)
        {
            lblSignInStatus.Text = "";
            string id = txtSignInUser.Text.Trim();
            string pass = txtSignInPass.Text.Trim();

            if (id == "" || pass == "")
            {
                lblSignInStatus.Text = "Enter email/phone and password.";
                return;
            }

            IMongoDatabase db;
            try { db = MongoConnection.GetDatabase(); }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to database: " + ex.Message);
                return;
            }

            try
            {
                var customers = db.GetCollection<Customer>("Customer");

                var filter = Builders<Customer>.Filter.Or(
                    Builders<Customer>.Filter.Eq(c => c.email, id),
                    Builders<Customer>.Filter.Eq(c => c.phone, id),
                    Builders<Customer>.Filter.Eq(c => c.customerID, id)
                );

                var customer = await customers.Find(filter).FirstOrDefaultAsync();
                if (customer == null)
                {
                    lblSignInStatus.Text = "User not found.";
                    return;
                }

                if (customer.password != pass)
                {
                    lblSignInStatus.Text = "Invalid password.";
                    return;
                }

                var accounts = db.GetCollection<Account>("Account");
                var account = await accounts.Find(a => a.customerID == customer.customerID).FirstOrDefaultAsync();

                if (account == null)
                {
                    lblSignInStatus.Text = "No account found.";
                    return;
                }

                if (account.status == "Pending")
                {
                    MessageBox.Show("Your account is pending approval.", "Account Pending", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (account.status != "Active")
                {
                    MessageBox.Show($"Account status '{account.status}' does not allow login.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var home = new CustomerHomeForm(customer, account);
                home.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sign-in failed: " + ex.Message);
            }
        }

        // ===============================================================
        // SIGN-UP
        // ===============================================================
        private void BtnShowSignUpPass_Click(object sender, EventArgs e)
        {
            txtSignUpPass.UseSystemPasswordChar = !txtSignUpPass.UseSystemPasswordChar;
            btnShowSignUpPass.Text = txtSignUpPass.UseSystemPasswordChar ? "Show" : "Hide";
        }

        private async void BtnSignUp_Click(object sender, EventArgs e)
        {
            lblSignUpStatus.Text = "";

            string name = txtSignUpName.Text.Trim();
            string email = txtSignUpEmail.Text.Trim();
            string phone = txtSignUpPhone.Text.Trim();
            string address = txtSignUpAddress.Text.Trim();
            string pass = txtSignUpPass.Text.Trim();

            if (name == "" || email == "" || phone == "" || address == "" || pass == "")
            {
                lblSignUpStatus.Text = "All fields are required.";
                return;
            }

            IMongoDatabase db;
            try { db = MongoConnection.GetDatabase(); }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to database: " + ex.Message);
                return;
            }

            try
            {
                var customers = db.GetCollection<Customer>("Customer");

                var existing = await customers.Find(c => c.email == email || c.phone == phone).FirstOrDefaultAsync();
                if (existing != null)
                {
                    lblSignUpStatus.Text = "Email or phone already exists.";
                    return;
                }

                string newCustomerID = await GenerateNextCustomerID(db);

                var newCustomer = new Customer
                {
                    customerID = newCustomerID,
                    name = name,
                    address = address,
                    phone = phone,
                    email = email,
                    password = pass
                };

                await customers.InsertOneAsync(newCustomer);

                string assignedEmployeeID = await GetRandomEmployeeID(db);

                var accounts = db.GetCollection<Account>("Account");
                string newAccountID = await GenerateNextAccountID(db);

                var newAccount = new Account
                {
                    accountID = newAccountID,
                    customerID = newCustomerID,
                    employeeID = assignedEmployeeID,
                    balance = 0,
                    currency = "EGP",
                    openDate = DateTime.Now,
                    accountType = "Saving",
                    status = "Pending",
                    card = new Card
                    {
                        cardNo = GenerateCardNumber(),
                        pin = GeneratePin(),
                        expiryDate = DateTime.Now.AddYears(3),
                        cvv = GenerateCVV()
                    }
                };

                await accounts.InsertOneAsync(newAccount);

                lblSignUpStatus.ForeColor = Color.Green;
                lblSignUpStatus.Text = $"Account created! ID = {newCustomerID}. Pending approval.";
                tabControl1.SelectedTab = tabSignIn;

                txtSignUpName.Text =
                txtSignUpEmail.Text =
                txtSignUpPhone.Text =
                txtSignUpAddress.Text =
                txtSignUpPass.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sign-up failed: " + ex.Message);
            }
        }
    }
}
