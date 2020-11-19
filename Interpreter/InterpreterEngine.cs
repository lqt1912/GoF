using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class InterpreterEngine
    {
        public int Mul(string input)
        {
            String[] token = Interpret(input);
            int num1 = int.Parse(token[0]);
            int num2 = int.Parse(token[2]);
            return num1 * num2;
        }

        public int Div(string input)
        {
            String[] token = Interpret(input);
            int num1 = int.Parse(token[0]);
            int num2 = int.Parse(token[2]);
            return num1/num2;
        }
        private string[] Interpret(string input)
        {
            String str = input.Replace("[^0-9]", " ");
            str = str.Replace("( )+", " ").Trim();
            return str.Split(" ");
        }
    }
}
