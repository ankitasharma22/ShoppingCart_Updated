using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Controllers
{
    public class UserInteraction
    {
        public void GetUserChoice()
        {
            Constants message = new Constants();
            message.Welcome();
            int itemId = -1, countOfItems=-1;
            CartFunctionalities cartFunctionalities = new CartFunctionalities();
            message.AskForChoice();
 

            GetItemBySpecificValue getItem = new GetItemBySpecificValue();

            int userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("----Enter Item id to add----");
                    itemId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("----Enter number of items to be added----");
                    countOfItems = Convert.ToInt32(Console.ReadLine());

                    Item newItemInCart = getItem.GetItemById(itemId); 
                    cartFunctionalities.AddItemToCart(newItemInCart);
                    break;

                case 2:
                    Console.WriteLine("----Enter Item id to remove ----");
                    itemId = Convert.ToInt32(Console.ReadLine());
                    Item removeItemFromCart = getItem.GetItemById(itemId);
                    cartFunctionalities.RemoveItemFromCart(removeItemFromCart);
                    break;

                case 3:
                    cartFunctionalities.DisplayCartItems();
                    break;

                case 4:
                    TotalCartAmountCalculation total = new TotalCartAmountCalculation();
                    total.TotalAmount();
                    break;
 
            }
        }
    }
}