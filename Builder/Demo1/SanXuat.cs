using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// Class sản xuất xe
    /// </summary>
    public abstract class SanXuat
    {

        /// <summary>
        /// Phương tiện sẽ sản xuất 
        /// </summary>
        protected PhuongTien phuongTien;

        /// <summary>
        /// Lấy giá trị phương tiện 
        /// </summary>
        public PhuongTien GetPhuongTien { get { return phuongTien; } }


        /// <summary>
        /// Sản xuất bánh xe
        /// </summary>
        public abstract void SanXuatBanhXe();

        /// <summary>
        /// Sản xuất động cơ 
        /// </summary>
        public abstract void SanXuatDongCo();

        /// <summary>
        /// Sản xuất cửa sổ 
        /// </summary>
        public abstract void SanXuatCuaSo();

        /// <summary>
        /// Sản xuất khung xe
        /// </summary>
        public abstract void SanXuatKhungXe();



    }
}
