using System;

namespace _05.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double avaliableMoney = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "";
            string accommodation = "";
            double moneyForVacation = 0;

            if (avaliableMoney <= 1000)
            {
                accommodation = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    moneyForVacation = avaliableMoney * 0.65;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    moneyForVacation = avaliableMoney * 0.45;
                }
            }
            else if (avaliableMoney <= 3000)
            {
                accommodation = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    moneyForVacation = avaliableMoney * 0.80;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    moneyForVacation = avaliableMoney * 0.60;
                }
            }
            else
            {
                accommodation = "Hotel";
                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                }
                moneyForVacation = avaliableMoney * 0.90;
            }

            Console.WriteLine($"{location} - {accommodation} - {moneyForVacation:f2}");
        }
    }
}
