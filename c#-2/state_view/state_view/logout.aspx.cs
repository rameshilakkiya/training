using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace state_view
{
    public partial class logout : System.Web.UI.Page
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            //if (Session["user"] != null)
            if(Application["user"]!=null)
            {
                Application["user"] = null;
                //Session["user"] = null;
                Response.Redirect("sessionstate.aspx");
            }
        }
    }
}