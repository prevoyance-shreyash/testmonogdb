using MongodbTest.Model;
using MongodbTest.Services;
using System.Collections.Generic;

namespace MongodbTest
{
    public class UserBL 
    {
        private readonly UserService _userService;
        public UserBL(UserService userService)
        {
            _userService = userService;
        }



        //public async Task<List<UserDetail>> Get()
        //{
        //    List<UserDetail> users = new List<UserDetail>();
        //    try
        //    {
        //        users = await _userService.GetAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return users;
        //}
    }
}
