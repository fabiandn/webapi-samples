using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Samples.ReturnTypes.Models;

namespace Samples.ReturnTypes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[]{ "Hello", "World"};
        }

        [HttpGet("IActionResult")]
        public IActionResult GetIActionResult()
        {
            return this.Ok(new string[]{ "Hello", "World"});
        }

        [HttpPost("test")]
        public IActionResult TestPost([FromBody]MyModel model){
            return this.Ok();
        }
    }
}
