using System;

namespace _06.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylons = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            /*Сума за найлон: (10 + 2) * 1.50 = 18 лв.
            Сума за боя: (11 + 10 %) * 14.50 = 175.45 лв.
            Сума за разредител: 4 * 5.00 = 20.00 лв.
            Сума за торбички: 0.40 лв.
            Обща сума за материали: 18 + 175.45 + 20.00 + 0.40 = 213.85 лв.
            Сума за майстори: (213.85 * 30 %) * 8 = 513.24 лв.
            Крайна сума: 213.85 + 513.24 = 727.09 лв.*/

            double priceForNylons = (nylons + 2) * 1.50;
            double priceForPaint = (paint + paint * 0.1) * 14.50;
            double priceForThinner = thinner * 5;
            double price = priceForNylons + priceForPaint + priceForThinner + 0.40;
            double priceForMasterPerHour = price * 0.3;
            double priceForMasters = priceForMasterPerHour * hours;
            double finalPrice = price + priceForMasters;
            Console.WriteLine(finalPrice);
        }
    }
}
