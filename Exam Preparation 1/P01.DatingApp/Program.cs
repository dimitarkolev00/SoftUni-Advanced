using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P01.DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] males = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] females = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> malesStack = new Stack<int>(males);
            Queue<int> femaleQueue = new Queue<int>(females);

            int matchesCount = 0;

            while (malesStack.Count > 0 && femaleQueue.Count > 0)
            {
                int currentMale = malesStack.Peek();
                int currentFemale = femaleQueue.Peek();

                if (currentMale <= 0)
                {
                    malesStack.Pop();
                    continue;
                }
                if (currentFemale <= 0)
                {
                    femaleQueue.Dequeue();
                    continue;
                }

                if (currentFemale % 25 == 0)
                {
                    femaleQueue.Dequeue();
                    if (femaleQueue.Count >= 1)
                    {
                        femaleQueue.Dequeue();
                    }
                    continue;
                }

                if (currentMale % 25 == 0)
                {
                    malesStack.Pop();
                    if (malesStack.Count >= 1)
                    {
                        malesStack.Pop();
                    }
                    continue;
                }

                if (currentMale == currentFemale)
                {
                    matchesCount++;
                    malesStack.Pop();
                    femaleQueue.Dequeue();
                }
                else
                {
                    femaleQueue.Dequeue();

                    malesStack.Pop();
                    malesStack.Push(currentMale - 2);
                }
            }

            Console.WriteLine($"Matches: {matchesCount}");

            if (malesStack.Count == 0)
            {
                Console.WriteLine("Males left: none");
            }
            else
            {
                var result = $"{string.Join(", ", malesStack)}";
                Console.WriteLine($"Males left: {result}");
            }
            if (femaleQueue.Count == 0)
            {
                Console.WriteLine("Females left: none");
            }
            else
            {
                var result = $"{string.Join(", ", femaleQueue)}";
                Console.WriteLine($"Females left: {result}");
            }

        }
    }
}
