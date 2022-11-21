using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET_GetttingStarted_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into emp values(@name,@email,@pass,@mobile,@dob,@sex,@education,@location)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", nametext.Text);
            cmd.Parameters.AddWithValue("@email", emailtext.Text);
            cmd.Parameters.AddWithValue("@pass", passtext.Text.Trim());
            cmd.Parameters.AddWithValue("@mobile", mobile.Text);
            cmd.Parameters.AddWithValue("@dob", Calendar1.SelectedDate);
            cmd.Parameters.AddWithValue("@sex", gender.Text);
            String edu;
            if (ug.Checked == true)
            {
                edu = ug.Text;
            }
            else if (pg.Checked == true)
            {
                edu = pg.Text;
            }
            else
            {
                edu = other.Text;
            }
            cmd.Parameters.AddWithValue("@education", edu);
            cmd.Parameters.AddWithValue("@location", DropDownList1.SelectedValue);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "script", "alert('Registration Successfull for  user: " + nametext.Text +" Email Id: "+emailtext.Text+ " and Password is: " + passtext.Text.Trim() + "  Mobile: " + mobile.Text + " D O B: " + Calendar1.SelectedDate + " Sex: " + gender.Text + "  Education: " + edu + " Location: " + DropDownList1.SelectedValue + "');", true);
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
            nametext.Text=emailtext.Text=passtext.Text=mobile.Text=gender.SelectedValue="";
        }

        protected void mal_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}