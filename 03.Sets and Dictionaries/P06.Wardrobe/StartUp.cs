using System;
using System.Collections.Generic;

namespace _6._Wardrobe
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = commandArgs[0];

                string[] clothes = commandArgs[1]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                foreach (var cloth in clothes)
                {
                    if (!wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color][cloth] = 0;
                    }
                    wardrobe[color][cloth]++;

                }
            }

            string[] searchArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string searchColor = searchArgs[0];
            string searchCloth = searchArgs[1];

            foreach (var cdp in wardrobe)
            {
                string color = cdp.Key;
                Dictionary<string, int> clothes = cdp.Value;
                Console.WriteLine($"{color} clothes:");

                foreach (var cqp in clothes)
                {
                    string cloth = cqp.Key;
                    int quantity = cqp.Value;

                    if (color == searchColor && cloth == searchCloth)
                    {
                        Console.WriteLine($"* {cloth} - {quantity} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth} - {quantity} ");
                    }
                }
            }
        }
    }
}
