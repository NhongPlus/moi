using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP05_Cau2
{
    internal class HinhChuNhat : Hinh
    {
        private double a;
        private double b;

        public double B { get => b; set => b = value; }
        public double A { get => a; set => a = value; }

        public override double TinhChuVi()
        {
            return 2 * (A + B);
        }
        public override double TinhDienTich()
        {
            return A * B;
        }
    }
}
