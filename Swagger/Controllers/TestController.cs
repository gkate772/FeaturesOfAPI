using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swagger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    /// <summary>
    /// Gets all test.
    /// </summary>
    /// <returns>This is test Endpoint</returns>
    public class TestController : ControllerBase
    {
        [HttpGet("ping")]
        public string Ping() => "API working from Console App!";
    }
}
