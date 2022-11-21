using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class Registeration : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into users values(@name,@email,@mobile,@addr,@loc,@pass,@zipc)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", nametext.Text);
            cmd.Parameters.AddWithValue("@email", emailid.Text);
            cmd.Parameters.AddWithValue("@mobile", mobile.Text);
            cmd.Parameters.AddWithValue("@addr", address.Text);
            cmd.Parameters.AddWithValue("@loc", locc.Text);
            cmd.Parameters.AddWithValue("@pass", passtext.Text.Trim());
            cmd.Parameters.AddWithValue("@zipc", zip.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "script", "alert('Registration Successfull for  user: " + nametext.Text + "\\nEmail Id: " + emailid.Text +  "\\nMobile: " + mobile.Text + "\\nAddress: "+address.Text+ "\\nLocation: "+locc.Text+"\\nPassword is: " + passtext.Text.Trim() + "\\nZipCode: " + zip.Text + "');", true);
                ClearControls();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Registration Failed !!')</script>");
            }
            con.Close();
        }
        void ClearControls()
        {
            nametext.Text = emailid.Text=mobile.Text=address.Text=locc.Text=passtext.Text=zip.Text= "";
        }
    }
}