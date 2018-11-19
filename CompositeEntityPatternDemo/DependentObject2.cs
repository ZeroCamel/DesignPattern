using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEntityPatternDemo
{
    //创建依赖对象
    class DependentObject2
    {
        private string data;
        public void setData(string data)
        {
            this.data = data;
        }
        public string getData()
        {
            return this.data;
        }
    }
}
