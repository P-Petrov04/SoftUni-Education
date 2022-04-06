using System;

namespace _03._TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int hoursInMin = hours * 60;
            int minutesAfter15 = minutes + hoursInMin + 15;
            int finalHours = minutesAfter15 / 60;
            int finalMins = minutesAfter15 % 60;

            if (finalHours == 24)
            {
                finalHours = 0;
            }
            Console.WriteLine($"{finalHours}:{finalMins:D2}");
        }
    }
}
