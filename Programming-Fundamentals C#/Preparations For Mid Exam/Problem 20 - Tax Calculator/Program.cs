using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_20___Tax_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = Console.ReadLine().Split(">>").ToList();

            int taxes = 0;
            double finaltax = 0;
            double totalTaxes = 0;
            bool isValidCar = true;
            for (int i = 0; i < cars.Count; i++)
            {
                List<string> argOfCurrentCar = cars[i].Split().ToList();
                string carType = argOfCurrentCar[0];
                int yearsOfCar = int.Parse(argOfCurrentCar[1]);
                int kmOfCar = int.Parse(argOfCurrentCar[2]);

                if (carType == "family")
                {
                    taxes = 50;
                    finaltax = kmOfCar / 3000 * 12 + (taxes - yearsOfCar * 5);
                }
                else if (carType == "heavyDuty")
                {
                    taxes = 80;
                    finaltax = kmOfCar / 9000 * 14 + (taxes - yearsOfCar * 8);
                }
                else if (carType == "sports")
                {
                    taxes = 100;
                    finaltax = kmOfCar / 2000 * 18 + (taxes - yearsOfCar * 9);
                }
                else
                {
                    Console.WriteLine("Invalid car type.");
                    isValidCar = false;
                    continue;
                }
                if (isValidCar)
                {
                    Console.WriteLine($"A {carType} car will pay {finaltax:f2} euros in taxes.");
                }
                totalTaxes += finaltax;
                isValidCar = true;
            }

            Console.WriteLine($"The National Revenue Agency will collect {totalTaxes:f2} euros in taxes.");
        }
    }
}
