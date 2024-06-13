using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP05_Cau2
{
    internal class HinhTamGiac : Hinh
    {
        private double a;
        private double b;
        private double c;

        public double C { get => c; set => c = value; }
        public double B { get => b; set => b = value; }
        public double A { get => a; set => a = value; }

        public override double TinhChuVi()
        {
            return A + B + C;
        }
        public override double TinhDienTich()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
