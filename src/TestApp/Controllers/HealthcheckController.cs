using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HealthcheckController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var version = await Task.Factory.StartNew(() => {
                return new Version();
            });

            return Ok(version);
        }
    }
}
