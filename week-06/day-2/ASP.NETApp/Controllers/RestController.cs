using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETApp.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        // public IActionResult Index()
        // {
        //     return View();
        // }

        [HttpGet("greeting")]
        public Greeting Greet()
        {
           
        }
    }
}