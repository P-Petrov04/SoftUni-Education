using System;

namespace _03._exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double kg = double.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());

            double moneyPerKm = 0;
            double moreMoney = 0;
            double kgNewMoney = 0;

            switch (text)
            {
                case "standard":
                    if (kg < 1)
                    {
                        moneyPerKm = 0.03;
                    }
                    else if (kg < 10)
                    {
                        moneyPerKm = 0.05;
                    }
                    else if (kg < 40)
                    {
                        moneyPerKm = 0.1;
                    }
                    else if (kg < 90)
                    {
                        moneyPerKm = 0.15;
                    }
                    else
                    {
                        moneyPerKm = 0.2;
                    }
                    break;
                case "express":
                    if (kg < 1)
                    {
                        moreMoney = 0.03 * 0.8;
                        moneyPerKm = 0.03;
                    }
                    else if (kg < 10)
                    {
                        moreMoney = 0.05 * 0.4;
                        moneyPerKm = 0.05;
                    }
                    else if (kg < 40)
                    {
                        moreMoney = 0.1 * 0.05;
                        moneyPerKm = 0.1;
                    }
                    else if (kg < 90)
                    {
                        moreMoney = 0.15 * 0.02;
                        moneyPerKm = 0.15;
                    }
                    else
                    {
                        moreMoney = 0.2 * 0.01; 
                        moneyPerKm = 0.2;
                    }
                    break;
            }
            kgNewMoney = kg * moreMoney;
            double newMoneyDistance = kgNewMoney * distance;
            double moneyDIstance = distance * moneyPerKm;
            double total = newMoneyDistance + moneyDIstance;

            Console.WriteLine($"The delivery of your shipment with weight of {kg:f3} kg. would cost {total:f2} lv."

);

        }
    }
}
