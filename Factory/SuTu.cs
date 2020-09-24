using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// Sư tử là động vật ăn thịt
    /// </summary>
    public class SuTu : DongVatAnThit
    {

        /// <summary>
        /// Hàm khởi tạo của con sư tử
        /// </summary>
        /// <param name="tenLoai"></param>
        public SuTu(string tenLoai) : base(tenLoai)
        {
        }

        /// <summary>
        /// Sư tử ăn thịt động vật ăn cỏ 
        /// </summary>
        /// <param name="dv"></param>
        public override void AnThit(DongVatAnCo dv)
        {
            Console.WriteLine(this.GetTenLoai() +"đang ăn thịt "+ dv.GetTenLoai());
        }

        /// <summary>
        /// Trả về tên gọi của nó
        /// </summary>
        /// <returns></returns>
        public override string GetTenLoai()
        {
            return TenLoai;
        }
    }
}
