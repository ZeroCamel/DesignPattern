using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservePatternDemo
{
    class Program
    {
        //观察者模式
        //解释：对象关系一对多；当一个的对象被修改时，自动通知他的依赖对象
        //本质：类与类之间通信
        //何时使用：一个对象的状态发生改变，所有的依赖对象都将得到通知，进行广播通知
        //应用实例：1、拍卖的时候，拍卖师观察最高标价通知给其他竞标者
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            new HexaObserver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);

            Console.WriteLine("First state change:15");
            subject.SetState(15);
            subject.nofityAllObservers();

            Console.WriteLine("Second state change:1010");
            subject.SetState(10);

            subject.nofityAllObservers();

            Console.Read();
        }
    }
}
