using System;

namespace Bai05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            cdsGiaoDich ds = new cdsGiaoDich();
            int chon;
            do
            {
                Console.WriteLine("\n========== MENU ==========");
                Console.WriteLine("1. Nhập danh sách giao dịch");
                Console.WriteLine("2. Xuất danh sách giao dịch");
                Console.WriteLine("3. Tính tổng giá bán từng loại");
                Console.WriteLine("4. Lọc giao dịch theo điều kiện");
                Console.WriteLine("5. Tìm kiếm nhà phố / chung cư");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1: ds.NhapdsGiaoDich(); break;
                    case 2: ds.XuatdsGiaoDich(); break;
                    case 3: ds.TongGiaBan(); break;
                    case 4: ds.LocGiaoDich(); break;
                    case 5: ds.TimKiem(); break;
                }
            } while (chon != 0);
        }
    }
}
