using PSD_ProjectLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Handler
{
    public class OrderHandler
    {
        public static void addToCart(int userId,int makeupId, int qty)
        {
            OrderRepo.addToCart(userId, makeupId, qty);
        }

        public static List<Makeup> getAllMakeup()
        {
            List<Makeup>makeup= OrderRepo.getAllOrder();
            return makeup;
        }

        public static List<Cart> getAllOrderById(int id)
        {
            List<Cart> cart = OrderRepo.getAllOrderById(id);
            return cart;
        }

        public static void removeAllFromCart(int userId)
        {
            OrderRepo.removeAllFromCart(userId);
        }

        public static void checkoutCart(int userId, DateTime transactionDate, String status)
        {
            OrderRepo.checkoutCart(userId, transactionDate, status);
        }
    }
}