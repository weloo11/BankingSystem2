using System;
using System.Collections.Generic;
using MongoDB.Driver;
using EmployeeApp.Models;

namespace EmployeeApp.Services
{
    public class AccountService
    {
        private readonly IMongoCollection<Account> _accounts;

        public AccountService()
        {
            var db = MongoConnection.GetDatabase();
            _accounts = db.GetCollection<Account>("Account");
        }

        public List<Account> GetPendingAccounts()
        {
            return _accounts.Find(a => a.Status == "Pending").ToList();
        }

        public List<Account> GetAccountsByCustomer(string customerID)
        {
            return _accounts.Find(a => a.CustomerID == customerID).ToList();
        }

        public void ApproveAccount(string accountID, CardInfo card)
        {
            var update = Builders<Account>.Update
                .Set(a => a.Status, "Active")
                .Set(a => a.Card, card);

            _accounts.UpdateOne(a => a.AccountID == accountID, update);
        }

        public void RejectAccount(string accountID)
        {
            var update = Builders<Account>.Update
                .Set(a => a.Status, "Rejected");

            _accounts.UpdateOne(a => a.AccountID == accountID, update);
        }

        public void UpdateStatus(string accountID, string status)
        {
            var update = Builders<Account>.Update
                .Set(a => a.Status, status);

            _accounts.UpdateOne(a => a.AccountID == accountID, update);
        }

        public CardInfo GenerateCard()
        {
            var rnd = new Random();
            string cardNo = "";
            for (int i = 0; i < 16; i++)
            {
                cardNo += rnd.Next(0, 10).ToString();
            }

            string cvv = rnd.Next(100, 999).ToString();

            return new CardInfo
            {
                CardNo = cardNo,
                Pin = "1234",
                Cvv = cvv,
                ExpiryDate = DateTime.Now.AddYears(5)
            };
        }
    }
}