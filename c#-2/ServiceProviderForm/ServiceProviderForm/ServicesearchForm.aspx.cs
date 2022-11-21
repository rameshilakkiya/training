using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServiceProviderForm
{
    public partial class ServicesearchForm : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            showAll();
        }
        void showAll()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from serviceprovider";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
        void searchbyservice()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from serviceprovider where servicetype like '%"+inputtext.Text.Trim()+"%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@nam", inputtext.Text);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
        void searchbylocation()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from serviceprovider where location like '%" + inputtext.Text.Trim() + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@loc", inputtext.Text);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                searchbyservice();
            }
            else if(DropDownList1.SelectedIndex==1)
            {
                searchbylocation();
            }
            else{
                showAll();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedIndex == 0)
            {
                searchbyservice();
            }
            else if(DropDownList1.SelectedIndex==1)
            {
                searchbylocation();
            }
            else
            {
                showAll();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("serviceproviderform.aspx");
        }
    }
}