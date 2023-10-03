using API_Resume.Models;
using API_Resume.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_Resume.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly MongoDBService _mongoDBService;

        public MessageController(MongoDBService mongoDBService)
        {
            _mongoDBService = mongoDBService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] MessageModel Message)
        {
            await _mongoDBService.CreateMessage(Message);
            return CreatedAtAction(nameof(Post), Message);
        }
    }
}
