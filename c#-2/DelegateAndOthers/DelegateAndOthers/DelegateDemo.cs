using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndOthers
{
    //public delegate int Calculate(int n1, int n2);
    internal class Calculator
    {
        public static int Add(int n1,int n2)
        {
            return n1 + n2;
        }
    }
    internal class DelegateDemo
    {
        public static void demodelegate()
        {
            int result = 0;
            Calculator.Add(10, 20);
            result= Calculator.Add(10, 20);
            Console.WriteLine("regular method call: "+result);
        }
    }
}
