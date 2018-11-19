using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPatternDemo
{
    //定义一个表示元素的接口
    interface ComputerPart
    {
        void accept(ComputerPartVisitor computerPartVisitor);
    }
}
