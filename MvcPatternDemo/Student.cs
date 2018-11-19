using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcPatternDemo
{
    public class Student
    {
        private string rollNum;

        public string RollNum
        {
            get { return rollNum; }
            set { rollNum = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getRollNum()
        {
            return this.rollNum;
        }
        public void setRollNum(string rollNum)
        {
            this.rollNum = rollNum;
        }

    }
}
