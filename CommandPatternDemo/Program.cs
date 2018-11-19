using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo
{
    class Program
    {
        //命令模式-数据驱动的设计模式
        //逻辑：一般情况下，行为请求者和行为实现者是紧耦合的，将行为请求和行为实现封装成对象，实现松耦合
        static void Main(string[] args)
        {
            //实例化请求-行为请求者
            Stock abcStock = new Stock();

            //实例化命令-行为实现者
            BuyStock buyStock = new BuyStock(abcStock);
            SellStock sellSock = new SellStock(abcStock);

            //调用命令
            Broker broker = new Broker();
            broker.takeOrder(buyStock);
            broker.takeOrder(sellSock);

            broker.placeOrder();

            Console.Read();
        }
    }
}
