using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ATMApp.Models
{
    public class ATMModel
    {
        // This matches the MongoDB field name _id EXACTLY
        [BsonId]
        [BsonElement("_id")]
        public ObjectId _id { get; set; }

        [BsonElement("atmID")]
        public string atmID { get; set; }
    }
}
