using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Samples.ReturnTypes.Models;

namespace Samples.ReturnTypes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(string[]), StatusCodes.Status200OK)]
        public IEnumerable<string> Get()
        {
            return new string[]{ "Hello", "World"};
        }

        [HttpGet("IActionResult")]
        [ProducesResponseType(typeof(string[]), StatusCodes.Status200OK)]
        public IActionResult GetIActionResult()
        {
            return this.Ok(new string[]{ "Hello", "World"});
        }

        [HttpPost("test")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult TestPost([FromBody]MyModel model){
            return this.Ok();
        }

        [HttpGet("GetModelsById")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<MyModel> GetModelsById(int id){
            if (id == 0)
            {
                return BadRequest();
            }

            return new MyModel();
        }
    }
}
