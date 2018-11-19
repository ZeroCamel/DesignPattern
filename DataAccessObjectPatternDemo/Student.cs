using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjectPatternDemo
{
    /// <summary>
    /// 创建数值对象
    /// </summary>
    public class Student
    {
        private string name;
        private int rollNo;
        public Student(string name, int rollNo)
        {
            this.name = name;
            this.rollNo = rollNo;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getRollNo()
        {
            return this.rollNo;
        }
        public void setRollNo(int rollNo)
        {
            this.rollNo = rollNo;
        }
    }
}
