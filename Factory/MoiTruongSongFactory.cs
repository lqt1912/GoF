using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{

    /// <summary>
    /// Factory tạo ra môi trường sống
    /// </summary>
    public abstract class MoiTruongSongFactory
    {
        /// <summary>
        /// Factory tạo ra động vật ăn cỏ 
        /// </summary>
        /// <returns></returns>
        public abstract DongVatAnCo CreateDongVatAnCo();

        /// <summary>
        /// Factory tạo ra đông vật ăn thịt
        /// </summary>
        /// <returns></returns>
        public abstract DongVatAnThit CreateDongVatAnThit();
             
    }
}
