using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongodbTest.Model;
namespace MongodbTest.Services
{
    public class UserService
    {

        private readonly IMongoCollection<UserDetail> _userCollection;

        public UserService(
     IOptions<UserDatabaseSetting> userDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                userDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                userDatabaseSettings.Value.DatabaseName);

            _userCollection = mongoDatabase.GetCollection<UserDetail>(
                userDatabaseSettings.Value.CollectionName);
        }

        public async Task<List<UserDetail>> GetAsync() =>
        await _userCollection.Find(_ => true).ToListAsync();

    }
}
