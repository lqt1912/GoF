using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class SanXuatXeMay : SanXuat
    {
        /// <summary>
        /// Khởi tạo giá trị phương tiện sẽ sản xuất là xe máy 
        /// </summary>
        public SanXuatXeMay()
        {
            phuongTien = new PhuongTien("Xe máy");
        }

        /// <summary>
        /// Sản xuất bánh xe của xe hai bánh 
        /// </summary>
        public override void SanXuatBanhXe()
        {
            phuongTien["Bánh xe "] = "2 bánh";
        }

        /// <summary>
        /// Sản xuất cửa sổ của xe máy => Xe máy không có cửa sổ 
        /// </summary>
        public override void SanXuatCuaSo()
        {
            phuongTien["Cửa sổ "] = "Không có cửa sổ ";
        }

        /// <summary>
        /// Động cơ xe máy có 125cc
        /// </summary>
        public override void SanXuatDongCo()
        {
            phuongTien["Động cơ "] = "Động cơ 125cc";
        }

        /// <summary>
        /// Khung xe máy làm bằng sắt 
        /// </summary>
        public override void SanXuatKhungXe()
        {
            phuongTien["Khung xe "] = "Khung xe bằng sắt";
        }
    }
}
