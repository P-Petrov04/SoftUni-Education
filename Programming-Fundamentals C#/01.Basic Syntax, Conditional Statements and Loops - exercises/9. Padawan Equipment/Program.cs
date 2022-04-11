using System;

namespace _9._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double johnMoney = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double swords = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            double priceSwords = swords * (countStudents + Math.Ceiling(countStudents * 0.1));
            double priceRobes = robes * countStudents;
            int freeBelts = countStudents / 6;
            double priceBelts = belts * (countStudents - freeBelts);
            double finalPrice = priceSwords + priceRobes + priceBelts;

            if (johnMoney >= finalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {finalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(finalPrice - johnMoney):f2}lv more.");
            }
        }
    }
}
