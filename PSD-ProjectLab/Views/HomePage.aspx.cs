using PSD_ProjectLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_ProjectLab.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
            }
            else
            {
                User user;
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
                name.Text = "Name: " + user.Username;
                role.Text = "Role: " + user.UserRole;
                if(user.UserRole == "Admin")
                {
                    AdminPanel.Visible = true;
                    List<User> users = UserRepo.GetAllUser();
                    UserData.DataSource = users;
                    UserData.DataBind();
                }
                else
                {
                    AdminPanel.Visible= false;
                }
            }
        }
    }
}