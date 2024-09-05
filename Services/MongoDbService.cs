using MongoDB.Driver;

namespace MongodbTest.Services
{
    public class MongoDbService
    {

        private readonly IConfiguration _configuration;
        private readonly IMongoDatabase _database;

        public MongoDbService(IConfiguration configuration)
        {
            _configuration = configuration;
            var connectionString = _configuration["Database:ConnectionString"];
            var mongoUrl=MongoUrl.Create(connectionString);
            var mongoClient=new MongoClient(mongoUrl);
            _database = mongoClient.GetDatabase(_configuration["Database:DatabaseName"]);
        }

        public IMongoDatabase Database => _database;
    }
}
