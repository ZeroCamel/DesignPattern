using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternDemo
{
    class Program
    {
        //代理模式
        //定义：一个类代表另一个类的功能
        //优点：职责清晰、高扩展、智能化
        //缺点：处理速度会变慢、增加了额外的处理工作和成本
        //应用实例：火车代售点、windows 快捷方式
        //使用场景：远程代理、虚拟代理
        //与其他模式的区别：适配器不同借口的不同功能的组合、代理模式不能改变代理类的接口；
        //装饰器是对功能的扩展、而代理模式是为了加以控制
        static void Main(string[] args)
        {
            Image image = new ProxyImage("test_10ml.jpg");

            //图像将从磁盘加载
            image.display();
            Console.WriteLine("");

            //图像将无法从磁盘加载
            image.display();

            Console.Read();
        }
    }
}
