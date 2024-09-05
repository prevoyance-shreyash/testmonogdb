using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongodbTest.Model;
using MongodbTest.Services.Interface;

namespace MongodbTest.Services
{
    public class UserService : IUserService
    {

        private readonly IMongoCollection<UserDetail>? _userCollection;
        //private readonly IConfiguration _configuration;
        //private readonly MongoClient _mongoclient;
        public UserService(MongoDbService mongoDbService)
        {
            //_configuration = configuration;
            //_mongoclient = new MongoClient(_configuration["Database:ConnectionString"]);
            //var _mongoDatabase = _mongoclient.GetDatabase(_configuration["Database:DatabaseName"]);
            _userCollection = mongoDbService.Database?.GetCollection<UserDetail>("userdetails");

        }

        public async Task<List<UserDetail>> GetAsync() =>
        await _userCollection.Find(_ => true).ToListAsync();

    }
}
