using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace projectlocalbusiness
{
    public partial class adminlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ValidateUser(object sender, EventArgs e)
        {
            if(Login1.UserName=="admin" && Login1.Password == "ilak@123")
            {
                MessageBox.Show("Login Successfully");
                Response.Redirect("~/adminloged.aspx");
            }
            else
            {
                Label1.Text = "You are not a authorized person";
            }
        }
    }
}