using Microsoft.AspNetCore.Mvc;
using Project_WEB_application.Models;

namespace Project_WEB_application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetHome()
        {
            return "Hello";
        }

        [HttpGet("hello")]
        public ActionResult<string> GetPersonalizedHello([FromQuery] string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return BadRequest("Name cannot be empty");
            }

            return Ok("Hello " + name);
        }
    }
}
