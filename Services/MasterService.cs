using MetaData.Model;
using MongoDB.Driver;
using MongodbTest.Model;
using MongodbTest.Services.Interface;

namespace MongodbTest.Services
{
    public class MasterService : IMasterService
    {

        private readonly IMongoCollection<MasterCollection>? _masterCollection;
        private readonly IMongoCollection<MasterCollection2>? _masterCollection2;
        public MasterService(MongoDbService mongoDbService)
        {
            _masterCollection = mongoDbService.Database?.GetCollection<MasterCollection>("MasterCollection");
            _masterCollection2 = mongoDbService.Database?.GetCollection<MasterCollection2>("MasterCollection2");
        }

        public async Task<List<MasterCollection>> Get()
        {
            try
            {
                return await _masterCollection.Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public async Task<List<MasterCollection2>> GetChild2()
        {
            try
            {
                return await _masterCollection2.Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public async Task Insert(MasterCollection masterCollection)
        {
            try
            {
                //var collection = _masterCollection.GetCollection<MasterCollection>("MasterCollection");
                var result = _masterCollection?.InsertOneAsync(masterCollection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Update(MasterCollection masterCollection)
        {
            try
            {
                //var collection = _masterCollection.GetCollection<MasterCollection>("MasterCollection");
                var result = _masterCollection?.ReplaceOneAsync(x => x.Id == masterCollection.Id,masterCollection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task Delete(string id)
        {
            try
            {
                //var collection = _masterCollection.GetCollection<MasterCollection>("MasterCollection");
                var result = _masterCollection?.DeleteOneAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
