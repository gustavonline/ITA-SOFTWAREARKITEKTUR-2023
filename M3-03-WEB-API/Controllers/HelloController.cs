using Microsoft.AspNetCore.Mvc;

namespace M3_03_WEB_API.Controllers
{
    [ApiController]
    [Route("api/hello")]
    public class HelloController : ControllerBase
    {
        [HttpGet("{name}/{age}")]
        public ActionResult<object> GetHelloMessage(string name, int age) => new { Message = $"Hello {name}! your age is {age}" };
    }
}