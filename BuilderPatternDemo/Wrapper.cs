using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    //打包接口的实体类
    public class Wrapper : Packing
    {
        public string pack()
        {
            return "Wrapper";
        }
    }
}
