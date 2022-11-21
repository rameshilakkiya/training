using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace state_view
{
    public partial class _2state : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["user"] != null)
            if (Application["user"]!=null)
            {
                //Response.Write("Welcome" + Session["user"].ToString());
                Response.Write("Welcome" + Application["user"].ToString());
            }
            else
            {
                Response.Redirect("sessionstate.aspx");
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("logout.aspx");
        }
    }
}