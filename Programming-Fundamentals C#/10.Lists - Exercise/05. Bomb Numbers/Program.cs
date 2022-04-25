using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombArguments = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNum = bombArguments[0];
            int bombPower = bombArguments[1];
            int indexOfBomb = -1;

            while (numbers.Contains(bombNum))
            {
                for (int index = 0; index < numbers.Count; index++)
                {
                    if (numbers[index] == bombNum)
                    {
                        indexOfBomb = index;

                        int indexToRight = indexOfBomb + bombPower;
                        if (indexToRight >= numbers.Count)
                        {
                            indexToRight = numbers.Count - 1;
                        }
                        for (int i = indexOfBomb; i <= indexToRight; i++)
                        {
                            numbers.RemoveAt(indexOfBomb);
                        }

                        int indexToLeft = indexOfBomb - bombPower;
                        if (indexToLeft < 0)
                        {
                            indexToLeft = 0;
                        }
                        for (int j = indexToLeft; j < indexOfBomb; j++)
                        {
                            numbers.RemoveAt(indexToLeft);
                        }
                    }
                }
            }

            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
