using System;
using System.Linq;

namespace _2X2_Squares_in_Matrix
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
                char[] currentRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int counter = 0;

            for (int row = 0; row <= rows - 2; row++)
            {
                for (int col = 0; col <= cols - 2; col++)
                {
                    if (matrix[row,col]==matrix[row,col+1]&&
                        matrix[row,col]==matrix[row+1,col]&&
                        matrix[row,col]==matrix[row+1,col+1])
                    {
                        counter++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
