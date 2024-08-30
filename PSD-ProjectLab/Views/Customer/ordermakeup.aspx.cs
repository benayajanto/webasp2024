using PSD_ProjectLab.Controller;
using PSD_ProjectLab.Modules;
using PSD_ProjectLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_ProjectLab.Views.Customer
{
    public partial class ordermakeup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Makeup> order = OrderController.getAllMakeup();
                if (order != null)
                {
                GridView1.DataSource = order;
                GridView1.DataBind();

                }
                User user = (User)Session["user"];
                int userId = Convert.ToInt32(user.UserID);
                List<Cart> cart = OrderRepo.getAllOrderById(userId);
                if (cart != null)
                {
                    GridView2.DataSource = cart;
                    GridView2.DataBind();

                }
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Buy")
            {
                User user = (User)Session["user"];
                int userId = Convert.ToInt32(user.UserID);
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                TextBox txtQuantity = (TextBox)row.FindControl("txtQuantity");
                int qty = Convert.ToInt32(txtQuantity.Text);
                Label errorMessage = (Label)row.FindControl("errormessage");
                int makeupId = Convert.ToInt32(row.Cells[7].Text);
                String response = OrderController.addToCart(userId, makeupId, qty);
                if (response == "ok")
                {
                    errorMessage.Text = "Success";
                    errorMessage.ForeColor = System.Drawing.Color.Green;
                    List<Cart> cart = OrderRepo.getAllOrderById(userId);
                    if (cart != null)
                    {
                        GridView2.DataSource = cart;
                        GridView2.DataBind();

                    }
                }
                else
                {
                    errorMessage.Text = response;
                    errorMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void clearCart()
        {
            User user = (User)Session["user"];
            int userId = Convert.ToInt32(user.UserID);
            OrderController.removeAllFromCart(userId);
            List<Cart> cart = OrderRepo.getAllOrderById(userId);
            if (cart != null)
            {
                GridView2.DataSource = cart;
                GridView2.DataBind();

            }
        }
        protected void clear_btn_Click(object sender, EventArgs e)
        {
            clearCart();
        }

        protected void checkout_btn_Click(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            int userId = Convert.ToInt32(user.UserID);
            String response = OrderController.checkoutCart(userId, DateTime.Now, "Unhandled");
            if (response == "ok")
            {
                errormessage2.Text = "Success";
                errormessage2.ForeColor = System.Drawing.Color.Green;
                clearCart();
            }
            else
            {
                errormessage2.Text = response;
                errormessage2.ForeColor= System.Drawing.Color.Red;
            }
        }
    }
}