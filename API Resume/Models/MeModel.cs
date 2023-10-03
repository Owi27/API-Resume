using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace API_Resume.Models
{
    public class MeModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        string? _id { get; set; }

        public string Name { get; set; }
        public string Headline { get; set; }
        public string AboutMe { get; set; }
    }
}
