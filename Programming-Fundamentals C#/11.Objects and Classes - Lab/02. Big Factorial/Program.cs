﻿using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger facotorial = 1;

            for (int i = 1; i <= number; i++)
            {
                facotorial *= i;
            }

            Console.WriteLine(facotorial);
        }
    }
}
