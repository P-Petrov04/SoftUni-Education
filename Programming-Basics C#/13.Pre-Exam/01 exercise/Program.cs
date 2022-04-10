using System;

namespace _01_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int transport = int.Parse(Console.ReadLine());
            int museum = int.Parse(Console.ReadLine());

            double moneyNights = nights * 20;
            double moneyTransport = transport * 1.60;
            double moneyMuseum = museum * 6;
            double moneyPerMan = moneyNights + moneyTransport + moneyMuseum;
            double moneyForGroup = moneyPerMan * people;
            double total = moneyForGroup + moneyForGroup * 0.25;

            Console.WriteLine($"{total:f2}");
        }
    }
}
