using MongoDB.Driver;
using MongoDB.Bson;
using System.Runtime.CompilerServices;
using API_Resume.Models;
using Microsoft.Extensions.Options;

namespace API_Resume.Services
{
    public class MongoDBService
    {
        private readonly IMongoCollection<ExperienceModel> _experienceCollection;
        private readonly IMongoCollection<ContactModel> _contactCollection;
        private readonly IMongoCollection<MeModel> _meCollection;
        private readonly IMongoCollection<MessageModel> _messageCollection;

        public MongoDBService(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.connectionUri);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.databaseName);
            _experienceCollection = database.GetCollection<ExperienceModel>(mongoDBSettings.Value.experienceCollection);
            _contactCollection = database.GetCollection<ContactModel>(mongoDBSettings.Value.contactCollection);
            _meCollection = database.GetCollection<MeModel>(mongoDBSettings.Value.meCollection);
            _messageCollection = database.GetCollection<MessageModel>(mongoDBSettings.Value.messageCollection);
        }

        public async Task<IEnumerable<ExperienceModel>> GetExperience()
        {
            return await _experienceCollection.Find(_ => true).ToListAsync();
        }

        public async Task<ContactModel> GetContact()
        {
            return await _contactCollection.Find(_ => true).FirstAsync();
        }

        public async Task<MeModel> GetMe()
        {
            return await _meCollection.Find(_ => true).FirstAsync();
        }

        public async Task CreateMessage(MessageModel Message)
        {
            await _messageCollection.InsertOneAsync(Message);
            return;
        }
    }
}
