﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimesions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int rows = dimesions[0];
            int cols = dimesions[1];

            char[,] matrix = new char[rows, cols];

            int playerRow = 0;
            int playerCol = 0;

            bool isWon = false;
            bool isDead = false;

            //ReadMatrix
            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
            char[] directions = Console.ReadLine()
                .ToCharArray();

            foreach (char direction in directions)
            {
                int playerNewRow = playerRow;
                int playerNewCol = playerCol;

                switch (direction)
                {
                    case 'U':
                        playerNewRow--;
                        break;
                    case 'D':
                        playerNewRow++;
                        break;
                    case 'L':
                        playerNewCol--;
                        break;
                    case 'R':
                        playerNewCol++;
                        break;
                }

                isWon = IsWon(matrix, playerNewRow, playerNewCol);
                if (!isWon)
                {
                    isDead = IsSymbol(matrix, 'B', playerNewRow, playerNewCol);
                    if (!isDead)
                    {
                        matrix[playerNewRow, playerNewCol] = 'P';
                    }
                    matrix[playerRow, playerCol] = '.';
                    playerRow = playerNewRow;
                    playerCol = playerNewCol;
                }
                else
                {
                    matrix[playerRow, playerCol] = '.';
                }

                List<int> bunniesCoordinates = new List<int>();
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (matrix[row, col] == 'B')
                        {
                            bunniesCoordinates.Add(row);
                            bunniesCoordinates.Add(col);
                        }
                    }
                }
                for (int i = 0; i < bunniesCoordinates.Count; i += 2)
                {
                    int bunnyRow = bunniesCoordinates[i];
                    int bunnyCol = bunniesCoordinates[i + 1];
                    SpreadBunny(matrix, bunnyRow, bunnyCol);
                }

                 isDead = IsSymbol(matrix, 'B', playerRow, playerCol);
                if (isWon||isDead)
                {
                    break;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
            if (isWon)
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
            else if (isDead)
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }

        }

        private static void SpreadBunny(char[,] matrix, int bunnyRow, int bunnyCol)
        {
            if (bunnyRow - 1 >= 0)
            {
                matrix[bunnyRow - 1, bunnyCol] = 'B';
            }
            if (bunnyRow + 1 < matrix.GetLength(0))
            {
                matrix[bunnyRow + 1, bunnyCol] = 'B';
            }
            if (bunnyCol - 1 >= 0)
            {
                matrix[bunnyRow, bunnyCol - 1] = 'B';
            }
            if (bunnyCol + 1 < matrix.GetLength(1))
            {
                matrix[bunnyRow, bunnyCol + 1] = 'B';
            }
        }

        private static bool IsSymbol(char[,] matrix, char symbol, int row, int col)
        {
            bool isSymbol = false;
            if (matrix[row, col] == symbol)
            {
                isSymbol = true;
            }
            return isSymbol;
        }

        private static bool IsWon(char[,] matrix, int row, int col)
        {
            bool isWon = true;
            if (row >= 0 && row < matrix.GetLength(0) &&
                col >= 0 && col < matrix.GetLength(1))
            {
                isWon = false;
            }
            return isWon;
        }
    }
}
