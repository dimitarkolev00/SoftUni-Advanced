using System;
using System.Collections.Generic;

namespace _5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();

            foreach (var ch in input)
            {
                if (!dictionary.ContainsKey(ch))
                {
                    dictionary[ch] = 0;
                }
                dictionary[ch]++;

            }
            foreach (var (key, value) in dictionary)
            {
                Console.WriteLine($"{key}: {value} time/s");
            }
        }
    }
}
