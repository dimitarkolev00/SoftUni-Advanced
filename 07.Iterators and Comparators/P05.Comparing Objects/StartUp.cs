using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] personInfo = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                string town = personInfo[2];

                Person person = new Person(name, age, town);
                people.Add(person);
            }
            int n = int.Parse(Console.ReadLine());
            int matchesCount = 0;

            Person personToCompare = people[n - 1];

            foreach (var person in people)
            {
                if (personToCompare.CompareTo(person) == 0)
                {
                    matchesCount++;
                }
            }
            if (matchesCount <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int notMatched = people.Count - matchesCount;

                Console.WriteLine($"{matchesCount} {notMatched} {people.Count}");
            }
        }
    }
}
