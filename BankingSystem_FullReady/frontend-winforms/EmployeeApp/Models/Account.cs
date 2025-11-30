using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace EmployeeApp.Models
{
    public class CardInfo
    {
        [BsonElement("cardNo")]
        public string CardNo { get; set; }

        [BsonElement("pin")]
        public string Pin { get; set; }

        [BsonElement("expiryDate")]
        public DateTime ExpiryDate { get; set; }

        [BsonElement("cvv")]
        public string Cvv { get; set; }
    }

    public class Account
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("accountID")]
        public string AccountID { get; set; }

        [BsonElement("customerID")]
        public string CustomerID { get; set; }

        [BsonElement("employeeID")]
        public string EmployeeID { get; set; }

        [BsonElement("balance")]
        public double Balance { get; set; }

        [BsonElement("currency")]
        public string Currency { get; set; }

        [BsonElement("openDate")]
        public DateTime OpenDate { get; set; }

        [BsonElement("accountType")]
        public string AccountType { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }  // Active, Pending, Rejected

        [BsonElement("card")]
        public CardInfo Card { get; set; }
    }
}