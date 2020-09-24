using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// Động vật ăn cỏ 
    /// </summary>
    public abstract class DongVatAnCo
    {
        protected string TenLoai;
        public abstract string GetTenLoai();
        public DongVatAnCo( string tenLoai)
        {
            TenLoai = tenLoai;
        }
    }
}
