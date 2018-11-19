using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    class OpearationMultiply:IStrategy
    {
        public int doOperation(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
