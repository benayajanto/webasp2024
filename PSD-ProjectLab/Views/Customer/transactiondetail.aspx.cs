using PSD_ProjectLab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_ProjectLab.Views.Customer
{
    public partial class transactiondetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<TransactionDetail> detail = TransactionController.getTransactionDetailbyTransactionId(Convert.ToInt32(Request["id"]));
                GridView1.DataSource = detail;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/transactionhistory.aspx");
        }
    }
}