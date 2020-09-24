using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class NhaMaySanXuat
    {
        public void XayDungNhaMay(SanXuat sanXuat)
        {
            sanXuat.SanXuatBanhXe();
            sanXuat.SanXuatCuaSo();
            sanXuat.SanXuatDongCo();
            sanXuat.SanXuatKhungXe();
        }
    }
}
