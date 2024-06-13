using System;
using System.Text;

namespace LAP05_Cau2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            List<Hinh> hinhs = new List<Hinh>();

            hinhs.Add(new HinhTron());
            hinhs.Add(new HinhVuong());
            hinhs.Add(new HinhTamGiac());
            hinhs.Add(new HinhChuNhat());

            Console.Write("Nhập bán kính hình tròn: ");
            double r = double.Parse(Console.ReadLine());
            ((HinhTron)hinhs[0]).BanKinh = r;

            Console.Write("Nhập cạnh hình vuông: ");
            double a = double.Parse(Console.ReadLine());
            ((HinhVuong)hinhs[1]).Canh = a;

            Console.WriteLine("Nhập 3 cạnh hình tam giác: ");
            Console.Write("Cạnh 1 : ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("Cạnh 2 : ");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("Cạnh 3 : ");
            double a3 = double.Parse(Console.ReadLine());
            ((HinhTamGiac)hinhs[2]).C = a1;
            ((HinhTamGiac)hinhs[2]).B = a2;
            ((HinhTamGiac)hinhs[2]).A = a3;

            Console.WriteLine("Nhập chiều dài và chiều rộng hình chữ nhật: ");
            Console.Write("Chiều dài : ");
            double a4 = double.Parse(Console.ReadLine());
            Console.Write("Chiều rộng : ");
            double a5 = double.Parse(Console.ReadLine());
            ((HinhChuNhat)hinhs[3]).A = a4;
            ((HinhChuNhat)hinhs[3]).B = a5;

            double chuviTong = 0;
            for (int i = 0; i < hinhs.Count; i++)
            {
                chuviTong += hinhs[i].TinhChuVi();
            }
            double dienTichTong = 0;
            for (int i = 0; i < hinhs.Count; i++)
            {
                dienTichTong += hinhs[i].TinhDienTich();
            }
            Console.WriteLine("Tổng chu vi: {0}", chuviTong);
            Console.WriteLine("Tổng diện tích: {0}", dienTichTong);
            Console.ReadKey();
        }
    }
}