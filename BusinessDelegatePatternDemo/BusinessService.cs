using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePatternDemo
{
    /// <summary>
    /// 业务服务接口
    /// 远程通信技术
    /// 术语：服务消费方/服务提供方-本地调用
    /// 涉及技术：序列化和反序列化
    /// 成熟的技术：hessian、protobuf、thrift、avro
    /// 两种IO通信模型
    /// WebService
    /// 优点：跨语言 跨平台 有更大的独立性
    /// 缺点：不支持对象 不支持异步调用 无法在编译器检查错误 只能在运行时检查
    /// EJB-Enterprise Java Beans
    /// RMI-Remoter Method Invoke
    /// JNDI-Java Named Directory Interface - java命名和目录接口
    /// JMS-JAVA MESSAGE SERVICE
    /// </summary>
     interface BusinessService
    {
         void doProccessing();
    }
}
