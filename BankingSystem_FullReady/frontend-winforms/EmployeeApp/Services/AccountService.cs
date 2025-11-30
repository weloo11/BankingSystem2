using MongoDB.Driver;
using EmployeeApp.Models;
using System.Collections.Generic;

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

        public void ApproveAccount(string accountID, string employeeID)
        {
            var update = Builders<Account>.Update
                .Set(a => a.Status, "Active")
                .Set(a => a.EmployeeID, employeeID);

            _accounts.UpdateOne(a => a.AccountID == accountID, update);
        }

        public void RejectAccount(string accountID, string employeeID)
        {
            var update = Builders<Account>.Update
                .Set(a => a.Status, "Rejected")
                .Set(a => a.EmployeeID, employeeID);

            _accounts.UpdateOne(a => a.AccountID == accountID, update);
        }
    }
}