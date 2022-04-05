using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int mounths = int.Parse(Console.ReadLine());
            double percents = double.Parse(Console.ReadLine());

            //1.Изчисляваме натрупаната лихва: 200 * 0.057(5.7 %) = 11.40 лв.
            //2.Изчисляваме лихвата за 1 месец: 11.40 лв. / 12 месеца = 0.95 лв.
            //3.Общата сума е: 200 лв. + 3 * 0.95 лв. = 202.85 лв.

            double interest = deposit * (percents / 100);
            double interestForMonth = interest / 12;
            double sum = deposit + mounths * interestForMonth;

            Console.WriteLine(sum);
        }
    }
}
