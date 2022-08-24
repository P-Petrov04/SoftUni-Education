using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_21___The_Angry_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int entryPoint = int.Parse(Console.ReadLine());
            string typeItem = Console.ReadLine();

            string position = string.Empty;
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (typeItem == "cheap")
                {
                    if (numbers[i] < numbers[entryPoint])
                    {
                        if (i < entryPoint)
                        {
                            position = "Left";
                            leftSum += numbers[i];
                        }
                        else if (i > entryPoint)
                        {
                            position = "Right";
                            rightSum += numbers[i];
                        }
                    }
                }
                else
                {
                    if (numbers[i] >= numbers[entryPoint])
                    {
                        if (i < entryPoint)
                        {
                            position = "Left";
                            leftSum += numbers[i];
                        }
                        else if (i > entryPoint)
                        {
                            position = "Right";
                            rightSum += numbers[i];
                        }
                    }
                }
            }

            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }
    }
}
