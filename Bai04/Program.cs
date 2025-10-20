using System;
using System.Collections.Generic;

namespace Bai04
{
    internal class Program
    {
        static cFraction NhapPhanSo()
        {
            Console.Write("Tử số = ");
            int tu = int.Parse(Console.ReadLine());
            int mau;
            do
            {
                Console.Write("Mẫu số = ");
                mau = int.Parse(Console.ReadLine());
                if (mau == 0) Console.WriteLine("Mẫu không thể bằng 0!");
            } while (mau == 0);
            return new cFraction(tu, mau);
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập phân số a:");
            cFraction a = NhapPhanSo();
            Console.WriteLine("Nhập phân số b:");
            cFraction b = NhapPhanSo();
            Console.WriteLine($"\nTổng: {a + b}");
            Console.WriteLine($"Hiệu: {a - b}");
            Console.WriteLine($"Tích: {a * b}");
            Console.WriteLine($"Thương: {a / b}");
            Console.Write("\nNhập số lượng phân số: ");
            int n = int.Parse(Console.ReadLine());
            List<cFraction> list = new();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Phân số {i + 1}:");
                list.Add(NhapPhanSo());
            }
            cFraction max = list[0];
            foreach (var f in list)
                if (f.CompareTo(max) > 0) max = f;
            Console.WriteLine($"\nPhân số lớn nhất: {max}");
            list.Sort();
            Console.WriteLine("Dãy sắp tăng dần:");
            foreach (var f in list) Console.Write(f + " ");
        }
    }
}
