using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;

            int greenSec = greenLight;
            int freeSec = freeWindow;
            string command = Console.ReadLine();
            while (command != "END")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                    command = Console.ReadLine();
                    continue;
                }

                while (cars.Count > 0)
                {
                    string currCar = cars.Dequeue();
                    if (greenSec >= currCar.Length)
                    {
                        greenSec -= currCar.Length;
                        passedCars++;
                        if (greenSec == 0)
                        {
                            break;
                        }
                        continue;
                    }
                    else if (greenSec + freeSec >= currCar.Length)
                    {
                        passedCars++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{currCar} was hit at {currCar[greenSec + freeSec]}.");
                        Environment.Exit(0);
                    }
                }

                greenSec = greenLight;
                command = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}
