using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1basicsofcsharp
{
    internal class CoronaTest
    {
        public static void ee()
        {
           
            CoronaDashBoard dash = new CoronaDashBoard();
            Console.WriteLine("CORONA LIST");
            Corona s = new Corona(40, "Maharashtra", 8000, 7000, 8000, 90000);
            Corona s1 = new Corona(43, "Kerala", 6000, 4000, 900, 8000);
            Corona s2 = new Corona(50, "Karnataka", 9000, 5000, 700, 6000);
            Corona s3 = new Corona(80, "Tamil Nadu", 2000, 8000, 400, 4000);
            Corona s4 = new Corona(60, "Andhra Pradesh", 4000, 7000, 200, 2000);
            dash.addCoronaData(s);
            dash.addCoronaData(s1);
            dash.addCoronaData(s2);
            dash.addCoronaData(s3);
            dash.addCoronaData(s4);
            dash.listCoronaData();
            Corona u = new Corona(60, "Andhra Pradesh", 4000, 7000, 200, 2000);
            u.active -= 10; u.total -= 10;
            dash.updateCoronaData(u);
            
            Corona d = new Corona(43, "Kerala", 6000, 4000, 900, 8000);
            dash.deleteCorona(d);
            dash.listCoronaData();
            dash.displayTopStates();
            
        }
    }
}
