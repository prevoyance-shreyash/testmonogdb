using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson.IO;
using MongodbTest.Model;
using MongodbTest.Services;
using MongodbTest.Services.Interface;
using Newtonsoft.Json;

namespace MongodbTest.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userServices;
        public UserController(IUserService userServices)
        {
            _userServices = userServices;
        }


        //[HttpGet]
        //public async Task<List<UserDetail>> Get() =>
        //await _userServices.GetAsync();
        [HttpGet]
        [ActionName("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = Newtonsoft.Json.JsonConvert.SerializeObject(await _userServices.GetAsync(), Formatting.Indented);
                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


       
    }
}
