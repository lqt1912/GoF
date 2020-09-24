using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Demo2
{
    public class LamBanhPizza : LamBanh
    {
        public LamBanhPizza()
        {
            tenBanh = new Banh("Bánh Pizza ");
        }
        public override void ThucHienLamBanh()
        {
            Console.WriteLine("\n Đầu bếp đã làm xong Pizza");
        }
    }
}
