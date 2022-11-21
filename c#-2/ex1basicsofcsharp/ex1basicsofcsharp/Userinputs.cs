using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1basicsofcsharp
{
    internal class Userinputs
    {
        public void eligible()
        {
            Console.WriteLine("***********CHECKING AGE FOR VOTING*****************");
            Console.Write("Enter Your Name:");
            String name=Console.ReadLine();
            Console.WriteLine("Your Name:" +name);
            Console.Write("Enter Your Age:");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Age:" + age);
            if (age < 18)
            {
                Console.WriteLine("You are NotEligible to vote!!!");
            }
            else
            {
                Console.WriteLine("Congrats!! You are Eligible to Vote");
            }
        }
    }
}
