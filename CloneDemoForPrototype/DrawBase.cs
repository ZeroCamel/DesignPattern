using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneDemoForPrototype
{
    [Serializable]
    class DrawBase : System.Object, ICloneable
    {
        public string name = "jmj";
        public DrawBase() { }
        public object Clone()
        {
            return this as object;  //引用同一个对象
            //return this.MemberwiseClone();  //浅复制
            //return new DrawBase() as object;    //深复制
        }
    }
}
