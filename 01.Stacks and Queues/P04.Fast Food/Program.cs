using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.__Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFoodQuantity = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(input);

            while (orders.Any())
            {
                int biggestOrder = orders.Max();
                Console.WriteLine(biggestOrder);
                int n = orders.Count;

                for (int i = 0; i < n; i++)
                {
                    int currentOrder = input[i];

                    if (totalFoodQuantity < currentOrder)
                    {
                        Console.WriteLine($"Orders left: " + string.Join(" ", orders));
                        return;
                    }

                    else if (totalFoodQuantity >= currentOrder)
                    {
                        totalFoodQuantity -= currentOrder;
                        orders.Dequeue();
                        if (orders.Count == 0)
                        {
                            Console.WriteLine("Orders complete");
                        }
                    }

                }
            }
        }
    }
}
