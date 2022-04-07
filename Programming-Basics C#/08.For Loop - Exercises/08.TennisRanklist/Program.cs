using System;

namespace _08.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i--)
            {
                Console.WriteLine(i);
            }




            //int tournaments = int.Parse(Console.ReadLine());
            //int pointsStart = int.Parse(Console.ReadLine());

            //int pointsTornament = 0;
            //int winingTournaments = 0;

            //for (int i = 0; i < tournaments; i++)
            //{
            //    string stage = Console.ReadLine();

            //    if (stage == "W")
            //    {
            //        pointsTornament += 2000;
            //        winingTournaments++;
            //    }
            //    else if (stage == "F")
            //    {
            //        pointsTornament += 1200;
            //    }
            //    else if (stage == "SF")
            //    {
            //        pointsTornament += 720;
            //    }
            //}
            //double averagePoints = pointsTornament / tournaments;
            //Console.WriteLine($"Final points: {pointsStart + pointsTornament}");
            //Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            //Console.WriteLine($"{(1.0 * winingTournaments / tournaments * 100):f2}%");
        }
    }
}
