using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int pieces = a * b;

            while (pieces > 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }

                int n = int.Parse(input);
                pieces -= n;
            }
            if (pieces >= 0)
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
            }
        }
    }
}
