Atmservices

using MongoDB.Driver;
using ATMApp.Models;

namespace ATMApp.Services
{
    public static class ATMServices
    {
        private static readonly IMongoCollection<ATMModel> _atmCollection;

        static ATMServices()
        {
            _atmCollection = MongoConnection.GetDatabase()
                .GetCollection<ATMModel>("ATM");
        }

        public static ATMModel GetATM(string atmID)
        {
            return _atmCollection.Find(a => a.atmID == atmID).FirstOrDefault();
        }

        public static bool ValidateATM(string atmID)
        {
            var atm = GetATM(atmID);
            return atm != null;
        }

        public static bool IsATMActive(string atmID)
        {
            var atm = GetATM(atmID);
            if (atm == null)
                return false;

            return atm.status == "Active";
        }
    }
}
