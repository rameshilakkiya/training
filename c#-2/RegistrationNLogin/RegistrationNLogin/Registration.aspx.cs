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
    public partial class Registration : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            String query = "insert into users values(@name,@email,@mobile,@password)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name",nametext.Text);
            cmd.Parameters.AddWithValue("@email",emailtextbox.Text);
            cmd.Parameters.AddWithValue("@mobile",mobiletext.Text);
            cmd.Parameters.AddWithValue("@password",passtextbox.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "script", "alert('Regisration Successfully for user: " + nametext.Text + "and password is: " + passtextbox.Text + "');", true);
                ClearControls();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>alert('Registration Failed!!')</script>");
            }
            con.Close();
        }
        void ClearControls()
        {
            nametext.Text = emailtextbox.Text = mobiletext.Text = passtextbox.Text = confirmtext.Text = "";
        }
    }
}