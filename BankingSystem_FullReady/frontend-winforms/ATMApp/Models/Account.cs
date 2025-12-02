using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace ATMApp.Models
{
    public class Account
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("accountID")]
        public string accountID { get; set; }

        [BsonElement("customerID")]
        public string customerID { get; set; }

        [BsonElement("employeeID")]
        public string employeeID { get; set; }

        [BsonElement("balance")]
        public double balance { get; set; }

        [BsonElement("currency")]
        public string currency { get; set; }

        [BsonElement("openDate")]
        public DateTime openDate { get; set; }   // ← FIX HERE

        [BsonElement("accountType")]
        public string accountType { get; set; }

        [BsonElement("status")]
        public string status { get; set; }

        [BsonElement("card")]
        public Card card { get; set; }
    }

    public class Card
    {
        [BsonElement("cardNo")]
        public string cardNo { get; set; }

        [BsonElement("pin")]
        public string pin { get; set; }

        [BsonElement("cvv")]
        public string cvv { get; set; }

        [BsonElement("expiryDate")]
        public DateTime expiryDate { get; set; } // important: it exists in DB
    }
}
