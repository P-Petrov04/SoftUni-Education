using System;

namespace _01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int sumTime = firstTime + secondTime + thirdTime;
            int timeInMin = sumTime / 60;
            int timeInSec = sumTime % 60;

            if (timeInSec < 10)
            {
                Console.WriteLine($"{timeInMin}:0{timeInSec}");
            }
            else
            {
                Console.WriteLine($"{timeInMin}:{timeInSec}");
            }
        }
    }
}
