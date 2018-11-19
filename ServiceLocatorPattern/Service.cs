using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    /// <summary>
    /// 创建服务接口
    /// </summary>
    public interface Service
    {
        string getName();
        void execute();
    }
}
