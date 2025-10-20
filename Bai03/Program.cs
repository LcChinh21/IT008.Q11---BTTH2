using System;

namespace Bai03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Số dòng: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Số cột: ");
            int c = int.Parse(Console.ReadLine());
            cMatrix m = new cMatrix(r, c);
            m.InputMatrix();
            m.OutputMatrix();
            Console.Write("Nhập số cần tìm: ");
            int k = int.Parse(Console.ReadLine());
            m.FindMember(k);
            m.OutputPrimeNumber();
            m.RowContainMostPrime();
        }
    }
}
