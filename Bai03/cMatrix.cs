using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai03
{
    internal class cMatrix
    {
        private int row, col;
        private int[,] matrix;
        private bool containPrimeNumber = true;
        public cMatrix(int n, int m)
        {
            row = n; col = m;
            matrix = new int[row, col];
        }
        private bool isPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }
        public void InputMatrix()
        {
            Console.WriteLine("Nhập ma trận:");
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"matrix[{i + 1},{j + 1}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
        }
        public void OutputMatrix()
        {
            Console.WriteLine($"Ma trận {row}x{col}:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                    Console.Write($"{matrix[i, j],4}");
                Console.WriteLine();
            }
        }
        public void FindMember(int k)
        {
            bool found = false;
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    if (matrix[i, j] == k)
                    {
                        if (!found) Console.WriteLine($"Số {k} xuất hiện tại:");
                        Console.WriteLine($"[{i + 1},{j + 1}]");
                        found = true;
                    }
            if (!found) Console.WriteLine($"Không có {k} trong ma trận.");
        }
        public void OutputPrimeNumber()
        {
            List<int> primes = new List<int>();
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    if (isPrime(matrix[i, j])) primes.Add(matrix[i, j]);
            if (primes.Count == 0)
            {
                containPrimeNumber = false;
                Console.WriteLine("Không có số nguyên tố trong ma trận.");
            }
            else
            {
                primes = primes.Distinct().OrderBy(x => x).ToList();
                Console.WriteLine("Các số nguyên tố: " + string.Join(" ", primes));
            }
        }
        public void RowContainMostPrime()
        {
            if (!containPrimeNumber) return;
            int maxCount = 0, rowMax = -1;
            for (int i = 0; i < row; i++)
            {
                int cnt = 0;
                for (int j = 0; j < col; j++)
                    if (isPrime(matrix[i, j])) cnt++;
                if (cnt > maxCount)
                {
                    maxCount = cnt;
                    rowMax = i;
                }
            }
            Console.WriteLine($"Dòng {rowMax + 1} có nhiều số nguyên tố nhất.");
        }
    }
}
