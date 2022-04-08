using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double avaliableMoney = double.Parse(Console.ReadLine());
            int counterDays = 0;
            int counterSpendDays = 0;
            string input = "";
            double money = 0;

            while (avaliableMoney < neededMoney)
            {
                input = Console.ReadLine();
                money = double.Parse(Console.ReadLine());
                counterDays++;

                if (input == "spend")
                {
                    counterSpendDays++;
                    avaliableMoney -= money;
                    if(money > avaliableMoney)
                    {
                        avaliableMoney = 0;
                    }

                    if (counterSpendDays == 5)
                    {
                        break;
                    }
                    
                }
                else
                {
                    avaliableMoney += money;
                    counterSpendDays = 0;
                }
            }

            if (counterSpendDays == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(counterDays);
            }
            else
            {
                Console.WriteLine($"You saved the money for {counterDays} days.");
            }
        }
    }
}
