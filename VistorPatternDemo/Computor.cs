using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPatternDemo
{
    //创建元素接口的实体类
    class Computor:ComputerPart
    {
        //对象数组
        ComputerPart[] parts;

        //构造函数注入
        public Computor()
        {
            parts = new ComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }
        public void accept(ComputerPartVisitor computerPartVisitor)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i].accept(computerPartVisitor);
            }
            computerPartVisitor.visit(this);
        }
    }
}
