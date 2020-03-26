using System;

namespace P02.TronRaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            int firstPlayerRow = -1;
            int firstPlayerCol = -1;

            int secondPlayerRow = -1;
            int secondPlayerCol = -1;

            int playersCount = 0;

            for (int row = 0; row < n; row++)
            {
                var currentRowInput = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRowInput[col];

                    if (matrix[row, col] == 'f')
                    {
                        firstPlayerRow = row;
                        firstPlayerCol = col;
                        playersCount++;
                    }
                    if (matrix[row, col] == 's')
                    {
                        secondPlayerRow = row;
                        secondPlayerCol = col;
                        playersCount++;
                    }
                }
            }

            int currentRow = firstPlayerRow;
            int currentCol = firstPlayerCol;

            int currentRow2 = secondPlayerRow;
            int currentCol2 = secondPlayerCol;

            while (playersCount > 1)
            {
                string[] commands = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstPlayerCommand = commands[0];
                string secondPlayerCommand = commands[1];


                if (firstPlayerCommand == "up")
                {
                    currentRow = currentRow - 1;

                    if (currentRow >= 0 && currentRow < matrix.GetLength(0) &&
                        currentCol >= 0 && currentCol < matrix.GetLength(1))
                    {
                        if (matrix[currentRow, currentCol] == 's')
                        {
                            matrix[currentRow, currentCol] = 'x';
                            playersCount--;
                            break;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = 'f';
                        }

                    }
                    else
                    {
                        GoToTheOtherSide(n, matrix, ref currentRow, ref currentCol);
                    }
                }
                else if (firstPlayerCommand == "down")
                {
                    currentRow = currentRow + 1;

                    if (currentRow >= 0 && currentRow < matrix.GetLength(0) &&
                        currentCol >= 0 && currentCol < matrix.GetLength(1))
                    {
                        if (matrix[currentRow, currentCol] == 's')
                        {
                            matrix[currentRow, currentCol] = 'x';
                            playersCount--;
                            break;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = 'f';
                        }

                    }
                    else
                    {
                        GoToTheOtherSide(n, matrix, ref currentRow, ref currentCol);
                    }

                }
                else if (firstPlayerCommand == "left")
                {
                    currentCol = currentCol - 1;

                    if (currentRow >= 0 && currentRow < matrix.GetLength(0) &&
                        currentCol >= 0 && currentCol < matrix.GetLength(1))
                    {
                        if (matrix[currentRow, currentCol] == 's')
                        {
                            matrix[currentRow, currentCol] = 'x';
                            playersCount--;
                            break;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = 'f';
                        }

                    }
                    else
                    {
                        GoToTheOtherSide(n, matrix, ref currentRow, ref currentCol);
                    }
                }
                else if (firstPlayerCommand == "right")
                {
                    currentCol = currentCol + 1;

                    if (currentRow >= 0 && currentRow < matrix.GetLength(0) &&
                        currentCol >= 0 && currentCol < matrix.GetLength(1))
                    {
                        if (matrix[currentRow, currentCol] == 's')
                        {
                            matrix[currentRow, currentCol] = 'x';
                            playersCount--;
                            break;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = 'f';
                        }

                    }
                    else
                    {
                        GoToTheOtherSide(n, matrix, ref currentRow, ref currentCol);
                    }
                }


                if (secondPlayerCommand == "up")
                {
                    currentRow2 = currentRow2 - 1;

                    if (currentRow2 >= 0 && currentRow2 < matrix.GetLength(0) &&
                        currentCol2 >= 0 && currentCol2 < matrix.GetLength(1))
                    {
                        if (matrix[currentRow2, currentCol2] == 'f')
                        {
                            matrix[currentRow2, currentCol2] = 'x';
                            playersCount--;
                            break;
                        }
                        else
                        {
                            matrix[currentRow2, currentCol2] = 's';
                        }

                    }
                    else
                    {
                        GoToTheOtherSide2(n, matrix, ref currentRow2, ref currentCol2);
                    }

                }
                else if (secondPlayerCommand == "down")
                {
                    currentRow2 = currentRow2 + 1;

                    if (currentRow2 >= 0 && currentRow2 < matrix.GetLength(0) &&
                        currentCol2 >= 0 && currentCol2 < matrix.GetLength(1))
                    {
                        if (matrix[currentRow2, currentCol2] == 'f')
                        {
                            matrix[currentRow2, currentCol2] = 'x';
                            playersCount--;
                            break;
                        }
                        else
                        {
                            matrix[currentRow2, currentCol2] = 's';
                        }

                    }
                    else
                    {
                        GoToTheOtherSide2(n, matrix, ref currentRow2, ref currentCol2);
                    }

                }
                else if (secondPlayerCommand == "left")
                {
                    currentCol2 = currentCol2 - 1;

                    if (currentRow2 >= 0 && currentRow2 < matrix.GetLength(0) &&
                        currentCol2 >= 0 && currentCol2 < matrix.GetLength(1))
                    {
                        if (matrix[currentRow2, currentCol2] == 'f')
                        {
                            matrix[currentRow2, currentCol2] = 'x';
                            playersCount--;
                            break;
                        }
                        else
                        {
                            matrix[currentRow2, currentCol2] = 's';
                        }

                    }
                    else
                    {
                        GoToTheOtherSide2(n, matrix, ref currentRow2, ref currentCol2);
                    }

                }
                else if (secondPlayerCommand == "right")
                {
                    currentCol2 = currentCol2 + 1;

                    if (currentRow2 >= 0 && currentRow2 < matrix.GetLength(0) &&
                        currentCol2 >= 0 && currentCol2 < matrix.GetLength(1))
                    {
                        if (matrix[currentRow2, currentCol2] == 'f')
                        {
                            matrix[currentRow2, currentCol2] = 'x';
                            playersCount--;
                            break;
                        }
                        else
                        {
                            matrix[currentRow2, currentCol2] = 's';
                        }

                    }
                    else
                    {
                        GoToTheOtherSide2(n, matrix, ref currentRow2, ref currentCol2);
                    }

                }

            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write((char)matrix[row, col]);
                }
                Console.WriteLine();
            }

        }

        private static void GoToTheOtherSide2(int n, int[,] matrix, ref int currentRow2, ref int currentCol2)
        {
            if (currentRow2 + 1 >= matrix.GetLength(0))
            {
                currentRow2 = 0;
                matrix[currentRow2, currentCol2] = 's';
            }
            if (currentRow2 - 1 < 0)
            {
                currentRow2 = n - 1;
                matrix[currentRow2, currentCol2] = 's';
            }
            if (currentCol2 + 1 >= matrix.GetLength(1))
            {
                currentCol2 = 0;
                matrix[currentRow2, currentCol2] = 's';
            }
            if (currentCol2 - 1 < 0)
            {
                currentCol2 = n - 1;
                matrix[currentRow2, currentCol2] = 's';
            }
        }

        private static void GoToTheOtherSide(int n, int[,] matrix, ref int currentRow, ref int currentCol)
        {
            if (currentRow + 1 >= matrix.GetLength(0))
            {
                currentRow = 0;
                matrix[currentRow, currentCol] = 'f';
            }
            if (currentRow - 1 < 0)
            {
                currentRow = n - 1;
                matrix[currentRow, currentCol] = 'f';
            }
            if (currentCol + 1 >= matrix.GetLength(1))
            {
                currentCol = 0;
                matrix[currentRow, currentCol] = 'f';
            }
            if (currentCol - 1 < 0)
            {
                currentCol = n - 1;
                matrix[currentRow, currentCol] = 'f';
            }
        }
    }
}
