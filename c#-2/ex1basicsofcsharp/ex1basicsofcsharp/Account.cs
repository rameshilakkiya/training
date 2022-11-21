using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ex1basicsofcsharp
{
    internal class Account
    {
        public int accountnumber;
        string name;
        string email;
        long mobile;
        int balance = 0;
        public Account(int accountnumber, string name, string email, long mobile, int balance)
        {
            this.accountnumber = accountnumber;
            this.name = name;
            this.email = email;
            this.mobile = mobile;
            this.balance = balance;
        }
       
        public void Depositamt()
        {
            Console.Write("Enter your depositamount: ");
            int d = Convert.ToInt32(Console.ReadLine());
            balance += d;


        }
        
        public void Withdrawamt()
        {


            try
            {
                Console.Write("Enter your Withdrawamount: ");

                int w = Convert.ToInt32(Console.ReadLine());
                //
                int bal;
                bal = balance - w; 
                if (bal>0)
                {
                    balance -= w;
                    
                }
                else
                {
                    throw new InsufficientAmountException();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

            

        }



        public void checkBalance()
        {
            Console.WriteLine("Available balance: " + balance);
        }

        [Serializable]


        private class InsufficientAmountException : Exception
        {
            public InsufficientAmountException()
            {
                Console.WriteLine("Insufficient balance");
            }

            public InsufficientAmountException(float w) : base("insufficientAmount")
            {
            }


        }
    }
}
