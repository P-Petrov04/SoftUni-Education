using System;

namespace ex._4_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int cats = int.Parse(Console.ReadLine());

            int counterGroup1 = 0;
            int counterGroup2 = 0;
            int counterGroup3 = 0;

            double money = 0;
            double allgrams = 0;

            for (int i = 1; i <= cats; i++)
            {
                double gramsEat = double.Parse(Console.ReadLine());
                allgrams += gramsEat;

                if (gramsEat < 200)
                {
                    counterGroup1++;

                }
                else if (gramsEat < 300)
                {
                    counterGroup2++;
                }
                else
                {
                    counterGroup3++;
                }
            }

            double kg = allgrams / 1000;
            money = kg * 12.45;

            Console.WriteLine($"Group 1: {counterGroup1} cats.");
            Console.WriteLine($"Group 2: {counterGroup2} cats.");
            Console.WriteLine($"Group 3: {counterGroup3} cats.");
            Console.WriteLine($"Price for food per day: {money:f2} lv.");
        }
    }
}
