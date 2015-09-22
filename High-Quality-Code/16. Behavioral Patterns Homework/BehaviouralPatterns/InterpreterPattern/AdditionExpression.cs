using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class AdditionExpression : IExpressionBase
    {
        IExpressionBase _expr1;
        IExpressionBase _expr2;

        public AdditionExpression(IExpressionBase expr1, IExpressionBase expr2)
        {
            _expr1 = expr1;
            _expr2 = expr2;
        }

        public int Evaluate()
        {
            int value1 = _expr1.Evaluate();
            int value2 = _expr2.Evaluate();
            return value1 + value2;
        }

        public override string ToString()
        {
            return string.Format("({0} + {1})", _expr1, _expr2);
        }
    }

}
