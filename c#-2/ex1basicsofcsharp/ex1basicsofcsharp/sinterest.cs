using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1basicsofcsharp
{
    internal class sinterest
    {
        public static void calc()
        {
            Console.WriteLine("******SIMPLE INTEREST*****");
            Console.Write("Enter Profit:");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number or Years:");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Rate:");
            int r=Convert.ToInt32(Console.ReadLine());
            int total = (p * n * r) / 100;
            Console.WriteLine("Total Interest:"+total);

        }
        public static void table()
        {
            Console.WriteLine("*****Printing Tables*****");
            Console.Write("Enter Your Table Number:");
            int t=Convert.ToInt32(Console.ReadLine());
            int total;
            for(int i = 1; i <= 10; i++)
            {
                total = i * t;
                Console.WriteLine(i +"*" +t+ "=" +total);
            }
        }
        public static void convertmile()
        {
            Console.WriteLine("*****CONVERTING MILES TO KILOMETERS*****");
            Console.Write("Enter Miles value:");
            int mile=Convert.ToInt32(Console.ReadLine());
            float km = 1.609f;
            float value = mile * km;
            Console.WriteLine("Converted to KiloMeters:" + value);
        }
        public static void convertcurrency()
        {
            Console.WriteLine("*****CONVERTING CURRENCIES*****");
            Console.Write("Enter value:");
            int v = Convert.ToInt32(Console.ReadLine());
            float inr = 79.889012f;
            float usd = v * inr;
            float inr1 = 79.2421f;
            float eur = v * inr1;
            Console.WriteLine("Converted to USD to INR:" + usd);
            Console.WriteLine("Converted to EURO to INR:" + eur);

        }
    }
}
