using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WhApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Ping() => Ok("Server is working !");
    }
}
