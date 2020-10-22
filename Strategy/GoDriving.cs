using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class GoDriving : IGoInterface
    {
        public void Go()
        {
            Console.WriteLine("I am driving!");
        }
    }
}
