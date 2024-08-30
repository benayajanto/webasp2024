using PSD_ProjectLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_ProjectLab.Views
{
    public partial class Navbar : System.Web.UI.MasterPage
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
                    CustomerPanel.Visible = true;
                    AdminPanel.Visible = false;
                }
                else if (user.UserRole == "Admin")
                {
                    CustomerPanel.Visible = false;
                    AdminPanel.Visible = true;
                }
            }
        }

        protected void logout_btn_Click(object sender, EventArgs e)
        {
            string[] cookies = Request.Cookies.AllKeys;
            foreach (string cookie in cookies)
            {
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
            }
            //Application["count_user"]
            Session.Remove("user");
            Response.Redirect("~/Views/Guest/LoginPage.aspx");
        }

        protected void profile_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ProfilePage.aspx");
        }

        protected void home_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void manage_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/ManageMakeup.aspx");
        }

        protected void order_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/ordermakeup.aspx");
        }

        protected void history_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/transactionhistory.aspx");
        }

        protected void orderqueue_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/handletransaction.aspx");
        }

        protected void transaction_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/TransactionReport.aspx");
        }
    }
}