using Microsoft.AspNetCore.Mvc;

namespace Hermes_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello from Hermes-Backend!" });
        }
    }
}
