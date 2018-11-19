using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPatternDemo
{
    //表示一个访问者的接口
    /// <summary>
    /// 接口里直接将类作为参数
    /// </summary>
    interface ComputerPartVisitor
    {
         void visit(Computor computor);
         void visit(Keyboard keyboard);
         void visit(Monitor monitor);
         void visit(Mouse mouse);
    }
}
