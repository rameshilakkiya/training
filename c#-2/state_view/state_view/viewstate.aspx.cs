using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace state_view
{
    public partial class viewstate : System.Web.UI.Page
    {
        String a, b;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void restore_Click(object sender, EventArgs e)
        {
            if (ViewState["user"]!=null)
            {
                usertext.Text = ViewState["user"].ToString();

            }
            if (ViewState["pass"] != null)
            {
                passtext.Text = ViewState["pass"].ToString();

            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            ViewState["user"]=usertext.Text;
            ViewState["pass"] = passtext.Text;
            usertext.Text=String.Empty;
            passtext.Text=String.Empty;
            //Response.Redirect("state2.aspx");
        }
    }
}