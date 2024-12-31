using DummyAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace DummyAPI.Persistence
{
    public class UserService
    {
        private readonly IMongoCollection<DummyUser> _usersCollection;
        public UserService(IOptions<DatabaseSettings> dbSettings)
        {
            var mongoClient = new MongoClient(dbSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(dbSettings.Value.DatabaseName);

            _usersCollection = mongoDatabase.GetCollection<DummyUser>(dbSettings.Value.UsersCollectionName);
        }

        public List<DummyUser> Get()
        {
            var users = _usersCollection.AsQueryable().ToList();
            return users;
        }
        public async Task<DummyUser?> GetAsync(int id) =>
            await _usersCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(DummyUser newDummyUser) =>
            await _usersCollection.InsertOneAsync(newDummyUser);

        public async Task UpdateAsync(int id, DummyUser updatedDummyUser) =>
            await _usersCollection.ReplaceOneAsync(x => x.Id == id, updatedDummyUser);

        public async Task RemoveAsync(int id) =>
            await _usersCollection.DeleteOneAsync(x => x.Id == id);
    }
}
