using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectlocalbusiness
{
    public partial class serviceloginaspx : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int userid = 0;
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            using(SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand("Insert_User"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", nametext.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", emailtext.Text.Trim());
                        cmd.Parameters.AddWithValue("@Mobile", mobiletext.Text.Trim());
                        cmd.Parameters.AddWithValue("@City", citytext.Text.Trim());
                        cmd.Parameters.AddWithValue("@Location", loctext.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", addtext.Text.Trim());
                        cmd.Parameters.AddWithValue("@Zip", ziptext.Text.Trim());
                        string encryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(passtext.Text.Trim(), "SHA1");
                        SqlParameter password=new SqlParameter("@Password",encryptedPassword);
                        //string query = "Insert into serviceprovider";
                        cmd.Parameters.Add(password);
                        cmd.Parameters.AddWithValue("@Roleid",DropDownList1.SelectedValue.Trim());
                        cmd.Connection = con;
                        con.Open();
                        userid = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();


                    }

                }
                string message = string.Empty;
                switch (userid)
                {
                    case -1:
                        message = "username already exists";
                        break;
                    case -2:
                        message = "Emailid already exists";
                        break;
                        default:
                        message = "Registration successful";
                        
                        break;
                }
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('" + message + "');", true);
                Response.Redirect("~/servicelogin.aspx");
            }
            
            
        }
    }
}