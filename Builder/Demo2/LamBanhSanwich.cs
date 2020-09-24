using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Demo2
{
    public class LamBanhSanwich : LamBanh
    {
        public LamBanhSanwich()
        {
            tenBanh = new Banh("Bánh Sandwich");
        }
        public override void ThucHienLamBanh()
        {
            Console.WriteLine("\n Đầu bếp đã làm xong  sandwich");
        }
    }
}
