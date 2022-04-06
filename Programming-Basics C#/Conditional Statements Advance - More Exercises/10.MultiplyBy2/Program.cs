using System;

namespace _10.MultiplyBy2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            while (true)
            {
                if (num < 0)
                {
                    Console.WriteLine("Negative number!");
                    break;
                }

                num = num * 2;
                Console.WriteLine($"Result: {num:f2}");
                num = double.Parse(Console.ReadLine());
            }
        }
    }
}
