using System;

namespace _08.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int episodeTime = int.Parse(Console.ReadLine());
            int luchBreakTime = int.Parse(Console.ReadLine());

            double timeForLunch = luchBreakTime / 8.0;
            double timeForRest = luchBreakTime / 4.0;
            double timeLeft = luchBreakTime - timeForLunch - timeForRest;

            if(timeLeft >= episodeTime)
            {
                double freeTime = timeLeft - episodeTime;
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(freeTime)} minutes free time.");
            }
            else
            {
                double timeNeeded = episodeTime - timeLeft;
                timeNeeded = Math.Abs(timeNeeded);
                timeNeeded = Math.Ceiling(timeNeeded);
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {timeNeeded} more minutes.");
            }
        }
    }
}
