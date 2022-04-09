using System;

namespace _06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double foodDogPerDay = double.Parse(Console.ReadLine());
            double foodCatPerDay = double.Parse(Console.ReadLine());
            double foodТurtlePerDay = double.Parse(Console.ReadLine());

            double foodDog = foodDogPerDay * days;
            double foodCat = foodCatPerDay * days;
            double foodTurtle = foodТurtlePerDay * days;
            double foodTurtleInKg = foodTurtle / 1000;

            double foodNeed = foodDog + foodCat + foodTurtleInKg;

            if (food >= foodNeed)
            {
                double foodLeft = food - foodNeed;
                foodLeft = Math.Floor(foodLeft);
                Console.WriteLine($"{foodLeft} kilos of food left.");
            }
            else
            {
                double foodNeeded = foodNeed - food;
                foodNeeded = Math.Ceiling(foodNeeded);
                Console.WriteLine($"{foodNeeded} more kilos of food are needed.");
            }
        }
    }
}
