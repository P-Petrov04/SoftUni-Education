using System;

namespace _03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfGoods = int.Parse(Console.ReadLine());

            double pricePerT = 0;
            double allT = 0;
            double averagePriceForAllT = 0;

            double tByMicroBus = 0;
            double tByBus = 0;
            double tByTrain = 0;

            for (int i = 1; i <= numOfGoods; i++)
            {
                int T = int.Parse(Console.ReadLine());
                if (T <= 3)
                {
                    tByMicroBus += T;
                    pricePerT = 200;
                }
                else if (T <= 11)
                {
                    tByBus += T;
                    pricePerT = 175;
                }
                else
                {
                    tByTrain += T;
                    pricePerT = 120;
                }
                allT += T;
            }
            averagePriceForAllT = (tByMicroBus * 200 + tByBus * 175 + tByTrain * 120) / allT;
            double percentMicroBus = tByMicroBus / allT * 100;
            double percentBus = tByBus / allT * 100;
            double percentTrain = tByTrain / allT * 100;

            Console.WriteLine($"{averagePriceForAllT:f2}");
            Console.WriteLine($"{percentMicroBus:f2}%");
            Console.WriteLine($"{percentBus:f2}%");
            Console.WriteLine($"{percentTrain:f2}%");
        }
    }
}
