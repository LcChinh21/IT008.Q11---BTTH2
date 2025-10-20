using System;

namespace Bai05
{
    internal class cNhaPho : cGiaoDich
    {
        public int namXayDung { get; protected set; }
        public int soTang { get; protected set; }
        public cNhaPho() : base() { }
        public cNhaPho(string diaDiem, double giaBan, double dienTich, int namXayDung, int soTang)
            : base(diaDiem, giaBan, dienTich)
        {
            this.namXayDung = namXayDung;
            this.soTang = soTang;
        }
        public override void Nhap()
        {
            Console.WriteLine("\n=== Nhập thông tin Nhà Phố ===");
            base.Nhap();
            Console.Write("Nhập năm xây dựng: ");
            namXayDung = int.Parse(Console.ReadLine());
            Console.Write("Nhập số tầng: ");
            soTang = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine($"\n[Thông tin Nhà Phố]");
            base.Xuat();
            Console.WriteLine($"Năm xây dựng: {namXayDung}");
            Console.WriteLine($"Số tầng: {soTang}");
        }
    }
}
