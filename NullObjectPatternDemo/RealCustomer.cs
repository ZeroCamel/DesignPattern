using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPatternDemo
{
    class RealCustomer:AbstractCustomer
    {
        public RealCustomer(string name)
        {
            this.name = name;
        }
        public override bool isNil()
        {
            return false;
        }

        public override string getName()
        {
            return name;
        }
    }
}
