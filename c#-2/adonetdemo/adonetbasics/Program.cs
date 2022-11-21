using adonetbasics;
using System.Data.SqlClient;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("ADO .NET");
        //Connection();
        //BasicCrud.ReadData();
        //BasicCrud.InsertData();
        //BasicCrud.UpdateData();
        BasicCrud.DeleteData();

    }
    static void Connection()
    {
        String cs = "Data Source=FWS-LP-1249\\SQLSERVER2019;Initial Catalog=demodb;Integrated Security=true;";
        SqlConnection con = new SqlConnection(cs);
        try
        {
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Connection has been successfully created");
            }
        }catch(SqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            con.Close();
        }

    }
}