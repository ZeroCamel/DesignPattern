using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpaterPatternDemo
{
    class Program
    {
        //解释器模型
        //用途：sql解析、符号处理引擎
        //应用实例：编译器、运算表达式示例
        //实例代码：构建环境类，包含解释器之外的一些全局信息，一般是HashMap
        static void Main(string[] args)
        {
            Expression isMale = getMaleExpression();
            Expression isMarriedWoman = getMarriedWomanExpression();

            Console.WriteLine("John is Male? "+isMale.interpret("John"));
            Console.WriteLine("Julie is a Married woman? "+isMarriedWoman.interpret("Married Julie"));

            Console.Read();
        }

        //规则：Rober和John是男性
        public static Expression getMaleExpression()
        {
            Expression robert = new TerminalExpression("Robert");
            Expression john = new TerminalExpression("John");

            return new OrExpression(robert,john);
        }

        //规则：Julie是一个已婚女性
        public static Expression getMarriedWomanExpression()
        {
            Expression julie = new TerminalExpression("Julie");
            Expression married = new TerminalExpression("Married");

            return new AndExpression(julie,married);
        }
    }
}
