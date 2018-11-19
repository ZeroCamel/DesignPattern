using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FlyweightPatternDemo
{
    class ShapeFactory
    {
        //java HashMap<string,Shape> circleMap=new HashMap();
        //HashMap是HashTable非线程安全的实现，效率可能高于HashTable
        private static Hashtable circleMap = new Hashtable();
        private static HashSet<string> circleMap2 = new HashSet<string>();
        public static Shape getCircle(string color)
        {
            Circle circle = circleMap[color] as Circle;

            if (circle == null)
            {
                circle = new Circle(color);
                circleMap.Add(color, circle);
                Console.WriteLine("Creating Circle of Color:" + color);
            }
            return circle;
        }
    }
}
