using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] directions = Console.ReadLine().Split(' ').ToArray();
            int row = 0;
            int col = 0;
            string[][] field = new string[n][];

            for (int i = 0; i < n; i++)
            {

                field[i] = Console.ReadLine().Split(' ').ToArray();
                if (field[i].Contains("s"))
                {
                    row = i;
                    col = Array.IndexOf(field[i], "s");
                }
            }
            HashSet<Tuple<int, int>> coalLocations = new HashSet<Tuple<int, int>>();
            GetLocations(coalLocations, field);
            Tuple<int, int> eLocation = GetLocationOfe(field);

            for (int i = 0; i < directions.Length; i++)
            {
                string direction = directions[i];
                switch (direction)
                {
                    case "left":
                        if (col > 0)
                        {
                            col--;
                        }
                        break;
                    case "right":
                        if (col + 1 < field[row].Length)
                        {
                            col++;
                        }
                        break;
                    case "up":
                        if (row > 0)
                        {
                            row--;
                        }
                        break;
                    case "down":
                        if (row + 1 < field.Length)
                        {
                            row++;
                        }
                        break;
                }
                if (eLocation.Equals(new Tuple<int, int>(row, col)))
                {
                    Console.WriteLine($"Game over! ({row}, {col})");
                    return;
                }
                if (coalLocations.Contains(new Tuple<int, int>(row, col)))
                {
                    coalLocations.Remove(new Tuple<int, int>(row, col));
                    if (coalLocations.Count == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({row}, {col})");
                        return;
                    }
                }

            }
            Console.WriteLine($"{coalLocations.Count} coals left. ({row}, {col})");
        }

        private static Tuple<int, int> GetLocationOfe(string[][] field)
        {
            int row = 0;
            int col = 0;
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j] == "e")
                    {
                        row = i;
                        col = j;
                    }
                }
            }
            return new Tuple<int, int>(row, col);
        }


        private static HashSet<Tuple<int, int>> GetLocations(HashSet<Tuple<int, int>> coalLocations, string[][] field)
        {
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j] == "c")
                    {
                        coalLocations.Add(new Tuple<int, int>(i, j));
                    }
                }
            }

            return coalLocations;
        }
    }
}