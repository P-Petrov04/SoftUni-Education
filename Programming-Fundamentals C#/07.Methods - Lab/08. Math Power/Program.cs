using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int powerNum = int.Parse(Console.ReadLine());

            Console.WriteLine(PoweredNum(number, powerNum));
        }

        static double PoweredNum(double @base, int power)
        {
            double poweredNum = 1;
            for (int i = 1; i <= power; i++)
            {
                poweredNum *= @base;
            }

            return poweredNum;
        }
    }
}
