using System;
using System.Linq;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int commandsCount = int.Parse(Console.ReadLine());

            char[][] field = new char[size][];
            int startingRow = 0;
            int startingCol = 0;

            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == 'f')
                    {
                        startingRow = row;
                        startingCol = i;
                    }
                }
                field[row] = input.ToArray();
            }
            bool hasWon = false;
            field[startingRow][startingCol] = '-';

            for (int i = 0; i < commandsCount; i++)
            {
                string command = Console.ReadLine();
                if (command == "up")
                {
                    if (startingRow - 1 >= 0)
                    {
                        startingRow--;
                    }
                    else
                    {
                        startingRow = size - 1;
                    }
                }
                else if (command == "down")
                {
                    if (startingRow + 1 < size)
                    {
                        startingRow++;
                    }
                    else
                    {
                        startingRow = 0;
                    }
                }
                else if (command == "left")
                {
                    if (startingCol - 1 >= 0)
                    {
                        startingCol--;
                    }
                    else
                    {
                        startingCol = size - 1;
                    }
                }
                else if (command == "right")
                {
                    if (startingCol + 1 < size)
                    {
                        startingCol++;
                    }
                    else
                    {
                        startingCol = 0;
                    }
                }


                if (field[startingRow][startingCol] == 'B')
                {
                    if (command == "up")
                    {
                        if (startingRow - 1 >= 0)
                        {
                            startingRow--;
                        }
                        else
                        {
                            startingRow = size - 1;
                        }
                    }
                    else if (command == "down")
                    {
                        if (startingRow + 1 < size)
                        {
                            startingRow++;
                        }
                        else
                        {
                            startingRow = 0;
                        }
                    }
                    else if (command == "left")
                    {
                        if (startingCol - 1 >= 0)
                        {
                            startingCol--;
                        }
                        else
                        {
                            startingCol = size - 1;
                        }
                    }
                    else if (command == "right")
                    {
                        if (startingCol + 1 < size)
                        {
                            startingCol++;
                        }
                        else
                        {
                            startingCol = 0;
                        }
                    }
                }


                if (field[startingRow][startingCol] == 'F')
                {
                    field[startingRow][startingCol] = 'f';
                    hasWon = true;
                    Console.WriteLine("Player won!");
                    for (int row = 0; row < size; row++)
                    {
                        Console.WriteLine(string.Join("", field[row]));
                    }
                    break;
                }
                else if (field[startingRow][startingCol] == 'T')
                {
                    if (command == "up")
                    {
                        if (startingRow + 1 < size)
                        {
                            startingRow++;
                        }
                        else
                        {
                            startingRow = 0;
                        }
                    }
                    else if (command == "down")
                    {
                        if (startingRow - 1 >= 0)
                        {
                            startingRow--;
                        }
                        else
                        {
                            startingRow = size - 1;
                        }
                    }
                    else if (command == "left")
                    {
                        if (startingCol + 1 < size)
                        {
                            startingCol++;
                        }
                        else
                        {
                            startingCol = 0;
                        }
                    }
                    else if (command == "right")
                    {
                        if (startingCol - 1 >= 0)
                        {
                            startingCol--;
                        }
                        else
                        {
                            startingCol = size - 1;
                        }
                    }
                }
            }

            if (!hasWon)
            {
                field[startingRow][startingCol] = 'f';
                Console.WriteLine("Player lost!");
                for (int row = 0; row < size; row++)
                {
                    Console.WriteLine(string.Join("", field[row]));
                }
            }
        }
    }
}