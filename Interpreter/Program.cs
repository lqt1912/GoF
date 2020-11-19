using System;
using System.Text;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap phep tinh : ");
            var a = Console.ReadLine();
            Console.WriteLine($"Ket qua cua phep tinh {a} la {InterpretInput(a)}" );
        }

        static int InterpretInput(String input)
        {
            Expression expression = null;
            if (input.Contains("nhân"))
            {
                expression = new MulExpression(input);
            }
            else if (input.Contains("chia"))
            {
                expression = new DivExpression(input);
            }
            return expression.Interpret(new InterpreterEngine()) ;
        }
    }
}
