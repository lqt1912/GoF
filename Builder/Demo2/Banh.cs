using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Demo2
{
    public class Banh
    {
        private string tenBanh;

        public Banh(string tenBanh)
        {
            this.tenBanh = tenBanh;
        }

        public void Show()
        {
            Console.WriteLine("\n Đầu bếp đang làm bánh : {0}", tenBanh);
        }
    }
}
