using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace autocomplete
{
    public partial class loadmore : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        int num = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                num = 5;
                ViewState["num"] = num;
                BindRepeaterWithDB(num);
            }

        }
        void BindRepeaterWithDB(int NoOfRows)
        {
            int rowCount = GetTotalRowsOfTable();
            if (NoOfRows>rowCount)
            {
                LoadButton.Visible = false;
            }
            SqlConnection con=new SqlConnection(cs);
            string query = "select top(@val) * from empp";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            sda.SelectCommand.Parameters.AddWithValue("@val",NoOfRows);
            DataTable data = new DataTable();
            sda.Fill(data);
            if(data.Rows.Count > 0)
            {
                Repeater1.DataSource = data;
                Repeater1.DataBind();
            }
            else
            {
                Repeater1.DataSource = null;
            }

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            int numValue = Convert.ToInt32(ViewState["num"]) + 5;
            BindRepeaterWithDB(numValue);
            ViewState["num"] = numValue;
        }
        int GetTotalRowsOfTable()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select count(*) from empp";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            int rowCount=Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return rowCount;
        }
    }
}