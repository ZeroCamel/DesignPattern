using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCallBackDemo
{
    class Program
    {
        //首先创建一个回调对象,然后再创建一个控制器对象,将回调对象需要被调用的方法告诉控制器对象.
        //控制器对象负责检查某个场景是否出现或某个条件是否满足.当此场景出现或此条件满足时,自动调用回调对象的方法. 
        static void Main(string[] args)
        {
            //创建一个控制器对象，将提供给他的回调对象传入
            Controller c = new Controller(new CallBack());
            c.Star();
            
        }
    }
}
