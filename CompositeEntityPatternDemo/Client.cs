using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEntityPatternDemo
{
    //客户端类
    class Client
    {
        private ComposityEntity composityEntity = new ComposityEntity();
        public void printData()
        {
            int length = composityEntity.getData().Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Data:"+composityEntity.getData()[i]);
            }
        }
        public void setData(string data1,string data2)
        {
            composityEntity.setData(data1, data2);
        }
    }
}
