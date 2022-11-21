using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCupT20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = null;
            try
            {
                using(con=new SqlConnection(cs))
                {
                    //int iid = Convert.ToInt32(id.Text);
                    String name = cname.Text;
                    int match=Convert.ToInt32(mplay.Text);
                    int won=Convert.ToInt32(wo.Text);
                    int los=Convert.ToInt32(lo.Text);
                    int poi = Convert.ToInt32(point.Text);
                    String query = "insert into wct2022 values(@name,@match,@won,@los,@poi)";
                    //String qu = "update wct2022 set name=@name,matches=@match,won=@won,lost=@los,points=@poi";
                    SqlCommand cmd=new SqlCommand(query, con);
                    //SqlCommand cm = new SqlCommand(qu, con);

                   
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@match", match);
                    cmd.Parameters.AddWithValue("@won", won);
                    cmd.Parameters.AddWithValue("@los", los);
                    cmd.Parameters.AddWithValue("@poi", poi);
                    con.Open();
                    int status = cmd.ExecuteNonQuery();
                    if (status > 0)
                    {
                        result.Text = "Insertion Successfully";
                    }
                    else
                    {
                        result.Text = "Insertion Failed";
                    }


                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            
            
        }

       
    }
}
