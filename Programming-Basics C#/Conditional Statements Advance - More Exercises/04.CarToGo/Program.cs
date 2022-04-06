using System;

namespace _04.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double avaliableMoney = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string carClass = "";
            string typeCar = "";
            double moneyForCar = 0;

            if (avaliableMoney <= 100)
            {
                carClass = "Economy class";

                if (season == "Summer")
                {
                    typeCar = "Cabrio";
                    moneyForCar = avaliableMoney * 0.35;

                }
                else if (season == "Winter")
                {
                    typeCar = "Jeep";
                    moneyForCar = avaliableMoney * 0.65;
                }
            }
            else if (avaliableMoney <= 500)
            {
                carClass = "Compact class";

                if (season == "Summer")
                {
                    typeCar = "Cabrio";
                    moneyForCar = avaliableMoney * 0.45;

                }
                else if (season == "Winter")
                {
                    typeCar = "Jeep";
                    moneyForCar = avaliableMoney * 0.80;
                }
            }
            else
            {
                carClass = "Luxury class";
                typeCar = "Jeep";
                moneyForCar = avaliableMoney * 0.9;
            }
            Console.WriteLine(carClass);
            Console.WriteLine($"{typeCar} - {moneyForCar:f2}");
        }
    }
}
