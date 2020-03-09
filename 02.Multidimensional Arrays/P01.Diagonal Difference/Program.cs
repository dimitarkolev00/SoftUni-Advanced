using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int diagonalOne = 0;
            for (int i = 0; i < n; i++)
            {
                diagonalOne += matrix[i, i];
            }

            int diagonalTwo = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                int row = n - i - 1;
                int col = i;
                diagonalTwo += matrix[row, col];
            }

            Console.WriteLine(Math.Abs(diagonalOne - diagonalTwo));
        }
    }
}
