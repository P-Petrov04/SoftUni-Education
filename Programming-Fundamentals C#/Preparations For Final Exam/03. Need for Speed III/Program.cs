using System;
using System.Collections.Generic;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split("|");

                GetCarInfo(carInfo, cars);
            }

            string commandInfo = Console.ReadLine();
            while (commandInfo != "Stop")
            {
                string[] commandArgs = commandInfo.Split(" : ");

                string typeCommand = commandArgs[0];
                if (typeCommand == "Drive")
                {
                    string car = commandArgs[1];
                    int distance = int.Parse(commandArgs[2]);
                    int fuelToUse = int.Parse(commandArgs[3]);

                    DriveACar(cars, car, distance, fuelToUse);
                }
                else if (typeCommand == "Refuel")
                {
                    string car = commandArgs[1];
                    int fuelToRefuel = int.Parse(commandArgs[2]);

                    RefuelACar(cars, car, fuelToRefuel);
                }
                else if (typeCommand == "Revert")
                {
                    string car = commandArgs[1];
                    int kilometers = int.Parse(commandArgs[2]);

                    RevertACar(cars, car, kilometers);
                }

                commandInfo = Console.ReadLine();
            }

            PrintAllCars(cars);
        }

        static Dictionary<string, List<int>> GetCarInfo(string[] carInfo, Dictionary<string, List<int>> cars)
        {
            string carName = carInfo[0];
            int mileage = int.Parse(carInfo[1]);
            int fuel = int.Parse(carInfo[2]);

            cars.Add(carName, new List<int>());
            cars[carName].Add(mileage);
            cars[carName].Add(fuel);

            return cars;
        }
        static void DriveACar(Dictionary<string, List<int>> cars, string car, int distance, int fuelToUse)
        {
            if (fuelToUse > cars[car][1])
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            else
            {
                cars[car][0] += distance;
                cars[car][1] -= fuelToUse;
                Console.WriteLine($"{car} driven for {distance} kilometers. {fuelToUse} liters of fuel consumed.");
            }

            if (cars[car][0] >= 100000)
            {
                cars.Remove(car);
                Console.WriteLine($"Time to sell the {car}!");
            }
        }

        static void RefuelACar(Dictionary<string, List<int>> cars, string car, int fuelToRefuel)
        {
            int originalFuelInTank = cars[car][1];

            cars[car][1] += fuelToRefuel;
            if (cars[car][1] > 75)
            {
                cars[car][1] = 75;
            }
            Console.WriteLine($"{car} refueled with {cars[car][1] - originalFuelInTank} liters");
        }

        static void RevertACar(Dictionary<string, List<int>> cars, string car, int kilometers)
        {
            cars[car][0] -= kilometers;
            if (cars[car][0] < 10000)
            {
                cars[car][0] = 10000;

            }
            else
            {
                Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
            }
        }

        static void PrintAllCars(Dictionary<string, List<int>> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}
