using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPatternDemo
{
    class Program
    {
        //责任链模式
        //实现方式：对请求的发送者和接收者进行解耦，如果被接收者不能解决接收者请求，以此类推
        //拦截的类都使用统一的接口
        //应用实例：击鼓传花，JS事件冒泡
        static void Main(string[] args)
        {
            AbstractLogger loggerChain = getChainLogger();
            loggerChain.LogMessage(AbstractLogger.DEGUG,"This is a Debug Message!");
            loggerChain.LogMessage(AbstractLogger.ERROR, "This is a Error Message!");
            loggerChain.LogMessage(AbstractLogger.INFO, "This is a Info Message!");

            Console.Read();
        }

        private static AbstractLogger getChainLogger()
        {
            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FIleLogger(AbstractLogger.DEGUG);
            AbstractLogger consoleLoger = new ConsoleLogger(AbstractLogger.INFO);

            //Error->file->console
            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLoger);

            return errorLogger;
        }
    }
}
