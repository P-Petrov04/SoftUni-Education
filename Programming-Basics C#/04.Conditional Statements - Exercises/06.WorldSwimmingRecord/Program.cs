using System;

namespace _06.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());

            double distanceInSeconds = meters * timeForMeter;
            double timesDilay = meters / 15;
            timesDilay = Math.Floor(timesDilay);
            double bonusSeconds = timesDilay * 12.5;
            double finalSeconds = distanceInSeconds + bonusSeconds;
            if(finalSeconds < recordInSec)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {finalSeconds:f2} seconds.");
            }
            else
            {
                double neededSeconds = finalSeconds - recordInSec;
                Console.WriteLine($"No, he failed! He was {neededSeconds:f2} seconds slower.");
            }
        }
    }
}
