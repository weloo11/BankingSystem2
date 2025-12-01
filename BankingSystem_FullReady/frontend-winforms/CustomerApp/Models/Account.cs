using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CustomerApp.Models
{
    [BsonIgnoreExtraElements]   // ignore any extra fields Mongo adds
    public class Account
    {
        // MongoDB document id
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        public string accountID { get; set; }
        public string customerID { get; set; }
        public string employeeID { get; set; }
        public double balance { get; set; }
        public string currency { get; set; }
        public System.DateTime openDate { get; set; }
        public string accountType { get; set; }
        public string status { get; set; }

        public CardInfo card { get; set; }
    }

    public class CardInfo
    {
        public string cardNo { get; set; }
        public string pin { get; set; }
        public System.DateTime expiryDate { get; set; }
        public string cvv { get; set; }
    }
}
