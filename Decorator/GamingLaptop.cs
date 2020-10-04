using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class GamingLaptop : ILaptop
    {
        public string UpgradeLaptop()
        {
            return "New gaming laptop have 512GB RAM";
        }
    }
}
