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
    public partial class showsprovider : System.Web.UI.Page
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
        void showall()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from serviceprovider where userid=(select Id from users1 where email=@nam)";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@nam", Application["user"].ToString());
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
    }
}