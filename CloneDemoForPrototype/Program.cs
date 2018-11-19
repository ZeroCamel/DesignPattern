using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneDemoForPrototype
{
    class Program
    {
        //浅copy-IColonable MemberWiseClonable 深copy-无自定义方法自己实现
        static void Main(string[] args)
        {
            #region student,classroom,ideepcopy,ishallowcopy

            Student s1 = new Student("a", 10);
            Console.WriteLine("s1=[" + s1 + "]");
            //指针式-浅copy
            Student s2 = (Student)s1.ShallowCopy();
            //完全分离-深copy
            //Student s2 = (Student)s1.DeepCopy(); 
            Console.WriteLine("s2=[" + s2 + "]");
            Console.WriteLine("-----------------------");

            s2.Name = "b";
            s2.Age = 20;
            s2.Room.RoomID = 2;
            s2.Room.RoomName = "Room2";

            Console.WriteLine("s1=[" + s1 + "]");
            Console.WriteLine("s2=[" + s2 + "]");

            Console.Read();

            #endregion

            #region drawbase
            //引用同一个对象 后面的赋值会覆盖类初始化的值
            //浅复制和深复制 后面的值不会覆盖类初始化的值
            ////DrawBase db = new DrawBase();
            ////Console.WriteLine(db.name);
            ////DrawBase b = db.Clone() as DrawBase;
            ////b.name = "b";
            ////Console.WriteLine(db.name);
            ////DrawBase c = b.Clone() as DrawBase;
            ////c.name = "c";
            ////Console.WriteLine(db.name);
            ////Console.WriteLine(object.ReferenceEquals(b, c));
            ////Console.Read();
            #endregion

            #region person,address

            //Person p = new Person();
            //Person a = p.Clone();
            //a._name = "c";
            //Console.WriteLine(p._name);
            //Person b = p.Clone1() as Person;
            //b._name = "b";
            //Console.WriteLine(p._name);
            //Console.Read();

            #endregion
        }
    }
}
