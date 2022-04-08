using System;

namespace _07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int S = a * b * h;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                int n = int.Parse(input);
                S -= n;

                if (S <= 0)
                {
                    break;
                }
            }
            if (S > 0)
            {
                Console.WriteLine($"{S} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(S)} Cubic meters more.");
            }
        }
    }
}
