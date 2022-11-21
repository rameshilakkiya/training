using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxGettingStarted
{
    public partial class ajaxcalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1=int.Parse(TextBox1.Text);
            int n2=int.Parse(TextBox2.Text);
            int result = n1 + n2;
            Label3.Text = result.ToString();
            Label3.Visible = true;
        }
    }
}