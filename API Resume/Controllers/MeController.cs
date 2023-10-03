using API_Resume.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_Resume.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MeController : ControllerBase
    {
        private readonly MongoDBService _mongoDBService;

        public MeController(MongoDBService mongoDBService)
        {
            _mongoDBService = mongoDBService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mongoDBService.GetMe());
        }
    }
}
