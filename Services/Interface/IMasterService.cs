using MetaData.Model;
using Microsoft.AspNetCore.Mvc;
using MongodbTest.Model;

namespace MongodbTest.Services.Interface
{
    public interface IMasterService
    {
        Task<List<MasterCollection>> Get();
        Task Insert(MasterCollection masterCollection);
        Task<List<MasterCollection2>> GetChild2();
        Task Update(MasterCollection masterCollection);
        Task Delete(string id);
    }
}