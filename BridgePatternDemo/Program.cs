using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternDemo
{
    class Program
    {
        //目的：抽象化和实现化解耦分离
        //起点：在有多种可能会变化的情况下，类多层次继承会造成类爆炸，扩展不灵活
        //场景：一个类存在两个独立变化的维度，且这两个维度都需要扩展
        //注意：泛化-继承（is-a）强耦合的关系、父类变子类变
        //      
        //设计原则：开闭原则、优先使用合成/聚合复用原则-耦合度低  上层引用、下层实现
        static void Main(string[] args)
        {
            Shape redCircle = new Circle(100, 100, 10, new RedCircle());
            Shape greenCicle = new Circle(200, 200, 20, new GreenCircle());

            redCircle.draw();
            greenCicle.draw();

            Console.Read();
        }
    }
}
