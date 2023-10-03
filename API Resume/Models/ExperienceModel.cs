using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API_Resume.Models
{
    public class ExperienceModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        string? _id { get; set; }

        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Timeframe { get; set; }
        public List<string> Responsibilities { get; set; }
    }
}
