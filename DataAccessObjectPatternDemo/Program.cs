using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjectPatternDemo
{
    class Program
    {
        /// <summary>
        /// 把低级的数据访问API或操作从高级的业务服务中分离出来
        /// 1、数据访问对象接口-该接口定义了在一个模型对象上要执行的标准操作
        /// 2、数据访问对象实体类（concreate class）-该类实现了上述的接口，该类负责从数据源获取数据，数据源可以
        ///    是数据库，也可以是XML，或者是其他的存储机制
        /// 3、模型对象/数据对象
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            StudentDao studentDao = new StudentDaoImp();

            foreach (Student std in studentDao.getAllStudent())
            {
                Console.WriteLine("Student:[RollNO:"+std.getRollNo()+",NAME:"+std.getName()+"]");
            }

            Student student = studentDao.getAllStudent()[0];
            student.setName("Michel");
            studentDao.updateStudent(student);
            Student student1 = studentDao.getAllStudent()[1];

            studentDao.getStudent(0);
            studentDao.deleteStudent(student1);
            Console.WriteLine("Student:[RollNO:" + student.getRollNo() + ",NAME:" + student.getName() + "]");

            foreach (Student std in studentDao.getAllStudent())
            {
                Console.WriteLine("Student:[RollNO:" + std.getRollNo() + ",NAME:" + std.getName() + "]");
            }
            Console.Read();
        }
    }
}
