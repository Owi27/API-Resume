namespace API_Resume.Models
{
    public class MongoDBSettings
    {
        public string? connectionUri { get; set; }
        public string? databaseName { get; set; }
        public string? experienceCollection { get; set; }
        public string? contactCollection { get; set; }
        public string? meCollection { get; set; }
        public string? messageCollection { get; set; }
    }
}
