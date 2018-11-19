using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatterDemo
{
    class Program
    {
        //迭代器模式
        //特点:java 和 .net 编程环境中常用的设计模式，用于顺序访问集合对象的元素，不需要知道集合对象的底层显示
        //分类：行为型模式
        //应用实例：java中的Iterator
        //优点：1.支持以不同方式遍历一聚合对象；2、迭代器简化了聚合类；3、同一个聚合可以有多个遍历
        //      4、在迭代器模式中、增加新的聚合类和迭代器类很方便，无法修改原有代码
        //缺点：1、存储数据和遍历数据职责分离，增加新的聚合类需要增加新的迭代器类，类的个数成倍增加，一定程度上增加系
        //      统的复杂度
        //对比：与过滤器模式的区别
        static void Main(string[] args)
        {
            NameRepository nameRepository = new NameRepository();

            //for(i=0;i<10;i++)-->泛化-面向对象-->for(对象；bool值；可省略)
            for (Iterator iter = nameRepository.getIterator(); iter.hasNext(); )
            {
                string name = (string)iter.next();

                Console.WriteLine("NAME:" + name);
            }
            Console.Read();
        }
    }
}
