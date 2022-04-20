using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculatingArea(side, height));
        }

        static int CalculatingArea(int side, int height)
        {
            return side * height;
        }
    }
}
