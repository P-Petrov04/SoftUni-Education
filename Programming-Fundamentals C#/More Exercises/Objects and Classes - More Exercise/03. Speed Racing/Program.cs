using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Speed_Racing
{
    class Car
    {
        public Car(string model, double fuel, double fuelPerKm)
        {
            this.Model = model;
            this.Fuel = fuel;
            this.FuelPerKm = fuelPerKm;
            this.Distance = 0;
        }
        public string Model { get; set; }
        public double Fuel { get; set; }
        public double FuelPerKm { get; set; }
        public double Distance { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] carArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carArgs[0];
                double fuel = double.Parse(carArgs[1]);
                double fuelPerKm = double.Parse(carArgs[2]);

                Car newCar = new Car(model, fuel, fuelPerKm);
                cars.Add(newCar);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] comdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = comdArgs[1];
                double km = double.Parse(comdArgs[2]);

                Car currentCar = cars.FirstOrDefault(c => c.Model == model);
                double neededFuel = km * currentCar.FuelPerKm;
                if (neededFuel <= currentCar.Fuel)
                {
                    currentCar.Fuel -= neededFuel;
                    currentCar.Distance += km;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

                command = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.Distance}");
            }
        }
    }
}
