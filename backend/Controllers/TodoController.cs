using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var todos = new[]
            {
                new { Id = 1, Name = "Andrew Learning VUE|.NET|API" },
                new { Id = 2, Name = "Guestpix" }
            };
            return Ok(todos);
        }
    }
}
