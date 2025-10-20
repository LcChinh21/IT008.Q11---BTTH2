using System;
using MyLibrary;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so dong n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Nhap so cot m: ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = MatrixHelper.CreateRandomMatrix(n, m, 0, 50);
        Console.WriteLine("Ma tran ban dau:");
        MatrixHelper.PrintMatrix(matrix);
        Console.WriteLine("Phan tu lon nhat: " + MatrixHelper.MaxElement(matrix));
        Console.WriteLine("Phan tu nho nhat: " + MatrixHelper.MinElement(matrix));
        Console.WriteLine("Dong co tong lon nhat: " + MatrixHelper.RowWithMaxSum(matrix));
        Console.WriteLine("Tong cac so khong phai so nguyen to: " + MatrixHelper.SumNonPrimes(matrix));
        Console.Write("Nhap dong k can xoa: ");
        int k = int.Parse(Console.ReadLine());
        matrix = MatrixHelper.DeleteRow(matrix, k);
        Console.WriteLine("Ma tran sau khi xoa dong thu " + k + ":");
        MatrixHelper.PrintMatrix(matrix);
        matrix = MatrixHelper.DeleteColumnWithMax(matrix);
        Console.WriteLine("Ma tran sau khi xoa cot chua phan tu lon nhat:");
        MatrixHelper.PrintMatrix(matrix);
    }
}
