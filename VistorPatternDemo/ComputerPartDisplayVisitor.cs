using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPatternDemo
{
    //创建实现访问者接口的实体类
    class ComputerPartDisplayVisitor:ComputerPartVisitor
    {
        public void visit(Computor computor)
        {
            Console.WriteLine("Displaying Computor!");
        }

        public void visit(Keyboard keyboard)
        {
            Console.WriteLine("Displaying keyboard!");
        }

        public void visit(Monitor monitor)
        {
            Console.WriteLine("Displaying monitor!");
        }

        public void visit(Mouse mouse)
        {
            Console.WriteLine("Displaying mouse!");
        }
    }
}
