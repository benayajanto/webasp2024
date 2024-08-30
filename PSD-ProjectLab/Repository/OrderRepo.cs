using PSD_ProjectLab.Factory;
using PSD_ProjectLab.Modules;
using PSD_ProjectLab.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Repository
{
    public class OrderRepo
    {
        private static Database1Entities db = DatabaseManager.getInstance();
        public static List<Makeup> getAllOrder()
        {
            return db.Makeups.ToList();
        }

        public static List<Cart> getAllOrderById(int userId)
        {
            return (from x in db.Carts where x.UserID == userId select x).ToList();
        }

        private static int getId()
        {
            int lastID = (from x in db.Carts select x.CartID).ToList().LastOrDefault();
            if (lastID == 0)
            {
                lastID = 1;
            }
            else
            {
                lastID++;
            }
            return lastID;
        }

        private static int getTransactionId()
        {
            int lastID = (from x in db.TransactionHeaders select x.TransactionID).ToList().LastOrDefault();
            if (lastID == 0)
            {
                lastID = 1;
            }
            else
            {
                lastID++;
            }
            return lastID;
        }

        public static Cart findCartByMakeupId(int makeupId)
        {
            Cart cart = (from x in db.Carts where x.MakeupID == makeupId select x).FirstOrDefault();
            if (cart == null)
            {
                return null;
            }
            else
            {
                return cart;
            }
        }

        public static void addToCart(int userId, int makeupId,int quantity)
        {
            Cart cart = findCartByMakeupId(makeupId);
            if(cart == null)
            {
                int cartId = getId();
                Cart carts = CartFactory.Create(cartId,userId,makeupId,quantity);
                db.Carts.Add(carts);
                db.SaveChanges();

            }
            else
            {
                cart.Quantity += quantity;
                db.SaveChanges();
            }

        }
        public static void removeAllFromCart(int userId)
        {
            var itemsToRemove = db.Carts.Where(c => c.UserID == userId).ToList();
            db.Carts.RemoveRange(itemsToRemove);
            db.SaveChanges();
        }

        public static void checkoutCart(int userId,DateTime transactionDate,String status)
        {
            int transactionId = getTransactionId();
            TransactionHeader header = TransactionHeaderFactory.Create(transactionId, userId,transactionDate,status);
            db.TransactionHeaders.Add(header);
   
            List<Cart> cart = getAllOrderById(userId);
            foreach(Cart c in cart)
            {
                TransactionDetail detail = TransactionDetailFactory.Create(transactionId, c.MakeupID, c.Quantity);
                db.TransactionDetails.Add(detail);
                
            }
            db.SaveChanges();

        }
    }
}