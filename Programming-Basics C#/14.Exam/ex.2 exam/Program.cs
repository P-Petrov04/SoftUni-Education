using System;

namespace ex._2_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int procesorsCount = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int daysForWork = int.Parse(Console.ReadLine());

            int hours = workersCount * daysForWork * 8;
            double processorsPerAllHours = hours / 3;
            processorsPerAllHours = Math.Floor(processorsPerAllHours);

            if (processorsPerAllHours < procesorsCount)
            {
                double neededProcessors = procesorsCount - processorsPerAllHours;
                double moneyDown = neededProcessors * 110.10;
                Console.WriteLine($"Losses: -> {moneyDown:f2} BGN");
            }
            else
            {
                double moreProcessors = processorsPerAllHours - procesorsCount;
                double spendMoney = moreProcessors * 110.10;
                Console.WriteLine($"Profit: -> {spendMoney:f2} BGN");
            }
        }
    }
}
