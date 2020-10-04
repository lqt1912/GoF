using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class OfficeLaptop : ILaptop
    {
        public string UpgradeLaptop()
        {
            return "New office laptop has 1TB HDD";
        }
    }
}
