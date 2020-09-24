using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// Sản xuất xe đạp 
    /// </summary>
    public class SanXuatXeDap : SanXuat
    {
        /// <summary>
        /// Khởi tạo giá trị sản xuất là xe đạp 
        /// </summary>
        public SanXuatXeDap()
        {
            phuongTien = new PhuongTien("Xe đạp ");
        }


        /// <summary>
        /// Sản xuất bánh xe đạp 
        /// </summary>
        public override void SanXuatBanhXe()
        {
            phuongTien["Bánh xe"] = "Xe đạp có hai bánh";
        }

        /// <summary>
        /// Sản xuất cửa sổ xe đạp 
        /// </summary>
        public override void SanXuatCuaSo()
        {
            phuongTien["Cửa sổ "] = "Xe đạp làm gì có cửa sổ";
        }


        /// <summary>
        /// Sản xuất động cơ 
        /// </summary>
        public override void SanXuatDongCo()
        {
            phuongTien["Động cơ "] = "Xe đạp chạy bằng hai chân ";
        }

        /// <summary>
        /// Sản xuất khung xe đạp 
        /// </summary>
        public override void SanXuatKhungXe()
        {
            phuongTien["Khung xe "] = "Xe đạp có khung bằng nhôm ";
        }

    }
}
