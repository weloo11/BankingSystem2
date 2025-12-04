using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CustomerApp.Models
{
    public class Loan
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        public string loanID { get; set; }
        public string accountID { get; set; }
        public double amount { get; set; }
        public double interestRate { get; set; }
        public System.DateTime issueDate { get; set; }
        public string status { get; set; }
        public System.DateTime dueDate { get; set; }
    }
}
 