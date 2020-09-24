using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class LamBanhPizza : LamBanh
    {
        public override Banh CreateBanh()
        {
            return new BanhPizza(" xuân ");
        }
    }
}
