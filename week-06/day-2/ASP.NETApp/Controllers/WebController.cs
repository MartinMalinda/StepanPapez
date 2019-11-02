using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETApp.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("greeting")]
        public IActionResult Greeting(string name)
        {
            var greeting = new Greeting(name);

            return View(greeting);
        }

    }
}