using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class dashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null)
            {
                Response.Write("Welcome to Amazon Mr/Mrs : Email: " + Session["email"].ToString());
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["email"] != null)
            {
                Session["email"] = null;
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("products.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("searchProduct.aspx");
        }
    }
}