using PSD_ProjectLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Handler
{
    public class TransactionHandler
    {
        public static List<TransactionHeader> getAllTransactionHeader()
        {
            return TransactionRepo.getAllTransactionHeader();
        }

        public static List<TransactionHeader> getAllTransactionHeaderbyUserId(int userId)
        {
            return TransactionRepo.getAllTransactionHeaderbyUserId(userId);
        }

        public static List<TransactionDetail> getTransactionDetailbyTransactionId(int transactionid)
        {
            return TransactionRepo.getTransactionDetailbyTransactionId(transactionid);
        }

        public static void HandleTransaction(int transactionid)
        {
            TransactionRepo.HandleTransaction(transactionid);
        }
    }
}