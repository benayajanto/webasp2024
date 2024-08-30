using PSD_ProjectLab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_ProjectLab.Views.Admin
{
    public partial class UpdateMakeup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void update_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["id"]);
            String name = name_txt.Text;
            int price = Convert.ToInt32(price_txt.Text);
            int weight = Convert.ToInt32(weight_txt.Text);
            int typeId = Convert.ToInt32(typeid_txt.Text);
            int brandId = Convert.ToInt32(brand_txt.Text);
            String response = MakeupController.updateMakeup(id,name, price, weight, typeId, brandId);
            if (response == "True")
            {
                errormessage.Text = "Success";
                errormessage.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                errormessage.Text = response;
                errormessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void back_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageMakeup.aspx");
        }
    }
}