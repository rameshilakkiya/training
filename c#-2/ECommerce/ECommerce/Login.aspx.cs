using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ECommerce
{
    public partial class Login : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            String query = "Select * from users where email=@ema and password=@pas";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ema", emailtext.Text);
            cmd.Parameters.AddWithValue("@pas", passtext.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Session["email"] = emailtext.Text;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Login Successful !!')</script>");
                Response.Redirect("dashBoard.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Login Failed UserName is not Exit You have to Register First**!!')</script>");
            }
            con.Close();
        }
    }
}