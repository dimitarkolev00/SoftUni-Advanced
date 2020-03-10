using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Sets_of_Elements
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] lengths = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            HashSet<int> firstSet = new HashSet<int>();

            for (int i = 0; i < lengths[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < lengths[1]; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(string.Join(" ", firstSet.Intersect(secondSet)));
        }


    }
}
