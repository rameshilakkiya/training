using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1basicsofcsharp
{
    public class Loops
    {
        public static void ForLoop()
        {
            int start = 5, end = 50;
            Console.WriteLine("Forloop for printing 5's table");
            for(int i = start; i <= end; i += 5)
            {
                Console.WriteLine(i);
            }
        }
        public static void WhileLoop()
        {
            int start=2,end=20;
            Console.WriteLine("WhileLoop for printing 2's Table");
            while(start <= end)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
        public static void Forloopusingbreakandcontinue()
        {
            int start = 5, end = 50;
            Console.WriteLine("Printing 5 table without 25");
            for(int i = start; i <= end; i+=5)
            {
                if (i == 25)
                    continue;
                Console.WriteLine(i);
            }
            Console.WriteLine("Printing 5 table upto 10");
            for(int i = start; i <= end; i+=5)
            {
                Console.WriteLine(i);
                if (i == 10)
                    break;
            }
        }
    }
}
