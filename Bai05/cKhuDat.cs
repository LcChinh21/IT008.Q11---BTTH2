using System;

namespace Bai05
{
    internal class cKhuDat : cGiaoDich
    {
        public cKhuDat() : base() { }
        public cKhuDat(string diaDiem, double giaBan, double dienTich)
            : base(diaDiem, giaBan, dienTich) { }
        public override void Nhap()
        {
            Console.WriteLine("\n=== Nhập thông tin Khu Đất ===");
            base.Nhap();
        }
        public override void Xuat()
        {
            Console.WriteLine($"\n[Thông tin Khu Đất]");
            base.Xuat();
        }
    }
}
