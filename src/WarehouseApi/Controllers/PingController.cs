﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WarehouseApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Ping() => Ok("Server is working !");
    }
}
