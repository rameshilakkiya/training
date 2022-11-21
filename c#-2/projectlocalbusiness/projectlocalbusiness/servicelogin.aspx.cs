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

namespace projectlocalbusiness
{
    public partial class servicelogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }*/
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (AuthenticateUser(nametext.Text, passtext.Text))
            //  if (FormsAuthentication.Authenticate(txtUserName.Text, txtPassword.Text))
            {
                //    FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, false);
                FormsAuthentication.RedirectFromLoginPage(nametext.Text, CheckBox1.Checked);
                Application["user"] = nametext.Text;
                Response.Redirect("providerloged.aspx");
            }
            else
            {
                Label1.Text = "Invalid User Name and/or password";
            }
            
        }
        private bool AuthenticateUser(string username, string password)
        {
            // ConfigurationManager class is in System.Configuration namespace
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            // SqlConnection is in System.Data.SqlClient namespace
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spAuthenticateUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // FormsAuthentication is in System.Web.Security
                string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");
                // SqlParameter is in System.Data namespace
                SqlParameter paramUsername = new SqlParameter("@UserName", username);
                SqlParameter paramPassword = new SqlParameter("@Password", EncryptedPassword);

                cmd.Parameters.Add(paramUsername);
                cmd.Parameters.Add(paramPassword);

                con.Open();
                int ReturnCode = (int)cmd.ExecuteScalar();
                return ReturnCode == 1;
            }
        }
        /*protected void ValidateUser(object sender,EventArgs e)
{
   int userId = 0;
   string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
   using(SqlConnection con=new SqlConnection(cs))
   {
       using(SqlCommand cmd = new SqlCommand("Validate_User"))
       {
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@Username", Login1.UserName);
           cmd.Parameters.AddWithValue("@Password", Login1.Password);
           cmd.Connection = con;
           con.Open();
           userId = Convert.ToInt32(cmd.ExecuteScalar());
           con.Close();
       }
       switch (userId)
       {
           case -1:
               Login1.FailureText = "Username and/or password is incorrect.";
               break;
           case -2:
               Login1.FailureText = "Account has not been activated.";
               break;
           default:
               Login1.FailureText = "Account has not been activated.";
               //FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
               break;
       }
   }
}*/
    }
}