using PSD_ProjectLab.Controller;
using PSD_ProjectLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_ProjectLab.Views.Customer
{
    public partial class transactionhistory : System.Web.UI.Page
    {
        User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
            }
            else
            {

                if (Session["user"] == null)
                {
                    var id = Request.Cookies["user_cookie"].Value;
                    user = UserRepo.getUserbyID(Convert.ToInt32(id));
                    Session["user"] = user;
                }
                else
                {
                    user = (User)Session["user"];
                }
            }
            if (!IsPostBack)
            {
                
                if (user.UserRole == "Customer")
                {
                    Customer_panel.Visible = true;
                    Admin_panel.Visible = false;
                    List<TransactionHeader> header = TransactionController.getAllTransactionHeaderbyUserId(user.UserID);
                    GridView2.DataSource = header;
                    GridView2.DataBind();
                }
                else if (user.UserRole == "Admin")
                {
                    Customer_panel.Visible = false;
                    Admin_panel.Visible = true;
                    List<TransactionHeader> header = TransactionController.getAllTransactionHeader();
                    GridView1.DataSource = header;
                    GridView1.DataBind();
                }
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                int transactionId = Convert.ToInt32(row.Cells[0].Text);
                Response.Redirect("~/Views/Customer/transactiondetail.aspx?id=" + transactionId);
              
            }
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView2.Rows[index];
                int transactionId = Convert.ToInt32(row.Cells[0].Text);
                Response.Redirect("~/Views/Customer/transactiondetail.aspx?id=" + transactionId);

            }
        }
    }
}