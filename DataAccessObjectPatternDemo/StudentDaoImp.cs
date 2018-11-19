using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjectPatternDemo
{
    /// <summary>
    /// 创建了实现了上述接口的实体类
    /// </summary>
    public class StudentDaoImp : StudentDao
    {
        List<Student> students;
        public StudentDaoImp()
        {
            students = new List<Student>();
            Student student = new Student("A", 0);
            Student student1 = new Student("B", 1);
            students.Add(student);
            students.Add(student1);
        }
        public List<Student> getAllStudent()
        {
            return students;
        }

        public Student getStudent(int rollNo)
        {
            return students[rollNo];
        }

        public void updateStudent(Student student)
        {
            students[student.getRollNo()].setName(student.getName());
            Console.WriteLine("Student:Roll No " + student.getRollNo() + ",update from database!");
        }

        public void deleteStudent(Student student)
        {
            students.Remove(student);
            Console.WriteLine("Student:Roll No "+student.getRollNo()+",deleted from database!");
        }
    }
}
