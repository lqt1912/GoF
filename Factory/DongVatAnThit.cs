using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    
    /// <summary>
    /// Động vật ăn thịt 
    /// </summary>
   public abstract class DongVatAnThit
    {
        /// <summary>
        /// Ăn thịt động vật ăn cỏ
        /// </summary>
        /// <param name="dv"></param>
        public abstract void AnThit(DongVatAnCo dv);
        public abstract string GetTenLoai();

        protected string TenLoai;
        public DongVatAnThit(string tenLoai)
        {
            TenLoai = tenLoai;
        }
    }
}
