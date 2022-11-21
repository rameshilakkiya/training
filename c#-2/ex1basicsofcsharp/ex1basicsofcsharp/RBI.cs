using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1basicsofcsharp
{
    internal class RBI
    {
        public virtual float rateofinterest()
        {
            float rate = 2.5f;
            return rate;
        }

    }
    internal class SBI : RBI
    {
        public override float rateofinterest()
        {
            float rate = 5f;
            return rate;
        }
    }
    internal class Tamilnadu : RBI
    {
        public override float rateofinterest()
        {
            float rate = 7f;
            return rate;
        }
    }
}
