using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetbasics
{
    internal class BasicCrud
    {
        internal static SqlConnection GetConnection()
        {
            String cs = "Data Source=FWS-LP-1249\\SQLSERVER2019;Initial Catalog=demodb;Integrated Security=true;";
            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Connection has been created Successfully");
                }
                else
                {
                    Console.WriteLine("Failed to establish the connection");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //con.Close();
            }
            return con;
        }
        internal static void ReadData()
        {
            String query = "select * from Product";
            SqlConnection conn=GetConnection();
            SqlCommand cmd=new SqlCommand(query, conn);
            SqlDataReader dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("ProductID: " + dr[0] +" , "+"ProductName: " + dr[1]+", "+"SupplierId: " + dr[2]+", "+"CategoryId: " + dr[3]);
            }
            conn.Close();
        }
        internal static void InsertData()
        {
            String query = "insert into Product values(6,'TV',2,1)";
            SqlConnection conn = GetConnection();
            SqlCommand cmd=new SqlCommand(query,conn);
            int status=cmd.ExecuteNonQuery();
            if (status > 0)
            {
                Console.WriteLine("Insertion Successfull");
            }
            else
            {
                Console.WriteLine("Insertion Failed");
            }
            conn.Close();
        }
        internal static void UpdateData()
        {
            Console.WriteLine("Update Data");
            Console.Write("Enter product id to update productname");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Updated productname");
            String pname=Console.ReadLine();
            String query = "update Product set productName=@pname where productID=@id";
            SqlConnection conn = GetConnection();
            SqlCommand cmd=new SqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@pname", pname);
            int status = cmd.ExecuteNonQuery();
            if (status > 0)
            {
                Console.WriteLine("updated successful");
            }
            else
            {
                Console.WriteLine("updation failed!!");
            }
            conn.Close();

        }
        internal static void DeleteData()
        {
            Console.WriteLine("Delete data");
            Console.Write("Enter quantity  for deletion ");
            int qu = Convert.ToInt32(Console.ReadLine());
            String query = "delete from OrderDetails where Quantity=@qu";
            SqlConnection conn=GetConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@qu", qu);
            int status=cmd.ExecuteNonQuery();
            if (status > 0)
            {
                Console.WriteLine("deleted successfully");
            }
            else
            {
                Console.WriteLine("deletion failed");
            }
            conn.Close();
        }
    }
}
