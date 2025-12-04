using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace CustomerApp.Models
{
    public class Account
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        public string accountID { get; set; }
        public string customerID { get; set; }
        public string employeeID { get; set; }
        public double balance { get; set; }
        public string currency { get; set; }
        public string accountType { get; set; }
        public string status { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTime openDate { get; set; }

        // ---------------------------
        // EMBEDDED CARD OBJECT HERE
        // ---------------------------
        public Card card { get; set; }
    }

    // ----------------------------------------
    // CARD CLASS (Now inside Account.cs)
    // ----------------------------------------
    public class Card
    {
        public string cardNo { get; set; }
        public string pin { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTime expiryDate { get; set; }

        public string cvv { get; set; }
    }
}
