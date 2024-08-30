using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Factory
{
    public class CartFactory
    {
        public static Cart Create(int cartId,int userId,int makeupId, int quantity)
        {
            Cart cart = new Cart();
            cart.CartID = cartId;
            cart.MakeupID = makeupId;
            cart.Quantity = quantity;
            cart.UserID = userId;
            return cart;
        }
    }
}