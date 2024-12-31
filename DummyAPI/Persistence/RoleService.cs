using DummyAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace DummyAPI.Persistence
{
    public class RoleService
    {
        private readonly IMongoCollection<DummyRole> _rolesCollection;
        public RoleService(IOptions<DatabaseSettings> roleStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(roleStoreDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(roleStoreDatabaseSettings.Value.DatabaseName);

            _rolesCollection = mongoDatabase.GetCollection<DummyRole>(roleStoreDatabaseSettings.Value.RolesCollectionName);
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
