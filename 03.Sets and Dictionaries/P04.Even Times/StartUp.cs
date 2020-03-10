using System;
using System.Collections.Generic;

namespace _4._Even_Times
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int curr = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(curr))
                {
                    dict[curr] = 0;
                }
                dict[curr]++;
            }

            foreach (var kvp in dict)
            {
                if (kvp.Value % 2 == 0)
                {
                    Console.WriteLine(kvp.Key);
                    break;
                }
            }

        }
    }
}
