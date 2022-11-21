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
using AjaxControlToolkit;
using System.Windows.Forms;

namespace projectlocalbusiness
{
    public partial class myservices : System.Web.UI.Page
    {
        static string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            showAll();

        }
        void showAll()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = " select users1.name, services.name as Services, services.Id as ServiceId,description,status from users1 cross join services where users1.roleid = 2";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

       /* protected void Rating1_Click(object sender, AjaxControlToolkit.RatingEventArgs e)
        {
            *//*SqlConnection con = new SqlConnection(cs);
            string rate = e.Value.ToString();
            Label3.Text=e.Value;*/
           /* string query="Insert into"*//*
        }*/
       

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "click to select serviceprovider.";
            }
            //Label3.Text = Rating1.CurrentRating.ToString() ;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("gray");
                    row.ToolTip = String.Empty;
                    String sid;
                    sid = row.Cells[2].Text;
                    Label3.Text = sid;
                    
                    



                }
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to slect this row";

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                bool select1 = Convert.ToBoolean(GridView1.SelectedIndex);

                if (select1)
                {
                   

                    SqlConnection con = new SqlConnection(cs);
                    //string sid = row.Cells[2].Text;
                    SqlCommand cmd = new SqlCommand("update serviceprovider set rating=@rate,comment=@com where serviceid=@sid", con);
                    //cmd.Parameters.AddWithValue("@date", d);
                    
                    cmd.Parameters.AddWithValue("@sid", row.Cells[2].Text);
                    cmd.Parameters.AddWithValue("@rate", DropDownList1.SelectedValue);
                    cmd.Parameters.AddWithValue("@com", TextBox1.Text);
                    
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //break;
                    

                }
                //break;
            }
            
            //MessageBox.Show("Rating sucessfully");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}