using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CustomerApp.Models
{
    [BsonIgnoreExtraElements]   // ignore extra fields if they exist
    public class Transaction
    {
        // MongoDB document id
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        public string transactionID { get; set; }
        public string accountID { get; set; }
        public string atmID { get; set; }
        public System.DateTime date { get; set; }
        public double amount { get; set; }
        public string type { get; set; }
    }
}
