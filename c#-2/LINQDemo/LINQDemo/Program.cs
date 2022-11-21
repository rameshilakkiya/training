using LINQDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter your num 1 or 2 or 3: ");
        int c=Convert.ToInt32(Console.ReadLine());
        switch(c){
            case 1:
                Console.WriteLine("Starting LINQ");
                demolinq.demo1();
                break;
                case 2:
                Console.WriteLine("\nUSing Lambda");
                demolinq.demo2Object();
                break;
            case 3:
               
                Console.WriteLine("\n LINQ query syntax");
                demolinq.linqquerydemo();
                break;
            default:
                Console.WriteLine("Enter Valid Number");
                break;
        }
        

        
       
        
    }
}