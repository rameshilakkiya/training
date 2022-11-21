using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace formbasesecurity
{
    public partial class security1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (FormsAuthentication.Authenticate(nametext.Text, passtext.Text))
            if(AuthenticateUser(nametext.Text,passtext.Text))
            {
                //FormsAuthentication.RedirectFromLoginPage(nametext.Text,CheckBox1.Checked);
                FormsAuthentication.RedirectFromLoginPage(nametext.Text, CheckBox1.Checked);
            }
            else
            {
                Label3.Text = "Invalid User Name And/or Password";
            }
        }
        private bool AuthenticateUser(string username,string password)
        {
            string CS = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            using (SqlConnection con=new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spAuthenticateUser", con);
                cmd.CommandType=CommandType.StoredProcedure;
                string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");
                SqlParameter paramUsername = new SqlParameter("@UserName", username);
                SqlParameter paramPassword = new SqlParameter("@Password",EncryptedPassword);
                cmd.Parameters.Add(paramUsername);
                cmd.Parameters.Add(paramPassword);
                con.Open();
                int ReturnCode = (int)cmd.ExecuteScalar();
                return ReturnCode == -1;
            }

        }
    }
}