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
    public partial class adminloged : System.Web.UI.Page
    {
        static string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void showAll()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select users1.name as UserName,users1.Id as userid ,email,mobile,city,location,address,zipcode, services.name as ServiceName,services.Id as serviceid,description ,serviceprovider.Id as spid,serviceprovider.status from users1 cross join services,serviceprovider  where users1.roleid = 2 ";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
    }
}