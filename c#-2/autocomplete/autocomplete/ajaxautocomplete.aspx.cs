using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace autocomplete
{
    public partial class ajaxautocomplete : System.Web.UI.Page
    {
        static string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]
        public static List<string> GetCompletionList(string prefixText,int count)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from city_tbl where cityname like @name+'%'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name",prefixText);
            List<string> CityNames = new List<string>();
            con.Open();
            SqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                CityNames.Add(dr["cityname"].ToString());

            }
            con.Close();
            return CityNames;
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void search()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from city_tbl where cityname=@name";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            sda.SelectCommand.Parameters.AddWithValue("@name", TextBox1.Text);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();


        }
        void showAll()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from city_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(cs);
            Session["city"] = TextBox1.Text;
            //showAll();
            
            //string query="select * from city_tbl where cityname=@name";
            //SqlCommand cmd = new SqlCommand(query, con);
            //con.Open();
            //cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //GridView1.DataSource = dt;
            //GridView1.DataBind();
            //con.Close();
            Response.Redirect("auto2.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            search();
        }
    }
}