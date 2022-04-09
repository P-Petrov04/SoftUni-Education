using System;

namespace _07.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double sideWall = x * y;
            double window = 1.5 * 1.5;
            double sideWallsWithOutWindows = 2 * sideWall - 2 * window;

            double backGroundWall = x * x;
            double door = 1.2 * 2;
            double groundWalls = 2 * backGroundWall - door;

            double sideRoof = 2 * (x * y);
            double groundRoof = 2 * (x * h / 2);

            double roof = sideRoof + groundRoof;
            double walls = sideWallsWithOutWindows + groundWalls;

            double greenPaint = walls / 3.4;
            double redPaint = roof / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
