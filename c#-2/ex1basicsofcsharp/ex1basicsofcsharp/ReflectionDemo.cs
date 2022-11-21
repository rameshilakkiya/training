using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ex1basicsofcsharp
{
    public class ReflectionDemo
    {
        public static void demoref1()
        {
            Type t = typeof(string);
            Console.WriteLine("Name: {0}", t.Name);
            Console.WriteLine("FullName: {0}",t.FullName);
            Console.WriteLine("Namespace: {0}",t.Namespace);
            Console.WriteLine("Base Type: {0}",t.BaseType);
        }
    }
}
