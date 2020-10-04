using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class SoundModDecorator : LaptopDecorator
    {
        public SoundModDecorator(ILaptop laptop) : base(laptop)
        {
        }

        public override string UpgradeLaptop()
        {
            return base.UpgradeLaptop()+ " and laptop's sound has been moded";
        }
    }
}
