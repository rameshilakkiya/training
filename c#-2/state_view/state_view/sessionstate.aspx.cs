using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace state_view
{
    public partial class state2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*Session["user"] = TextBox1.Text;*/
            Application["user"] = TextBox1.Text;
            Response.Redirect("2state.aspx");
        }
    }
}