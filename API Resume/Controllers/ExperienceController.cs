using API_Resume.Models;
using API_Resume.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace API_Resume.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExperienceController : ControllerBase
    {
        private readonly MongoDBService _mongoDBService;

        public ExperienceController(MongoDBService mongoDBService)
        {
            _mongoDBService = mongoDBService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mongoDBService.GetExperience());
        }
    }
}
