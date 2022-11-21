using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace projectlocalbusiness
{
    public partial class services : System.Web.UI.Page
    {
        static string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["user"] != null)
            {
                Response.Write("Welcome" + Application["user"].ToString());
                //string name=Application["user"].ToString();

            }
            showall();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        void showall()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from servicebooking where serviceid=(select serviceid from serviceprovider where  userid=(select Id from users1 where email=@nam))";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@nam", Application["user"].ToString());
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
        void search()
        {
            string d = TextBox1.Text;
            //string f = d.ToString("yyy-MM-dd");
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from servicebooking where date=@dat and serviceid=(select serviceid from serviceprovider where  userid=(select Id from users1 where email=@nam))";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@dat", "6/8/1905");
            cmd.Parameters.AddWithValue("@nam", Application["user"].ToString());
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            search();
        }
    }
}