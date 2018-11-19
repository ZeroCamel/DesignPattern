using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunPolyDemo
{
    class ClassB
    {
        //抽象方法是只有定义、没有实际方法体的函数，它只能在抽象函数中出现，并且在子类中必须重写；
        //虚方法则有自己的函数体，已经提供了函数实现，但是允许在子类中重写或覆盖。
        //重写的子类虚函数就是被覆盖了。

        //抽象方法必须是被派生类覆写的方法

        // 抽象方法

        //使用abstract关键字 public abstract bool Withdraw(…);

        //抽象方法是必须被派生类覆写的方法。

        //抽象方法是可以看成是没有实现体的虚方法

        //如果类中包含抽象方法，那么类就必须定义为抽象类，不论是否还包含其它一般方法

        //虚方法

        //使用virtual关键字 public virtual bool Withdraw(…);

        //调用虚方法，运行时将确定调用对象是什么类的实例，并调用适当的覆写的方法。

        //虚方法可以有实现体 若一个实例方法的声明中含有 virtual 修饰符，则称该方法为虚拟方法；

        //一个虚拟方法的实现可以由派生类取代。取代所继承的虚拟方法的实现的过程称为重写该方法；在一个虚拟方法调用中，该调用所涉及的那个实例的运行时类型确定了要被调用的究竟是该方法的哪一个实现。
        public virtual void AAA()
        {
            Console.WriteLine("ClassB AAA");
        }
        public virtual void BBB()
        {
            Console.WriteLine("ClassB BBB");
        }
        public virtual void CCC()
        {
            Console.WriteLine("ClassB CCC");
        }
    }
}
