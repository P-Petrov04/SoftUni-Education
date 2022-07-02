using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            int countOfShoots = 0;
            while (input != "End")
            {
                int indexToShoot = int.Parse(input);
                if (indexToShoot < 0 || indexToShoot >= numbers.Count)
                {
                    input = Console.ReadLine();
                    continue;
                }
                if (numbers[indexToShoot] != -1)
                {
                    countOfShoots++;
                    int currentNum = numbers[indexToShoot];
                    numbers[indexToShoot] = -1;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > currentNum && numbers[i] != -1)
                        {
                            numbers[i] -= currentNum;
                        }
                        else if (numbers[i] <= currentNum && numbers[i] != -1)
                        {
                            numbers[i] += currentNum;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {countOfShoots} -> {string.Join(" ", numbers)}");
        }
    }
}
