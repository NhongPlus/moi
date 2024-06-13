using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP05_Cau2
{
    internal class HinhVuong : Hinh
    {
        private double canh;

        public double Canh { get => canh; set => canh = value; }

        public override double TinhChuVi()
        {
            return 4 * Canh;
        }

        public override double TinhDienTich()
        {
            return Math.Pow(Canh , 2);
        }
    }
}
