using System;

namespace MyLibrary
{
    public static class MatrixHelper
    {
        private static Random rnd = new Random();
        public static int[,] CreateRandomMatrix(int n, int m, int min = 0, int max = 100)
        {
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    matrix[i, j] = rnd.Next(min, max + 1);
            return matrix;
        }
        public static void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }
        public static int MaxElement(int[,] matrix)
        {
            int max = matrix[0, 0];
            foreach (int x in matrix)
                if (x > max) max = x;
            return max;
        }
        public static int MinElement(int[,] matrix)
        {
            int min = matrix[0, 0];
            foreach (int x in matrix)
                if (x < min) min = x;
            return min;
        }
        public static int RowWithMaxSum(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int maxSum = int.MinValue;
            int rowIndex = -1;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                    sum += matrix[i, j];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    rowIndex = i;
                }
            }
            return rowIndex;
        }
        private static bool IsPrime(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i * i <= x; i++)
                if (x % i == 0) return false;
            return true;
        }
        public static int SumNonPrimes(int[,] matrix)
        {
            int sum = 0;
            foreach (int x in matrix)
                if (!IsPrime(x)) sum += x;
            return sum;
        }
        public static int[,] DeleteRow(int[,] matrix, int k)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            if (k < 0 || k >= n) return matrix;
            int[,] result = new int[n - 1, m];
            int ri = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == k) continue;
                for (int j = 0; j < m; j++)
                    result[ri, j] = matrix[i, j];
                ri++;
            }
            return result;
        }
        public static int[,] DeleteColumnWithMax(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int max = MaxElement(matrix);
            int colIndex = -1;
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] == max)
                    {
                        colIndex = j;
                        break;
                    }
                }
                if (colIndex != -1) break;
            }
            if (colIndex == -1) return matrix;
            int[,] result = new int[n, m - 1];
            for (int i = 0; i < n; i++)
            {
                int ci = 0;
                for (int j = 0; j < m; j++)
                {
                    if (j == colIndex) continue;
                    result[i, ci] = matrix[i, j];
                    ci++;
                }
            }
            return result;
        }
    }
}
