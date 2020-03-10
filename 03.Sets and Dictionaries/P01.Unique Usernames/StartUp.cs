using System;
using System.Collections.Generic;

namespace _1._Unique_Usernames
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string inputName = Console.ReadLine();
                set.Add(inputName);
            }

            foreach (var item in set)
            {
                Console.WriteLine(string.Join(" "+Environment.NewLine,item));
            }
        }
    }
}
