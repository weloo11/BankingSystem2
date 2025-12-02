using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EmployeeApp.Models
{
    public class Customer
    {
        [BsonId]
        [BsonElement("_id")]
        public ObjectId InternalId { get; set; }

        [BsonElement("customerID")]
        public string CustomerID { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }
    }
}