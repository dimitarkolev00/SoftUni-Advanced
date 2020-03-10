using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.GenericBoxofString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<double> elements = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double element = double.Parse(Console.ReadLine());
                elements.Add(element);

            }
            Box<double> box = new Box<double>(elements);

            double elToCompare = double.Parse(Console.ReadLine());
            int countOfGreaterEl = box.CountGreaterElements(elements, elToCompare);

            Console.WriteLine(countOfGreaterEl);

        }
    }
}
