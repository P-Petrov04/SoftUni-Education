using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfJuri = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();
            double allGrades = 0;
            int countPresentations = 0;
            while (presentationName != "Finish")
            {
                double currGrades = 0;
                countPresentations++;
                for (int i = 0; i < countOfJuri; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    currGrades += grade;
                }
                double averageGrade = currGrades / countOfJuri;
                allGrades += averageGrade;

                Console.WriteLine($"{presentationName} - {averageGrade:f2}.");
                presentationName = Console.ReadLine();
            }

            double average = allGrades / countPresentations;
            Console.WriteLine($"Student's final assessment is {average:f2}.");

            
        }
    }
}
