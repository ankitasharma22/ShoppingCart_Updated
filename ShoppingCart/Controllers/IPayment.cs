using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Controllers
{
    interface IPayment
    {
        void SaveBookingDetails();
        //will update db will purchase record
        //will have: customer ID, itemID, itemCount, itemPrice

        void ReceiptDetails();
        //contains warranty details, receipt details etc
        
    }
}
