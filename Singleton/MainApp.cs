using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class MainApp
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Singleton single1 = Singleton.GetInstance();
            Singleton single2 = Singleton.GetInstance();
            Singleton single3 = Singleton.GetNewInstance();

            Console.WriteLine("\n Định danh của Singleton single1 hiện tại là: "+ single1.DinhDanh);
            Console.WriteLine("\n Định danh của Singleton single2 hiện tại là: " + single2.DinhDanh);
            Console.WriteLine("\n Định danh của Singleton single2 hiện tại là: " + single3.DinhDanh);
            List<int> list = new List<int>();
            for(int i=0;i <10; i++)
            {
                list.Add(i);
                single1.GiaTriHienTai = single1.GiaTriHienTai + i;

                single2.GiaTriHienTai = single2.GiaTriHienTai + i;

                single3.GiaTriHienTai = single3.GiaTriHienTai + i;
            }

            Console.WriteLine("\nGiá trị hiện tại của biến đếm trong single1: " + single1.GiaTriHienTai);
            Console.WriteLine("\nGiá trị hiện tại của biến đếm trong single2: " + single2.GiaTriHienTai);
            Console.WriteLine("\nGiá trị hiện tại của biến đếm trong single3: " + single3.GiaTriHienTai);

            Console.ReadKey();
        }
    }
}
