using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    class Program
    {
        //策略模式
        //定义：一个类的行为和或其算法可以在运行时更改
        //意图：算法封装使得可以相互替换
        //关键代码：实现同一个接口
        //应用实例：1、诸葛亮锦囊妙计；2、旅游的出行方式；3、JAVA AWT 中的 LayoutManager。
        //优点：1、算法可自由切换，避免使用多重判断，扩展性良好
        //缺点：1、策略类会增多；2、所有策略类都需要暴露
        //使用场景：1、如果一个系统里面有许多类，他们之间的区别仅在于他的行为，使用策略模式可以动态地让一个对象在许多行为中选择一个行为；2、一个系统需要在几种算法中动态地选择几种；3、如果一个对象有很多地行为，如果不用恰当地模式这些行为就只好使用多重条件语句来实现
        //注意事项：如果一个策略模式多于四个，就要考虑混和模式，解决类膨胀地问题
        static void Main(string[] args)
        {
            Context context = new Context(new OperationAdd());
            Console.WriteLine("10 + 5 = " + context.executeStrategy(10, 5));

            context = new Context(new OperationSubject ());
            Console.WriteLine("10 - 5 = " + context.executeStrategy(10, 5));

            context = new Context(new  OpearationMultiply());
            Console.WriteLine("10 * 5 = " + context.executeStrategy(10, 5));

            Console.Read();
        }
    }
}
