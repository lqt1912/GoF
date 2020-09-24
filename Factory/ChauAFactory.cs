using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// Class Môi trường Châu Á kế thừa môi trường sống. Môi trường sống có nhiều kiểu, Á, Âu, ... 
    /// </summary>
    public class ChauAFactory : MoiTruongSongFactory
    {

        /// <summary>
        /// override phương thức sinh đông vật ăn cỏ của MoiTruongSongFactory 
        /// </summary>
        /// <returns></returns>
        public override DongVatAnCo CreateDongVatAnCo()
        {
            return new LinhDuong("Linh Dương");
        }


        /// <summary>
        /// override phương thức sinh đông vật ăn cỏ của MoiTruongSongFactory 
        /// </summary>
        /// <returns></returns>
        public override DongVatAnThit CreateDongVatAnThit()
        {
            return new SuTu("Sư Tử ");
        }
    }
}
