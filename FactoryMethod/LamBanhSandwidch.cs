using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class LamBanhSandwidch : LamBanh
    {
        public override Banh CreateBanh()
        {
            return new BanhSandwidch();
        }
    }
}
