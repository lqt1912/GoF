using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class LaptopDecorator : ILaptop
    {
        protected ILaptop _laptop;

        public ILaptop GetLaptop()
        {
            return _laptop;
        }

        public void SetLaptop(ILaptop laptop)
        {
            _laptop = laptop;
        }
        public  LaptopDecorator(ILaptop laptop)
        {
            _laptop = laptop;
        }

        public virtual string UpgradeLaptop() 
        {
            return _laptop.UpgradeLaptop();
        }
    }
}
