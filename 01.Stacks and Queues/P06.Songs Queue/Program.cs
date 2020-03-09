using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.__Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var forQueue = Console.ReadLine()
                .Split(", ")
                .ToArray();

            var queue = new Queue<string>(forQueue);

            while (queue.Any())
            {
                var input = Console.ReadLine()
                .Split()
                .ToArray();

                switch (input[0])
                {
                    case "Play":
                        queue.Dequeue();
                        break;
                    case "Add":
                        string song = string.Empty;
                        for (int i = 1; i < input.Length; i++)
                        {
                            song += input[i];
                            if (!(i + 1 == input.Length))
                            {
                                song += " ";
                            }
                        }

                        if (!queue.Contains(song))
                        {
                            queue.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", queue));
                        break;

                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
