using PSD_ProjectLab.Handler;
using PSD_ProjectLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Controller
{
    public class OrderController
    {
        public static String addToCart(int userId, int makeupId, int qty)
        {
            if (qty <= 0)
            {
                return "Quantity must be greater than 0";
            }

            OrderHandler.addToCart(userId, makeupId, qty);
            return "ok";

        }

        public static List<Makeup> getAllMakeup()
        {
            List<Makeup> makeup = OrderHandler.getAllMakeup();
            return makeup;
        }

        public static List<Cart> getAllOrderById(int id)
        {
            List<Cart> cart = OrderHandler.getAllOrderById(id);
            return cart;
        }

        public static void removeAllFromCart(int userId)
        {
            OrderHandler.removeAllFromCart(userId);
        }

        public static String checkoutCart(int userId, DateTime transactionDate, String status)
        {
            List<Cart> cart = getAllOrderById(userId);
            if (cart.Count != 0)
            {
                OrderHandler.checkoutCart(userId, transactionDate, status);
                return "ok";
            }
            else
            {
                return "Cart is empty!";
            }
        }
    }
}