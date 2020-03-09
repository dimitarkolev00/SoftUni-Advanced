using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] locks = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int intelligenceValue = int.Parse(Console.ReadLine());

            int sumOfBullets = 0;
            int shotsCount = 0;

            Stack<int> bulletsStack = new Stack<int>(bullets);
            Queue<int> locksQueue = new Queue<int>(locks);

            while (locksQueue.Count != 0 && bulletsStack.Count != 0)
            {
                int curentBullet = bulletsStack.Peek();
                int currentLock = locksQueue.Peek();

                if (curentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    bulletsStack.Pop();
                    locksQueue.Dequeue();
                    sumOfBullets += bulletPrice;
                    shotsCount++;

                }
                else if (curentBullet > currentLock)
                {
                    Console.WriteLine("Ping!");
                    bulletsStack.Pop();
                    sumOfBullets += bulletPrice;
                    shotsCount++;
                }

                if (shotsCount == gunBarrelSize)
                {
                    shotsCount = 0;
                    if (bulletsStack.Count == 0)
                    {
                    }
                    else
                    {
                        Console.WriteLine("Reloading!");
                    }

                }
            }
            int earnedMoney = intelligenceValue - sumOfBullets;
            if (locksQueue.Count == 0)
            {
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${earnedMoney}");
            }
            else if (bulletsStack.Count == 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
        }
    }
}
