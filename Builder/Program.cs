using Builder.Demo2;
using System;
using System.Text;

namespace Builder
{
    /// <summary>
    /// Director: NhaMaySanXuat
    /// Builder: SanXuat
    /// Concreate builder: SanXuatXeDap, SanXuatXeMay, SanXuatXeHoi
    /// Product: XeDap, XeMay, XeHoi
    /// </summary>


    class Program
    {
        /// <summary>
        /// 
        /// Builder Pattern chia cấu trúc của 1 object phức tạp từ 
        /// những chi tiết nhỏ của nó, 
        /// vì vậy 1 xứ lý giống nhau có thể tạo ra những object 
        /// với chi tiết khác nhau (nhờ những builder khác nhau) 
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Demo1
            SanXuat thietBiSanXuat;
            NhaMaySanXuat nhaMaySanXuat = new NhaMaySanXuat();

            thietBiSanXuat = new SanXuatXeDap();

            nhaMaySanXuat.XayDungNhaMay(thietBiSanXuat);

            thietBiSanXuat.GetPhuongTien.Show();

            thietBiSanXuat = new SanXuatXeHoi();
            nhaMaySanXuat.XayDungNhaMay(thietBiSanXuat);
            thietBiSanXuat.GetPhuongTien.Show();

            thietBiSanXuat = new SanXuatXeMay();
            nhaMaySanXuat.XayDungNhaMay(thietBiSanXuat);
            thietBiSanXuat.GetPhuongTien.Show();
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            DauBep dauBep = new DauBep();

            LamBanh lamBanh;
            lamBanh = new LamBanhPizza();
            lamBanh.GetBanh.Show();
            dauBep.NhanYeuCauLamBanh(lamBanh);
           


            lamBanh = new LamBanhSanwich();
            lamBanh.GetBanh.Show();
            dauBep.NhanYeuCauLamBanh(lamBanh);

        }
    }
}
