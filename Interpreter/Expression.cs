using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public interface Expression
    {
        int Interpret(InterpreterEngine engine);

    }

    public class MulExpression : Expression
    {
        string Expression;
        public MulExpression(string expression)
        {
            this.Expression = expression;
        }
        public int Interpret(InterpreterEngine engine)
        {
            return engine.Mul(Expression);
        }
    }

    public class DivExpression : Expression
    {
        string Expression;
        public DivExpression(string expression)
        {
            this.Expression = expression;
        }
        public int Interpret(InterpreterEngine engine)
        {
            return engine.Mul(Expression);
        }
    }
}
