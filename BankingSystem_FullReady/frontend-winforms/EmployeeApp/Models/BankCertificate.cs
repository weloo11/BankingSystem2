using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace EmployeeApp.Models
{
    public class BankCertificate
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("certificateID")]
        public string CertificateID { get; set; }

        [BsonElement("accountID")]
        public string AccountID { get; set; }

        [BsonElement("issueDate")]
        public DateTime IssueDate { get; set; }

        [BsonElement("expiryDate")]
        public DateTime ExpiryDate { get; set; }

        [BsonElement("amount")]
        public double Amount { get; set; }

        [BsonElement("interest")]
        public double Interest { get; set; }

        // This field is not in your validator but REQUIRED for approvals
        [BsonElement("status")]
        public string Status { get; set; }   // Pending, Approved, Rejected
    }
}