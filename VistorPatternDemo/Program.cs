using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPatternDemo
{
    class Program
    {
        //访问者模式
        //定义：使用一个访问者类，改变元素类的执行算法，元素的执行算法随着访问者的改变而改变
        //意图：数据结构和操作分离
        //优点：符合单一职责原则；优秀的扩展；灵活性
        //缺点：具体元素对访问者公布细节，违反了迪米特原则；具体元素变更比较困难；依赖于具体类，没有依赖抽象
        //使用场景：1、对象结构中对应的类很少改变，但经常需要在此对象结构上定义新的操作；2、需要一个对象结构中的对象进行很多不同的并且不相关的操作，需要对一个对象结构中的对象进行很多不同的并且不相关的操作，而需要避免让这些操作“污染”这些对象的类，也不希望在增加新操作时修改这些类
        //注意事项：访问者对功能进行统一，可以做报表、UI、拦截器与过滤器
        static void Main(string[] args)
        {
            Computor computor = new Computor();
            computor.accept(new ComputerPartDisplayVisitor());

            Console.Read();
        }
    }
}
