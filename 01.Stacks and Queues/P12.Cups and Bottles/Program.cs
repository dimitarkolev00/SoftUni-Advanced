using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] filledBottles = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> bottlesStack = new Stack<int>(filledBottles);
            Queue<int> cupsQueue = new Queue<int>(cupsCapacity);

            int wastedWater = 0;

            while (true)
            {
                int currentCupCapacity = cupsQueue.Peek();
                int currentBottleCapacity = bottlesStack.Peek();

                if (currentBottleCapacity >= currentCupCapacity)
                {
                    wastedWater += currentBottleCapacity - currentCupCapacity;
                    bottlesStack.Pop();
                    cupsQueue.Dequeue();
                }
                else if (currentBottleCapacity < currentCupCapacity)
                {
                    currentCupCapacity -= currentBottleCapacity;
                    bottlesStack.Pop();
                    while (currentCupCapacity > 0)
                    {
                        int nextBottleCapacity = bottlesStack.Peek();
                        if (nextBottleCapacity < currentCupCapacity)
                        {
                            currentCupCapacity -= nextBottleCapacity;
                            bottlesStack.Pop();
                        }
                        else if (nextBottleCapacity >= currentCupCapacity)
                        {
                            wastedWater += nextBottleCapacity - currentCupCapacity;
                            bottlesStack.Pop();
                            currentCupCapacity = 0;
                            if (cupsQueue.Any())
                            {
                                cupsQueue.Dequeue();
                            }
                        }
                    }

                }
                if (cupsQueue.Count <= 0)
                {
                    var remainingBottles = $"{string.Join(' ', bottlesStack)}";
                    Console.WriteLine($"Bottles: {remainingBottles}");
                    break;
                }
                else if (bottlesStack.Count <= 0)
                {
                    var remainingCups = $"{string.Join(' ', cupsQueue)}";
                    Console.WriteLine($"Cups: {remainingCups}");
                    break;
                }

            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");

        }
    }
}
