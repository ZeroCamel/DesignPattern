using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    class Context
    {
        private IStrategy IStrategy;

        public Context(IStrategy IStrategy)
        {
            this.IStrategy = IStrategy;
        }

        public int executeStrategy(int num1,int num2)
        {
            return IStrategy.doOperation(num1, num2);
        }
    }
}
