using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EmployeeApp.Models
{
    public class ATM
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("atmID")]
        public string atmID { get; set; }

        [BsonElement("status")]
        public string status { get; set; }
    }
}
