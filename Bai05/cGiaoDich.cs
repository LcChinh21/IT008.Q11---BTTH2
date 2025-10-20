using System;

namespace Bai05
{
    internal class cGiaoDich
    {
        public string diaDiem { get; protected set; }
        public double giaBan { get; protected set; }
        public double dienTich { get; protected set; }
        public cGiaoDich() { }
        public cGiaoDich(string diaDiem, double giaBan, double dienTich)
        {
            this.diaDiem = diaDiem;
            this.giaBan = giaBan;
            this.dienTich = dienTich;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhập địa điểm: ");
            diaDiem = Console.ReadLine();
            Console.Write("Nhập giá bán (VND): ");
            giaBan = double.Parse(Console.ReadLine());
            Console.Write("Nhập diện tích (m²): ");
            dienTich = double.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"Địa điểm: {diaDiem}");
            Console.WriteLine($"Giá bán: {giaBan:N0} VND");
            Console.WriteLine($"Diện tích: {dienTich} m²");
        }
    }
}
