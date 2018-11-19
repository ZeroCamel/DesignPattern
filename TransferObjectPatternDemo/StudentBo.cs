using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjectPatternDemo
{
    //创建业务对象
    class StudentBO
    {
        //列表相当于一个数据库
        List<StudentVO> students;

        public StudentBO()
        {
            students = new List<StudentVO>();
            StudentVO student1 = new StudentVO("Rollver",0);
            StudentVO student2 = new StudentVO("Joho",1);
            students.Add(student1);
            students.Add(student2);
        }
        public void deleteStudent(StudentVO student)
        {
            students.Remove(students[0]);
            Console.WriteLine("Student：name-"+student.getName(),"rollNo-"+student.getRollNo()+"has deleted from database.");
        }
        public List<StudentVO> getAllStudents()
        {
            return students;
        }

        public StudentVO getStudent(int rollNo)
        {
            return students[rollNo];
        }
        public void updateStudent(StudentVO student)
        {
            students[student.getRollNo()].setName(student.getName());
            Console.WriteLine("Student：name-" + student.getName(), "rollNo-" + student.getRollNo() + "has update in the database.");
        }
    }
}
