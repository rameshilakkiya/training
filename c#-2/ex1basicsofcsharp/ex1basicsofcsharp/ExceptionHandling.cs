using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static ex1basicsofcsharp.Throw;

namespace ex1basicsofcsharp
{
    internal class ExceptionHandling
    {
    
        public class Student
        {

            public string? StudentName { get; set; }
        }
        public static void demoex1()
        {
            try
            {
                Console.Write("Enter Number: ");
                var number = int.Parse(Console.ReadLine());
                Console.WriteLine("Square of {0} is {1}", number, number * number);
            }
            catch
            {
                Console.WriteLine("Error Occured: ");
            }
            finally
            {
                Console.WriteLine("Re-type Proper Value!!");
            }
        }
        /*public static void demoex2()
        {
            Console.WriteLine("EXCEPTION FILTERS");
            Console.Write("Please enter a number to divide 100: ");

            try
            {
                int num = int.Parse(Console.ReadLine());

                int result = 100 / num;

                Console.WriteLine("100 / {0} = {1}", num, result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero. Please try again.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Invalid operation. Please try again.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Not a valid format. Please try again.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred! Please try again.");
            }
        }
        public static void demoex3()
        {
            var divider = 0;

            try
            {
                try
                {
                    var result = 100 / divider;
                }
                catch
                {
                    Console.WriteLine("Inner catch");
                }
            }
            catch
            {
                Console.WriteLine("Outer catch");
            }
        }
        public static void demoex4()
        {
            Student std = null;

            var divider = 0;

            try
            {
                try
                {
                    var result = 100 / divider;
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Inner catch");
                }
            }
            catch
            {
                Console.WriteLine("Outer catch");
            }
        }*/
    }
}
