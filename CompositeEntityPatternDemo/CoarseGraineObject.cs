using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEntityPatternDemo
{
    //创建粗粒度对象
    //该对象包含依赖对象，有自己的生命周期，也能管理依赖对象的生命周期
    //整合细节
    class CoarseGraineObject
    {
        DependentObject1 do1 = new DependentObject1();
        DependentObject2 do2 = new DependentObject2();

        public void setData(string data1,string data2)
        {
            do1.setData(data1);
            do2.setData(data2);
        }

        public string[] getData()
        {
            return new string[] { do1.getData(), do2.getData() };
        }
    }
}
