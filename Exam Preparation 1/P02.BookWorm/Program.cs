﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P02.BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] initialWord = Console.ReadLine()
                .ToCharArray();
            Stack<char> word = new Stack<char>(initialWord);

            int n = int.Parse(Console.ReadLine());
            char[][] field = new char[n][];

            int playerRow = 0;
            int playerCol = 0;
            bool playerPositionFound = false;

            InitializeField(n, field, ref playerRow, ref playerCol, ref playerPositionFound);

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "up")
                {
                    playerRow = MoveUp(word, field, playerRow, playerCol);
                }
                else if (command == "down")
                {
                    if (playerRow + 1 < n)
                    {
                        playerRow++;
                        char symbol = field[playerRow][playerCol];
                        if (Char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }
                        field[playerRow][playerCol] = 'P';
                        field[playerRow - 1][playerCol] = '-';
                    }
                    else
                    {
                        Punish(word);
                    }
                }
                else if (command == "left")
                {
                    if (playerCol - 1 >= 0)
                    {
                        playerCol--;
                        char symbol = field[playerRow][playerCol];
                        if (Char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }
                        field[playerRow][playerCol] = 'P';
                        field[playerRow][playerCol + 1] = '-';
                    }
                    else
                    {
                        Punish(word);
                    }
                }
                else if (command == "right")
                {
                    if (playerCol + 1 < n)
                    {
                        playerCol++;
                        char symbol = field[playerRow][playerCol];
                        if (Char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }
                        field[playerRow][playerCol] = 'P';
                        field[playerRow][playerCol - 1] = '-';
                    }
                    else
                    {
                        Punish(word);
                    }
                }
            }
            Console.WriteLine(String.Join("", word.Reverse()));

            PrintField(field);
        }

        private static void PrintField(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    Console.Write(field[row][col]);
                }
                Console.WriteLine();
            }
        }

        private static int MoveUp(Stack<char> word, char[][] field, int playerRow, int playerCol)
        {
            if (playerRow - 1 >= 0)
            {
                playerRow--;
                char symbol = field[playerRow][playerCol];
                if (Char.IsLetter(symbol))
                {
                    word.Push(symbol);
                }
                field[playerRow][playerCol] = 'P';
                field[playerRow + 1][playerCol] = '-';
            }
            else
            {
                Punish(word);
            }

            return playerRow;
        }

        private static void Punish(Stack<char> word)
        {
            if (word.Count > 0)
            {
                word.Pop();
            }
        }

        private static void InitializeField(int n, char[][] field, ref int playerRow, ref int playerCol, ref bool playerPositionFound)
        {
            for (int row = 0; row < n; row++)
            {
                char[] currentRow = Console.ReadLine()
                    .ToCharArray();
                if (!playerPositionFound)
                {
                    for (int col = 0; col < currentRow.Length; col++)
                    {
                        if (currentRow[col] == 'P')
                        {
                            playerRow = row;
                            playerCol = col;
                            playerPositionFound = true;
                            break;
                        }
                    }
                }
                field[row] = currentRow;
            }
        }
    }
}
