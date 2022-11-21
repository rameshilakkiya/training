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

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            SqlDataSource2.InsertParameters["name"].DefaultValue =
                ((TextBox)GridView1.FooterRow.FindControl("TextBox4")).Text;
            SqlDataSource2.InsertParameters["gender"].DefaultValue =
                ((DropDownList)GridView1.FooterRow.FindControl("footerddlname")).SelectedValue;
            SqlDataSource2.InsertParameters["class"].DefaultValue =
                ((TextBox)GridView1.FooterRow.FindControl("TextBox5")).Text;

            int a=SqlDataSource2.Insert();
            if (a > 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Insertion Successfully!!')</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Insertion Failed!!')</script>");

            }
        }
    }
}