using PSD_ProjectLab.Controller;
using PSD_ProjectLab.Modules;
using PSD_ProjectLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_ProjectLab.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
      
        }

        protected void submit_button_Click(object sender, EventArgs e)
        {
            string usernameText = username_textbox.Text;
            string passwordText = password_textbox.Text;
            bool checkBox = RememberMe.Checked;
            Response<User> response = AuthController.validateLogin(usernameText, passwordText);
            if (response.Success)
            {
                var user = response.Payload;
                Session["user"] = user;
                if (checkBox)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = user.UserID.ToString();
                    cookie.Expires = DateTime.Now.AddHours(24);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("~/Views/HomePage.aspx");
            }
            else
            {
                errormessage.Text = response.Message;
                errormessage.ForeColor = System.Drawing.Color.Red;
            }
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }
    }
}