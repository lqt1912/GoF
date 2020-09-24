using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Builder.Demo2
{
    public abstract class LamBanh
    {
        protected Banh tenBanh;

        public Banh GetBanh
        {
            get
            {
                return tenBanh;
            }
        }
        public abstract void ThucHienLamBanh();
    }
}
