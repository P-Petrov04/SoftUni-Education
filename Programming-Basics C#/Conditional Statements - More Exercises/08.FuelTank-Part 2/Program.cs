using System;

namespace _08.FuelTank_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFuel = Console.ReadLine();
            double countFuel = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            double priceFuel = 0;
            double discount = 0;
            double secondDiscount = 0;

            if (typeFuel == "Gasoline")
            {
                priceFuel = 2.22;

                if (card == "Yes")
                {
                    discount = 0.18;
                }
            }
            else if (typeFuel == "Diesel")
            {
                priceFuel = 2.33;

                if (card == "Yes")
                {
                    discount = 0.12;
                }
            }
            else if (typeFuel == "Gas")
            {
                priceFuel = 0.93;

                if (card == "Yes")
                {
                    discount = 0.08;
                }
            }

            double priceForFuel = priceFuel * countFuel - discount * countFuel;

            if (countFuel >=20 && countFuel <= 25)
            {
                secondDiscount = 0.08;
            }
            else if (countFuel > 25)
            {
                secondDiscount = 0.1;
            }

            double finalPrice = priceForFuel - priceForFuel * secondDiscount;

            Console.WriteLine($"{finalPrice:f2} lv.");
        }
    }
}
