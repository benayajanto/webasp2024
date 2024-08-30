using PSD_ProjectLab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_ProjectLab.Views.Admin
{
    public partial class handletransaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<TransactionHeader> header = TransactionController.getAllTransactionHeader();
                GridView1.DataSource = header;
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Handle")
            {
                int transactionID = Convert.ToInt32(e.CommandArgument);
                TransactionController.HandleTransaction(transactionID);

                List<TransactionHeader> header = TransactionController.getAllTransactionHeader();
                GridView1.DataSource = header;
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string status = DataBinder.Eval(e.Row.DataItem, "Status").ToString();
                Button handleButton = (Button)e.Row.FindControl("HandleButton");

                if (status != "Unhandled")
                {
                    handleButton.Visible = false;
                }
            }
        }
    }
}