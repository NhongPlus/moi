using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP05_Cau1
{
    internal class PhanSo
    {
        private float tuSo;
        private float mauSo;

        public float TuSo { get => tuSo; set => tuSo = value; }
        public float MauSo { get => mauSo; set => mauSo = value; }
        public void Nhap()
        {
            Console.Write("Nhập Tử Số : ");
            tuSo = float.Parse(Console.ReadLine());
            Console.Write("Nhập Mẫu Số : ");
            mauSo = float.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        public static PhanSo Cong(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.TuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            c.MauSo = a.MauSo * b.MauSo;
            return c;
        }
    }
    
}
