using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpaterPatternDemo
{
    class AndExpression:Expression
    {
        private Expression expr1 = null;
        private Expression expr2 = null;

        public AndExpression(Expression expr1, Expression expr2)
        {
            this.expr1 = expr1;
            this.expr2 = expr2;
        }

        public bool interpret(string context)
        {
            return expr1.interpret(context) || expr2.interpret(context);
        }
    }
}
