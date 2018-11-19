using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternDemo
{
    class Program
    {
        //中介者模式
        //目的:降低多个对象和类之间的通讯复杂度
        //实现方式：通常提供了一个中介类，该类通常处理不同类中间的通讯，并支持松耦合，使代码易于维护
        //应用实例：MVC框架中C可以看做是V和M的中介者
        //优点：降低类的复杂度将一对多转换成一对一；符合迪米特原则（最少知道原则：一个实体应该尽量少的与其他实体之间发生相互关系，使得系统功能模块相对独立）
        //缺点：中介者会变得庞大，难以维护
        //注意事项：不应当在职责混乱的时候使用

        //对比：桥接者模式-抽象和实现分离-实现可能包含多个操作通过定义接口实现
        static void Main(string[] args)
        {
            User robert = new User("Robert");
            User john = new User("John");

            robert.ShowMessage("Hi,John");
            john.ShowMessage("Hello,Robert");

            Console.Read();
        }
    }
}
