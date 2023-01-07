using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsPass = int.Parse(Console.ReadLine());
            string car = Console.ReadLine();
            Queue<string> allCars = new Queue<string>();
            int countPassCars = 0;
            while (car != "end")
            {
                if (car != "green")
                {
                    allCars.Enqueue(car);
                }
                else
                {
                    for (int i = 0; i < carsPass; i++)
                    {
                        if (allCars.Count == 0)
                        {
                            break;
                        }
                        string currCar = allCars.Dequeue();
                        Console.WriteLine($"{currCar} passed!");
                        countPassCars++;
                    }
                }

                car = Console.ReadLine();
            }

            Console.WriteLine($"{countPassCars} cars passed the crossroads.");
        }
    }
}
