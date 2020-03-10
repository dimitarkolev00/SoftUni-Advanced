using System;
using System.Collections.Generic;

namespace _3._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> sortedSteck = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int length = input.Length;

                for (int j = 0; j < length; j++)
                {
                    string currentElement = input[j];

                    if (!sortedSteck.Contains(currentElement))
                    {
                        sortedSteck.Add(currentElement);
                    }
                }
            }
            foreach (var el in sortedSteck)
            {
                Console.Write($"{el} ");
            }
        }
    }
}
