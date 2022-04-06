using System;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            int workDays = 365 - holidays;
            int playTimeWork = workDays * 63;
            int playTimeHoliday = holidays * 127;
            int realPlayTime = playTimeWork + playTimeHoliday;

            if (realPlayTime <= 30000)
            {
                int timeMoreSleep = 30000 - realPlayTime;
                int minsToHours = timeMoreSleep / 60;
                int minsLeftFromHours = timeMoreSleep % 60;

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{minsToHours} hours and {minsLeftFromHours} minutes less for play");
            }
            else
            {
                int timeLessSleep = realPlayTime - 30000;
                int minsToHours = timeLessSleep / 60;
                int minsLeftFromHours = timeLessSleep % 60;

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{minsToHours} hours and {minsLeftFromHours} minutes more for play");
            }
        }
    }
}
