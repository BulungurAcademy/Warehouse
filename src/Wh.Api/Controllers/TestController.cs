using Microsoft.AspNetCore.Mvc;

namespace Wh.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTest() => Ok("Test");
    }
}
