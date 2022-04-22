using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            Longer(x1, y1, x2, y2, x3, y3, x4, y4);

        }

        static void Closer(double x, double y, double z, double p) // Метод определящ коя точка е по-близо до (0,0)
        {
            if (x * x + y * y <= z * z + p * p)
            {
                Console.WriteLine($"({x}, {y})({z}, {p})");
            }
            else
            {
                Console.WriteLine($"({z}, {p})({x}, {y})");
            }
        }

        static void Longer(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double z1 = Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2); // дължината на квадрат на 1-та отсечка
            double z2 = Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2); // дължината на квадрат на 2-та отсечка

            if (z1 >= z2)
            {
                Closer(x1, y1, x2, y2);
            }
            else
            {
                Closer(x3, y3, x4, y4);
            }
        }
    }
}
