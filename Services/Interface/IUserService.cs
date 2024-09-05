using MongodbTest.Model;

namespace MongodbTest.Services.Interface
{
    public interface IUserService
    {
        Task<List<UserDetail>> GetAsync();
    }
}