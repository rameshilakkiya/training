using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Windows.Forms;

namespace projectlocalbusiness
{
    public partial class providerloged : System.Web.UI.Page
    {
        static string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["user"] != null)
            {
                Response.Write("Welcome" + Application["user"].ToString());
                //string name=Application["user"].ToString();

            }
            showAll();
        }
        void showAll()
        {
            //string name = Application["user"].ToString();
            SqlConnection con = new SqlConnection(cs);
            //string qu = "select serviceprovider.serviceid,userid,serviceprovider.status,date,rating,comment,services.name as serviceName,users1.name as ProviderName from users1 cross join services,serviceprovider where serviceprovider.serviceid=2 and services.Id=2 and users1.Id=(select Id from users1 where email=@nam);\r\n";
            string query = " select * from serviceprovider where userid=(select Id from users1 where email=@nam)";
            
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nam", Application["user"].ToString());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string d = DateTime.UtcNow.ToString("yyyy-MM-dd");
            int usid = -1;
            int sid = -1;
            SqlConnection con = new SqlConnection(cs);
            //string cm = "insert into serviceprovider(status,date,rating,comment,serviceid,userid)Values('r',@d,3,@des,@sid,@userid)";
            string q = "select Id from users1 where email=@ema";
            SqlCommand cmd1=new SqlCommand(q, con);
            cmd1.Parameters.AddWithValue("@ema", Application["user"].ToString());
            con.Open();
            SqlDataReader dr=cmd1.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    usid = Convert.ToInt32(dr[0]);
                }
            }
            dr.Close();
            string s = "select Id from services where name=@nam";
            SqlCommand cmd2=new SqlCommand(s, con);
            cmd2.Parameters.AddWithValue("@nam", nametext.Text);
            
            SqlDataReader dr1 = cmd2.ExecuteReader();
            if (dr1.HasRows)
            {
                while (dr1.Read())
                {
                    sid = Convert.ToInt32(dr1[0]);
                }
            }
            dr1.Close();
            
            //SqlCommand cmd = new SqlCommand("Insert into services(name,description,status)Values(@nam,@des,@stat)", con);
            SqlCommand cmd = new SqlCommand("insert into serviceprovider(status,date,rating,comment,serviceid,userid)Values('r',@d,3,@des,@sid,@uid)", con);
            cmd.Parameters.AddWithValue("@nam", nametext.Text);
            cmd.Parameters.AddWithValue("@d", d);
            cmd.Parameters.AddWithValue("@uid", usid);
            cmd.Parameters.AddWithValue("@sid", sid);
            cmd.Parameters.AddWithValue("@des", destext.Text);
            cmd.Parameters.AddWithValue("@ema", Application["user"].ToString());
            //cmd.Parameters.AddWithValue("@stat", 'I');
            //SqlCommand cmd1 = new SqlCommand("Insert into serviceprovider(serviceid,userid,status,date,rating,comment)Values(@sid,@userid,@sta,@da,@rat,@com)", con);
            //cmd1.Parameters.AddWithValue("@sid",)

            //con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Services Added Successfully");
        }
    }
}