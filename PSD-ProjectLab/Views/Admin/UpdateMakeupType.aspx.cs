using PSD_ProjectLab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_ProjectLab.Views.Admin
{
    public partial class UpdateMakeupType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void update_btn_Click(object sender, EventArgs e)
        {
            String name = name_txt.Text;
            int id = Convert.ToInt32(Request["id"]);
            String response = MakeupTypeController.updateMakeupType(id, name);
            if (response == "ok")
            {
                errormessage.Text = "Success";
                errormessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                errormessage.Text = response;
                errormessage.ForeColor= System.Drawing.Color.Red;
            }
        }

        protected void Back_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageMakeup.aspx");
        }
    }
}