using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatterDemo
{
    interface Iterator
    {
        //bool 是 Boolean 的别名，成员是一样的
         Boolean hasNext();

        //聚合类对象
         object next();
    }
}
