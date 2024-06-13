using System.Text;
using System;

namespace LAP05_Cau1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<PhanSo> phanSos = new List<PhanSo>();

            int n;
            Console.Write("Nhập số lượng phân số: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                PhanSo phanSo = new PhanSo();
                phanSo.Nhap();
                phanSos.Add(phanSo);
            }

            PhanSo tong = PhanSo.Cong(phanSos[0], phanSos[1]);
            for (int i = 2; i < n; i++)
            {
                tong = PhanSo.Cong(tong, phanSos[i]);
            }

            Console.WriteLine($"Tổng các phân số là: {tong.TuSo}");
            Console.WriteLine("                     ---");
            Console.WriteLine($"                     {tong.MauSo}");
            Console.ReadKey();
        }
    }
}


