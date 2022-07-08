using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_12___Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split("@").Select(int.Parse).ToList();
            string input = Console.ReadLine();

            int startIndex = 0;
            int lastIndex = -1;
            while (input != "Love!")
            {
                string[] jumpCommand = input.Split();
                int jumpLenght = int.Parse(jumpCommand[1]);

                int nextIndex = startIndex + jumpLenght;
                if (nextIndex >= numbers.Count)
                {
                    nextIndex = 0;
                }
                if (numbers[nextIndex] == 0)
                {
                    lastIndex = nextIndex;
                    startIndex = lastIndex;
                    Console.WriteLine($"Place {nextIndex} already had Valentine's day.");
                    input = Console.ReadLine();
                    continue;
                }
                numbers[nextIndex] -= 2;
                if (numbers[nextIndex] == 0)
                {
                    Console.WriteLine($"Place {nextIndex} has Valentine's day." );
                }

                lastIndex = nextIndex;
                startIndex = lastIndex;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {lastIndex}.");
            if (numbers.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                numbers.RemoveAll(number => number == 0);
                Console.WriteLine($"Cupid has failed {numbers.Count} places.");
            }
        }
    }
}
