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
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        [HttpGet]
        // Note that this could be replaced with just a single[HttpGet("greeting")] attribute.
        public Greeting Greet(string name)
        {
            return new Greeting(++Greeting.CallCount, $"Hello, {name}!");
        }
    }
}
