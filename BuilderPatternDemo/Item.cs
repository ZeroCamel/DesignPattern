using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    //接口：食物条目
    public interface Item
    {
         string name();
         Packing pack();
         float price();
    }
}
