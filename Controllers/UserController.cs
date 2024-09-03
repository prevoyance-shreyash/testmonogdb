using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson.IO;
using MongodbTest.Services;
using Newtonsoft.Json;

namespace MongodbTest.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userServices;
        public UserController(UserService userServices)
        {
            _userServices = userServices;
        }

        [HttpGet]
        [ActionName("Get")]   
        public IActionResult Get()
        {
            try
            {
               var result= Newtonsoft.Json.JsonConvert.SerializeObject(_userServices.GetAsync(), Formatting.Indented);
                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
