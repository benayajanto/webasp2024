using PSD_ProjectLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_ProjectLab.Views.Admin
{
    public partial class ManageMakeup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Makeup> makeupList = MakeupRepo.getAllMakeup();
                GridView1.DataSource = makeupList;
                GridView1.DataBind();

                List<MakeupType> makeupTypeList = MakeupTypeRepo.getAllMakeupType();
                GridView2.DataSource = makeupTypeList;
                GridView2.DataBind();

                List<MakeUpBrand> makeupBrandList = MakeUpBrandRepo.getAllMakeupBrand();
                GridView3.DataSource = makeupBrandList;
                GridView3.DataBind();
            }
        }

        protected void insertMakeup_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/InsertMakeups.aspx");
        }

        protected void insertMakeuptype_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/InsertMakeUpType.aspx");
        }

        protected void insertMakeupBrand_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/InsertMakeUpBrands.aspx");
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            Response.Redirect("~/Views/Admin/UpdateMakeup.aspx?id=" + id);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            MakeupRepo.removeMakeup(id);
            List<Makeup> makeupList = MakeupRepo.getAllMakeup();
            GridView1.DataSource = makeupList;
            GridView1.DataBind();
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridView2.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            MakeupTypeRepo.removeMakeupType(id);
            List<MakeupType> makeupList = MakeupTypeRepo.getAllMakeupType();
            GridView2.DataSource = makeupList;
            GridView2.DataBind();
        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GridView2.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            Response.Redirect("~/Views/Admin/UpdateMakeupType.aspx?id=" + id);
        }

        protected void GridView3_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridView3.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            MakeUpBrandRepo.removeMakeupBrand(id);
            List<MakeUpBrand> makeupList = MakeUpBrandRepo.getAllMakeupBrand();
            GridView3.DataSource = makeupList;
            GridView3.DataBind();
        }

        protected void GridView3_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GridView3.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            Response.Redirect("~/Views/Admin/UpdateMakeupBrand.aspx?id=" + id);
        }
    }
}