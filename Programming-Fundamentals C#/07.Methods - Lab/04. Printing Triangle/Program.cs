﻿using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                PrintLine(1, i);
            }

            for (int i = height - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        static void PrintLine(int start, int end)
        {
            for (int j = start; j <= end; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
