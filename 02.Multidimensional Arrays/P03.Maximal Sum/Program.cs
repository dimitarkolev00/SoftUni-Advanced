using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimesions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rows = dimesions[0];
            int cols = dimesions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }

            }

            int maxSum = int.MinValue;
            int bestRowIndex = 0;
            int bestColIndex = 0;

            for (int row = 0; row <= rows - 3; row++)
            {
                for (int col = 0; col <= cols - 3; col++)
                {
                    int rowOne = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2];
                    int rowTwo = matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
                    int rowThree = matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    int currentSum = rowOne + rowTwo + rowThree;

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        bestRowIndex = row;
                        bestColIndex = col;

                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int row = bestRowIndex; row < bestRowIndex + 3; row++)
            {
                for (int col = bestColIndex; col < bestColIndex + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
