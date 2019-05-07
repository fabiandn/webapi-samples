using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Samples.Format.Models;

namespace Samples.Format.Controllers
{
    [Produces("application/xml")]
    [FormatFilter]
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[]{ "Hello", "World"};
        }

        [HttpGet("Hey")]
        public string GetHey()
        {
            return "Hey";
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

        [HttpGet("GetModelsById/{id}")]
        public ActionResult<MyModel> GetModelsById(int id){
            if (id == 0)
            {
                return BadRequest();
            }

            if (id == -1) 
            {
                return null;
            }

            return new MyModel{Name= "test", Description= "test" };
        }

        [Route("GetById/{id}.{format?}")]
        public MyModel GetById(int id){
            return new MyModel{Name= "test", Description= "test" };
        }
    }
}
