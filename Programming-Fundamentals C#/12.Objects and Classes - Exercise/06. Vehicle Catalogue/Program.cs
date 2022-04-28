using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Car
    {
        public Car(string model, string color, int horsePower)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePowers = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePowers { get; set; }
    }
    class Truck
    {
        public Truck(string model, string color, int horsePower)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePowers = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePowers { get; set; }
    }
    class Catalog
    {
        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            string vehicle = Console.ReadLine();
            while (vehicle != "End")
            {
                string[] vehicleArgs = vehicle.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = vehicleArgs[0];
                string model = vehicleArgs[1];
                string color = vehicleArgs[2];
                int horsePower = int.Parse(vehicleArgs[3]);

                if (type == "car")
                {
                    Car newCar = new Car(model, color, horsePower);
                    catalog.Cars.Add(newCar);
                }
                else if (type == "truck")
                {
                    Truck newTruck = new Truck(model, color, horsePower);
                    catalog.Trucks.Add(newTruck);
                }

                vehicle = Console.ReadLine();
            }

            string vehicleModel = Console.ReadLine();
            while (vehicleModel != "Close the Catalogue")
            {
                if (catalog.Cars.Any(c => c.Model == vehicleModel))
                {
                    Car currCar = catalog.Cars.FirstOrDefault(c => c.Model == vehicleModel);
                    Console.WriteLine($"Type: Car");
                    Console.WriteLine($"Model: {vehicleModel}");
                    Console.WriteLine($"Color: {currCar.Color}");
                    Console.WriteLine($"Horsepower: {currCar.HorsePowers}");
                }
                else
                {
                    Truck currTruck = catalog.Trucks.FirstOrDefault(t => t.Model == vehicleModel);
                    Console.WriteLine($"Type: Truck");
                    Console.WriteLine($"Model: {vehicleModel}");
                    Console.WriteLine($"Color: {currTruck.Color}");
                    Console.WriteLine($"Horsepower: {currTruck.HorsePowers}");
                }

                vehicleModel = Console.ReadLine();
            }

            double averageHorsePowerOfCars = 0;
            if (catalog.Cars.Count != 0)
            {
                double powerOfCars = 0;
                foreach (Car car in catalog.Cars)
                {
                    double currHorsePower = car.HorsePowers;
                    powerOfCars += currHorsePower;
                }
                averageHorsePowerOfCars = powerOfCars / catalog.Cars.Count;
            }
            Console.WriteLine($"Cars have average horsepower of: {averageHorsePowerOfCars:f2}.");

            double averageHorsePowerOfTrucks = 0;
            if (catalog.Trucks.Count != 0)
            {
                double powerOfTrucks = 0;
                foreach (Truck truck in catalog.Trucks)
                {
                    double currHorsePower = truck.HorsePowers;
                    powerOfTrucks += currHorsePower;
                }
                averageHorsePowerOfTrucks = powerOfTrucks / catalog.Trucks.Count;
            }
            Console.WriteLine($"Trucks have average horsepower of: {averageHorsePowerOfTrucks:f2}.");
        }
    }
}
