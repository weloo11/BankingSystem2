using MongoDB.Driver;
using CustomerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerApp.Services
{
    public class MonthlyStatementService
    {
        private readonly IMongoCollection<MonthlyStatement> _statements;
        private readonly IMongoCollection<Transaction> _transactions;
        private readonly IMongoCollection<Account> _accounts;

        public MonthlyStatementService()
        {
            var db = MongoConnection.GetDatabase();
            _statements = db.GetCollection<MonthlyStatement>("MonthlyStatements");
            _transactions = db.GetCollection<Transaction>("Transaction");
            _accounts = db.GetCollection<Account>("Account");
        }

        public MonthlyStatement GenerateStatement(string accountID, int year, int month)
        {
            // 1. Get all transactions for that month
            var start = new DateTime(year, month, 1);
            var end = start.AddMonths(1);

            var monthlyTransactions = _transactions
                .Find(t => t.accountID == accountID &&
                           t.date >= start &&
                           t.date < end)
                .ToList();

            // Calculate totals
            double totalDeposited = monthlyTransactions
                .Where(t => t.type == "Deposit")
                .Sum(t => t.amount);

            double totalWithdrawn = monthlyTransactions
                .Where(t => t.type == "Withdraw")
                .Sum(t => t.amount);

            // 2. Get current balance
            var account = _accounts.Find(a => a.accountID == accountID).FirstOrDefault();
            double balance = account.balance;

            // 3. Create statement ID
            string statementID = "S" + DateTime.Now.Ticks.ToString().Substring(10);

            var statement = new MonthlyStatement
            {
                statementID = statementID,
                accountID = accountID,
                issueDate = DateTime.Now,
                accountBalance = balance,
                totalDeposited = totalDeposited,
                totalWithdrawn = totalWithdrawn
            };

            _statements.InsertOne(statement);
            return statement;
        }

        public List<MonthlyStatement> GetStatements(string accountID)
        {
            return _statements.Find(s => s.accountID == accountID).ToList();
        }
    }
}