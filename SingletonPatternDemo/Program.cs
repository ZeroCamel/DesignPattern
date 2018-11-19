using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDemo
{
    class Program
    {
        //非静态-多次占用和销毁
        //控制实例数目、节省系统资源、减少内存开销、避免对资源多重占用
        //单例模式的多重实现方式
        //1.懒汉式、线程不安全
        static void Main(string[] args)
        {
            SingleObject sinOb = SingleObject.getInstance();

            sinOb.showMessage();
        }
    }
}
