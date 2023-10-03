using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace API_Resume.Models
{
    public class MessageModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        string? _id { get; set; }

        public string? Name { get; set; }
        public string? Email { get; set; }
        public string Message { get; set; }
    }
}
