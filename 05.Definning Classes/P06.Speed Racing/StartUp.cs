using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = data[0];
                double fuelAmount = double.Parse(data[1]);
                double fuelConsumption = double.Parse(data[2]);

                Car currentCar = new Car(model, fuelAmount, fuelConsumption);

                cars.Add(currentCar);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                else
                {
                    string[] data = input
                        .Split(' ')
                        .ToArray();

                    string model = data[1];
                    double amountKm = double.Parse(data[2]);

                    Car carForDriving = cars
                        .Where(x => x.Model == model)
                        .First();

                    carForDriving.CanIReachTheDistance( amountKm);
                }
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{ item.Model} { item.FuelAmount:F2} {item.TravelledDistance}");
            }
        }
    
    }
}
