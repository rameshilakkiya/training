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

namespace projectlocalbusiness
{
    public partial class serviceprovider : System.Web.UI.Page
    {
        static string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            showAll();
        }
        void showAll()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select users1.name as CustomerName,email as CustomerEmail,mobile as CustomerContact,city as CustomerCity,location as CustomerLocation,address as CustomerAddress,zipcode as CustomerZipcode,servicebooking.Id as bookid,servicebooking.description as Problem from users1  cross join servicebooking where roleid = 3";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "click to select serviceprovider.";
            }
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
                    //sid = row.Cells[2].Text;
                   






                }
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to slect this row";

                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                /*for (int i = 0; i < GridView1.Columns.Count; i++)
                {
                    *//*String header = Gridview1.SelectedIndex.Cells[1].Text.ToString();
                    String cellText = row.Cells[i].Text;
                    
                    *//*if (row.Cells[row.Cells.Count - 2].Text == header)
                    {
                        Response.Write(row.Cells);
                    }*//*
                    //Response.Write(cellText);
                    Label1.Text = row.SelectedRow.Cells[1].Text.ToString();*//*
                   


                }*/
                bool select1 = Convert.ToBoolean(GridView1.SelectedIndex);

                if (select1)
                {

                    Label1.Text = row.Cells[7].Text;

                    SqlConnection con = new SqlConnection(cs);
                    //string sid = row.Cells[2].Text;
                    //update servicebooking set status = 'accept' where Id = 5
                    SqlCommand cmd = new SqlCommand("UPDATE serviceprovider SET serviceprovider.status = @sta FROM serviceprovider E, servicebooking C WHERE E.serviceid = @bid;update services set services.status=@sta from services s, serviceprovider E, servicebooking C where s.Id=@bid; UPDATE servicebooking  SET servicebooking.status = @sta FROM serviceprovider E, servicebooking C WHERE  C.serviceid=@bid;", con);
                    //cmd.Parameters.AddWithValue("@date", d);
                    cmd.Parameters.AddWithValue("@sta", DropDownList1.Text);
                    cmd.Parameters.AddWithValue("@bid", row.Cells[7].Text);



                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                   


                }
                break;
            }

        }
    }
}