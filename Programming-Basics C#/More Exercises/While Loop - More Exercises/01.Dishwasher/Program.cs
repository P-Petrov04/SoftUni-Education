using System;

namespace _01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int preparationBottles = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int preparation = preparationBottles * 750;

            int countPlates = 0;
            int countPots = 0;
            int counter = 0;
            int prepationForVessel = 0;
            int prepationForAllVessels = 0;

            while (input != "End")
            {
                counter++;
                if (counter < 3)
                {
                    prepationForVessel = 5;
                    countPlates += int.Parse(input);
                }
                else
                {
                    prepationForVessel = 15;
                    countPots += int.Parse(input);
                    counter = 0;
                }

                prepationForAllVessels += int.Parse(input) * prepationForVessel;

                if (prepationForAllVessels > preparation)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            preparation -= prepationForAllVessels;
             if (preparation >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{countPlates} dishes and {countPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {preparation} ml.");
            }
             else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(preparation)} ml. more necessary!");
            }
        }
    }
}
