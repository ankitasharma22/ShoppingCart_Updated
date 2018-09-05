using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class Item 
    {
       
        public string Name { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; } 
        public int Quantity { set; get; }
    }
}