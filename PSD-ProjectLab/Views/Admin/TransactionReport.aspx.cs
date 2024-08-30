using PSD_ProjectLab.Dataset;
using PSD_ProjectLab.Handler;
using PSD_ProjectLab.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_ProjectLab.Views.Admin
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport report = new CrystalReport();
            CrystalReportViewer1.ReportSource = report;
            DataSet data = getData(Handler.TransactionHandler.getAllTransactionHeader());
            report.SetDataSource(data);
        }

        private DataSet getData(List<TransactionHeader> transactions)
        {
            DataSet ds = new DataSet();
            var headertable = ds.TransactionHeader;
            var detailtable = ds.TransactionDetail;
            foreach( TransactionHeader t in transactions )
            {
                var hrow = headertable.NewRow();
                hrow["TransactionId"] = t.TransactionID;
                hrow["User"] = t.UserID;
                hrow["TransactionDate"] = t.TransactionDate;
                decimal totalPrice = 0;
                foreach (TransactionDetail detail in t.TransactionDetail)
                {
                    var drow = detailtable.NewRow();
                    drow["TransactionId"] = detail.TransactionID;
                    drow["Item"] = detail.Makeup.MakeupName;
                    drow["Quantity"] = detail.Quantity;
                    drow["Price"] = detail.Makeup.MakeupPrice;
                    drow["Subtotal"] = detail.Quantity * detail.Makeup.MakeupPrice;
                    totalPrice += detail.Quantity * detail.Makeup.MakeupPrice;
                    detailtable.Rows.Add(drow);
                }
                hrow["TotalPrice"] = totalPrice;
                headertable.Rows.Add(hrow);
            }

            return ds;
        }
    }
}