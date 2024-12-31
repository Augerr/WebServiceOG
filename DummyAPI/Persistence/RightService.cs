using DummyAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace DummyAPI.Persistence
{
    public class RightService
    {
        private readonly IMongoCollection<DummyRight> _rightsCollection;
        public RightService(IOptions<DatabaseSettings> rightStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(rightStoreDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(rightStoreDatabaseSettings.Value.DatabaseName);

            _rightsCollection = mongoDatabase.GetCollection<DummyRight>(rightStoreDatabaseSettings.Value.RightsCollectionName);
        }

        public Task<List<IDummyEntity>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDummyEntity?> GetAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
