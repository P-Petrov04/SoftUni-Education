using System;

namespace _07._AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double num = double.Parse(Console.ReadLine());
                double S = num * num;
                Console.WriteLine($"{S:f3}");
            }
            else if (figure == "rectangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double S = num1 * num2;
                Console.WriteLine($"{S:f3}");
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double S = r * r * Math.PI;
                Console.WriteLine($"{S:f3}");
            }
            else if (figure == "triangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double numH = double.Parse(Console.ReadLine());
                double S = num1 * numH / 2;
                Console.WriteLine($"{S:f3}");
            }
        }
    }
}
