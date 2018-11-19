using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEntityPatternDemo
{
    //创建组合实体
    class ComposityEntity
    {
        private CoarseGraineObject cgo = new CoarseGraineObject();

        public void setData(string data1,string data2)
        {
            cgo.setData(data1, data2);
        }
        public string[] getData()
        {
            return cgo.getData();
        }
    }
}
