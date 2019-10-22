using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETApp.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        Greeting greetOne = new Greeting( 1, "Hello World" );
        public IActionResult Index()
        {
            return View();
        }

        // [Route("greeting")]
        // [HttpGet]
        [HttpGet("greeting")]
        public Greeting Greet()
        {
            return greetOne;
        }
    }
}