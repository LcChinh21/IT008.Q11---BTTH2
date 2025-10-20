using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai05
{
    internal class cdsGiaoDich
    {
        private List<cGiaoDich> ds = new List<cGiaoDich>();
        public void NhapdsGiaoDich()
        {
            int select;
            do
            {
                Console.WriteLine("\n== Chọn loại giao dịch cần nhập ==");
                Console.WriteLine("1. Khu Đất");
                Console.WriteLine("2. Nhà Phố");
                Console.WriteLine("3. Chung Cư");
                Console.WriteLine("0. Thoát nhập");
                Console.Write("Lựa chọn: ");
                select = int.Parse(Console.ReadLine());
                cGiaoDich gd = null;
                switch (select)
                {
                    case 1: gd = new cKhuDat(); break;
                    case 2: gd = new cNhaPho(); break;
                    case 3: gd = new cChungCu(); break;
                }
                if (gd != null)
                {
                    gd.Nhap();
                    ds.Add(gd);
                }
            } while (select != 0);
        }
        public void XuatdsGiaoDich()
        {
            Console.WriteLine("\n===== DANH SÁCH GIAO DỊCH =====");
            foreach (var gd in ds)
                gd.Xuat();
        }
        public void TongGiaBan()
        {
            double tongKhuDat = ds.OfType<cKhuDat>().Sum(x => x.giaBan);
            double tongNhaPho = ds.OfType<cNhaPho>().Sum(x => x.giaBan);
            double tongChungCu = ds.OfType<cChungCu>().Sum(x => x.giaBan);
            Console.WriteLine("\n===== TỔNG GIÁ BÁN =====");
            Console.WriteLine($"Khu Đất: {tongKhuDat:N0} VND");
            Console.WriteLine($"Nhà Phố: {tongNhaPho:N0} VND");
            Console.WriteLine($"Chung Cư: {tongChungCu:N0} VND");
        }
        public void LocGiaoDich()
        {
            Console.WriteLine("\n===== LỌC GIAO DỊCH =====");
            bool found = false;
            foreach (var gd in ds)
            {
                if ((gd is cKhuDat && gd.dienTich > 100) ||
                    (gd is cNhaPho np && gd.dienTich > 60 && np.namXayDung >= 2019))
                {
                    found = true;
                    gd.Xuat();
                }
            }
            if (!found)
                Console.WriteLine("Không có giao dịch phù hợp!");
        }
        public void TimKiem()
        {
            Console.Write("\nNhập địa điểm cần tìm: ");
            string DiaDiem = Console.ReadLine();
            Console.Write("Nhập giá bán tối đa (VND): ");
            double giaMax = double.Parse(Console.ReadLine());
            Console.Write("Nhập diện tích tối thiểu (m²): ");
            double dtMin = double.Parse(Console.ReadLine());
            var ketQua = ds.Where(gd =>
                (gd is cNhaPho || gd is cChungCu) &&
                gd.diaDiem.ToLower().Contains(DiaDiem.ToLower()) &&
                gd.giaBan <= giaMax &&
                gd.dienTich >= dtMin);
            Console.WriteLine("\n===== KẾT QUẢ TÌM KIẾM =====");
            if (!ketQua.Any())
                Console.WriteLine("Không có kết quả phù hợp!");
            else
                foreach (var g in ketQua)
                    g.Xuat();
        }
    }
}
