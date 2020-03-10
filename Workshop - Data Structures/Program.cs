using System;

namespace WorkshopDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList();
            myList.Add(3);
            myList.Add(6);
            myList.Add(9);
            myList.Add(12);

            myList.RemoveAt(3);
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            Console.WriteLine(myList.Count);
            Console.WriteLine(myList.Contains(3));
            Console.WriteLine(myList.Contains(12));
        }
    }
}
