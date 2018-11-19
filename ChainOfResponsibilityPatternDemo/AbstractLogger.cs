using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPatternDemo
{
    //抽象类：日志记录级别
    public abstract class AbstractLogger
    {
        public static int INFO = 1;
        public static int DEGUG = 2;
        public static int ERROR = 3;

        protected int LEVEL;

        //责任链中的下一个元素
        protected AbstractLogger nextLogger;

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            this.nextLogger = nextLogger;
        }

        public void LogMessage(int level,string message)
        {
            if (this.LEVEL<=level)
            {
                write(message);
            }
            if (nextLogger!=null)
            {
                nextLogger.LogMessage(level,message);
            }
        }

        abstract protected void write(string message);
    }
}
