using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjectPatternDemo
{
    class Program
    {
        /// <summary>
        /// 传输对象模型-数据访问对象模型
        /// 定义：
        /// 从客户端向服务器一次性传递带有多个属性的字段，传输对象也被称为数值对象，
        /// 传输对象是一个具有getter/setter方法的简单POJO类，他是可以序列化的，所以他可以
        /// 通过网络传输，他没有任何的行为，服务器端的业务类通常从数据库读取数据
        /// 然后填充POJO,并把他发送到客户端并按值传递，客户端可以传输自己的传输对象，并把他传输给服务器
        /// 已便一次性的更新数据库中的数值
        /// 相关实体：
        /// 业务对象-为传输对象填充数据的业务服务
        /// 传输对象-简单的POJO类，只有设置或获取实体的方法
        /// 客户端-客户端可以发送请求或传输对象到业务对象
        /// 对象类型：
        /// PO-持久对象
        /// VO-值对象-通常用于业务层之间的数据传递
        /// DAO-数据访问对象-包含了各种数据库访问的方法
        /// BO-业务对象
        /// POJO-简单无规则的对象
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            StudentBO studentBusinessObject = new StudentBO();

            //输出所有的学生
            foreach (StudentVO student in studentBusinessObject.getAllStudents())
            {
                Console.WriteLine("Student: [RollNo : "
                + student.getRollNo() + ", Name : " + student.getName() + " ]");
            }

            //更新学生
            StudentVO student1 = studentBusinessObject.getAllStudents()[0];
            student1.setName("Michael");
            studentBusinessObject.updateStudent(student1);

            //获取学生
            studentBusinessObject.getStudent(0);
            Console.WriteLine("Student: [RollNo : "
            + student1.getRollNo() + ", Name : " + student1.getName() + " ]");
            Console.Read();
        }
    }
}
