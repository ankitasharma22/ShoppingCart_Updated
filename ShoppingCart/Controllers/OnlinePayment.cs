using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Controllers
{
    public class OnlinePayment : IPayment, ITotalCartAmount
    {
        public void ReceiptDetails()
        {
            throw new NotImplementedException();
        }

        public void SaveBookingDetails()
        {
            
        }

        public void SaveCardDetails()
        {
            //card transaction details, for future reference will be updated in the database
        }

        public decimal TotalAmount()
        {
            throw new NotImplementedException();
        }
    }
}