using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class Parser
    {
        public IExpressionBase Parse(string polish)
        {
            var symbols = new List<string>(polish.Split(' '));
            return ParseNextExpression(symbols);
        }

        public IExpressionBase ParseNextExpression(List<string> symbols)
        {
            int value;
            if (int.TryParse(symbols[0], out value))
            {
                symbols.RemoveAt(0);
                return new IntegerExpression(value);
            }
            return ParseNonTerminalExpression(symbols);
        }

        private IExpressionBase ParseNonTerminalExpression(List<string> symbols)
        {
            var symbol = symbols[0];
            symbols.RemoveAt(0);

            var expr1 = ParseNextExpression(symbols);
            var expr2 = ParseNextExpression(symbols);

            switch (symbol)
            {
                case "+":
                    return new AdditionExpression(expr1, expr2);
                case "-":
                    return new SubtractionExpression(expr1, expr2);
                default:
                    string message = string.Format("Invalid Symbol ({0})", symbol);
                    throw new InvalidOperationException(message);
            }
        }
    }
}
