using PSD_ProjectLab.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Repository
{
    public class TransactionRepo
    {
        private static Database1Entities db = DatabaseManager.getInstance();
        public static List<TransactionHeader> getAllTransactionHeader()
        {
            return db.TransactionHeaders.ToList();
        }

        public static List<TransactionHeader> getAllTransactionHeaderbyUserId(int userId)
        {
            return (from x in db.TransactionHeaders where x.UserID == userId select x).ToList();
        }

        public static List<TransactionDetail> getTransactionDetailbyTransactionId(int transactionid)
        {
            return (from x in db.TransactionDetails where x.TransactionID == transactionid select x).ToList();
        }

        public static void HandleTransaction(int transactionId)
        {
            TransactionHeader header = db.TransactionHeaders.Find(transactionId);
            header.Status = "Handled";
            db.SaveChanges();
        }
    }
}