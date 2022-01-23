using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ForumGames.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Put()
        {
            return NoContent();
        }
    }
}
