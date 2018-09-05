using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Controllers
{
    public class GetItemBySpecificValue
    {
        ItemManager_DB itemsAvailable = new ItemManager_DB();


        public Item GetItemById(int itemID)
        {
            List<Item> database = itemsAvailable.GetDatabase();
            for (int i = 0; i < database.Count; i++)
            {
                if (database[i].Id == itemID)
                    return database[i];
            }
            return database[0]; //Default
        }
    }
}