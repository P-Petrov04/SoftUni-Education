using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Raw_Data
{
    class Engine
    {
        public Engine(int speed, int power)
        {
            this.EngineSpeed = speed;
            this.EnginePower = power;
        }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
    class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }
        public int Weight { get; set; }
        public string Type { get; set; }
    }
    class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.EngineInfo = engine;
            this.CargoInfo = cargo;
        }
        public string Model { get; set; }
        public Engine EngineInfo { get; set; }
        public Cargo CargoInfo { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> allCars = new List<Car>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] carArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carArgs[0];
                int speed = int.Parse(carArgs[1]);
                int power = int.Parse(carArgs[2]);
                int weight = int.Parse(carArgs[3]);
                string cargoType = carArgs[4];

                Engine newEngine = new Engine(speed, power);
                Cargo newCargo = new Cargo(weight, cargoType);

                Car newCar = new Car(model, newEngine, newCargo);
                allCars.Add(newCar);
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                List<Car> neededCars = allCars
                    .Where(c => c.CargoInfo.Type == "fragile" && c.CargoInfo.Weight < 1000)
                    .ToList();

                foreach (Car car in neededCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command == "flamable")
            {
                List<Car> neededCars = allCars
                    .Where(c => c.CargoInfo.Type == "flamable" && c.EngineInfo.EnginePower > 250)
                    .ToList();

                foreach (Car car in neededCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
