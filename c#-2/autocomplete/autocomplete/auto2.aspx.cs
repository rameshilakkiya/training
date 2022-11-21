using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace autocomplete
{
    public partial class auto2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["city"] != null)
            {
                Response.Write(Session["city"].ToString());
            }
            else
            {
                Response.Redirect("ajaxautocomplete.aspx");
            }
        }

    }
}