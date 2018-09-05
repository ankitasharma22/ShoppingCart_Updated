using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Controllers
{
    interface ICart
    {
        void DisplayCartItems(); 
        void ClearCart();
        bool AddItemToCart(Item addItem); 
        bool RemoveItemFromCart(Item removeItem);
         
    }
}
