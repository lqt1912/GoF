using System;
using System.Collections.Generic;
using System.Text;

namespace BT_23._10._2020_Nhom04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            NhanVienComposite ceo = new NhanVienComposite("CEO");
            ceo.Add(new NhanVienComposite("Marketting "));
            ceo.Add(new NhanVienComposite("Sản xuất"));
            ceo.GetChild(0).Add(new NhanVienComposite("Quảng cáo"));
            ceo.GetChild(0).Add(new NhanVienComposite("kế Toán"));

            ceo.GetChild(1).Add(new NhanVienLeaf("Quảng cáo leaf"));
            ceo.GetChild(1).Add(new NhanVienComposite("kế Toán"));

            ceo.GetSalary();
            Console.WriteLine();
            ceo.GetChild(0).GetSalary();
            ceo.GetChild(1).GetSalary();

            ceo.GetChild(1).GetChild(0).GetSalary();
        }
    }

    abstract class NhanVien
    {
        public string LoaiNhanVien { get; set; }
        public abstract void GetSalary();

        public abstract void Add(NhanVien nv);
        public abstract void Remove(NhanVien nv);
        public abstract NhanVien GetChild(int indexNhanVien);
    }

    class NhanVienLeaf : NhanVien
    {
        public NhanVienLeaf(string nhanVienType)
        {
            this.LoaiNhanVien = nhanVienType;
        }

        public override void Add(NhanVien nv)
        {
        }

        public override NhanVien GetChild(int indexNhanVien)
        {
            throw new NotImplementedException();
        }

        public override void GetSalary()
        {
            Console.WriteLine($"Lương của loại nhân viên {LoaiNhanVien} là {new Random().Next(1000, 100000)}");
        }

        public override void Remove(NhanVien nv)
        {
            throw new NotImplementedException();
        }
    }

    class NhanVienComposite : NhanVien
    {
        private List<NhanVien> SubNhanVien = new List<NhanVien>();

        public NhanVienComposite(string loaiNv)
        {
            this.LoaiNhanVien = loaiNv;
        }

        public override void Add(NhanVien nv)
        {
            SubNhanVien.Add(nv);
        }

        public override NhanVien GetChild(int indexNhanVien)
        {
            return SubNhanVien[indexNhanVien];
        }

        public override void GetSalary()
        {
            Console.WriteLine($"Lương của loại nhân viên {LoaiNhanVien} là {new Random().Next(1000, 100000)}"  );
        }

        public override void Remove(NhanVien nv)
        {
            SubNhanVien.Remove(nv);
        }
    }
}
