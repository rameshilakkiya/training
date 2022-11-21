using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationNLogin
{
    public partial class DashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {
                Response.Write("Welcome to Amazon Mr/Mrs : Name: " + Session["name"].ToString());
            }
            else
            {
                Response.Redirect("LoginForm.aspx");
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {
                Session["name"] = null;
                Response.Redirect("LoginForm.aspx");
            }
        }
    }
}