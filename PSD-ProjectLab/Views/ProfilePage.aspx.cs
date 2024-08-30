using PSD_ProjectLab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_ProjectLab.Views
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User user;
                user = (User)Session["user"];
                txtUsername.Text = user.Username;
                txtEmail.Text = user.UserEmail;
                RadioButtonList1.SelectedValue = user.UserGender;
                DOBCalendar.SelectedDate = user.UserDOB;

            } 
        }

        protected void update_btn_Click(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            int id = user.UserID;
            String username = txtUsername.Text;
            String email = txtEmail.Text;
            String gender = RadioButtonList1.SelectedValue;
            DateTime date = DOBCalendar.SelectedDate;
            String response = AuthController.updateProfile(id, username, email, gender, date);
            if (response != "ok")
            {
                errormessage.Text = response;
                errormessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                errormessage.Text = "Success";
                errormessage.ForeColor = System.Drawing.Color.Green;
            }
        }

        protected void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            int id = user.UserID;
            String dbPass = user.UserPassword;
            String oldPass = txtOldPassword.Text;
            String newPass = txtNewPassword.Text;   
            String confirm = txtConfirmPassword.Text;
            String response = AuthController.updatePassword(id,dbPass,oldPass,newPass,confirm);
            if (response != "ok")
            {
                errormessage2.Text = response;
                errormessage2.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                errormessage2.Text = "Success";
                errormessage2.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}