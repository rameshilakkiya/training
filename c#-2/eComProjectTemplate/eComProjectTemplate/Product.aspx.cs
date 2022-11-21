using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eComProjectTemplate
{
    public partial class Product : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into products values(@cod,@nam,@description,@manufacturer,@price)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@cod", codtext.Text);
            cmd.Parameters.AddWithValue("@nam", nametext.Text);
            cmd.Parameters.AddWithValue("@description", descrip.Text);
            cmd.Parameters.AddWithValue("@manufacturer", manu.Text);
            cmd.Parameters.AddWithValue("@price", pri.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "script", "alert('Products Added Successfully Code: " + codtext.Text + " ProductName: " + nametext.Text + " Description: " + descrip.Text + "  Manufacturer: " + manu.Text + " Price: " + pri.Text + "');", true);
                ClearControls();
                //Response.Redirect("dashBoard.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Products Not Added !!')</script>");
            }
            //Response.Redirect("dashBoard.aspx");
            con.Close();
        }
        void ClearControls()
        {
            codtext.Text = nametext.Text = descrip.Text = manu.Text = pri.Text = "";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}