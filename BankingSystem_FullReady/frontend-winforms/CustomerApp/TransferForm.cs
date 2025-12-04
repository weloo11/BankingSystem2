using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using CustomerApp.Models;
using CustomerApp.Services;

namespace CustomerApp
{
    public partial class TransferForm : Form
    {
        private readonly Customer _customer;
        private readonly Account _account;

        private readonly IMongoCollection<CustomerApp.Models.Transaction> _transactions;
        private readonly IMongoCollection<Account> _accounts;

        private string _currentFilter = "All";

        // ============================================================
        //   FIXED CONSTRUCTOR
        // ============================================================
        public TransferForm(Customer customer, Account account)
        {
            _customer = customer;
            _account = account;

            var db = MongoConnection.GetDatabase();
            _transactions = db.GetCollection<CustomerApp.Models.Transaction>("Transaction");
            _accounts = db.GetCollection<Account>("Account");

            InitializeComponent();
            LoadTransactions();
        }

        // ============================================================
        //   TRANSFER MONEY
        // ============================================================
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            string receiverCardNo = txtToCardNo.Text.Trim();

            if (!double.TryParse(txtAmount.Text, out double amount))
            {
                MessageBox.Show("Enter a valid amount");
                return;
            }

            bool ok = TransferMoney(_account.accountID, receiverCardNo, amount);

            if (ok)
            {
                MessageBox.Show("Transfer Successful");
                txtToCardNo.Clear();
                txtAmount.Clear();
                LoadTransactions();
            }
            else
            {
                MessageBox.Show("Transfer Failed (invalid card or insufficient balance)");
            }
        }

        private bool TransferMoney(string senderAccID, string receiverCardNo, double amount)
        {
            var sender = _accounts.Find(a => a.accountID == senderAccID).FirstOrDefault();
            if (sender == null) return false;

            var receiver = _accounts.Find(a => a.card.cardNo == receiverCardNo).FirstOrDefault();
            if (receiver == null) return false;

            if (sender.balance < amount) return false;

            // Update balances
            _accounts.UpdateOne(
                a => a.accountID == sender.accountID,
                Builders<Account>.Update.Inc(a => a.balance, -amount));

            _accounts.UpdateOne(
                a => a.accountID == receiver.accountID,
                Builders<Account>.Update.Inc(a => a.balance, amount));

            // Insert transactions into DB
            InsertTransaction(sender.accountID, "Sent Money", amount);
            InsertTransaction(receiver.accountID, "Received Money", amount);

            return true;
        }

        private void InsertTransaction(string accID, string type, double amount)
        {
            var newT = new CustomerApp.Models.Transaction
            {
                transactionID = Guid.NewGuid().ToString(),
                accountID = accID,
                atmID = "ATM01",
                date = DateTime.Now,
                amount = amount,
                type = type
            };

            _transactions.InsertOne(newT);
        }

        // ============================================================
        //   LOAD TRANSACTIONS (AGGREGATION PIPELINE)
        // ============================================================
        private void LoadTransactions()
        {
            var pipeline = new System.Collections.Generic.List<BsonDocument>();

            // Match account
            pipeline.Add(new BsonDocument("$match",
                new BsonDocument("accountID", _account.accountID)));

            // Filter by type
            if (_currentFilter == "Deposits")
            {
                pipeline.Add(new BsonDocument("$match",
                    new BsonDocument("type", "Deposit")));
            }
            else if (_currentFilter == "Withdrawals")
            {
                pipeline.Add(new BsonDocument("$match",
                    new BsonDocument("type", "Withdraw")));
            }
            else if (_currentFilter == "Transfers")
            {
                pipeline.Add(new BsonDocument("$match",
                    new BsonDocument("type",
                        new BsonDocument("$in",
                            new BsonArray { "Sent Money", "Received Money" }))));
            }

            // Join with Account collection
            pipeline.Add(
                new BsonDocument("$lookup",
                    new BsonDocument
                    {
                        { "from", "Account" },
                        { "localField", "accountID" },
                        { "foreignField", "accountID" },
                        { "as", "AccountInfo" }
                    })
            );

            pipeline.Add(new BsonDocument("$unwind", "$AccountInfo"));
            pipeline.Add(new BsonDocument("$sort", new BsonDocument("date", -1)));

            // Projection
            pipeline.Add(
                new BsonDocument("$project",
                    new BsonDocument
                    {
                        { "_id", 0 },
                        { "Type", "$type" },
                        { "Amount", "$amount" },
                        { "ATM", "$atmID" },
                        { "AccountID", "$accountID" },
                        { "CardNo", "$AccountInfo.card.cardNo" },
                        {
                            "Date",
                            new BsonDocument("$dateToString",
                                new BsonDocument
                                {
                                    { "format", "%Y-%m-%d %H:%M" },
                                    { "date", "$date" }
                                })
                        }
                    })
            );

            var results = _transactions.Aggregate<BsonDocument>(pipeline).ToList();

            dgvTransactions.DataSource = results
                .Select(t => new
                {
                    Type = t["Type"].AsString,
                    Amount = t["Amount"].ToDouble(),
                    ATM = t["ATM"].AsString,
                    Date = t["Date"].AsString,
                    AccountID = t["AccountID"].AsString,
                    CardNo = t["CardNo"].AsString
                })
                .ToList();
        }

        // ============================================================
        //   FILTER BUTTONS
        // ============================================================
        private void btnAll_Click(object sender, EventArgs e)
        {
            _currentFilter = "All";
            LoadTransactions();
        }

        private void btnTransfers_Click(object sender, EventArgs e)
        {
            _currentFilter = "Transfers";
            LoadTransactions();
        }

        private void btnDeposits_Click(object sender, EventArgs e)
        {
            _currentFilter = "Deposits";
            LoadTransactions();
        }

        private void btnWithdrawals_Click(object sender, EventArgs e)
        {
            _currentFilter = "Withdrawals";
            LoadTransactions();
        }
    }
}
