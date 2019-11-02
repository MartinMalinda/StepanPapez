using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet("home")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("login")]
        public IActionResult GetLogin()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult PostLogin()
        {
            return View();
        }
    }
}