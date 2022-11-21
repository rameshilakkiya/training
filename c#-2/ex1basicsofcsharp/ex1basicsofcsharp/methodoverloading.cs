using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1basicsofcsharp
{
    internal class methodoverloading
    {
        public int Add(int n1, int n2)
        {
            int res = n1 + n2;
            Console.Write("add:");
            return res;
        }
        public float Add(float n1, float n2,float n3)
        {
            float res=n1+n2+n3;
            return res;
        }

    }
}
