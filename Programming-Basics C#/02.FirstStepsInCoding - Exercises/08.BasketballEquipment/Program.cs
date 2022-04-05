using System;

namespace _08.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceForYear = int.Parse(Console.ReadLine());

            /*
            Цена на тренировките за година: 365
            Цена на баскетболните кецове: 365 – 40% = 219
            Цена на баскетболен екип: 219 – 20% = 175.20
            Цена на баскетболна топка: 1 / 4 от 175.20 = 43.80
            Цена на баскетболни аксесоари: 1 /  5 от 43.80 = 8.76
            Обща цена за екипировката: 365 + 219 + 175.20 + 43.80 + 8.76 = 811.76*/
            double priceForBoots = priceForYear - priceForYear * 0.4;
            double priceForOutFit = priceForBoots - priceForBoots * 0.2;
            double priceForBall = priceForOutFit / 4;
            double priceForAcc = priceForBall / 5;

            double finalPrice = priceForYear + priceForBoots + priceForOutFit + priceForBall + priceForAcc;
            Console.WriteLine(finalPrice);
        }
    }
}
