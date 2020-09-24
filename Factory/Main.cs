using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class MainApp
    {
        /// <summary>
        /// 
        /// Trong Abstract Factory pattern, 1 interface chịu trách nhiệm
        /// để tạo ra 1 nhà máy cho những object 
        /// tương tự nhau mà không chỉ định rõ ra class của chúng. 
        /// Mỗi nhà máy tạo ra có thể đưa ra những 
        /// object theo kiểu nhà máy khác nhau (Factory Pattern). 
        /// 
        /// </summary>
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            MoiTruongSongFactory chauA = new ChauAFactory();

            TheGioiDongVat theGioiDongVat = new TheGioiDongVat(chauA);
            theGioiDongVat.HoatDong();

            Console.ReadKey();
        }
    }
}
