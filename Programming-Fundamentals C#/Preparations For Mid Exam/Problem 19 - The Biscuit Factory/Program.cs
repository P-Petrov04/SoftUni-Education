using System;

namespace Problem_19___The_Biscuit_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerDay = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int countOfBiscuitsForOtherFactory = int.Parse(Console.ReadLine());

            double allBiscuitsPerDay = biscuitsPerDay * countOfWorkers;
            double originalBiscuitsCountPerDay = allBiscuitsPerDay;
            double myBiscuits = 0;
            int counterOfDays = 0;

            for (int i = 1; i <= 30; i++)
            {
                counterOfDays++;
                if ( counterOfDays == 3)
                {
                    allBiscuitsPerDay -= Math.Floor(allBiscuitsPerDay * 0.25);
                    counterOfDays = 0;
                }
                myBiscuits += allBiscuitsPerDay;
                allBiscuitsPerDay = originalBiscuitsCountPerDay;
            }

            Console.WriteLine($"You have produced {myBiscuits} biscuits for the past month");
            double difference = 0;
            double percents = 0;
            if (myBiscuits < countOfBiscuitsForOtherFactory)
            {
                difference = Math.Abs(myBiscuits - countOfBiscuitsForOtherFactory);
                percents = difference / countOfBiscuitsForOtherFactory * 100;
                Console.WriteLine($"You produce {percents:f2} percent less biscuits");
            }
            else
            {
                difference = myBiscuits - countOfBiscuitsForOtherFactory;
                percents = difference / countOfBiscuitsForOtherFactory * 100;
                Console.WriteLine($"You produce {percents:f2} percent more biscuits");
            }
        }
    }
}
