using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int hoursToMin = hours * 60;
            int allMin = hoursToMin + minutes + 30;

            int hourAfter30Mins = allMin / 60;
            int minAfter30Min = allMin % 60;

            if (minAfter30Min > 59)
            {
                hourAfter30Mins++;
            }
            if (hourAfter30Mins > 23)
            {
                hourAfter30Mins = 0;
            }

            Console.WriteLine($"{hourAfter30Mins}:{minAfter30Min:d2}");
        }
    }
}
