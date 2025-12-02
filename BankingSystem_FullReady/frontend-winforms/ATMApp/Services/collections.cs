using MongoDB.Driver;
using ATMApp.Models;

namespace ATMApp.Services
{
    public static class Collections
    {
        private static readonly IMongoDatabase db = MongoConnection.GetDatabase();

        public static IMongoCollection<Account> Accounts =>
            db.GetCollection<Account>("Account");

        public static IMongoCollection<Transaction> Transactions =>
            db.GetCollection<Transaction>("Transaction");

        public static IMongoCollection<ATMModel> ATMs =>
            db.GetCollection<ATMModel>("ATM");
    }
}
