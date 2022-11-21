using ex1basicsofcsharp;
using System.Security.Cryptography;
//using static ex1basicsofcsharp.Throw;

public class Program
{
    public static void Main(string[] args) //static calling by  .net
        
    {
        ReflectionDemo.demoref1();
        /*Console.WriteLine("Hello, World!");
        Console.WriteLine($"A:{2}");
        Program pgm=new Program();
        pgm.display();//without static we have to create object[pgm]
        convert();
        Operators.arithmaticOps();
        Operators.AssignmentOps();
        Loops.ForLoop();
        Loops.WhileLoop();
        Loops.Forloopusingbreakandcontinue();
        //Userinputs eli=new Userinputs();
        //eli.eligible();
        //sinterest.calc();//simple interest ass-1
        //sinterest.table();//printing tables
        //sinterest.convertmile();converting mile to kilometers
        //sinterest.convertcurrency();
        //Accountttbank*/
        /*Account ac1 = new Account(12345,"ilakk", "ilak@gmail.com", 9678574532, 3000);
        Account ac2 = new Account(1003, "Sadhan", "sadha@gmail.com", 8976564312, 90000);
        int options = 5, acc;
        bool flag = false;
        Account[] arr = { ac1,ac2};
        Console.Write("Enter Your AccountNo: ");
        acc=Convert.ToInt32(Console.ReadLine());
        do
        {
            foreach (Account a in arr)
            {
                if (a.accountnumber == acc)
                {
                    flag = true;
                    Console.Write("Select options:1-DepositAmt,2-WithdrawAmt,3-CheckBalance,4-Exit");
                    options = Convert.ToInt32(Console.ReadLine());
                    switch (options)
                    {
                        case 1:
                            a.Depositamt();
                            break;
                        case 2:
                            a.Withdrawamt();
                            break;
                        case 3:
                            a.checkBalance();
                            break;
                    }
                }
                if (!flag)
                {
                    Console.WriteLine("Accoun not exist");
                    Console.WriteLine("Enter your accno");
                    acc = Convert.ToInt32(Console.ReadLine());
                }
            }

        } while (options != 4);
        //ExceptionHandling.demoex1();*/
        CoronaTest.ee();





        /*Console.WriteLine(ac1.infor());
        Console.WriteLine(ac1.Depositamt(12345,50000f));
        Console.WriteLine(ac1.Withdrawamt(12345,600f));
        Console.WriteLine(ac1.checkBalance(12345));*/
        //arrayAccount.DepositAmt();

        /*methodoverloading result = new methodoverloading();
        int s1=result.Add(2, 3);
        Console.WriteLine(s1);
        Console.WriteLine(result.Add(30f, 40f,70f));
        RBI rbi = new SBI();
        Console.WriteLine(rbi.rateofinterest());
        rbi = new Tamilnadu();
        Console.WriteLine(rbi.rateofinterest());
        */
        //Interfacedemo.interfacetest();
        //Abstractdemo.abstracttest();
        /*ArrayListDemo.demo1();
        ArrayListDemo.demo2();
        ArrayListDemo.demo3();
        ArrayListDemo.demo4();
        ArrayListDemo.demo5();
        ArrayListDemo.demo6();
        ArrayListDemo.demo7();
        ArrayListDemo.demo8();*/
        /*ListDemo.demo1();
        ListDemo.demo2();
        ListDemo.demo3();
        ListDemo.demo4();   
        ListDemo.demo5();
        ListDemo.demo6();
        ListDemo.demo7();*/
        //CWG.CWGTest();
        /*DictionaryDemo.dicdemo1();
        DictionaryDemo.dicdemo2();
        DictionaryDemo.dicdemo3();
        DictionaryDemo.dicdemo4();
        
        ExceptionHandling.demoex2();
        ExceptionHandling.demoex3();
        ExceptionHandling.demoex4();

        //Throw.demothrow1(null);
        //Throw.demothrow2();*/
        //Throw.demoth3();





    }
    public void display()
    {
        int a = 10;
        float b = 200f;
        string s = "Ilakk";
        char ch = 'S';
        double db = 30000d;
        bool on = true;
        //long l = 30l;
        Console.WriteLine("Data Types of C#");
        Console.WriteLine(a);
        Console.WriteLine($"Float:{b}");
        Console.WriteLine($"String:{s}");
        Console.WriteLine($"Character:{ch}");
        Console.WriteLine($"Double:{db}");
        Console.WriteLine($"Bool:{on}");
        //Console.WriteLine($"Long:{l}");
    }
    static void convert()
    {
        int n1 = 3;
        float f1 = 33.00f;
        double d2 = n1;
        int n2 = (int) f1;
        Console.WriteLine("Type Convertion");
        Console.WriteLine(Convert.ToDouble(n1));
        Console.WriteLine("Implicit Casting");
        Console.WriteLine(d2);
        Console.WriteLine("Explicit Casting");
        Console.WriteLine(n2);

    }
}