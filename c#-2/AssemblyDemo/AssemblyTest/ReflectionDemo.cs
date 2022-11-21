using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyTest
{
    internal class ReflectionDemo
    {
        class Student
        {
            public int RollNo { get; set; }
            public String Name { get; set; }
            public Student()
            {
                RollNo = 0;
                Name=String.Empty;
            }
            public Student(int rno,String n)
            {
                RollNo=rno;
                Name=n;
            }
            public void DisplayData()
            {
                Console.WriteLine("RollNo:{0}",RollNo);
                Console.WriteLine("Name: {0}",Name);
            }
        }
        
            public void demo1()
            {
                Assembly executing=Assembly.GetExecutingAssembly();
                Type[] types=executing.GetTypes();
                foreach(var item in types)
                {
                    Console.WriteLine("Class: {0}",item.Name);
                    MethodInfo[] methods=item.GetMethods();
                    foreach(var method in methods)
                    {
                        Console.WriteLine("Method: {0}",method.Name);
                        ParameterInfo[] parameters=method.GetParameters();
                        foreach(var arg in parameters)
                        {
                            Console.WriteLine("Parameters:{0} Type:{1}",arg.Name,arg.ParameterType);
                        }
                    }
                }
            }
        
    }
}
