using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            FillMatrix(n, matrix);

            string[] coordinates = Console.ReadLine().Split(' ');

            for (int i = 0; i < coordinates.Length; i++)
            {
                string[] coorditane = coordinates[i].Split(',');
                int r = int.Parse(coorditane[0]);
                int c = int.Parse(coorditane[1]);

                int currentBombValue = matrix[r, c];

                if (currentBombValue > 0)
                {
                    if (r - 1 >= 0)
                    {
                        if (matrix[r - 1, c] <= 0)
                        {
                           
                        }
                        else
                        {
                            matrix[r - 1, c] -= currentBombValue;
                        }
                        
                    }
                    if (r + 1 < matrix.GetLength(0))
                    {
                        if (matrix[r + 1, c] <= 0)
                        {
                          
                        }
                        else
                        {
                            matrix[r + 1, c] -= currentBombValue;
                        }
                        
                    }
                    if (c - 1 >= 0)
                    {
                        if (matrix[r, c - 1] <= 0)
                        {
                           
                        }
                        else
                        {
                            matrix[r, c - 1] -= currentBombValue;
                        }
                        
                    }
                    if (c + 1 < matrix.GetLength(1))
                    {
                        if (matrix[r, c + 1] <= 0)
                        {
                            
                        }
                        else
                        {
                            matrix[r, c + 1] -= currentBombValue;
                        }
                        
                    }


                    if (r - 1 >= 0 && c - 1 >= 0)
                    {
                        if (matrix[r - 1, c - 1]<=0)
                        {

                        }
                        else
                        {
                            matrix[r - 1, c - 1] -= currentBombValue;
                        }
                        
                    }
                    if (r - 1 >= 0 && c + 1 < matrix.GetLength(1))
                    {
                        if (matrix[r - 1, c + 1]<=0)
                        {

                        }
                        else
                        {
                            matrix[r - 1, c + 1] -= currentBombValue;
                        }
                       
                    }
                    if (r + 1 < matrix.GetLength(0) && c - 1 >= 0)
                    {
                        if (matrix[r + 1, c - 1]<=0)
                        {

                        }
                        else
                        {
                            matrix[r + 1, c - 1] -= currentBombValue;
                        }
                        
                    }
                    if (r + 1 < matrix.GetLength(0) && c + 1 < matrix.GetLength(1))
                    {
                        if (matrix[r + 1, c + 1]<=0)
                        {

                        }
                        else
                        {
                            matrix[r + 1, c + 1] -= currentBombValue;
                        }
                        
                    }
                    matrix[r, c] = 0;
                }
                else
                {
                    //Console.WriteLine("Dead cell");
                    break;
                }
            }
            int aliveCellsCount = 0;
            int aliveCellsSum = 0;
            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    aliveCellsCount++;
                    aliveCellsSum += item;
                }
            }
            Console.WriteLine($"Alive cells: {aliveCellsCount}");
            Console.WriteLine($"Sum: {aliveCellsSum}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col] + " "}");
                }
                Console.WriteLine();

            }

        }

        private static void FillMatrix(int n, int[,] matrix)
        {
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
        }
    }
}
