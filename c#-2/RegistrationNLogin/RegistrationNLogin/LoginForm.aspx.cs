using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationNLogin
{
    public partial class LoginForm : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            String query = "Select * from users where name=@nam and password=@pas";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nam",name.Text);
            cmd.Parameters.AddWithValue("@pas",passtext.Text);
            con.Open();
            SqlDataReader dr=cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Session["name"]=name.Text;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Login Successful !!')</script>");
                Response.Redirect("DashBoard.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Login Failed UserName is not Exit You have to Register First**!!')</script>");
            }
            con.Close();
        }
    }
}