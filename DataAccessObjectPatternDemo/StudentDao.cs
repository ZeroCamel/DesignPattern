using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjectPatternDemo
{
    /// <summary>
    /// 创建数据访问对象接口
    /// </summary>
    interface StudentDao
    {
        List<Student> getAllStudent();
        Student getStudent(int rollNo);
        void updateStudent(Student student);
        void deleteStudent(Student student);
    }
}
