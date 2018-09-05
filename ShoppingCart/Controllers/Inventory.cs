using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Controllers
{
    public class Inventory
    {
        public List<Item> listOfItems = new List<Item>(); 
        public List<Item> listInCart()
        {
            return listOfItems;
        }

    }
}