using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Light
    {
        string state;

        public void TurnOn()
        {
            this.state = "On";
            Console.WriteLine($"Light turn {state} !");
        }

        public void TurnOff()
        {
            this.state = "Off";
            Console.WriteLine($"Light turn {state} !");
        }

        public void BreakLight()
        {
            this.state = "Broken";
            Console.WriteLine($"Light is {state} !");
        }
    }
}
