using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcPatternDemo
{
    class Program
    {
        /// <summary>
        /// Mvp模式
        /// 应用范围:应用程序的分层开发
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Student stuModel = retriveStudentFromDatabase();

            StudentView stuView = new StudentView();
            StudentController contronl = new StudentController(stuModel,stuView);
            contronl.updateView();

            contronl.setStudentName("bb");
            contronl.updateView();
            Console.Read();
        }
        public static Student retriveStudentFromDatabase()
        {
            Student stuModel = new Student();
            stuModel.Name = "a";
            stuModel.RollNum = "1";
            return stuModel;
        }
    }
}
