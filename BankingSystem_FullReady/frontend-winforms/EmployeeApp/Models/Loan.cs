using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace EmployeeApp.Models
{
    public class Loan
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("loanID")]
        public string LoanID { get; set; }

        [BsonElement("accountID")]
        public string AccountID { get; set; }

        [BsonElement("amount")]
        public double Amount { get; set; }

        [BsonElement("interestRate")]
        public double InterestRate { get; set; }

        [BsonElement("issueDate")]
        public DateTime IssueDate { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }    // Pending, Approved, Rejected

        [BsonElement("dueDate")]
        public DateTime DueDate { get; set; }
    }
}