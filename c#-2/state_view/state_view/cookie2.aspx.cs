using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace state_view
{
    public partial class cookie2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user"];
            if (cookie != null)
            {
                Response.Write("Welcome " + cookie["user"].ToString());
            }
        }
    }
}