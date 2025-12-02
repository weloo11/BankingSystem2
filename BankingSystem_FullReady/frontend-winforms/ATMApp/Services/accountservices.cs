using MongoDB.Driver;
using ATMApp.Models;
using System;

namespace ATMApp.Services
{
    public static class AccountServices
    {
        public static bool ValidateATM(string atmID)
        {
            var atm = Collections.ATMs.Find(a => a.atmID == atmID).FirstOrDefault();
            return atm != null;
        }

        public static Account ValidateAccount(string accountID, string cardNo)
        {
            return Collections.Accounts
                .Find(a => a.accountID == accountID && a.card.cardNo == cardNo)
                .FirstOrDefault();
        }

        public static double Deposit(string accountID, double amount)
        {
            var update = Builders<Account>.Update.Inc(a => a.balance, amount);
            Collections.Accounts.UpdateOne(a => a.accountID == accountID, update);
            return Collections.Accounts.Find(a => a.accountID == accountID).First().balance;
        }

        public static double Withdraw(string accountID, double amount)
        {
            var acc = Collections.Accounts.Find(a => a.accountID == accountID).First();

            if (acc.balance < amount)
                throw new Exception("Insufficient balance");

            var update = Builders<Account>.Update.Inc(a => a.balance, -amount);
            Collections.Accounts.UpdateOne(a => a.accountID == accountID, update);
            return Collections.Accounts.Find(a => a.accountID == accountID).First().balance;
        }

        public static void SaveTransaction(string tID, string accountID, string atmID, double amount, string type)
        {
            var transaction = new Transaction
            {
                transactionID = tID,
                accountID = accountID,
                atmID = atmID,
                amount = amount,
                type = type,
                date = DateTime.Now
            };

            Collections.Transactions.InsertOne(transaction);
        }
    }
}
