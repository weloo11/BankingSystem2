using MongoDB.Driver;

namespace CustomerApp.Services {
    public static class MongoConnection {
        private static readonly string _connectionString =
            "mongodb+srv://banking_user:7jxo9IVt3gEwslZA@bankingcluster.z7ttnao.mongodb.net/BankingSystem";

        private static readonly string _databaseName = "BankingSystem";

        public static IMongoDatabase GetDatabase() {
            var client = new MongoClient(_connectionString);
            return client.GetDatabase(_databaseName);
        }
    }
}
