using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDemo
{
    class SingleObject
    {
        #region c#高级特性写法
        //private SingleObject() { }

        //private static readonly SingleObject instance = new SingleObject();

        #endregion

        #region 懒汉式-普通-c#
        //创建对象
        private static SingleObject instance = new SingleObject();

        //静态构造函数，保证类不会实例化
        private SingleObject() { }

        //获取唯一可用对象
        public static SingleObject getInstance()
        {
            return instance;
        }

        public void showMessage()
        {
            Console.WriteLine("Hello,World!");
        }
        #endregion

        #region 懒汉式-单例(加锁、效率低)-(经典写法、支持多线程)-c#

        ////volatie多用于多线程环境变量定义从Memory内存里读而不是从Cache缓存里读
        ////保证变量值是最新的
        //private volatile static SingleObject _instance = null;
        //线程锁
        //private static readonly object lockHelper = new object();

        ////私有构造函数不可以实例化
        //private SingleObject() { }

        //public static SingleObject CreateInstance()
        //{
        //    if (_instance == null)
        //    {
        //        lock (lockHelper)
        //        {
        //            if (_instance == null)
        //            {
        //                _instance = new SingleObject();
        //            }
        //        }
        //        return new SingleObject();
        //    }
        //    return _instance;
        //}
        #endregion

        #region 懒汉式-单例-(不安全、不支持多线程)-java版本
        //private static SingleObject instance = null;
        //private SingleObject() { }

        //public static SingleObject getInstance()
        //{
        //    if (instance == null)
        //    {
        //        return new SingleObject();
        //    }
        //    return instance;
        //}
        #endregion

        #region 懒汉式-单例-(效率低 、支持多线程) java-写法
        //private static SingleObject instance;
        //private SingleObject() { }

        //public static synchronized SingleObject getInstance()
        //{
        //    if (instance == null)
        //    {
        //        return new SingleObject();
        //    }
        //    return instance;
        //}
        #endregion

        #region 饿汉式 不常用 易产生垃圾对象 不加锁 效率高 -jdk1.5

        //private static SingleObject instance = new SingleObject();

        //private SingleObject() { }

        //public static SingleObject getInstance()
        //{
        //    return instance;
        //}
        #endregion

        #region 双检索/双重检验锁 DCL 多线程条件下保持高性能-jdk1.5

        //较难实现

        //private volatile static SingleObject instance;
        //private SingleObject() { }

        //public static SingleObject getInstance()
        //{
        //    if (instance==null)
        //    {
        //        synchornized(instance.class){
        //            if (true)
        //            {
        //                instance = new SingleObject();
        //            }
        //        }
        //    }
        //    return instance;
        //}

        #endregion

        #region 双检索/双重检验锁 DCL 多线程条件下保持高性能-jdk1.5

        //容易实现

        //private volatile static SingleObject instance;
        //private SingleObject() { }

        //public static SingleObject getInstance()
        //{
        //    if (instance==null)
        //    {
        //        synchornized(instance.class){
        //            if (true)
        //            {
        //                instance = new SingleObject();
        //            }
        //        }
        //    }
        //    return instance;
        //}

        #endregion

        #region 登记式

        #endregion

        #region 枚举

        #endregion
    }
}
