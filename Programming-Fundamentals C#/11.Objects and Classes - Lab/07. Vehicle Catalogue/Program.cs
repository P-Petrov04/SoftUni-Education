using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Catalog
    {
        public Catalog()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] vehicleArgs = input.Split("/");
                string type = vehicleArgs[0];
                string brand = vehicleArgs[1];
                string model = vehicleArgs[2];
                int finalParam = int.Parse(vehicleArgs[3]);

                if (type == "Car")
                {
                    Car newCar = new Car(brand, model, finalParam);
                    catalog.Cars.Add(newCar);
                }
                else
                {
                    Truck newTruck = new Truck(brand, model, finalParam);
                    catalog.Trucks.Add(newTruck);
                }

                input = Console.ReadLine();
            }

            List<Car> sortedCars = catalog.Cars.OrderBy(c => c.Brand).ToList();
            List<Truck> sortedTrucks = catalog.Trucks.OrderBy(t => t.Brand).ToList();
            
            if (sortedCars.Count != 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (sortedTrucks.Count != 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in sortedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
