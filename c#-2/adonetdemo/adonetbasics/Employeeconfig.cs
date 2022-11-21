using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetbasics
{
    internal class Employeeconfig
    {
        internal static void EmployeeCrud()
        {
            String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = null;
            try
            {
                using(con=new SqlConnection(cs))
                {
                    Console.Write("Employee Name: ");
                    String name=Console.ReadLine();
                    Console.Write("Employee Gender: ");
                    String gender=Console.ReadLine();
                    Console.Write("Employee Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Employee Salary: ");
                    decimal salary=Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Employee City: ");
                    String city = Console.ReadLine();
                    String query = "insert into employee_tbl values(@name,@gender,@age,@salary,@city)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    cmd.Parameters.AddWithValue("@city", city);
                    con.Open();
                    int status = cmd.ExecuteNonQuery();
                    if (status > 0)
                    {
                        Console.WriteLine("Insertion successful");
                    }
                    else
                    {
                        Console.WriteLine("Insertion failed");
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
