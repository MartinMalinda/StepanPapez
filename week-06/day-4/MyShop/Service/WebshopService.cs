using MyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Service
{
    public class WebshopService
    {
        private static List<ShopItem> shopItemsList = new List<ShopItem>
            {
               new ShopItem("Running Shoes", "Nike running shoes for every day sport", 1000.0, 5),
               new ShopItem("Printer", "Some HP printer that will print pages", 3000.0, 2),
               new ShopItem("Coca Cola", "0.5 l standard coke", 25.9, 0),
               new ShopItem("Wokin", "Chicken with fried rice and WOKIN sauce", 119.0, 100),
               new ShopItem("T-shirt", "Blue with a corgi on a bike", 300.0, 1)
            };

        public static List<ShopItem> ShopItemsList
        {
            get
            {
                return shopItemsList;
            }
        }

        // only-available
        public static List<ShopItem> GetOnlyAvailable(List<ShopItem> list)
        {
            return list.Where(si => si.Quantity > 0).ToList();
        }

        // cheapest-first
    }
}
