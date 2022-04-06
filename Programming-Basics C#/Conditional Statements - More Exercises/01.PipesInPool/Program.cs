using System;

namespace _01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int Vpool = int.Parse(Console.ReadLine());
            int pipeOne = int.Parse(Console.ReadLine());
            int pipeTwo = int.Parse(Console.ReadLine());
            double hoursAway = double.Parse(Console.ReadLine());

            double litersPipeOne = pipeOne * hoursAway;
            double litersPipeTwo = pipeTwo * hoursAway;
            double litersForHours = litersPipeOne + litersPipeTwo;

            if (litersForHours <= Vpool)
            {
                double litersInPersents = litersForHours /Vpool * 100;
                double pipe1Percents = litersPipeOne / litersForHours * 100;
                double pipe2Percents = litersPipeTwo / litersForHours * 100;

                Console.WriteLine($"The pool is {litersInPersents}% full. Pipe 1: {pipe1Percents:f2}%. Pipe 2: {pipe2Percents:f2}%.");
            }
            else
            {
                double litersOut = litersForHours - Vpool;
                Console.WriteLine($"For {hoursAway:f2} hours the pool overflows with {litersOut:f2} liters.");
            }
        }
    }
}
