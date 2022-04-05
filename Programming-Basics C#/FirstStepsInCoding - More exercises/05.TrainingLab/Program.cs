using System;

namespace _05.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double wInM = double.Parse(Console.ReadLine());
            double hInM = double.Parse(Console.ReadLine());

            double hInCm = hInM * 100;
            double wInCm = wInM * 100;

            double spaceWithOutCorridor = hInCm - 100;
            double countOfOffices = spaceWithOutCorridor / 70;
            countOfOffices = Math.Floor(countOfOffices);

            double countOfOffices2 = wInCm / 120;
            countOfOffices2 = Math.Floor(countOfOffices2);

            double allOffices = countOfOffices * countOfOffices2 - 3;
            Console.WriteLine(allOffices);
        }

    }
}
