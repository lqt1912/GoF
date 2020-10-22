using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class KeyboardModDecorator : LaptopDecorator
    {
        public KeyboardModDecorator(ILaptop laptop) : base(laptop)
        {
        }

        public override string UpgradeLaptop()
        {
            return base.UpgradeLaptop()+ " and laptop's keyboard has been moded";
        }

        public string KeycapMod()
        {
            return "This laptop has Keycap's mod!";
        }
    }
}
