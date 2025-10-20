using System;

namespace Bai05
{
    internal class cChungCu : cGiaoDich
    {
        public int Tang { get; protected set; }
        public cChungCu() : base() { }
        public cChungCu(string diaDiem, double giaBan, double dienTich, int Tang)
            : base(diaDiem, giaBan, dienTich)
        {
            this.Tang = Tang;
        }
        public override void Nhap()
        {
            Console.WriteLine("\n=== Nhập thông tin Chung Cư ===");
            base.Nhap();
            Console.Write("Nhập tầng: ");
            Tang = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine($"\n[Thông tin Chung Cư]");
            base.Xuat();
            Console.WriteLine($"Tầng: {Tang}");
        }
    }
}
