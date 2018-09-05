using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Controllers
{
    public class UserEntryPoint
    {
        static void Main(string[] args)
        {
            UserInteraction userInteraction = new UserInteraction();
            userInteraction.GetUserChoice();
        }
    }
}