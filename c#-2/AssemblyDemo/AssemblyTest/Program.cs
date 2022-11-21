using AssemblyTest;
using CalculatorLib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Class1 calc=new Class1();
        calc.add(10, 20);
        ElectricityBill bill = new ElectricityBill();
        Console.Write("Enter your Unit Value: ");
        var val=Convert.ToInt32(Console.ReadLine());
        var res=bill.CalculateBill(val);
        Console.WriteLine($"Your Electricity Bill for {val} is: { res}Rs/-");
        Console.WriteLine("**********Reflection on Electricity Bill**********");
        bill.Ref();
        /*ReflectionDemo dem=new ReflectionDemo();
       
        dem.demo1();*/
       
       
        
       

        
    }
}