using System;

namespace _08.CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double P = 2 * Math.PI * r;
            double S = r * r * Math.PI;

            Console.WriteLine($"{S:f2}");
            Console.WriteLine($"{P:f2}");
        }
    }
}
