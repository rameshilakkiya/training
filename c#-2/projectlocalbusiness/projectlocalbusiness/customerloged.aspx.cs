using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace projectlocalbusiness
{
    public partial class customerloged : System.Web.UI.Page
    {
        static string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Application["user"] != null)
                {
                    Response.Write("Welcome" + Application["user"].ToString());
                    //string name=Application["user"].ToString();

                }
                showAll();
                
            }
            else { byname();
                    
            }
            
            
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
        void byname()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select users1.name as UserName,users1.Id as userid,email,mobile,city,location,address,zipcode, services.name as ServiceName,services.Id as serviceid,description ,serviceprovider.Id as spid,serviceprovider.status from users1 cross join services,serviceprovider  where users1.roleid = 2  and services.name=@nam";
            SqlCommand cmd=new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.Parameters.AddWithValue("@nam", find.Text);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                byname();
            
            
        }
        

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Visible = true;

            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("gray");
                    row.ToolTip = String.Empty;
                    String sid;
                    sid = row.Cells[9].Text;
                    string spid;
                    spid = row.Cells[11].Text;
                    string userid;
                    userid = row.Cells[1].Text;
                    string des;
                    des = row.Cells[10].Text;
                    string stat;
                    stat = row.Cells[12].Text;
                    


                }
                else{
                    row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to slect this row";

                }
            }
            
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "click to select serviceprovider.";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int usid = -1;
            TextBox1.Visible = false;

            foreach (GridViewRow row in GridView1.Rows)
            {
                bool select1 = Convert.ToBoolean(GridView1.SelectedIndex);
                
                if (select1)
                {
                    string d =  DateTime.UtcNow.ToString("yyyy-MM-dd");
                   
                    SqlConnection con = new SqlConnection(cs);
                    string q = "select Id from users1 where name=@ema";
                    SqlCommand cmd1 = new SqlCommand(q, con);
                    cmd1.Parameters.AddWithValue("@ema", row.Cells[0].Text);
                    con.Open();
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            usid = Convert.ToInt32(dr[0]);
                        }
                    }
                    dr.Close();
                    SqlCommand cmd = new SqlCommand("Insert into servicebooking(date,serviceid,spid,userid,description,status,providerdescription)Values(@date,@sid,@spid,@userid,@des,@stat,@prodes)", con);
                    cmd.Parameters.AddWithValue("@date", d);
                    cmd.Parameters.AddWithValue("@sid", row.Cells[9].Text);
                    cmd.Parameters.AddWithValue("@spid", row.Cells[11].Text);
                    cmd.Parameters.AddWithValue("@userid", usid);
                    cmd.Parameters.AddWithValue("@des", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@stat", row.Cells[12].Text);
                    cmd.Parameters.AddWithValue("@prodes", row.Cells[10].Text);
                    //con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                }
                
                break;
            }
            MessageBox.Show("Booked");
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/myservices.aspx");
        }
    }
}