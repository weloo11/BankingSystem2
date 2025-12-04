using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CustomerApp.Models
{
    public class Employee
    {
        // MongoDB always generates this even if not in schema
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        // Required according to schema
        public string employeeID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
