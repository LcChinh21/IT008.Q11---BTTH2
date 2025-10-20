using System;
using System.IO;

namespace Bai02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập đường dẫn thư mục: ");
            string path = Console.ReadLine();
            while (!Directory.Exists(path))
            {
                Console.WriteLine("Đường dẫn không tồn tại. Nhập lại:");
                path = Console.ReadLine();
            }
            Console.WriteLine($"\nDirectory of {path}");
            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                DirectoryInfo infoD = new DirectoryInfo(dir);
                Console.WriteLine($"{infoD.CreationTime:dd/MM/yyyy hh:mm tt} <DIR> {infoD.Name}");
            }
            Console.WriteLine($"\t{dirs.Length} Dir(s)");
            string[] files = Directory.GetFiles(path);
            long totalSize = 0;
            foreach (string file in files)
            {
                FileInfo infoF = new FileInfo(file);
                totalSize += infoF.Length;
                Console.WriteLine($"{infoF.CreationTime:dd/MM/yyyy hh:mm tt} {infoF.Length,15:N0} {infoF.Name}");
            }
            Console.WriteLine($"\t{files.Length} file(s)\t{totalSize:N0} bytes");
        }
    }
}
