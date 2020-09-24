using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// Linh Dương là động vật ăn cỏ 
    /// </summary>
    public class LinhDuong : DongVatAnCo
    {
        /// <summary>
        /// Hàm khởi tạo của con Linh Dương sẽ bao gồm tên của nó 
        /// </summary>
        /// <param name="tenLoai"></param>
        public LinhDuong(string tenLoai) : base(tenLoai)
        {
        }

        /// <summary>
        /// Trả về Tên gọi của nó 
        /// </summary>
        /// <returns></returns>
        public override string GetTenLoai()
        {
            return TenLoai;
        }
    }
}
