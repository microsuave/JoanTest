using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KloKController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var message = await Task.Factory.StartNew(() => {
                return new
                {
                    Date = DateTime.UtcNow,
                    Message = "Palomo"
                };
            });

            return Ok(message);
        }
    }
}
