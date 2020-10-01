using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Demo1
{
    public abstract class ColorPrototype
    {
        protected string IsCloned = "This is Auth color!";
        public abstract ColorPrototype Clone();
        public  void ShowInfo()
        {
            Console.WriteLine("Color info:{0} ", IsCloned);
        }
    }
}
