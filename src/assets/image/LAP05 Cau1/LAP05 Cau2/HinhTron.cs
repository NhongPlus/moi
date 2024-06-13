using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP05_Cau2
{
    internal class HinhTron : Hinh
    {
        private double banKinh;

        public double BanKinh { get => banKinh; set => banKinh = value; }

        public override double TinhChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }
        public override double TinhDienTich()
        {
            return Math.PI * Math.Pow(BanKinh , 2);
        }
    }
}
