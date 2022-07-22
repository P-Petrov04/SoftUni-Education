using System;

namespace Problem_16___Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int allDays = int.Parse(Console.ReadLine());
            int plunderPerDay = int.Parse(Console.ReadLine());
            double expectedPlunder = int.Parse(Console.ReadLine());

            double allPlunder = 0;
            int countOfDayForThirdDay = 0;
            int countOfDayForFifthDay = 0;
            for (int i = 1; i <= allDays; i++)
            {
                allPlunder += plunderPerDay;
                countOfDayForThirdDay++;
                countOfDayForFifthDay++;

                if (countOfDayForThirdDay == 3)
                {
                    allPlunder +=(double)plunderPerDay / 2;
                    countOfDayForThirdDay = 0;
                }
                if (countOfDayForFifthDay == 5)
                {
                    allPlunder -= allPlunder * 0.3;
                    countOfDayForFifthDay = 0;
                }
            }

            if (allPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {allPlunder:f2} plunder gained.");
            }
            else
            {
                double percentage = allPlunder / expectedPlunder * 100;
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}
