using System;

namespace ex._6_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int locations = int.Parse(Console.ReadLine());
            double allGold = 0;

            for (int i = 1; i <= locations; i++)
            {
                double averageYield = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                for (int o = 1; o <= days; o++)
                {
                    double goldPerDay = double.Parse(Console.ReadLine());
                    allGold += goldPerDay;
                }
                double averageGold = allGold / days;
                if (averageGold >= averageYield)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageGold:f2}.");
                }
                if (averageGold < averageYield)
                {
                    double goldNeeded = averageYield - averageGold;
                    Console.WriteLine($"You need {goldNeeded:f2} gold.");
                }
                allGold = 0;
            }
        }
    }
}
