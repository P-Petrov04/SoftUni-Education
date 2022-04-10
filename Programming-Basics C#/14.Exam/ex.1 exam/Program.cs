using System;

namespace ex._1_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int videoCard = int.Parse(Console.ReadLine());
            int adapter = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double spendMoneyPerDay = double.Parse(Console.ReadLine());

            int videoCardPrice = videoCard * 13;
            int adapterPrice = adapter * 13;
            int spendMoney = videoCardPrice + adapterPrice + 1000;
            double moneyCardPerDay = spendMoneyPerDay - energy;
            double moneyForAllCardsPerDay = 13 * moneyCardPerDay;
            double days = spendMoney / moneyForAllCardsPerDay;
            days = Math.Ceiling(days);

            Console.WriteLine(spendMoney);
            Console.WriteLine(days);
        }
    }
}
