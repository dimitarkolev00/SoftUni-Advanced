using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimesions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rows = dimesions[0];
            int cols = dimesions[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] currentRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
                string commandInput = Console.ReadLine();

            while (commandInput != "END")
            {
                string[] commandArgs = commandInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = commandArgs[0];

                if (command != "swap" || commandArgs.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    commandInput = Console.ReadLine();
                    continue;
                }

                int rowOne = int.Parse(commandArgs[1]);
                int colOne = int.Parse(commandArgs[2]);

                int rowTwo = int.Parse(commandArgs[3]);
                int colTwo = int.Parse(commandArgs[4]);

                bool isValidFirstCell = IsValidCell(matrix, rowOne, colOne);
                bool isValidSecondCell = IsValidCell(matrix, rowTwo, colTwo);

                if (isValidFirstCell && isValidSecondCell)
                {
                    string temp = matrix[rowOne, colOne];
                    matrix[rowOne, colOne] = matrix[rowTwo, colTwo];
                    matrix[rowTwo, colTwo] = temp;

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }


                commandInput = Console.ReadLine();
            }

            
            
        }

        static bool IsValidCell(string[,] matrix, int row, int col)
        {
            bool isValid = false;

            if (row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix.GetLength(1))
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
