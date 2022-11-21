using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1basicsofcsharp
{
     public static class Operators
    {

        public static void arithmaticOps()
        {
            int n1 = 2;
            int n2 = 3;
            int result = n1 + n2;
            result = n1 % n2;
            Console.WriteLine("n1+n2:" +result);
            Console.WriteLine("n1%n2:" + result);
        }
        public static void AssignmentOps()
        {
            int a= 10;
            int b= 80;
            int c = a += 5;
            int d = b -= 2;
            Console.WriteLine("Assign+:" +c);
            Console.WriteLine("Assign-:" + d);
        }
        public static void comparisonOps()
        {
            int a = 10;
            int b = 80;
           Console.WriteLine("A is Big:");
            Console.WriteLine(a>b);
            Console.WriteLine("B is Big:");
            Console.WriteLine(b>a);
            Console.WriteLine("A and B are Same:");
            Console.WriteLine(a==b);
            Console.WriteLine(a!=b);
        }


    }

}
