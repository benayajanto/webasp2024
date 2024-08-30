using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail Create(int transactionId,int makeupId,int qty)
        {
            TransactionDetail transactionDetail = new TransactionDetail();
            transactionDetail.TransactionID = transactionId;
            transactionDetail.MakeupID = makeupId;
            transactionDetail.Quantity = qty;
            return transactionDetail;
        }
    }
}