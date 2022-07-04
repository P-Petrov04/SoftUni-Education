using System;

namespace Problem_5___Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int myEnergy = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int countOfWins = 0;
            int countOfWinsInRow = 0;

            while (input != "End of battle" && myEnergy > 0)
            {
                int distanceToEnemy = int.Parse(input);
                if (myEnergy < distanceToEnemy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {countOfWins} won battles and {myEnergy} energy");
                    return;
                }
                myEnergy -= distanceToEnemy;
                countOfWins++;
                countOfWinsInRow++;
                if (countOfWinsInRow == 3)
                {
                    myEnergy += countOfWins;
                    countOfWinsInRow = 0;
                }

                input = Console.ReadLine();
            }
            if (input == "End of battle")
            {
                Console.WriteLine($"Won battles: {countOfWins}. Energy left: {myEnergy}");
            }
            else
            {
                Console.WriteLine($"Not enough energy! Game ends with {countOfWins} won battles and {myEnergy} energy");
            }
        }
    }
}
