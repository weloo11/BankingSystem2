using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CustomerApp.Models
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement("customerID")]
        public string customerID { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("address")]
        public string address { get; set; }

        [BsonElement("phone")]
        public string phone { get; set; }

        [BsonElement("email")]
        public string email { get; set; }

        [BsonElement("password")]
        public string password { get; set; }
    }
}
