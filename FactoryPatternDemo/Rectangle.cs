using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Permissions;

namespace FlyweightPatternDemo
{
    /// <summary>
    /// 实现接口的实体类：矩形
    /// </summary>
    [FileIOPermission(SecurityAction.Demand, Unrestricted = true)]
    public class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw().method.");
        }
    }
}
