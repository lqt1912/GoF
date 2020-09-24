using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class SanXuatXeHoi : SanXuat
    {
        public SanXuatXeHoi()
        {
            phuongTien = new PhuongTien("Xe hơi ");
        }

        /// <summary>
        /// Sản xuất bánh xe của xe hơi
        /// </summary>
        public override void SanXuatBanhXe()
        {
            phuongTien["Bánh xe "] = "4 bánh";
        }

        /// <summary>
        /// Sản xuất cửa sổ của xe hơi
        /// </summary>
        public override void SanXuatCuaSo()
        {
            phuongTien["Cửa sổ "] = "4 cửa sổ ";
        }

        /// <summary>
        /// Động cơ xe hơi 300HP
        /// </summary>
        public override void SanXuatDongCo()
        {
            phuongTien["Động cơ "] = "Động cơ 300HP";
        }

        /// <summary>
        /// Khung xe hơi làm bằng sắt 
        /// </summary>
        public override void SanXuatKhungXe()
        {
            phuongTien["Khung xe "] = "Khung xe bằng nhôm";
        }
    }
}
