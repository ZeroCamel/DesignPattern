using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    //打包接口的实体类
    public class Bottle : Packing
    {
        public string pack()
        {
            return "Bottle";
        }
    }
}
