using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo
{
    //创建命令调用类
    class Broker
    {
        private List<Order> orderList = new List<Order>();

        public void takeOrder(Order order)
        {
            orderList.Add(order);
        }

        public void placeOrder()
        {
            foreach (Order order in orderList)
            {
                order.execute();
            }
            orderList.Clear();
        }
    }
}
