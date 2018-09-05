using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Controllers
{
    public class ItemManager_DB
    {
        List<Item> AvailableItems = new List<Item>();
        public void AddIntoDatabase()
        { 
            Item item1 = new Item();
            Item item2 = new Item();
            Item item3 = new Item();
            Item item4 = new Item();
            Item item5 = new Item();

            item1.Id = 1; item1.Name = "Water Bottle"; item1.Price = 120; item1.Quantity=0;
            item2.Id = 2; item2.Name = "Bag"; item2.Price = 1550; item1.Quantity = 0;
            item3.Id = 3; item3.Name = "Jeans"; item3.Price = 1220; item1.Quantity = 0;
            item4.Id = 4; item4.Name = "Headphones"; item4.Price = 6520; item1.Quantity = 0;
            item5.Id = 5; item5.Name = "Laptop"; item5.Price = 65120; item1.Quantity = 0;

            AvailableItems.Add(item1);
            AvailableItems.Add(item2);
            AvailableItems.Add(item3);
            AvailableItems.Add(item4);
            AvailableItems.Add(item5);
        }

        public List<Item> GetDatabase()
        {
            return AvailableItems;
        }
    }
}