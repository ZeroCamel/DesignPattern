using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    class Program
    {
        //意图：将一个复杂的对象与其表示相分离，使得同样的构建过程可以创建不同的表示
        //优点：创建对象的最佳方式、建造者独立、已扩展、便于控制细节风险
        //缺点：产品有共同点、范围有限制
        //原则：依赖倒转-抽象不依赖于细节、细节应该依赖于抽象
        //适用：构建的对象有复杂的内部结构、内部属性相互依赖
        static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();
            Meal vegMeal = mealBuilder.prepareVegMeal();
            Console.WriteLine("Veg Meal");
            vegMeal.showItems();
            Console.WriteLine("Total Cost:" + vegMeal.getCost());

            Console.Read();
        }
    }
}
