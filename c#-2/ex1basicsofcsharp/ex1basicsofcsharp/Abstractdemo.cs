using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1basicsofcsharp
{
    internal abstract class Shape
    {
        public abstract void Draw();
        public void info()
        {
            Console.WriteLine("About Shapes");
        }
    
    }
    internal class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("It's circle");
            //throw new NotImplementedException();
        }
        public void Othershape()
        {
            Console.WriteLine("It's pentagon");
        }
    }

    internal class Abstractdemo
    {
        public static void abstracttest()
        {
            Shape shape = new Circle(); 
            shape.info();
            shape.Draw();
            Circle circle = new Circle();
            circle.Othershape();
        }

    }
}
