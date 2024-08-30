using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using PSD_ProjectLab.Handler;

namespace PSD_ProjectLab.Controller
{
    public class TransactionController
    {
        public static List<TransactionHeader> getAllTransactionHeader()
        {
            return Handler.TransactionHandler.getAllTransactionHeader();
        }

        public static List<TransactionHeader> getAllTransactionHeaderbyUserId(int userId)
        {
            return Handler.TransactionHandler.getAllTransactionHeaderbyUserId(userId);
        }

        public static List<TransactionDetail> getTransactionDetailbyTransactionId(int transactionid)
        {
            return Handler.TransactionHandler.getTransactionDetailbyTransactionId(transactionid);
        }

        public static void HandleTransaction(int transactionid)
        {
            Handler.TransactionHandler.HandleTransaction(transactionid);
        }
    }
}