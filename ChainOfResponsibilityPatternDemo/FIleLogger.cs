using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPatternDemo
{
    //抽象类子类：职责链3
    class FIleLogger : AbstractLogger
    {
        public FIleLogger(int level)
        {
            this.LEVEL = level;
        }
        protected override void write(string message)
        {
            Console.WriteLine("File logger::" + message);
        }
    }
}
