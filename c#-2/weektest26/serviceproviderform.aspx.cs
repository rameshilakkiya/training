using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServiceProviderForm
{
    public partial class serviceproviderform : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into serviceprovider values(@name,@email,@mobile,@service,@addr,@loc,@city,@zipc)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name",nametext.Text.Trim());
            cmd.Parameters.AddWithValue("@email",mailtext.Text.Trim());
            cmd.Parameters.AddWithValue("@mobile",phonetext.Text.Trim());
            cmd.Parameters.AddWithValue("@service",DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("@addr",addtext.Text.Trim());
            cmd.Parameters.AddWithValue("@loc",DropDownList2.SelectedValue);
            cmd.Parameters.AddWithValue("@city",citytext.Text.Trim());
            cmd.Parameters.AddWithValue("@zipc",ziptext.Text.Trim());
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "script", "alert('Registration Successfull for  user: " + nametext.Text + "\\nEmail Id: " + mailtext.Text + "\\nMobile: " + phonetext.Text +"\\nServiceType: "+DropDownList1.SelectedValue+ "\\nAddress: " + addtext.Text + "\\nLocation: " + DropDownList2.SelectedValue  +"\\nCity: "+citytext.Text+ "\\nZipCode: " + ziptext.Text + "');", true);
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
            nametext.Text = mailtext.Text = phonetext.Text = DropDownList1.SelectedValue = addtext.Text = DropDownList2.SelectedValue = citytext.Text = ziptext.Text = " ";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ServicesearchForm.aspx");
        }
    }
}