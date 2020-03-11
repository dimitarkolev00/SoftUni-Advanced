using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstBoxInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] secondBoxInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> firstQueue = new Queue<int>(firstBoxInput);
            Stack<int> secondSkack = new Stack<int>(secondBoxInput);

            List<int> claimedItemsSum = new List<int>();


            while (firstQueue.Count != 0 && secondSkack.Count != 0)
            {
                int currentFirst = firstQueue.Peek();
                int currentSecond = secondSkack.Peek();

                int sum = currentFirst + currentSecond;

                if (sum % 2 == 0)
                {
                    claimedItemsSum.Add(sum);
                    firstQueue.Dequeue();
                    secondSkack.Pop();
                }
                else
                {
                    int itemToMove = currentSecond;
                    firstQueue.Enqueue(itemToMove);
                    secondSkack.Pop();
                }
            }
            if (firstQueue.Count <= 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (secondSkack.Count <= 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            int totalSum = claimedItemsSum.Sum();
            if (totalSum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {totalSum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {totalSum}");
            }
        }
    }
}
