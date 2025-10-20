using System;
using System.Text;

namespace Bai01
{
    internal class Program
    {
        static bool checkInput(int m, int y)
        {
            if (m < 1 || m > 12 || y < 0)
            {
                Console.WriteLine("Tháng năm bạn nhập không hợp lệ!");
                Console.WriteLine("Mời bạn nhập lại!");
                return false;
            }
            return true;
        }
        static void createCalendar(int m, int y)
        {
            Console.WriteLine($"<3<3<3 Lịch tháng {m:00} năm {y} <3<3<3");
            Console.WriteLine("|Sun |Mon |Tue |Wed |Thu |Fri |Sat |");
            DateTime firstDay = new DateTime(y, m, 1);
            int startDay = (int)firstDay.DayOfWeek;
            int daysInMonth = DateTime.DaysInMonth(y, m);
            for (int i = 0; i < startDay; i++) Console.Write("     ");
            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write($"{day,3}  ");
                if ((startDay + day) % 7 == 0) Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int m, y;
            do
            {
                Console.Write("Nhập tháng: ");
                m = int.Parse(Console.ReadLine());
                Console.Write("Nhập năm: ");
                y = int.Parse(Console.ReadLine());
            } while (!checkInput(m, y));
            createCalendar(m, y);
            Console.ReadLine();
        }
    }
}
