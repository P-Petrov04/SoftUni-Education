﻿using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBiger = false;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (current > n)
                    {
                        isBiger = true;
                        break;
                    }
                    Console.Write($"{current} ");
                    current++;
                }
                if (isBiger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
