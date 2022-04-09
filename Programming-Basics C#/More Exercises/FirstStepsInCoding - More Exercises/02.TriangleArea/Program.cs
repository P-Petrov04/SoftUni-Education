using System;

namespace _02.TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1 = double.Parse(Console.ReadLine());
            double ha = double.Parse(Console.ReadLine());

            double S = a1 * ha / 2;
            Console.WriteLine($"{S:f2}");
        }
    }
}
