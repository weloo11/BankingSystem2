using System;                                 // REQUIRED
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CustomerApp.Models
{
    public class Certificate
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        public string certificateID { get; set; }
        public string accountID { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime issueDate { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime expiryDate { get; set; }

        public double amount { get; set; }
        public double interest { get; set; }
        public string status { get; set; } = "Pending";
    }
} 