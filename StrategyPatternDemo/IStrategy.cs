using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    interface IStrategy
    {
        int doOperation(int num1,int num2);
    }
}
