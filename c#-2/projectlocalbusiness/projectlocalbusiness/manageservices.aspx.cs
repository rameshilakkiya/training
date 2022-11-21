using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace projectlocalbusiness
{
    public partial class manageservices : System.Web.UI.Page
    {
        static string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            showAll();

        }
        void showAll()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select services.Id as ServiceID,name as ServiceName,description as AboutService,status as ServiceStatus from services";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Insert into services(name,description,status)Values(@nam,@des,@stat)", con);
            cmd.Parameters.AddWithValue("@nam", DropDownList1.Text);
            cmd.Parameters.AddWithValue("@des", TextBox1.Text);
            cmd.Parameters.AddWithValue("@stat", 'I');


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Services Added Successfully");
        }
    }
}