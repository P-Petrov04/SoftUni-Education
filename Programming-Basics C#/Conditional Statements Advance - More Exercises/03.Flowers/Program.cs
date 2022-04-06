using System;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());

            double moneyFlowers = 0;
            double discount = 0;

           if (season == "Spring" || season == "Summer")
            {
                moneyFlowers = chrysanthemums * 2.00 + roses * 4.10 + tulips * 2.5;

                
            }
           else if (season == "Autumn" || season == "Winter")
            {
                moneyFlowers = chrysanthemums * 3.75 + roses * 4.50 + tulips * 4.15;
            }

           if (holiday == 'Y')
            {
                moneyFlowers += moneyFlowers * 0.15;
            }
            if (season == "Spring" && tulips > 7)
            {
                discount += 0.05;
                moneyFlowers = moneyFlowers - moneyFlowers * discount;
            }
            if (season == "Winter" && roses >= 10)
            {
                discount = 0.1;
                moneyFlowers = moneyFlowers - moneyFlowers * discount;
            }
            if (chrysanthemums + roses + tulips > 20)
            {
                discount = 0.2;
                moneyFlowers = moneyFlowers - moneyFlowers * discount;
            }
            moneyFlowers += 2;

            Console.WriteLine($"{moneyFlowers:f2}");
        }
    }
}
