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
            // var greeting = new Greeting();
            // greeting.Content = Request.Query["Hello, world!"];
            // greeting.Id = Convert.ToInt64(Request.Query["id"]);
            // return greeting;

            Models.Greeting.CallCount++;
            return new Greeting(Greeting.CallCount, $"Hello, {name}!");
        }
    }
}
