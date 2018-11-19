using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunPolyDemo
{
    //加new virtual 修饰后 CC继承后便可以重写
    //用new和override可重写基类virtual的同签名函数

    //命名空间 并不是界定访问级别的 而是保证类的全局唯一性
    class BB:AA
    {
        public new virtual void X()
        {

        }
    }
}
