using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1basicsofcsharp
{
    internal class CoronaDashBoard
    {
        public List<Corona> listCorona = new List<Corona>();
        public void addCoronaData(Corona corona)
        {
            listCorona.Add(corona);
            //listCorona.Add(new Corona(code, name, active, recorded, death, total));
        }
        public void updateCoronaData(Corona cor)
        {
            Console.WriteLine("After Updation");
            foreach(var item in listCorona)
            {
                if (item.name == cor.name)
                {
                    listCorona[listCorona.IndexOf(item)] = cor;
                    break;
                }
            }
            foreach(var i in listCorona)
            {
                Console.WriteLine(i.info());
            }
        }
        int ind = -1;
        public List<int> a =new List<int>();
        int b;
        
        public void displayTopStates()
        {
            int code = 0;
            double maxdeath = 0;
            foreach (var rate in listCorona)
            {
                if((float)rate.death * 100 / rate.total > maxdeath)
                {
                    code = rate.code;
                    maxdeath = (float)rate.death * 100 / rate.total;
                }
                Console.WriteLine(maxdeath);
                //a.Add( rate.death);
                //b = a.Max()%100;
                
            }
            foreach(var rate in listCorona)
            {
                if (code == rate.code)
                {
                    Console.WriteLine($"State with {rate.name} Highest Death rate is: {rate.death}");
                }
            }
            /*Console.Write("Top death rate is Maharashtra");
            Console.WriteLine(b);*/
        }
        public void deleteCorona(Corona corona)
        {
            Console.WriteLine("After Deleted");  
            foreach(var dele in listCorona)
            {
                if (dele.name == corona.name)
                {
                    ind = listCorona.IndexOf(dele);
                    break;
                }
            }
            listCorona.RemoveAt(ind);
        }
        public void listCoronaData()
        {

            foreach (var item in listCorona)
            {
                Console.WriteLine(item.info());
            }
        }
    }
}
