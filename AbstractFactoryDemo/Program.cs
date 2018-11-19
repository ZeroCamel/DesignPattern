using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    class Program
    {
        //产品族难扩展、产品等级易扩展

        //简单工厂-单一产品-对产品单维的抽象-单一工厂类
        //抽象工厂-多个产品-对产品多维的抽象-多个工厂类-抽象工厂接口
        static void Main(string[] args)
        {
            AbstractFactory shadeFactory = FactoryProducer.getFactory("shape");

            Shape strShape = shadeFactory.getShapType("circle");
            strShape.Draw();

            Shape strShape1 = shadeFactory.getShapType("rectangle");
            strShape1.Draw();

            Console.Read();
        }
    }
}
