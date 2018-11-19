using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Service
{
    //3、根据Adapter模式进行重构
    //意图：将一个接口转换成客户希望的另一个接口
    interface IcacheStorage
    {
        //包含的契约
        void Remove(string key);
        void Store(string key, object data);
        T Retrieve<T>(string key);
    }
}
