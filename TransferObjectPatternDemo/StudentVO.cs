using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjectPatternDemo
{
    //创建传输对象
    public class StudentVO
    {
        private string name;

        private int rollNo;
        public StudentVO(string name,int rollNo)
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
