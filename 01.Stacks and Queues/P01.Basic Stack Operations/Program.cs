using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] numbersToPop = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbers = new Stack<int>();

            int n = input[0];
            int s = input[1];
            int x = input[2];
            FillStack(numbersToPop, numbers, n);
            DeleteFroStack(numbers, s);
            if (numbers.Contains(x))
            {
                Console.WriteLine("true");

            }
            else
            {
                if (numbers.Count==0)
                {
                    Console.WriteLine("0");
                }
                else 
                {
                    Console.WriteLine(numbers.Min());
                }
               
            }
        }

        private static void DeleteFroStack(Stack<int> numbers, int s)
        {
            for (int i = 0; i < s; i++)
            {
                numbers.Pop();
            }
        }

        private static void FillStack(int[] numbersToPop, Stack<int> numbers, int n)
        {
            for (int i = 0; i < n; i++)
            {
                numbers.Push(numbersToPop[i]);
            }
        }
    }
}
