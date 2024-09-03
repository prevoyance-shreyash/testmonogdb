using MongodbTest.Model;

namespace MongodbTest
{
    public interface IUserBL
    {
         Task<List<UserDetail>> Get();
    }
}