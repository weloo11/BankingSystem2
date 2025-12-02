using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace ATMApp.Models
{
    public class Transaction
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string transactionID { get; set; }
        public string accountID { get; set; }
        public string atmID { get; set; }
        public double amount { get; set; }
        public string type { get; set; }
        public DateTime date { get; set; }
    }
}
