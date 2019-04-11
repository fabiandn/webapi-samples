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
    public class SongController : ControllerBase
    {
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(string[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Get(int id)
        {            
            if (id < 1)
            {
                return this.BadRequest();
            }
            
            if (id == 20)
            {
                return NotFound();
            }

            return this.Ok(new string[]{ "Hello", "World"});
        }
    }
}
