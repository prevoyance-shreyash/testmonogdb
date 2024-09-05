using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongodbTest.Model;
using MongodbTest.Services;
using MongodbTest.Services.Interface;

namespace MongodbTest.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly IMasterService _masterService;
        public MasterController(IMasterService masterService)
        {
            _masterService = masterService;
        }


        [HttpGet]
        [ActionName("GetChild1")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = Newtonsoft.Json.JsonConvert.SerializeObject(await _masterService.Get(), Newtonsoft.Json.Formatting.Indented);
                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [ActionName("GetChild2")]
        public async Task<IActionResult> GetChild2()
        {
            try
            {
                var result = Newtonsoft.Json.JsonConvert.SerializeObject(await _masterService.GetChild2(), Newtonsoft.Json.Formatting.Indented);
                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPost]
        [ActionName("Insert")]
        public async Task<IActionResult> Insert([FromBody] MasterCollection masterCollection)
        {
            try
            {
                var result = Newtonsoft.Json.JsonConvert.SerializeObject(_masterService.Insert(masterCollection), Newtonsoft.Json.Formatting.Indented);
                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [ActionName("Update")]
        public async Task<IActionResult> Update([FromBody] MasterCollection masterCollection)
        {
            try
            {
                var result = Newtonsoft.Json.JsonConvert.SerializeObject(_masterService.Update(masterCollection), Newtonsoft.Json.Formatting.Indented);
                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpDelete]
        [ActionName("Delete")]
        public async Task<IActionResult> Delete([FromBody] string id)
        {
            try
            {
                var result = Newtonsoft.Json.JsonConvert.SerializeObject(_masterService.Delete(id), Newtonsoft.Json.Formatting.Indented);
                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }

}

