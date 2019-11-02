using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("useful")]
    public class HomeController : Controller
    {
        private UtilityService utility;

        public HomeController(UtilityService utility)
        {
            this.utility = utility;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("colored")]
        public IActionResult Colored()
        {
            return View(new ColorModel { Color = utility.RandomColor() } );
        }
    }
}
