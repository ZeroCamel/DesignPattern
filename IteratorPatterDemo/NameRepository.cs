using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatterDemo
{
    //创建了实现Container接口的实体类
    class NameRepository : Container
    {
        //静态：无法通过嵌套类型访问外部非静态成员
        public static string[] names = { "Robert", "John", "Julie", "Lora" };

        public Iterator getIterator()
        {
            return new NameIterator();
        }

        private class NameIterator : Iterator
        {
            int index;
            
            //是否存在下一个
            public bool hasNext()
            {
                if (index<names.Length)
                {
                    return true;
                }
                return false;
            }

            //下个实体对象
            public object next()
            {
                if (this.hasNext())
                {
                    return names[index++];
                }
                return null;
            }
        }
    }
}
