using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
using MyShop.Service;

namespace MyShop.Controllers
{
    [Route("webshop")]
    public class WebshopController : Controller
    {
        
        [HttpGet("")]
        public IActionResult GetAll()
        {
            return View(WebshopService.ShopItemsList);
        }

        [HttpGet("only-available")]
        public IActionResult OnlyAvailable()
        {
            return View("GetAll", WebshopService.GetOnlyAvailable(WebshopService.ShopItemsList));
        }
    }
}