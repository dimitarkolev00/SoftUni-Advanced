using System;

namespace Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var personInfo = Console.ReadLine().Split();

            string fullName = $"{personInfo[0]} {personInfo[1]}";
            string address = $"{personInfo[2]}";
            string town = $"{personInfo[3]}";

            var nameAndBeer = Console.ReadLine().Split();
            string name1 = nameAndBeer[0];
            int beersAmount = int.Parse(nameAndBeer[1]);
            string isDrunk = nameAndBeer[2];

            bool isDrunkOrNot;

            if (isDrunk == "drunk")
            {
                isDrunkOrNot = true;
            }
            else
            {
                isDrunkOrNot = false;
            }

            var thirdInput = Console.ReadLine().Split();
            string name2 = thirdInput[0];
            double bankBalance = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];

            Tuple<string, string, string> firtTuple = new Tuple<string, string, string>(fullName, address, town);
            Tuple<string, int, bool> secondTuple = new Tuple<string, int, bool>(name1, beersAmount, isDrunkOrNot);
            Tuple<string, double, string> thirdTuple = new Tuple<string, double, string>(name2, bankBalance, bankName);

            Console.WriteLine(firtTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
