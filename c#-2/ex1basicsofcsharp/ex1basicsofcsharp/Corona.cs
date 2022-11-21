using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ex1basicsofcsharp
{
    internal class Corona
    {
        public int code { get; set; }
        public String name { get; set; }
        public int active { get; set; }
        public int recorded { get; set; }
        public int death { get; set; }
        public int total { get; set; }

        public String info()
        {
            return $"Code: {code} Name: {name} Active: {active} Recorded: {recorded} Death:{death} Total: {total}";
        }
        public Corona(int code,String name,int active,int recorded, int death, int total)
        {
            this.code = code;
            this.name = name;
            this.active = active;
            this.recorded = recorded;
            this.death = death;
            this.total = total;
        }
        
    }
    
    
    
}
