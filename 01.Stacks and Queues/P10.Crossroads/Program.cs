﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.__Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightInterval = int.Parse(Console.ReadLine());
            int freeWindowInterval = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            string command;
            bool crash = false;
            string crashedCar = String.Empty;
            int hitIndex = -1;

            int passedCars = 0;

            while ((command = Console.ReadLine()) != "END")
            {

                if (command == "green")
                {
                    int currGreenLight = greenLightInterval;
                    while (currGreenLight > 0 && cars.Any())
                    {
                        string currentCar = cars.Peek();
                        int carLength = currentCar.Length;

                        currGreenLight -= carLength;
                        if (currGreenLight >= 0)
                        {
                            cars.Dequeue();
                            passedCars++;
                        }
                        else
                        {
                            int left = Math.Abs(currGreenLight);

                            if (left <= freeWindowInterval)
                            {
                                cars.Dequeue();
                                passedCars++;
                            }
                            else
                            {
                                crash = true;
                                crashedCar = currentCar;
                                hitIndex = carLength - left + freeWindowInterval;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                if (crash)
                {
                    break;
                }
            }
            if (crash)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{crashedCar} was hit at {crashedCar[hitIndex]}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{passedCars} total cars passed the crossroads.");
            }
        }
    }
}
