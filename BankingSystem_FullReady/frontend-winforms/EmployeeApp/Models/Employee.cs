using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EmployeeApp.Models
{
    public class Employee
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("employeeID")]
        public string EmployeeID { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }
    }
}