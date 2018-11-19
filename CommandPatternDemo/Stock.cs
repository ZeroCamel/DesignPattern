using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo
{
    //创建请求类
    class Stock
    {
        private string name = "ABC";
        private int quantity = 10;

        public void buy()
        {
            Console.WriteLine("Stock-Buy[name:" + name + ",Quatity:" + quantity + "]");
        }

        public void sell()
        {
            Console.WriteLine("Stock-Sell[name:" + name + ",Quatity:" + quantity + "]");
        }
    }
}
