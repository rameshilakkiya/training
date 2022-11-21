using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class ElectricityBill
    {
        
        public double CalculateBill(int units)
        {
            int amt;
            if (units <= 100)
                amt = units * 1;
            else if (units > 100 && units <= 200)
                amt = (100*1)+(units - 100) * 2;
            else if (units > 200 && units <= 300)
                amt= (100*1)+(100*2)+(units-200)*3;
            else
                amt= (100 * 1) + (100 * 2) + (100 * 3)+(units-300)*5;

            return amt;
        }
        public void Ref()
        {
            Assembly executing=Assembly.GetExecutingAssembly();
            Type[] type = executing.GetTypes();
            foreach(var item in type)
            {
                Console.WriteLine("Name: {0}", item.Name);
                MethodInfo[] method = item.GetMethods();
                Console.WriteLine("*****Methods*****");
                foreach (var mem in method)
                {
                    
                    Console.WriteLine("Methods: {0}", mem.Name);
                    ParameterInfo[] paramaters = mem.GetParameters();
                    Console.WriteLine("*****Paramaters*****");
                    foreach (var arg in paramaters)
                    {
                        Console.WriteLine("Parameters Name:{0} Parameters Type{1}",arg.Name,arg.ParameterType);
                    }

                }
            }
        }
    }
}
