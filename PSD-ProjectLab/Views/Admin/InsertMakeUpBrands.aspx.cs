using PSD_ProjectLab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_ProjectLab.Views.Admin
{
    public partial class InsertMakeUpBrands : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Back_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageMakeup.aspx");
        }

        protected void submit_btn_Click(object sender, EventArgs e)
        {
            String name = name_txt.Text;
            int rating = Convert.ToInt32(rating_txt.Text);
            String response = MakeUpBrandController.insertMakeUpBrand(name, rating);
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
    }
}