using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1basicsofcsharp
{
    internal class CWG
    {
        public int code { get; set; }
        public int year { get; set; }
        public int gold { get; set; }
        public int silver { get; set; }
        public int bronze { get; set; }
        public int total { get; set; }
        public String? name { get; set; }
     
        public string infor()
        {
            return $" Code : {code} Name : {name} Gold : {gold} Silver: {silver} Bronze: {bronze} Total: {total}";
        }
        public static void CWGTest()
        {
            var CWGList = new List<CWG>() {

            new CWG() { code= 101, name= "Australia", year = 2022,gold=67,silver=57,bronze=54,total=178 },
            new CWG() { code = 102, name = "England", year = 2022, gold = 57, silver = 66, bronze = 53, total = 178 },
            new CWG() { code = 103, name = "Canada", year = 2022, gold = 26, silver = 32, bronze = 34, total = 92 },
            new CWG() { code = 104, name = "India", year = 2022, gold = 22, silver = 16, bronze = 23, total = 61 },
            new CWG() { code = 105, name = "New Zealand", year = 2022, gold = 20, silver = 12, bronze = 17, total = 49 },
           
 };
            Console.WriteLine("TOP 5 COUNTRIES");


            foreach (var cwg in CWGList)
            {
                Console.WriteLine(cwg.infor());
            }
            Console.WriteLine("*****UPDATING*****");  
            foreach(var cwg in CWGList)
            {
                if(cwg.name=="India")
                {
                    cwg.gold += 2;
                    cwg.total += 2;
                    break;
                }
                
            }
            foreach (var cwg in CWGList)
            {
                Console.WriteLine(cwg.infor());
            }
            int ind=-1;
            foreach (var cwg in CWGList)
            {
                if (cwg.name == "Australia")
                {
                    ind = CWGList.IndexOf(cwg);
                    break;
                }
            }
            CWGList.RemoveAt(ind);
            Console.WriteLine("*****After Removed Australia*****");
            foreach (var cwg in CWGList)
            {
                Console.WriteLine(cwg.infor());
            }



        }
    }
}
