using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eComProjectTemplate
{
    public partial class crudwithgrid : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                
                using (SqlConnection con = new SqlConnection(cs))
                {
                    using(SqlCommand cmd = new SqlCommand("GetCustomers"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType=CommandType.StoredProcedure;
                        using(SqlDataAdapter sda=new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable(); 
                            sda.Fill(dt);
                            GridView2.DataSource = dt;
                            GridView2.DataBind();
                        }
                    }
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}