using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedEvaluations = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            double evaluationsSum = 0;
            int exercisesCount = 0;
            string lastExercise = "";
            int failsCount = 0;
            int evaluation = 0;

            while (input != "Enough") 
            {
                lastExercise = input;
                evaluation = int.Parse(Console.ReadLine());

                exercisesCount++;
                evaluationsSum += evaluation;

                if (evaluation <= 4.00)
                {
                    failsCount++;
                    if (failsCount == failedEvaluations)
                    {
                        break;
                    }
                }
                input = Console.ReadLine();
            }

            double averageEvaluation = evaluationsSum / exercisesCount;

            if (input == "Enough")
            {
                Console.WriteLine($"Average score: {averageEvaluation:f2}");
                Console.WriteLine($"Number of problems: {exercisesCount}");
                Console.WriteLine($"Last problem: {lastExercise}");
               
            }
            else
            {
                Console.WriteLine($"You need a break, {failsCount} poor grades.");
            }
        }
    }
}
