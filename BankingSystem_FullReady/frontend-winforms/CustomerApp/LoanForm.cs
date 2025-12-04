using CustomerApp.Models;
using CustomerApp.Services;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CustomerApp
{
    public partial class LoanForm : Form
    {
        private readonly Account _account;
        private readonly IMongoCollection<Loan> _loans;
        private readonly IMongoCollection<Account> _accounts;

        public LoanForm(Account account)
        {
            _account = account;

            var db = MongoConnection.GetDatabase();
            _loans = db.GetCollection<Loan>("Loans");
            _accounts = db.GetCollection<Account>("Account");

            InitializeComponent();
            LoadLoans();
            StyleForm();
        }

        // ================================================================
        //  UI STYLING (Blue theme)
        // ================================================================
        private void StyleForm()
        {
            BackColor = System.Drawing.Color.FromArgb(235, 242, 255);

            dgvLoans.BackgroundColor = System.Drawing.Color.White;
            dgvLoans.EnableHeadersVisualStyles = false;
            dgvLoans.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 90, 180);
            dgvLoans.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvLoans.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);

            dgvLoans.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);

            btnRequestLoan.BackColor = System.Drawing.Color.FromArgb(30, 90, 180);
            btnRequestLoan.ForeColor = System.Drawing.Color.White;

            btnPayLoan.BackColor = System.Drawing.Color.FromArgb(0, 130, 90);
            btnPayLoan.ForeColor = System.Drawing.Color.White;

            btnRefresh.BackColor = System.Drawing.Color.FromArgb(30, 90, 180);
            btnRefresh.ForeColor = System.Drawing.Color.White;
        }

        // ================================================================
        //  LOAD LOANS FOR THIS ACCOUNT
        // ================================================================
        private void LoadLoans()
        {
            var list = _loans.Find(l => l.accountID == _account.accountID).ToList();

            var display = list.Select(l => new LoanDisplay
            {
                LoanID = l.loanID,
                Amount = l.amount.ToString("0.00"),
                Interest = l.interestRate + " %",
                TotalDue = CalculateTotalDue(l).ToString("0.00"),
                Issue = l.issueDate.ToString("yyyy-MM-dd"),
                Due = l.dueDate.ToString("yyyy-MM-dd"),
                Status = l.status
            }).ToList();

            dgvLoans.AutoGenerateColumns = false;
            dgvLoans.DataSource = display;

            dgvLoans.Columns["LoanID"].DataPropertyName = "LoanID";
            dgvLoans.Columns["Amount"].DataPropertyName = "Amount";
            dgvLoans.Columns["Interest"].DataPropertyName = "Interest";
            dgvLoans.Columns["TotalDue"].DataPropertyName = "TotalDue";
            dgvLoans.Columns["Issue"].DataPropertyName = "Issue";
            dgvLoans.Columns["Due"].DataPropertyName = "Due";
            dgvLoans.Columns["Status"].DataPropertyName = "Status";

            dgvLoans.ClearSelection();
            txtPayLoanID.Clear();
            txtPayAmount.Clear();
        }

        public class LoanDisplay
        {
            public string LoanID { get; set; }
            public string Amount { get; set; }
            public string Interest { get; set; }
            public string TotalDue { get; set; }
            public string Issue { get; set; }
            public string Due { get; set; }
            public string Status { get; set; }
        }

        // ================================================================
        //  CALCULATE TOTAL DUE (Principal + interest)
        // ================================================================
        private double CalculateTotalDue(Loan loan)
        {
            return loan.amount + (loan.amount * (loan.interestRate / 100.0));
        }

        // ================================================================
        //  SELECT LOAN FROM TABLE
        // ================================================================
        private void dgvLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtPayLoanID.Text =
                dgvLoans.Rows[e.RowIndex].Cells["LoanID"].Value?.ToString();
        }

        // ================================================================
        //  REQUEST NEW LOAN
        // ================================================================
        private void btnRequestLoan_Click(object sender, EventArgs e)
        {
            double amt;
            if (!double.TryParse(txtRequestAmount.Text, out amt) || amt <= 0)
            {
                MessageBox.Show("Enter a valid loan amount.");
                return;
            }

            string newLoanID = GenerateNextLoanID();

            Loan loan = new Loan
            {
                loanID = newLoanID,
                accountID = _account.accountID,
                amount = amt,
                interestRate = 7.5,
                issueDate = DateTime.Now,
                dueDate = DateTime.Now.AddYears(1),
                status = "Pending"
            };

            _loans.InsertOne(loan);

            MessageBox.Show($"Loan {newLoanID} submitted and pending approval.");
            LoadLoans();
        }

        private string GenerateNextLoanID()
        {
            var all = _loans.Find(_ => true).ToList();

            if (all.Count == 0) return "L001";

            int max = 0;
            foreach (var l in all)
            {
                if (l.loanID.StartsWith("L") &&
                    int.TryParse(l.loanID.Substring(1), out int n))
                {
                    if (n > max) max = n;
                }
            }
            return $"L{(max + 1):000}";
        }

        // ================================================================
        //  PAY LOAN
        // ================================================================
        private void btnPayLoan_Click(object sender, EventArgs e)
        {
            string loanID = txtPayLoanID.Text.Trim();

            if (loanID == "")
            {
                MessageBox.Show("Select a loan first.");
                return;
            }

            double payAmount;
            if (!double.TryParse(txtPayAmount.Text, out payAmount) || payAmount <= 0)
            {
                MessageBox.Show("Enter a valid payment amount.");
                return;
            }

            var loan = _loans.Find(l => l.loanID == loanID).FirstOrDefault();
            if (loan == null)
            {
                MessageBox.Show("Loan not found.");
                return;
            }

            if (loan.status == "Pending")
            {
                MessageBox.Show("This loan is still pending approval.");
                return;
            }

            if (loan.status == "Paid")
            {
                MessageBox.Show("This loan is already paid.");
                return;
            }

            double totalDue = CalculateTotalDue(loan);

            if (payAmount > _account.balance)
            {
                MessageBox.Show("Insufficient account balance.");
                return;
            }

            // FULL PAYMENT
            if (payAmount >= totalDue)
            {
                loan.amount = 0;
                loan.status = "Paid";

                _loans.ReplaceOne(l => l.loanID == loanID, loan);

                _accounts.UpdateOne(
                    a => a.accountID == _account.accountID,
                    Builders<Account>.Update.Inc(a => a.balance, -totalDue)
                );

                _account.balance -= totalDue;

                MessageBox.Show("Loan fully paid.");
            }
            else
            {
                // PARTIAL PAYMENT
                double remaining = totalDue - payAmount;

                loan.amount = remaining / (1 + (loan.interestRate / 100.0));
                loan.status = "Approved";

                _loans.ReplaceOne(l => l.loanID == loanID, loan);

                _accounts.UpdateOne(
                    a => a.accountID == _account.accountID,
                    Builders<Account>.Update.Inc(a => a.balance, -payAmount)
                );

                _account.balance -= payAmount;

                MessageBox.Show("Partial payment applied.");
            }

            LoadLoans();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLoans();
        }
    }
}
