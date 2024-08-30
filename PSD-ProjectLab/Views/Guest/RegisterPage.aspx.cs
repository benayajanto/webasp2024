using PSD_ProjectLab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_ProjectLab.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_btn_Click(object sender, EventArgs e)
        {
            String usernameText = username_textbox.Text;
            String passwordText = password_textbox.Text;
            String emailText = email_textbox.Text;
            String confirmText = confirmpass_textbox.Text;
            String gender = RadioButtonList.SelectedValue;
            DateTime date = DOB_Cal.SelectedDate;
            String response = AuthController.validateRegister(usernameText, emailText, passwordText, confirmText, gender, date);
            if (response == "ok")
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                errormessage.Text = response;
                errormessage.ForeColor = System.Drawing.Color.Red;
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}