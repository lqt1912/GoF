using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{

    /// <summary>
    /// Giải thích thế giới: 
    /// Mỗi thế giới sẽ có một loài ăn cỏ, và một loài ăn thịt. 
    /// Thế giới hoạt động thì Động vật ăn thịt sẽ ăn thịt động vật ăn cỏ 
    /// Mỗi lần khởi tạo thế giới phải có môi trường cho trước. trong ví dụ này là Môi Trường Châu Á  
    /// Từ đó môi trường sẽ gọi ra loại động vật của riêng mình. 
    /// </summary>
    public class TheGioiDongVat
    {

        /// <summary>
        /// Động vật ăn cỏ 
        /// </summary>
        private DongVatAnCo _dongVatAnCo;

        /// <summary>
        /// Động vật ăn thịt 
        /// </summary>
        private DongVatAnThit _dongVatAnThit;

        /// <summary>
        /// Constructor của TheGioiDongVat
        /// </summary>
        /// <param name="factory"></param>
        public TheGioiDongVat(MoiTruongSongFactory factory )
        {
            _dongVatAnCo = factory.CreateDongVatAnCo();
            _dongVatAnThit = factory.CreateDongVatAnThit();
        }


        /// <summary>
        /// Chạy chuỗi thức ăn của môi trường đó. Ví dụ Động vật ăn thịt thì ăn đông vật ăn cỏ
        /// </summary>
        public void HoatDong()
        {
            _dongVatAnThit.AnThit(_dongVatAnCo);
        }
    }
}
