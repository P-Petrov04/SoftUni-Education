using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countBalls = int.Parse(Console.ReadLine());
            BigInteger MaxSnowBallValue = 0;
            int snowBallSnow = 0;
            int snowBallTime = 0;
            int snowBallQuality = 0;

            int maxSnowBallSnow = 0;
            int maxSnowBallTime = 0;
            int maxSnowBallQuality = 0;

            for (int i = 1; i <= countBalls; i++)
            {
                snowBallSnow = int.Parse(Console.ReadLine());
                snowBallTime = int.Parse(Console.ReadLine());
                snowBallQuality = int.Parse(Console.ReadLine());

                int snowBallValue = snowBallSnow / snowBallTime;
                BigInteger finalSnowBallValue = BigInteger.Pow(snowBallValue, snowBallQuality);
                
                if (finalSnowBallValue >= MaxSnowBallValue)
                {
                    MaxSnowBallValue = finalSnowBallValue;
                    maxSnowBallSnow = snowBallSnow;
                    maxSnowBallTime = snowBallTime;
                    maxSnowBallQuality = snowBallQuality;
                }
            }
            Console.WriteLine($"{maxSnowBallSnow} : {maxSnowBallTime} = {MaxSnowBallValue} ({maxSnowBallQuality})");


        }
    }
}
