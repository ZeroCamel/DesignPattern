using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheriDemo
{
    //只支持单类继承 不支持这种星型继承关系 请用接口实现
    //不允许环形依赖继承
    //子类对象可以直接赋值基类对象
    //基类对象赋值子类对象需要强制转换
    class Class1:Class2
    {
        //如果有意隐藏父方法，请使用关键字NEW
        //base中子类调用父类的函数和成员
        //父子进程通信Object是所有引用类型的基类
        public new void Display1()
        {
            Console.WriteLine("ClassA Display1");
            base.Display1();
        }
        public void Display()
        {
            Console.WriteLine("hh");
        }
    }
}
