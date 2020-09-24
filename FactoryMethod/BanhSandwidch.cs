using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class BanhSandwidch : Banh
    {
        public BanhSandwidch()
        {
            this.tenBanh = "Bánh sandwich";
        }
        public override string GetTenBanh()
        {
            return tenBanh;
        }
    }
}
