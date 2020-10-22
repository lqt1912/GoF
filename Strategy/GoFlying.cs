using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class GoFlying : IGoInterface
    {
        public void Go()
        {
            Console.WriteLine("I am flying! ");
        }
    }
}
