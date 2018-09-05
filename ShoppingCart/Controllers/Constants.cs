using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Controllers
{
    public class Constants
    {
        public void Welcome()
        {
            Console.WriteLine("------------SHOPPING CART-----------"); 
        }

        public void AskForChoice()
        { 
            Console.Write("1. Add Item to Cart");
            Console.Write("2. Remove Item from Cart");
            Console.Write("3. Display Items of Cart");
            Console.Write("4. Display Amount of Cart");
        }
    }
}