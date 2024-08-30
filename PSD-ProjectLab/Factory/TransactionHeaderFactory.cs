using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader Create(int transactionId,int userId,DateTime transactionDate, String status)
        {
            TransactionHeader transactionHeader = new TransactionHeader();
            transactionHeader.TransactionID = transactionId;
            transactionHeader.UserID = userId;
            transactionHeader.TransactionDate = transactionDate;
            transactionHeader.Status = status;
            return transactionHeader;
        }
    }
}