using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOthers
{
    public delegate int Calculate(int n1,int n2);
    internal class Calculator
    {
        public static int Add(int n1,int n2)
        {
            Console.WriteLine(n1 + n2);
            return 0;
        }
        public  static int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }
        public int Multiply(int n1,int n2)
        {
            return n1 * n2;
        }
        public int Devision(int n1, int n2)
        {
            return n1 / n2;
        }
    }
    internal class DelegateDemo
    {
        public static void demoDelegate()
        {
            int result = 0;
            result = Calculator.Add(10, 20);
            Console.WriteLine("Regular method call: "+result);
            Calculate calc = new Calculate(Calculator.Add);
            result = calc.Invoke(30, 20);
            Console.WriteLine("Delegate method call: "+result);
            calc = Calculator.Subtract;
            result=calc.Invoke(30, 20);
            Console.WriteLine("Delegate Subtract call: "+result);
            Calculator cal = new Calculator();
            calc = cal.Multiply;
            result = calc.Invoke(2, 3);
            Console.WriteLine("Delegate Multiply call: "+result);
            calc = cal.Devision;
            result=calc.Invoke(10, 3);
            Console.WriteLine("Delegate Division call: " + result);
            Console.WriteLine("Multicast Delegate");//it will be work properly for without return
            Calculate calc1 = new Calculate(Calculator.Add);
            calc1 += Calculator.Subtract;
            int result1 = 0;
            result1= calc1.Invoke(30, 20);
            Console.WriteLine("RESULT: "+result1);




        }
    }
}
