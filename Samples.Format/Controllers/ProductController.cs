
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Samples.Format.Models;

namespace Samples.Format.Controllers
{
    [FormatFilter]
    public class ProductsController
    {
        [Route("[controller]/[action]/{id}.{format?}")]
        public MyModel GetById(int id){
            return new MyModel{Name= "test", Description= "test" };
        }
    }
}