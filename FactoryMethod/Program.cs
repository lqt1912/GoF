using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            LamBanh[] lambanhs = new LamBanh[10];
            lambanhs[0] = new LamBanhPizza();
            lambanhs[1] = new LamBanhSandwidch();
            lambanhs[2] = new LamBanhPizza();
            lambanhs[3] = new LamBanhPizza();
            lambanhs[4] = new LamBanhSandwidch();
            lambanhs[5] = new LamBanhPizza();
            lambanhs[6] = new LamBanhSandwidch();
            lambanhs[7] = new LamBanhPizza();
            lambanhs[8] = new LamBanhSandwidch();
            lambanhs[9] = new LamBanhPizza();
            foreach (var lambanh in lambanhs)
            {
                Banh banh = lambanh.CreateBanh();

                Console.WriteLine("Đang làm: {0}", banh.GetTenBanh());
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Khi không dùng Factory: ");

            Banh[] banhs = new Banh[10];
            banhs[0] = new BanhPizza();
            banhs[1] = new BanhSandwidch();
            banhs[2] = new BanhPizza();
            banhs[3] = new BanhSandwidch();
            banhs[4] = new BanhPizza();
            banhs[5] = new BanhSandwidch();
            banhs[6] = new BanhPizza();
            banhs[7] = new BanhSandwidch();
            banhs[8] = new BanhPizza();
            banhs[9] = new BanhSandwidch();
            foreach (var banh in banhs)
            {
                Console.WriteLine("Đang làm: {0}", banh.GetTenBanh());
            }
        }
    }
}
