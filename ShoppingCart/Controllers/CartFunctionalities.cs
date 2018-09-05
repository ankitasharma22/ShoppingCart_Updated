using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingCart.Models;

namespace ShoppingCart.Controllers
{
    public class CartFunctionalities :  ICart
    {

        static Inventory inventory = new Inventory();
        List<Item> CartItems = inventory.listInCart();
        public bool AddItemToCart(Item newItemInCart)
        {
           
            int previousCountOfCart = CartItems.Count;
            CartItems.Add(newItemInCart);
            if (CartItems.Count == previousCountOfCart + 1)
                return true;
            else return false;
        }

        public void ClearCart()
        {
            CartItems.Clear();
        }

        public void DisplayCartItems()
        {
            for (int i = 0; i < CartItems.Count; i++)
            {
                Console.WriteLine(" ----Item ID---- " +CartItems[i].Id);
                Console.WriteLine(" ----Item Name---- " + CartItems[i].Name);
                Console.WriteLine(" ----Item Price---- " + CartItems[i].Price);
                Console.WriteLine("-----Item Quantity---" + CartItems[i].Quantity);
            }
        }

        public bool RemoveItemFromCart(Item removeItemFromCart)
        {
            int previousCountOfCart = CartItems.Count;
            CartItems.Remove(removeItemFromCart);
            if (CartItems.Count == previousCountOfCart - 1)
                return true;
            else return false;
        }

    }

}