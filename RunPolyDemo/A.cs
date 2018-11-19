using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunPolyDemo
{
    //A中定义虚函数，B中使用NEW 关键字重写修饰 ,C中使用OVERRIDE重写
    //错误 由于B中使用NEW修饰后隐藏其方法 所以C继承B重写方法失败
    class A
    {
        public virtual void x()
        {

        }
    }
}
