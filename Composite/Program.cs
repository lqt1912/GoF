using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CreateCake createCake = new CreateCake("Làm bánh nhỏ! ");
            createCake.ShowHowTo();
            Console.WriteLine( "Nướng bánh mất {0} phút.", createCake.GetTimeRequired());
            Console.WriteLine();

            CreateBiggerCake createBiggerCake = new CreateBiggerCake("Làm bánh to hơn xíu! ");
            createBiggerCake.ShowHowTo();
            Console.WriteLine("Nướng bánh mất {0} phút.", createBiggerCake.GetTimeRequired());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
