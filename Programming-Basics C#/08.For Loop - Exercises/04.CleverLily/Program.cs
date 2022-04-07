using System;

namespace _04.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundry = double.Parse(Console.ReadLine());
            int toys = int.Parse(Console.ReadLine());

            int money = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money = money + (i * 5 - 1); //money += i*5-1
                }
                else
                {
                    money += toys;
                }
            }
            if (money >= laundry)
            {
                Console.WriteLine($"Yes! {(money - laundry):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(laundry - money):f2}");
            }
        }
    }
}
