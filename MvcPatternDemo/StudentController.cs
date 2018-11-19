using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcPatternDemo
{
    /// <summary>
    /// 控制器
    /// </summary>
    class StudentController
    {
        private Student model;
        private StudentView view;

        //控制器-构造函数注入
        public StudentController(Student studentModel, StudentView studentView)
        {
            this.model = studentModel;
            this.view = studentView;
        }

        public void setStudentName(string name)
        {
            model.setName(name);
        }

        public string getStudentName()
        {
            return model.getName();
        }

        public void setStudentRollName(string rollNo)
        {
            model.setRollNum(rollNo);
        }

        public string getStudentRollName()
        {
            return model.getRollNum();
        }

        public void updateView()
        {
            view.printStudentDetails(model.getName(),model.getRollNum());
        }
    }
}
