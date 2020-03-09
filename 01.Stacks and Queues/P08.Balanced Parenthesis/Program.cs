using System;
using System.Collections.Generic;

namespace _08.__Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>(input);

            if (input.Length % 2 == 1)
            {
                Console.WriteLine("NO");
                return;
            }
            foreach (var item in input)
            {
                switch (item)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(item);
                        break;
                    default:
                        if ((item == ')' || item == '}' || item == ']') && stack.Count > 0)
                        {
                            if (stack.Peek() == '(' && item == ')' || stack.Peek() == '{' && item == '}' || stack.Peek() == '[' && item == ']')
                            {
                                stack.Pop();
                            }
                            else
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                }
            }
            Console.WriteLine("YES");
        }
    }
}
