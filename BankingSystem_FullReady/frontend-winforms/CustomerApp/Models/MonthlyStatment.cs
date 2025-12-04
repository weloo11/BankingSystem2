using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace CustomerApp.Models
{
    public class MonthlyStatement
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        public string statementID { get; set; }
        public string accountID { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime issueDate { get; set; }

        public double accountBalance { get; set; }
        public double totalWithdrawn { get; set; }
        public double totalDeposited { get; set; }
    }
}